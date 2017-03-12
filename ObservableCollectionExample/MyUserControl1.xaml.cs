using ObservableCollectionExample.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace ObservableCollectionExample
{
    public sealed partial class MyUserControl1 : UserControl
    {
        
        private List<Icon> Icons;
        //private List<Contact> Contacts;

            
        private ObservableCollection<Contact> Contacts;

        public MyUserControl1()
        {
            this.InitializeComponent();

            //Creating new list called icon
            Icons = new List<Icon>();

            //Add the icons to the icon list
            Icons.Add(new Icon { IconPath = "Assets/male-01.png" });
            Icons.Add(new Icon { IconPath = "Assets/male-02.png" });
            Icons.Add(new Icon { IconPath = "Assets/male-03.png" });
            Icons.Add(new Icon { IconPath = "Assets/female-01.png" });
            Icons.Add(new Icon { IconPath = "Assets/female-02.png" });
            Icons.Add(new Icon { IconPath = "Assets/female-03.png" });
            Icons.Add(new Icon { IconPath = "Assets/download.png" });

            //Contacts = new List<Contact>();

            //Creating a observable collection for Created Contacts
            Contacts = new ObservableCollection<Contact>();

        }

        private void NewContactButton_Click(object sender, RoutedEventArgs e)
        {
            string avatar = ((Icon)AvatarComboBox.SelectedValue).IconPath;
            Contacts.Add(new Contact { FirstName = FirstNameTextBox.Text, LastName = LastNameTextBox.Text, AvatarPath = avatar });

            FirstNameTextBox.Text = "";
            LastNameTextBox.Text = "";
            AvatarComboBox.SelectedIndex = -1;

            FirstNameTextBox.Focus(FocusState.Programmatic);
        }
    }
}
