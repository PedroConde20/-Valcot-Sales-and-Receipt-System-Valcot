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
using DAO.Model;
using DAO.Implementation;
using System.Data;
using Microsoft.Maps.MapControl.WPF;

namespace ValcotDB.Stores
{
    /// <summary>
    /// Lógica de interacción para winAdmStores.xaml
    /// </summary>
    public partial class winAdmStores : Window
    {
        StoreImpl implStore;
        Store store;
        sbyte option = -1;
        double lat;
        double lon;
        public winAdmStores()
        {
            InitializeComponent();
        }
        void LoadDataGrid()
        {
            try
            {
                implStore = new StoreImpl();
                dgvDatos.ItemsSource = null;
                dgvDatos.ItemsSource = implStore.Selec().DefaultView;
                
            }
            catch (Exception)
            {

                MessageBox.Show("No es posible completar la transaccion\n Comuniquese con el Adm. de sistemas");
            }
        }

        void EnableButtons()
        {
            btnInsert.IsEnabled = false;
            btnUpdate.IsEnabled = false;
            btnDelete.IsEnabled = false;

            btnSave.IsEnabled = true;
            btnCancerlar.IsEnabled = true;
            txtNombreTienda.IsEnabled = true;
            txtNombreTienda.Focus();
            txtDireccion.IsEnabled = true;
            txtDireccion.Focus();
            txtemail.IsEnabled = true;
            txtemail.Focus();
        }


        void DisableButtons()
        {
            btnInsert.IsEnabled = true;
            btnUpdate.IsEnabled = true;
            btnDelete.IsEnabled = true;

            btnSave.IsEnabled = false;
            btnCancerlar.IsEnabled = false;
            txtNombreTienda.IsEnabled = false;
            txtDireccion.IsEnabled = false;
            txtemail.IsEnabled = false;
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadDataGrid();
        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            EnableButtons();
            this.option = 1;
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            EnableButtons();
            this.option = 2;
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {

            if (dgvDatos.SelectedItem != null && dgvDatos.Items.Count > 0)
            {
                if (MessageBox.Show("Esta realmente segur@ \nde eliminar el registro?", "Eliminar", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
                {
                    try
                    {
                        implStore = new StoreImpl();
                        int res = implStore.Delete(store);
                        if (res > 0)
                        {
                            MessageBox.Show(res + "Registro Eliminado ");
                            LoadDataGrid();
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("No es posible realizar la accion");
                    }
                }
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            switch (this.option)
            {
                case 1: //insertar
                    try
                    {
                        store = new Store(txtDireccion.Text, txtNombreTienda.Text, txtemail.Text,double.Parse(txtLatitud.Text),double.Parse(txtLongitud.Text),Session.SessionID);
                        implStore = new StoreImpl();
                        int res = implStore.Insert(store);
                        if (res > 0)
                        {
                            MessageBox.Show("Registro Insertado con exito!");

                            LoadDataGrid();
                            DisableButtons();

                        }
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("No es posible completar la transaccion\nComuniquese con el adm de sistemas");
                    }
                    break;

                case 2: //Moodificar
                    try
                    {
                        store.StoreDirection = txtDireccion.Text;
                        store.StoreName = txtNombreTienda.Text;
                        store.StoreEmail = txtemail.Text;
                        store.StoreLatitud = double.Parse(txtLatitud.Text);
                        store.StoreLongitud = double.Parse(txtLongitud.Text);
                        store.UserID = (Byte)Session.SessionID;
                        implStore = new StoreImpl();
                        int res = implStore.Update(store);
                        if (res > 0)
                        {
                            MessageBox.Show("Registro Modificado con exito!");
                            LoadDataGrid();
                            DisableButtons();
                        }

                    }
                    catch (Exception)
                    {

                        MessageBox.Show("No es posible completar la transaccion\nComuniquese con el adm de sistemas");
                    }

                    break;
            }
        }

        private void btnCancerlar_Click(object sender, RoutedEventArgs e)
        {
            DisableButtons();
        }

        private void dgvDatos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgvDatos.Items.Count > 0 && dgvDatos.SelectedItem != null)
            {
                try
                {

                    DataRowView dataRow = (DataRowView)dgvDatos.SelectedItem;
                    byte id = byte.Parse(dataRow.Row.ItemArray[0].ToString());
                    implStore = new StoreImpl();
                    store = implStore.Get(id);
                    txtNombreTienda.Text = store.StoreName;
                    txtDireccion.Text = store.StoreDirection;
                    txtemail.Text = store.StoreEmail;
                    txtLatitud.Text = Convert.ToString(store.StoreLatitud);
                    txtLongitud.Text =Convert.ToString(store.StoreLongitud);
                }
                catch (Exception)
                {

                    MessageBox.Show("No es posible completar la transaccion\nComuniquese con el adm de sistemas");
                }
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAereo_Click(object sender, RoutedEventArgs e)
        {
            MyMap.Focus();
            MyMap.Mode = new AerialMode();
        }

        private void btnCalles_Click(object sender, RoutedEventArgs e)
        {
            MyMap.Focus();
            MyMap.Mode = new RoadMode();
        }

        private void btnzoommas_Click(object sender, RoutedEventArgs e)
        {
            MyMap.Focus();
            MyMap.ZoomLevel++;
        }

        private void btnzoommenos_Click(object sender, RoutedEventArgs e)
        {
            MyMap.Focus();
            MyMap.ZoomLevel--;
        }

        private void MyMap_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MyMap.Children.Clear();
            e.Handled = true;

            Point pointMouse = e.GetPosition(MyMap);
            Location location = MyMap.ViewportPointToLocation(pointMouse);
            Pushpin pushpin = new Pushpin();
            pushpin.Location = location;
            MyMap.Children.Add(pushpin);
            lat = double.Parse(pushpin.Location.Latitude.ToString());
            lon = double.Parse(pushpin.Location.Longitude.ToString());
            txtLatitud.Text = Convert.ToString(lat);
            txtLongitud.Text = Convert.ToString(lon);
        }
    }
}
