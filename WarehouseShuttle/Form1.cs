using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Web.Security;
using System.Windows.Forms;
using WarehouseShuttle.Common;
using WarehouseShuttle.Infrastructure;
using WarehouseShuttle.Models;
using WarehouseShuttle.Models.DTO;

namespace WarehouseShuttle
{
    public partial class MainFormScreen : Form
    {
        private readonly IStoreRepository _storeRepository;
        private List<StorageCell> _storageCells;
        private const int MOCK_MAX_NUMBER_OF_STORAGE_CELLS = 200;
        private const int MAX_NUMBER_OF_STORAGE_CELLS = 262144;

        public MainFormScreen(IStoreRepository storeRepository)
        {
            InitializeComponent();
            _storeRepository = storeRepository;

            _storageCells = new List<StorageCell>();
            for (int i = 0; i < MOCK_MAX_NUMBER_OF_STORAGE_CELLS; i++)
            {
                _storageCells.Add(new StorageCell()
                {
                    Number = i,
                    MaxMass = GlobalVariables.MaxMassAvailableInKG,
                    HasPackage = _storeRepository.IsThereAPackageInStorageCell(i),
                    // TODO: FIGURE OUT WHERE THE CELL IS LOCATED
                    Location = new Point(0, 0)
                });
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void StorePackageButton_Click(object sender, EventArgs e)
        {
            var (packageReadDto, responseMessage) = GetPackageFromUIFormInput();

            if (packageReadDto is null)
            {
                MessageBox.Show(responseMessage);
                return;
            }

            // - build a path for shuttle to appropriate storage cell
            // - show as shuttle goes with a red mark
            // (если робот опустился или поднялся то и камера тоже как бы опускается или подымается вместе с ним, показывая какие там есть cells на этому уровне)
            // - when shuttle finds the needed cell, it pushes a package there
            // - using the same route(or build another one) go to the initial position

            int nextPackageNumber = _storeRepository.LastPackageNumber() + 1;
            int storageCellNumber = _storageCells.SingleOrDefault(cell => cell.HasPackage is false).Number;
            string PIN = GeneratePIN();
            string password = GeneratePassword();
            string hashedPassword = HashPassword(password);

            var packageToStore = new Package()
            {
                Number = nextPackageNumber,
                StorageCellNumber = storageCellNumber,
                PackageInternationalNumber = PIN,
                Mass = packageReadDto.Mass,
                Owner = packageReadDto.Owner,
                StartDate = packageReadDto.StartDate,
                EndDate = packageReadDto.EndDate,
                Price = packageReadDto.Price,
                Password = hashedPassword,
                SoftDeleted = false
            };

            _storeRepository.StorePackageToDB(packageToStore);

            MessageBox.Show($"Your password: {password}, please, keep it in a safe place.");
        }

        private void UnstorePackageButton_Click(object sender, EventArgs e)
        {
            //1) input a package 4 last internation number(e.g 4490, the whole looks like: XXXXXXXXXX)
            //2) validate the number
            //3) get the whole package from database
            //4) take the position of cell and build path there
            //5) take the package
            //6) go to the initial position by some path
            //7) update package to the package - spoting history(as taken)
        }

        #region Private methods

        private (PackageReadDto, string) GetPackageFromUIFormInput()
        {
            bool massValid = decimal.TryParse(MassInput.Text, out decimal mass);
            bool priceValid = decimal.TryParse(PriceInput.Text, out decimal price);
            bool startValid = DateTime.TryParse(StartDateInput.Text, out DateTime startDate);
            bool endValid = DateTime.TryParse(EndDateInput.Text, out DateTime endDate);
            string owner = OwnerInput.Text;

            if (!massValid)
                return (null, "Mass is not valid.");

            if (owner == string.Empty)
                return (null, "Owner is not valid.");

            if (!priceValid)
                return (null, "Price is not valid.");

            if (!startValid)
                return (null, "Start date is not valid.");

            if (!endValid)
                return (null, "End date is not valid.");

            if (mass > GlobalVariables.MaxMassAvailableInKG)
                return (null, "The package is too heavy for our storage.");

            return (new PackageReadDto()
            {
                Mass = mass,
                Owner = owner,
                StartDate = startDate,
                EndDate = endDate,
                Price = price
            }, "Success");
        }

        private string GeneratePIN()
        {
            StringBuilder PIN = new StringBuilder();
            int pinLength = 10;
            var rnd = new Random(666);

            for (int i = 0; i < pinLength; i++)
            {
                PIN.Append(rnd.Next(0, 10));
            }

            return PIN.ToString();
        }

        private string GeneratePassword()
        {
            return Membership.GeneratePassword(5, 0);
        }

        private static string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        private static bool VerityPassword(string password, string hash)
        {
            return BCrypt.Net.BCrypt.Verify(password, hash);
        }

        #endregion
    }
}
