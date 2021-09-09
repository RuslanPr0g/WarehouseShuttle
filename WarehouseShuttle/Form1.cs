﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
        private const int MAX_NUMBER_OF_STORAGE_CELLS = 640;

        private readonly Point INITIAL_POINT = new Point();

        private const int SPACE_BETWEEN_TWO_SIDES = 50;
        private const int SPACE_BETWEEN_TWO_STORAGE_LINES = 40;
        private const int NUMBER_OF_CELLS_ON_EACH_SIDE_HORIZONTAL = 32;
        private const int NUMBER_OF_CELL_LINES_ON_EACH_SIDE_VERTICAL = 8;

        private static readonly Random rndSeed = new Random();

        public MainFormScreen(IStoreRepository storeRepository)
        {
            InitializeComponent();
            _storeRepository = storeRepository;

            int width = DrawPanel.Width;
            int height = DrawPanel.Height;

            int floorCount = 1;
            int xposCount = 1;
            int yposCount = 1;
            Point cellCenterPoint = new Point(StorageCell.Width / 2, StorageCell.Height / 2);

            _storageCells = new List<StorageCell>();
            for (int i = 1; i <= MAX_NUMBER_OF_STORAGE_CELLS; i++)
            {
                _storageCells.Add(new StorageCell()
                {
                    Number = i,
                    MaxMass = GlobalVariables.MaxMassAvailableInKG,
                    HasPackage = _storeRepository.IsThereAPackageInStorageCell(i),
                    Location = new StoragePoint3D(floorCount, xposCount, yposCount, cellCenterPoint)
                });

                xposCount++;
                if (i % (NUMBER_OF_CELLS_ON_EACH_SIDE_HORIZONTAL / NUMBER_OF_CELL_LINES_ON_EACH_SIDE_VERTICAL) == 0)
                    cellCenterPoint.X += (StorageCell.Width * 2) + SPACE_BETWEEN_TWO_SIDES;
                else
                    cellCenterPoint.X += StorageCell.Width * 2;

                if (i % ((NUMBER_OF_CELLS_ON_EACH_SIDE_HORIZONTAL / NUMBER_OF_CELL_LINES_ON_EACH_SIDE_VERTICAL) * 2) == 0)
                {
                    yposCount++;
                    cellCenterPoint.Y += StorageCell.Height + SPACE_BETWEEN_TWO_STORAGE_LINES;

                    xposCount = 1;
                    cellCenterPoint.X = StorageCell.Width / 2;
                }

                if (i % (NUMBER_OF_CELLS_ON_EACH_SIDE_HORIZONTAL * 2) == 0)
                {
                    floorCount++;

                    xposCount = 1;
                    yposCount = 1;
                    cellCenterPoint = new Point(StorageCell.Width / 2, StorageCell.Height / 2);
                }
            }

            Point initialPoint = new Point(((NUMBER_OF_CELL_LINES_ON_EACH_SIDE_VERTICAL / 2) * StorageCell.Width) +
                (SPACE_BETWEEN_TWO_SIDES) + (StorageCell.Width * 3), height - Shuttle.Height * 2);
            INITIAL_POINT = initialPoint;
            Shuttle.Position = new StoragePoint3D(1, 1, 1, initialPoint);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DrawShuttleMoving(StoragePoint3D moveTo, int cellIndex, bool store = true)
        {
            Graphics graphicsObj = DrawPanel.CreateGraphics();
            var red = new SolidBrush(Color.Red);
            var white = new SolidBrush(Color.White);

            DrawStorage(Shuttle.Position.Floor);

            // MOVE IN Y
            for (int pixel = Shuttle.Position.CenterPointOnPlane.Y; pixel >= moveTo.CenterPointOnPlane.Y + StorageCell.Height; pixel -= 5)
            {
                graphicsObj.FillEllipse(red, new Rectangle(Shuttle.Position.CenterPointOnPlane.X,
                    pixel, Shuttle.Width, Shuttle.Height));
                Thread.Sleep(50);
                graphicsObj.FillEllipse(white, new Rectangle(Shuttle.Position.CenterPointOnPlane.X,
                    pixel, Shuttle.Width, Shuttle.Height));
                Shuttle.Position.CenterPointOnPlane.Y = pixel;
            }

            // MOVE IN X
            if (moveTo.CenterPointOnPlane.X > Shuttle.Position.CenterPointOnPlane.X)
                for (int pixel = Shuttle.Position.CenterPointOnPlane.X; pixel <= moveTo.CenterPointOnPlane.X + 3; pixel += 3)
                {
                    graphicsObj.FillEllipse(red, new Rectangle(pixel,
                        Shuttle.Position.CenterPointOnPlane.Y, Shuttle.Width, Shuttle.Height));
                    Thread.Sleep(50);
                    graphicsObj.FillEllipse(white, new Rectangle(pixel,
                        Shuttle.Position.CenterPointOnPlane.Y, Shuttle.Width, Shuttle.Height));
                    Shuttle.Position.CenterPointOnPlane.X = pixel;
                }
            else
                for (int pixel = Shuttle.Position.CenterPointOnPlane.X; pixel >= moveTo.CenterPointOnPlane.X + 3; pixel -= 3)
                {
                    graphicsObj.FillEllipse(red, new Rectangle(pixel,
                        Shuttle.Position.CenterPointOnPlane.Y, Shuttle.Width, Shuttle.Height));
                    Thread.Sleep(50);
                    graphicsObj.FillEllipse(white, new Rectangle(pixel,
                        Shuttle.Position.CenterPointOnPlane.Y, Shuttle.Width, Shuttle.Height));
                    Shuttle.Position.CenterPointOnPlane.X = pixel;
                }

            DrawShuttle();

            // MOVE IN Z (floor)
            Thread.Sleep(1000);

            Shuttle.Position.Floor = moveTo.Floor;
            FloorText.Text = $"Floor: {moveTo.Floor}";
            DrawStorage(Shuttle.Position.Floor);
            DrawShuttle();

            Thread.Sleep(1000);

            if (store)
            {
                _storageCells[cellIndex].HasPackage = true;
            }
            else
            {
                _storageCells[cellIndex].HasPackage = false;
            }

            DrawStorage(Shuttle.Position.Floor);
            DrawShuttle();

            // MOVE BACK
            // MOVE IN Z (floor)
            Thread.Sleep(1000);
            Shuttle.Position.Floor = 1;
            FloorText.Text = $"Floor: {Shuttle.Position.Floor}";
            DrawStorage(Shuttle.Position.Floor);

            // MOVE IN X
            if (INITIAL_POINT.X > Shuttle.Position.CenterPointOnPlane.X)
                for (int pixel = Shuttle.Position.CenterPointOnPlane.X; pixel <= INITIAL_POINT.X + 3; pixel += 3)
                {
                    graphicsObj.FillEllipse(red, new Rectangle(pixel,
                        Shuttle.Position.CenterPointOnPlane.Y, Shuttle.Width, Shuttle.Height));
                    Thread.Sleep(50);
                    graphicsObj.FillEllipse(white, new Rectangle(pixel,
                        Shuttle.Position.CenterPointOnPlane.Y, Shuttle.Width, Shuttle.Height));
                    Shuttle.Position.CenterPointOnPlane.X = pixel;
                }
            else
                for (int pixel = Shuttle.Position.CenterPointOnPlane.X; pixel >= INITIAL_POINT.X + 3; pixel -= 3)
                {
                    graphicsObj.FillEllipse(red, new Rectangle(pixel,
                        Shuttle.Position.CenterPointOnPlane.Y, Shuttle.Width, Shuttle.Height));
                    Thread.Sleep(50);
                    graphicsObj.FillEllipse(white, new Rectangle(pixel,
                        Shuttle.Position.CenterPointOnPlane.Y, Shuttle.Width, Shuttle.Height));
                    Shuttle.Position.CenterPointOnPlane.X = pixel;
                }

            // MOVE IN Y
            for (int pixel = Shuttle.Position.CenterPointOnPlane.Y; pixel <= INITIAL_POINT.Y; pixel += 5)
            {
                graphicsObj.FillEllipse(red, new Rectangle(Shuttle.Position.CenterPointOnPlane.X,
                    pixel, Shuttle.Width, Shuttle.Height));
                Thread.Sleep(50);
                graphicsObj.FillEllipse(white, new Rectangle(Shuttle.Position.CenterPointOnPlane.X,
                    pixel, Shuttle.Width, Shuttle.Height));
                Shuttle.Position.CenterPointOnPlane.Y = pixel;
            }

            DrawShuttle();
        }

        private void DrawShuttle()
        {
            Graphics graphicsObj = DrawPanel.CreateGraphics();
            var green = new SolidBrush(Color.Green);

            graphicsObj.FillEllipse(green, new Rectangle(Shuttle.Position.CenterPointOnPlane.X,
                Shuttle.Position.CenterPointOnPlane.Y, Shuttle.Width, Shuttle.Height));
        }

        private void DrawStorage(int floor)
        {
            Graphics graphicsObj = DrawPanel.CreateGraphics();
            graphicsObj.Clear(Color.White);
            var blackPen = new Pen(Color.Black, 1);
            var redPen = new Pen(Color.Red, 1);

            var endCell = floor * (NUMBER_OF_CELLS_ON_EACH_SIDE_HORIZONTAL * 2);

            for (int i = endCell - (NUMBER_OF_CELLS_ON_EACH_SIDE_HORIZONTAL * 2); i < endCell; i++)
            {
                graphicsObj.DrawRectangle(blackPen, new Rectangle(_storageCells[i].Location.CenterPointOnPlane.X,
                    _storageCells[i].Location.CenterPointOnPlane.Y, StorageCell.Width, StorageCell.Height));

                if (_storageCells[i].HasPackage)
                {
                    var leftTop = new Point(_storageCells[i].Location.CenterPointOnPlane.X, _storageCells[i].Location.CenterPointOnPlane.Y);
                    var rightTop = new Point(_storageCells[i].Location.CenterPointOnPlane.X + StorageCell.Width,
                        _storageCells[i].Location.CenterPointOnPlane.Y);
                    var rightBottom = new Point(_storageCells[i].Location.CenterPointOnPlane.X + StorageCell.Width,
                        _storageCells[i].Location.CenterPointOnPlane.Y + StorageCell.Height);
                    var leftBottom = new Point(_storageCells[i].Location.CenterPointOnPlane.X,
                        _storageCells[i].Location.CenterPointOnPlane.Y + StorageCell.Height);

                    graphicsObj.DrawLine(redPen, leftTop, rightBottom);
                    graphicsObj.DrawLine(redPen, rightTop, leftBottom);
                }
            }

            FloorText.Text = $"Floor: {Shuttle.Position.Floor}";
        }

        private int? FindClosestPathFromShuttleToStorageCellAndReturnStorageCellNumber()
        {
            var floorCount = 1;

            for (int i = ((NUMBER_OF_CELLS_ON_EACH_SIDE_HORIZONTAL * 2) * floorCount) - 1; i >= (NUMBER_OF_CELLS_ON_EACH_SIDE_HORIZONTAL * 2) * (floorCount - 1); i--)
            {
                if (_storageCells.Count <= i)
                    return null;

                if (_storageCells.ElementAt(i).HasPackage is false)
                {
                    return _storageCells.ElementAt(i).Number;
                }
                
                if (i == (NUMBER_OF_CELLS_ON_EACH_SIDE_HORIZONTAL * 2) * (floorCount - 1))
                {
                    floorCount++;
                    i = ((NUMBER_OF_CELLS_ON_EACH_SIDE_HORIZONTAL * 2) * floorCount);
                }
            }

            return null;
        }

        private void StorePackageButton_Click(object sender, EventArgs e)
        {
            var (packageReadDto, responseMessage) = GetPackageFromUIFormInput();

            if (packageReadDto is null)
            {
                MessageBox.Show(responseMessage);
                return;
            }

            int nextPackageNumber = _storeRepository.LastPackageNumber() + 1;
            int? storageCellNumber = FindClosestPathFromShuttleToStorageCellAndReturnStorageCellNumber();
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
            DrawShuttleMoving(_storageCells.FirstOrDefault(c => c.Number == storageCellNumber).Location, indexToStore, true);

            int floor = _storageCells.FirstOrDefault(c => c.Number == storageCellNumber).Location.Floor;

            _storeRepository.StorePackageToDB(packageToStore);

            MessageBox.Show($"Your password: \"{password}\", please, keep it in a safe place. It is on the {floor} floor.");
            ClearAllInputsInGroup(StorePackage);
            TestShuttleButton.Text = $"Last floor: {floor}";
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

            var indexToUnStore = _storageCells.FindIndex(p => p.Number == package.StorageCellNumber);
            DrawShuttleMoving(_storageCells.FirstOrDefault(c => c.Number == package.StorageCellNumber).Location, indexToUnStore, false);

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

        private void TestShuttleButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TestInput.Text))
                TestInput.Text = MAX_NUMBER_OF_STORAGE_CELLS.ToString();
            
            for (int i = 0; i < int.Parse(TestInput.Text); i++)
            {
                MassInput.Text = "80";
                PriceInput.Text = "900";
                OwnerInput.Text = "ruslan";
                StorePackageButton_Click(sender, e);
            }
        }

        private void ShowFloor_Click(object sender, EventArgs e)
        {
            bool isFloorValid = int.TryParse(ShowFloorInput.Text, out int floor);

            if (isFloorValid && floor > _storageCells.Last().Location.Floor)
            {
                MessageBox.Show("No such floor");
                return;
            }

            if (isFloorValid)
            {
                DrawStorage(floor);
                FloorText.Text = $"Floor: {floor}";

                if (floor == 1)
                    DrawShuttle();
            }
        }

        #region Private methods

        private (StorePackageReadDto, string) GetPackageFromUIFormInput()
        {
            bool massValid = decimal.TryParse(MassInput.Text, out decimal mass);
            bool priceValid = decimal.TryParse(PriceInput.Text, out decimal price);
            DateTime start = StartDateInput.SelectionStart;
            DateTime end = EndDateInput.SelectionStart;
            string owner = OwnerInput.Text;

            if (!massValid)
                return (null, "Mass is not valid.");

            if (owner == string.Empty)
                return (null, "Owner is not valid.");

            if (!priceValid)
                return (null, "Price is not valid.");

            if (mass > GlobalVariables.MaxMassAvailableInKG)
                return (null, "The package is too heavy for our storage.");

            return (new StorePackageReadDto()
            {
                Mass = mass,
                Owner = owner,
                StartDate = start,
                EndDate = end,
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
