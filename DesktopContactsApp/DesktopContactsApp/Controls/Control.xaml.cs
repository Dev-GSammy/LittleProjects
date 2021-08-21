using DesktopContactsApp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DesktopContactsApp.Controls
{
    /// <summary>
    /// Interaction logic for Control.xaml
    /// </summary>
    public partial class Control : UserControl
    {
        /// <summary>
        /// The following lines are commented because C# did not regard them as a dependency property. It throws and "app break" error
        /// </summary>
        //private Contact contact;

        //public Contact Contact
        //{
        //    get { return Contact; }
        //    set
        //    {
        //        Contact = value;
        //        Nametextblock.Text = contact.Name;
        //        Emailtextblock.Text = contact.Email;
        //        Phonetextblock.Text = Contact.Phone;

        //    }
        //}


        public Contact contact
        {
            get { return (Contact)GetValue(contactProperty); }
            set { SetValue(contactProperty, value); }
        }

        // Using a DependencyProperty as the backing store for contact.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty contactProperty =
            DependencyProperty.Register("contact", typeof(Contact), typeof(Control), new PropertyMetadata(new Contact() {Name = "No name", Email = "yourname@domain.com", Phone = "(+234) 123 456 78"}, SetText));

        private static void SetText(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            Control control = d as Control;

            if(control != null)
            {
                control.Nametextblock.Text = (e.NewValue as Contact).Name;
                control.Emailtextblock.Text = (e.NewValue as Contact).Email;
                control.Phonetextblock.Text = (e.NewValue as Contact).Phone;
            }
        }

        public Control()
        {
            InitializeComponent();
        }
    }
}
