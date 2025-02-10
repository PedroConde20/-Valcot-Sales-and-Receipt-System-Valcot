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

namespace ValcotDB.Usuarios
{
    /// <summary>
    /// Lógica de interacción para Reportes.xaml
    /// </summary>
    public partial class Reportes : UserControl
    {
        public Reportes()
        {
            InitializeComponent();

        }

        private void btnReporte1_Click(object sender, RoutedEventArgs e)
        {
            DateTime dInicio = dtpInicioPickerr.SelectedDate.Value;
            DateTime dFin = dtpFinPickerr.SelectedDate.Value;
            /*CrystalReport1 cr1 = new CrystalReport1();
            cr1.Load(@"CrystalReport1.rpt");
            cr1.SetParameterValue("@inicio", Convert.ToString(dInicio));
            cr1.SetParameterValue("@fin", Convert.ToString(dFin));
            viewer.ViewerCore.ReportSource = cr1;*/
        }

        private void btnReporte2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnReporte3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            //no sirve
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
