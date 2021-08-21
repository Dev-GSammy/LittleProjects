using System.Windows;
using DesktopContactsApp.Classes;
using SQLite;

namespace DesktopContactsApp
{
    /// <summary>
    /// Interaction logic for ContactsAppWindow.xaml
    /// </summary>
    public partial class ContactsAppWindow : Window
    {
        public ContactsAppWindow()
        {
            InitializeComponent();
            Owner = Application.Current.MainWindow;
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void Button_Save_Click(object sender, RoutedEventArgs e)
        {
            //save into database.

            Contact contact = new Contact()
            {
                Name = Nametextbox.Text,
                Email = Emailtextbox.Text,
                Phone = Phonenumbertextbox.Text
            };
            using (SQLiteConnection connection = new SQLiteConnection(App.databasePath))
            {
                connection.CreateTable<Contact>();
                connection.Insert(contact);
            }
            Close();
        }
    }
}
