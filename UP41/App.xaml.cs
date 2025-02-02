﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO.IsolatedStorage;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using UP41.Components;

namespace UP41
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static UP421Entities db = new UP421Entities();
        public static string currentUser;

        protected override void OnExit(ExitEventArgs e)
        {
            App.db.SaveChanges();
            try
            {
                IsolatedStorageFile isolatedStorage = IsolatedStorageFile.GetUserStoreForAssembly();

                StreamWriter writer = new StreamWriter(new IsolatedStorageFileStream("isotest", FileMode.Create, isolatedStorage));

                if (App.Current.Properties[0] != null)
                {
                    writer.WriteLine(App.Current.Properties[0].ToString());
                }
                writer.Flush();
                writer.Close();
                base.OnExit(e);
            }
            catch (System.Security.SecurityException sx)
            {
                MessageBox.Show(sx.Message);
                throw;
            }
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            try
            {
                IsolatedStorageFile isolatedStorage = IsolatedStorageFile.GetUserStoreForAssembly();
                StreamReader srReader = new StreamReader(new IsolatedStorageFileStream("isotest", FileMode.OpenOrCreate, isolatedStorage));

                if (srReader == null)
                {
                    MessageBox.Show("No Data stored!");
                }
                else
                {
                    while (!srReader.EndOfStream)
                    {
                        currentUser = srReader.ReadLine();           
                    }
                }
                srReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
