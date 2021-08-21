using DesktopContactsApp.Classes;
using SQLite;
using System.Windows;


namespace DesktopContactsApp
{
    /// <summary>
    /// Interaction logic for contactdetailswindow.xaml
    /// </summary>
    public partial class contactdetailswindow : Window
    {
        Contact contact;
        public contactdetailswindow(Contact contact)
        { 
            InitializeComponent();
            //Next two lines references the Mainwindow as the motherwindow and makes this windows appear at it's center
            Owner = Application.Current.MainWindow;
            WindowStartupLocation = WindowStartupLocation.CenterScreen;

            this.contact = contact;
            Nametextbox.Text = this.contact.Name;
            Emailtextbox.Text = this.contact.Email;
            Phonenumbertextbox.Text = this.contact.Phone;
        }
        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        { 
            contact.Name = Nametextbox.Text;
            contact.Email = Emailtextbox.Text;
            contact.Phone = Phonenumbertextbox.Text;
            using (SQLiteConnection connection = new SQLiteConnection(App.databasePath))
            {
                connection.CreateTable<Contact>();
                connection.Update(contact);
            }
            Close();
        }
        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(App.databasePath))
            {
                connection.CreateTable<Contact>();
                connection.Delete(contact);
            }
            Close();
        }
    }
}
