﻿using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EFL_Xamarin
{
    public partial class App : Application
    {
        static Database database;
        public static Database Database
        {
            get
            {
                if (database == null)
                {
                    database = new Database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "eflxamarin.db3"));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new StudentsPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
