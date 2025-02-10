using Microsoft.Win32;
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
using System.Windows.Shapes;

namespace ValcotDB.CategoriaImagenes
{
    /// <summary>
    /// Lógica de interacción para winCategoryImg.xaml
    /// </summary>
    public partial class winCategoryImg : Window
    {
        string ruta;
        public winCategoryImg()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCancerlar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void dgvDatos_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void btnAgregarImagen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Archivos de Imagen|*.jpg";
            if (openFile.ShowDialog() == true)
            {
                ruta = openFile.FileName;
                imgFoto.Source = new BitmapImage(new Uri(ruta));
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {

        }

        private void cbxCategoryWine_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void dgvDatos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
