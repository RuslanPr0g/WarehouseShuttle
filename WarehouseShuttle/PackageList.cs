using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WarehouseShuttle.Models;

namespace WarehouseShuttle
{
    public partial class PackageList : Form
    {
        private readonly List<Package> _packages;

        public PackageList(List<Package> packages)
        {
            InitializeComponent();
            _packages = packages;
        }

        private void PackageList_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < _packages.Count; i++)
            {
                dataGridView1.Rows.Add(_packages.ElementAt(i).Number, 
                    _packages.ElementAt(i).StorageCellNumber,
                    _packages.ElementAt(i).PackageInternationalNumber,
                    _packages.ElementAt(i).Mass,
                    _packages.ElementAt(i).Owner,
                    _packages.ElementAt(i).StartDate,
                    _packages.ElementAt(i).EndDate,
                    _packages.ElementAt(i).Price,
                    _packages.ElementAt(i).SoftDeleted,
                    _packages.ElementAt(i).Password);
            }

            this.WindowState = FormWindowState.Maximized;
        }
    }
}
