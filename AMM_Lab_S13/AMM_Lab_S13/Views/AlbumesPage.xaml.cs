﻿using AMM_Lab_S13.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AMM_Lab_S13.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AlbumesPage : ContentPage
    {
        public AlbumesPage()
        {
            InitializeComponent();
            this.BindingContext = new AlbumesViewModel();
        }
    }
}