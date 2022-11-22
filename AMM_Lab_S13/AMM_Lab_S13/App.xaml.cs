﻿using AMM_Lab_S13.DataContext;
using AMM_Lab_S13.Interfaces;
using AMM_Lab_S13.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AMM_Lab_S13
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            GetContext().Database.EnsureCreated();
            MainPage = new NavigationPage(new AlbumesPage());

        }
        public static AppDbContext GetContext()
        {
            string DbPath = DependencyService.Get<IConfigDataBase>().GetFullPath("efCore.db");

            return new AppDbContext(DbPath);
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
