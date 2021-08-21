using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using DesktopContactsApp.Classes;
using SQLite;


namespace DesktopContactsApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Contact> contacts;

        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            contacts = new List<Contact>();
            ReadDatabase();
        }

        private void Save_Contact_click(object sender, RoutedEventArgs e)
        {
            ContactsAppWindow contactsAppWindow = new ContactsAppWindow();
            contactsAppWindow.ShowDialog();

            ReadDatabase();
        }
        void ReadDatabase()
        {
            
            using (SQLiteConnection connection = new SQLiteConnection(App.databasePath))
            {
                connection.CreateTable<Contact>();
                contacts = connection.Table<Contact>().ToList().OrderBy(c=> c.Name).ToList();
                
                //the lines below are the equiv of the Language Integrated Query (linq) above
                //var variable = from c1 in contacts
                //               orderby c1.Name
                //               select c1;
            }
            if(contacts != null)
            {
                //foreach (var c in contacts)
                //{
                //    contactListView.Items.Add(new ListViewItem() { Content = c });
                //}
                //the four lines above do the same as the line below. Not exactly the same function though
                contactListView.ItemsSource = contacts;
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox searchTextbox = sender as TextBox;
            var filteredList = contacts.Where(c => c.Name.ToLower().Contains(searchTextbox.Text.ToLower())).ToList();
            //the lines below are the Language Integrated Query (linq) equiv of the line above
            //var filteredlist = (from c2 in contacts
            //                    where c2.Name.ToLower().Contains(searchTextbox.Text.ToLower())
            //                    orderby c2.Name
            //                    select c2.Id).ToList();
            contactListView.ItemsSource = filteredList;
        }

        private void contactListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Contact SelectedContact = contactListView.SelectedItem as Contact;
            if(SelectedContact != null)
            {
                contactdetailswindow contactdetailswindow = new contactdetailswindow(SelectedContact);
                contactdetailswindow.ShowDialog();
            }
            ReadDatabase();
        }
    }
}