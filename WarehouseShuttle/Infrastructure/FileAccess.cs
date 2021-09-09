﻿using System;
using System.Collections.Generic;
using System.IO;
using WarehouseShuttle.Models;

namespace WarehouseShuttle.Infrastructure
{
    public class FileAccess
    {
        private const string packages = "packages.bin";

        public void WritePackageToFile(Package package)
        {
            FileStream fs;
            BinaryWriter bw;

            try
            {
                fs = new FileStream(packages, FileMode.Append);
                bw = new BinaryWriter(fs);
            }
            catch
            {
                return;
            }

            try
            {
                bw.Write(value: package.Number);
                bw.Write(value: package.StorageCellNumber);
                bw.Write(value: package.PackageInternationalNumber);
                bw.Write(value: package.Mass);
                bw.Write(value: package.Owner);
                bw.Write(value: package.StartDate.ToString());
                bw.Write(value: package.EndDate.ToString());
                bw.Write(value: package.Price);
                bw.Write(value: package.Password);
                bw.Write(value: package.SoftDeleted);
            }
            catch
            {
                return;
            }

            bw.Close();
            fs.Close();
        }

        public void ReWritePackagesToFile(List<Package> packages)
        {
            FileStream fs;
            BinaryWriter bw;

            try
            {
                fs = new FileStream(FileAccess.packages, FileMode.Create);
                bw = new BinaryWriter(fs);
            }
            catch
            {
                return;
            }

            try
            {
                foreach (var package in packages)
                {
                    bw.Write(value: package.Number);
                    bw.Write(value: package.StorageCellNumber);
                    bw.Write(value: package.PackageInternationalNumber);
                    bw.Write(value: package.Mass);
                    bw.Write(value: package.Owner);
                    bw.Write(value: package.StartDate.ToString());
                    bw.Write(value: package.EndDate.ToString());
                    bw.Write(value: package.Price);
                    bw.Write(value: package.Password);
                    bw.Write(value: package.SoftDeleted);
                }
            }
            catch
            {
                return;
            }

            bw.Close();
            fs.Close();
        }

        public List<Package> ReadPackagesFromFile()
        {
            List<Package> packages = new List<Package>();

            FileStream fs;
            BinaryReader br;

            try
            {
                fs = new FileStream(FileAccess.packages, FileMode.Open);
                br = new BinaryReader(fs);
            }
            catch
            {
                return packages;
            }

            int Id = 0;
            int StorageCellNumber = 0;
            string PackageInternationalNumber = string.Empty;
            decimal Mass = 0m;
            string Owner = string.Empty;
            DateTime StartDate;
            DateTime EndDate;
            decimal Price = 0;
            string Password = string.Empty;
            bool SoftDeleted = false;

            try
            {
                while (true)
                {
                    try
                    {
                        Id = br.ReadInt32();
                        StorageCellNumber = br.ReadInt32();
                        PackageInternationalNumber = br.ReadString();
                        Mass = br.ReadDecimal();
                        Owner = br.ReadString();
                        StartDate = DateTime.Parse(br.ReadString());
                        EndDate = DateTime.Parse(br.ReadString());
                        Price = br.ReadDecimal();
                        Password = br.ReadString();
                        SoftDeleted = br.ReadBoolean();

                        packages.Add(new Package()
                        {
                            Number = Id,
                            StorageCellNumber = StorageCellNumber,
                            PackageInternationalNumber = PackageInternationalNumber,
                            Mass = Mass,
                            Owner = Owner,
                            StartDate = StartDate,
                            EndDate = EndDate,
                            Price = Price,
                            Password = Password,
                            SoftDeleted = SoftDeleted
                        });
                    }
                    catch { break; }
                }
            }
            catch
            {
            }

            br.Close();
            fs.Close();

            return packages;
        }
    }
}
