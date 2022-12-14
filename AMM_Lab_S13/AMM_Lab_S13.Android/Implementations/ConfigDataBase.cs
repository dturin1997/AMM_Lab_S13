using AMM_Lab_S13.Droid.Implementations;
using AMM_Lab_S13.Interfaces;
using System.IO;
using Xamarin.Forms;


using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

[assembly: Dependency(typeof(ConfigDataBase))]
namespace AMM_Lab_S13.Droid.Implementations
{
    public class ConfigDataBase : IConfigDataBase
    {
        public string GetFullPath(string databaseFileName)
        {
            return Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), databaseFileName);
        }
    }

}