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
        private readonly List<StorageCell> _storageCells;
        private const int MOCK_MAX_NUMBER_OF_STORAGE_CELLS = 200;
        private const int MAX_NUMBER_OF_STORAGE_CELLS = 262144;

        private static readonly Random rndSeed = new Random();

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
            int? storageCellNumber = _storageCells.FirstOrDefault(cell => cell.HasPackage is false).Number;
            if (!storageCellNumber.HasValue)
            {
                MessageBox.Show("No available storage cells left!");
                return;
            }

            string PIN = GeneratePIN();
            string password = GeneratePassword();
            string hashedPassword = HashPassword(password);

            var packageToStore = new Package()
            {
                Number = nextPackageNumber,
                StorageCellNumber = storageCellNumber.Value,
                PackageInternationalNumber = PIN,
                Mass = packageReadDto.Mass,
                Owner = packageReadDto.Owner,
                StartDate = packageReadDto.StartDate,
                EndDate = packageReadDto.EndDate,
                Price = packageReadDto.Price,
                Password = hashedPassword,
                SoftDeleted = false
            };

            var indexToStore = _storageCells.FindIndex(p => p.Number == storageCellNumber.Value);
            _storageCells[indexToStore].HasPackage = true;

            _storeRepository.StorePackageToDB(packageToStore);

            MessageBox.Show($"Your password: \"{password}\", please, keep it in a safe place.");
            ClearAllInputsInGroup(StorePackage);
        }

        private void UnstorePackageButton_Click(object sender, EventArgs e)
        {
            var (readUnPackageDto, responseMessage) = GetUnPackageFromUIFormInput();

            if (readUnPackageDto is null)
            {
                MessageBox.Show(responseMessage);
                return;
            }

            var package = _storeRepository.GetPackageByPartOfPINAndOwner(readUnPackageDto.PackageInternationalNumber, readUnPackageDto.Owner);

            if (package is null)
            {
                MessageBox.Show("We don't have such a package!");
                return;
            }

            if (!VerityPassword(readUnPackageDto.Password, package.Password))
            {
                MessageBox.Show("The entered password doesn't match the stored one!");
                return;
            }

            // - take the position of cell and build path there
            // - take the package
            // - go to the initial position by some path

            var indexToUnStore = _storageCells.FindIndex(p => p.Number == package.StorageCellNumber);
            _storageCells[indexToUnStore].HasPackage = false;

            _storeRepository.UnStorePackageInDB(package.Number);

            StringBuilder info = new StringBuilder("Here is your package: \n");

            info.AppendLine($"Number: {package.Number}");
            info.AppendLine($"StorageCellNumber: {package.StorageCellNumber}");
            info.AppendLine($"PackageInternationalNumber: {package.PackageInternationalNumber}");
            info.AppendLine($"Mass: {package.Mass}");
            info.AppendLine($"Owner: {package.Owner}");
            info.AppendLine($"StartDate: {package.StartDate}");
            info.AppendLine($"EndDate: {package.EndDate}");
            info.AppendLine($"Price: {package.Price}");

            MessageBox.Show(info.ToString());
            ClearAllInputsInGroup(UnStoreGroup);
        }

        private void ShowPackagesButton_Click(object sender, EventArgs e)
        {
            StringBuilder info = new StringBuilder();

            var packages = _storeRepository.GetActualPackages();

            foreach (var package in packages)
            {
                info.AppendLine($"Number: {package.Number}");
                info.AppendLine($"StorageCellNumber: {package.StorageCellNumber}");
                info.AppendLine($"PackageInternationalNumber: {package.PackageInternationalNumber}");
                info.AppendLine($"Mass: {package.Mass}");
                info.AppendLine($"Owner: {package.Owner}");
                info.AppendLine($"StartDate: {package.StartDate}");
                info.AppendLine($"EndDate: {package.EndDate}");
                info.AppendLine($"Price: {package.Price}");
                info.AppendLine();
            }

            MessageBox.Show(info.ToString());
        }

        #region Private methods

        private (StorePackageReadDto, string) GetPackageFromUIFormInput()
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

            return (new StorePackageReadDto()
            {
                Mass = mass,
                Owner = owner,
                StartDate = startDate,
                EndDate = endDate,
                Price = price
            }, "Success");
        }

        private (UnStorePackageReadDto, string) GetUnPackageFromUIFormInput()
        {
            string PIN = UnStorePinInput.Text;
            string owner = UnstoreOwnerInput.Text;
            string password = UnStorePasswordInput.Text;

            if (PIN == string.Empty)
                return (null, "PIN is not valid.");

            if (owner == string.Empty)
                return (null, "Owner is not valid.");

            if (password == string.Empty)
                return (null, "Password is not valid.");

            return (new UnStorePackageReadDto()
            {
                PackageInternationalNumber = PIN,
                Owner = owner,
                Password = password
            }, "Success");
        }

        private void ClearAllInputsInGroup(GroupBox groupBox)
        {
            foreach (var control in groupBox.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Clear();
                }
            }
        }

        private string GeneratePIN()
        {
            StringBuilder PIN = new StringBuilder();
            int pinLength = 10;
            var rnd = new Random(rndSeed.Next(199, 99999));

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
