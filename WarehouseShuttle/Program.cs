﻿using System;
using System.Windows.Forms;
using WarehouseShuttle.Infrastructure;

namespace WarehouseShuttle
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainFormScreen(new MockStoreRepository()));
        }
    }
}