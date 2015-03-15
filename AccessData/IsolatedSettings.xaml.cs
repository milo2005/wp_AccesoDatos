using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.IO.IsolatedStorage;

namespace AccessData
{
    public partial class IsolatedSettings : PhoneApplicationPage
    {
        public const String TXT_KEY = "texto";

        public IsolatedSettings()
        {
            InitializeComponent();
            readSettings();
        }

        private void saveText(object sender, RoutedEventArgs e)
        {

            if (IsolatedStorageSettings
                .ApplicationSettings.Contains(TXT_KEY)) {
                IsolatedStorageSettings
                    .ApplicationSettings[TXT_KEY] = field.Text;
            }
            else { 

                IsolatedStorageSettings
                    .ApplicationSettings.Add(TXT_KEY,field.Text);
            }
        }

        public void readSettings() {

            if(IsolatedStorageSettings
                .ApplicationSettings.Contains(TXT_KEY)) { 
                String txt = IsolatedStorageSettings
                    .ApplicationSettings[TXT_KEY] as String;

                saved.Text = txt;
                }
        }

    }
}