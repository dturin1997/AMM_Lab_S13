using Foundation;
using System;
using System.IO;
using Xamarin.Forms;
using AMM_Lab_S13.Interfaces;
using AMM_Lab_S13.iOS.Implementations;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;

[assembly: Dependency(typeof(ConfigDataBase))]
namespace AMM_Lab_S13.iOS.Implementations
{
    public class ConfigDataBase : IConfigDataBase
    {
        public string GetFullPath(string databaseFileName)
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "..", "Library", databaseFileName);
        }
    }

}