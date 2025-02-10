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
using DAO.Implementation;
using DAO.Model;

namespace ValcotDB.Transacciones
{
    /// <summary>
    /// Lógica de interacción para winTransaction.xaml
    /// </summary>
    public partial class winTransaction : Window
    {
        SaleImpl implSale;
        Sale sale;
        List<SaleDetail> productList = new List<SaleDetail>();
        public winTransaction()
        {
            InitializeComponent();
            viewer.Owner = this;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dtpSalePicker.SelectedDate = DateTime.Now;
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //OMITIR ESTO
        }

        private void dgvDatos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //OMITIR ESTO
        }

        private void dgvDatos_Loaded(object sender, RoutedEventArgs e)
        {
            //OMITIR ESTO
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            double totalp = 0;
            try
            {
                foreach (SaleDetail item in productList)
                {
                    totalp += item.Price * item.Quantiy;

                    int productId = item.WineID;
                    int soldQuantity = item.Quantiy;
                    WineImpl productImpl = new WineImpl();
                    Wine product = productImpl.Get(productId);
                    int currentStock = product.Stock;

                    // Restar la cantidad de productos vendidos de la cantidad actual en stock
                    int newStock = currentStock - soldQuantity;

                    // Actualizar la cantidad actual en stock del producto en la base de datos
                    product.Stock = newStock;
                    productImpl.Update(product);
                }
                sale = new Sale(totalp,dtpSalePicker.SelectedDate.Value,short.Parse(cbxClient.SelectedValue.ToString()));
                implSale = new SaleImpl();
                int id;
                implSale.Insert(sale, productList);
                id = implSale.SaveId();

                MessageBox.Show("Transaccion Ejecutada con exito" + (id-1));

                CrystalReportRecibo cr1 = new CrystalReportRecibo();
                cr1.Load(@"CrystalReportRecibo.rpt");
                cr1.SetParameterValue("@id", Convert.ToInt32(id - 1));
                viewer.ViewerCore.ReportSource = cr1;
                Logo.Visibility = Visibility.Collapsed;
                viewer.Visibility = Visibility.Visible;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancerlar_Click(object sender, RoutedEventArgs e)
        {
            //OMITIR ESTO
        }

        private void cbxCategoryWine_Loaded(object sender, RoutedEventArgs e)
        {
            //OMITIR ESTO
        }

        void LoadComboClients()
        {
            try
            {
                ClienteImpl implClient = new ClienteImpl();
                cbxClient.DisplayMemberPath = "Client";
                cbxClient.SelectedValuePath = "clientID";
                cbxClient.ItemsSource = implClient.SelectIDDescription().DefaultView;
                cbxClient.SelectedIndex = 0;
            }
            catch (Exception)
            {

                MessageBox.Show("Error al Ingresar los datos");
            }
        }

        //void LoadComboStores()
        //{
        //    try
        //    {
        //        StoreImpl implStore = new StoreImpl();
        //        cbxStore.DisplayMemberPath = "storeName";
        //        cbxStore.SelectedValuePath = "storesID";
        //        cbxStore.ItemsSource = implStore.SelectStoreDescription().DefaultView;
        //        cbxStore.SelectedIndex = 0;
        //    }
        //    catch (Exception)
        //    {

        //        MessageBox.Show("Error al Procesar los datos");
        //    }
        //}

        private void cbxClient_Loaded(object sender, RoutedEventArgs e)
        {
            LoadComboClients();
        }

        private void cbxStore_Loaded(object sender, RoutedEventArgs e)
        {
            //OMITIR ESTO
        }

        private void mitAddProduct_Click(object sender, RoutedEventArgs e)
        {
            Cliente.winFindClientByName  win = new Cliente.winFindClientByName();
            DataClass.ClassID = "";
            win.ShowDialog();
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            if (DataClass.ClassID!="")
            {
                SaleDetail sale = new SaleDetail( short.Parse(DataClass.ClassID),int.Parse(DataClass.ClassData3), double.Parse(DataClass.ClassData2),DataClass.ClassData1);
                productList.Add(sale);
                dgvDatos.ItemsSource = null;
                dgvDatos.ItemsSource = productList;
                DataClass.ClassID = "";
            }
        }

        private void mitDelete_Click(object sender, RoutedEventArgs e)
        {
            //OMITIR ESTO
        }

        private void mitClear_Click(object sender, RoutedEventArgs e)
        {
            productList.Clear();
            dgvDatos.ItemsSource = null;
            dgvDatos.ItemsSource = productList;
        }

        private void btnRecibo_Click(object sender, RoutedEventArgs e)
        {
            winRecibo win = new winRecibo();
            win.ShowDialog();
        }
    }
}
