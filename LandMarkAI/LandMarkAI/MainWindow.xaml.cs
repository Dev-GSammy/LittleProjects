using LandMarkAI.Classes;
using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Linq;
using System.Net.Http;
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

namespace LandMarkAI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //The namespace Microsoft.win32 was added
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            dialog.Filter = "Image files (*.png; *.jpg; *.jpeg)|*.png;*.jpg;*.jpeg|All Files|(*.*)";
            if(dialog.ShowDialog() == true)
            {
                //the namespace system.io was added
                string filename = dialog.FileName;
                SelectedImage.Source = new BitmapImage(new Uri(filename));
                MakePredictionAsync(filename);
            }
        }

        /// <summary>
        /// Implementation of an API called REST. REST means Representational State Transfer.
        /// And By the way we used the function below to deserialize the objects sent by JSON (JavaScript Object Notation) and give
        /// it meaning in C# language.
        /// </summary>
        /// <param name="filename"></param>
        private async void MakePredictionAsync(string filename)
        {
            string url = "https://southcentralus.api.cognitive.microsoft.com/customvision/v3.0/Prediction/d8b32c96-155d-4a73-9be1-f2a59da5364a/classify/iterations/Iteration1/image";
            string predictionKey = "7b80e3a48c904b34803048bf20b0ad8d";
            string contentType = "application/octet-stream";
            var file = File.ReadAllBytes(filename);

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Prediction-Key", predictionKey);
                using (var content = new ByteArrayContent(file))
                {
                    //the namespace system.Net.http was added
                    try
                    {
                        content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue(contentType);
                        var response = await client.PostAsync(url, content);

                        //we downloaded the Nuget package Newtonsoft.json
                        var responseString = await response.Content.ReadAsStringAsync();

                        List<Prediction> predictions = (JsonConvert.DeserializeObject<CustomVision>(responseString).predictions);
                        predictionsListView.ItemsSource = predictions;
                    }
                    catch
                    {
                        MessageBox.Show("Unable to connect to internet. Please check your network and try again.");
                        Close();
                    }
                }
            }
        }
    }
}
