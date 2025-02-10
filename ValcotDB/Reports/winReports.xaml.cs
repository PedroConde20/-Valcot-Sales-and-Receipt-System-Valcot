using CrystalDecisions.CrystalReports.Engine;
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

namespace ValcotDB.Reports
{
    /// <summary>
    /// Lógica de interacción para winReports.xaml
    /// </summary>
    public partial class winReports : Window
    {
        public winReports()
        {
            InitializeComponent();
            viewer.Owner = this;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnReporte1_Click(object sender, RoutedEventArgs e)
        {
            var dateInicio = Convert.ToDateTime(dtpInicio.SelectedDate.Value).ToString("yyyy/MM/dd");
            var dateFin = Convert.ToDateTime(dtpFin.SelectedDate.Value).ToString("yyyy/MM/dd");
            //string inicio = txtInicio.Text;
            //string fin = txtfin.Text;
            CrystalReport4 cr1 = new CrystalReport4();
            cr1.Load(@"CrystalReport4.rpt");
            cr1.SetParameterValue("@inicio", Convert.ToString(dateInicio));
            cr1.SetParameterValue("@fin", Convert.ToString(dateFin));
            viewer.ViewerCore.ReportSource = cr1;
        }

        private void btnReporte2_Click(object sender, RoutedEventArgs e)
        {
            var dateInicio = Convert.ToDateTime(dtpInicio.SelectedDate.Value).ToString("yyyy/MM/dd");
            var dateFin = Convert.ToDateTime(dtpFin.SelectedDate.Value).ToString("yyyy/MM/dd");
            //string inicio = txtInicio.Text;
            //string fin = txtfin.Text;
            CrystalReport3 cr1 = new CrystalReport3();
            cr1.Load(@"CrystalReport3.rpt");
            cr1.SetParameterValue("@inicio", Convert.ToString(dateInicio));
            cr1.SetParameterValue("@fin", Convert.ToString(dateFin));
            viewer.ViewerCore.ReportSource = cr1;
        }

        private void btnReporte3_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
