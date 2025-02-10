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
using DAO.Model;
using DAO.Implementation;
using System.Data;
using System.IO;
using AForge.Video.DirectShow;
using System.Drawing;
using AForge.Video;
using System.Threading;

namespace ValcotDB.Usuarios
{
    /// <summary>
    /// Lógica de interacción para Usuarios.xaml
    /// </summary>
    public partial class Usuarios : UserControl
    {
        private bool HayDispositivos;
        private FilterInfoCollection Camera;
        private VideoCaptureDevice MiWebCam;

        System.Windows.Controls.Image image = new System.Windows.Controls.Image(); 


        private Bitmap ImagenBitmap;
        private Bitmap auxiliar;

        UserImpl implUser;
        User user;
        sbyte option = -1;
        public Usuarios()
        {
            InitializeComponent();
            CargaDispositivos();
        }
        void CargaDispositivos()
        {
            Camera = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (Camera.Count > 0)
            {
                HayDispositivos = true;
                for (int i = 0; i < Camera.Count; i++)
                {
                    cbxDispositivo.Items.Add(Camera[i].Name.ToString());
                    cbxDispositivo.Text = Camera[0].ToString();
                }
            }
            else
            {
                HayDispositivos = false;
            }
        }
        void LoadDataGrid()
        {
            try
            {
                implUser = new UserImpl();
                dgvDatos.ItemsSource = null;
                dgvDatos.ItemsSource = implUser.Selec().DefaultView;
                dgvDatos.Columns[0].Visibility = Visibility.Collapsed;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        void EnableButtons()
        {
            btnInsert.IsEnabled = false;
            btnUpdate.IsEnabled = false;
            btnDelete.IsEnabled = false;

            btnSave.IsEnabled = true;
            btnCancerlar.IsEnabled = true;

            txtNombre.IsEnabled = true;
            txtNombre.Focus();
            txtApellido.IsEnabled = true;
            txtApellido.Focus();
            txtRol.IsEnabled = true;
            txtRol.Focus();
            txtemail.IsEnabled = true;
            txtemail.Focus();
            txtNombreusuario.IsEnabled = true;
            txtNombreusuario.Focus();
            txtContraseña.IsEnabled = true;
            txtContraseña.Focus();
            txtCi.IsEnabled = true;
            txtCi.Focus();
        }


        void DisableButtons()
        {
            btnInsert.IsEnabled = true;
            btnUpdate.IsEnabled = true;
            btnDelete.IsEnabled = true;

            btnSave.IsEnabled = false;
            btnCancerlar.IsEnabled = false;
            txtNombre.IsEnabled = false;
            txtApellido.IsEnabled = false;
            txtRol.IsEnabled = false;
            txtemail.IsEnabled = false;
            txtNombreusuario.IsEnabled = false;
            txtContraseña.IsEnabled = false;
            txtCi.IsEnabled = false;
        }

        private void dgvDatos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgvDatos.Items.Count > 0 && dgvDatos.SelectedItem != null)
            {
                try
                {

                    DataRowView dataRow = (DataRowView)dgvDatos.SelectedItem;
                    byte id = byte.Parse(dataRow.Row.ItemArray[0].ToString());
                    implUser = new UserImpl();
                    user = implUser.GetAdmin(id);
                    txtRol.Text = user.Role;
                    txtNombreusuario.Text = user.UserName;
                    txtNombre.Text = user.UserFirstName;
                    txtApellido.Text = user.UserLastName;
                    txtemail.Text = user.UserEmail;
                    txtCi.Text = user.UserCI;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        #region PARA Usuario Y Contraseña
        private void Label_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            //GENERAR NOMBRE DE USUARIO
            int longitud = 6;
            txtNombreusuario.Text = GenerarPassword(longitud);
        }

        private void Label_MouseLeftButtonUp_1(object sender, MouseButtonEventArgs e)
        {
            //GENERAR CONTRASEÑA
            int longitud = 6;
            txtContraseña.Text = GenerarPassword(longitud);
        }
        public static string GenerarPassword(int longitud)
        {
            string contraseña = string.Empty;
            string[] letras = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "ñ", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z",
                                "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"};
            Random EleccionAleatoria = new Random();

            for (int i = 0; i < longitud; i++)
            {
                int LetraAleatoria = EleccionAleatoria.Next(0, 100);
                int NumeroAleatorio = EleccionAleatoria.Next(0, 9);

                if (LetraAleatoria < letras.Length)
                {
                    contraseña += letras[LetraAleatoria];
                }
                else
                {
                    contraseña += NumeroAleatorio.ToString();
                }
            }
            return contraseña;
        }
        #endregion


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
                        implUser = new UserImpl();
                        int res = implUser.Delete(user);
                        if (res > 0)
                        {
                            MessageBox.Show(res + "Registro Eliminado ");
                            LoadDataGrid();
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        public void enviarcorreo()
        { //PONER PARA QUE PASE LA CONTRASEÑA Y EL NOMBRE DE USUARIO
            string mensaje;
            string mensaje2;
            mensaje = "CONTRASEÑA DE ACCESO";
            mensaje2 = "Su Nombre de usuario es : " + txtNombreusuario.Text + "   Y su contraseña es: " + txtContraseña.Text;

            System.Net.Mail.MailMessage mmsg = new System.Net.Mail.MailMessage();

            mmsg.To.Add(txtemail.Text);
            mmsg.Subject = mensaje;
            mmsg.SubjectEncoding = System.Text.Encoding.UTF8;

            mmsg.Body = mensaje2;
            mmsg.BodyEncoding = System.Text.Encoding.UTF8;
            mmsg.IsBodyHtml = true;
            mmsg.From = new System.Net.Mail.MailAddress("Valcot2021@hotmail.com");


            System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();
            cliente.Credentials = new System.Net.NetworkCredential("Valcot2021@hotmail.com", "valcot2001");
            cliente.Port = 587;
            cliente.EnableSsl = true;
            cliente.Host = "smtp.office365.com";
            try
            {
                cliente.Send(mmsg);
            }
            catch (Exception)
            {

                MessageBox.Show("Error al enviar");
            }
        }
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            switch (this.option)
            {
                case 1: //insertar
                    try
                    {
                        int id;
                        user = new User(txtRol.Text, txtNombreusuario.Text, txtContraseña.Text, txtNombre.Text, txtApellido.Text, txtemail.Text, txtCi.Text,  Session.SessionID, 1);
                        implUser = new UserImpl();
                        int res = implUser.Insert(user);
                        id = implUser.SaveId();
                        if (res > 0)
                        {
                            Bitmap ImagenBit = ImagenBitmap;
                            id = id - 1;
                            ImagenBit.Save($@"{Config.UserImage}\{id}.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                            MessageBox.Show("Registro Insertado con exito!");
                            LoadDataGrid();
                            DisableButtons();
                            //enviarcorreo();
                        }

   
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                    break;

                case 2: //Moodificar
                    try
                    {
                        user.Role = txtRol.Text;
                        user.UserName = txtNombreusuario.Text;
                        user.Password = txtContraseña.Text;
                        user.UserFirstName = txtNombre.Text;
                        user.UserLastName = txtApellido.Text;
                        user.UserEmail = txtemail.Text;
                        user.UserCI = txtCi.Text;
                        user.UserID = Session.SessionID;
                        implUser = new UserImpl();
                        int res = implUser.Update(user);
                        if (res > 0)
                        {
                            MessageBox.Show("Registro Modificado con exito!");
                            LoadDataGrid();
                            DisableButtons();
                        }

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }

                    break;
            }
        }

        private void btnCancerlar_Click(object sender, RoutedEventArgs e)
        {
            DisableButtons();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            LoadDataGrid();
        }

        private void btnFoto_Click(object sender, RoutedEventArgs e)
        {
            image.Source = image1.Source;
            ImagenBitmap = auxiliar;
            CerrarWebCam();
        }

        private void btnCargar_Click(object sender, RoutedEventArgs e)
        {
            CerrarWebCam();
            int i = cbxDispositivo.SelectedIndex;
            string NombreVideo = Camera[i].MonikerString;
            MiWebCam = new VideoCaptureDevice(NombreVideo);
            MiWebCam.NewFrame += new NewFrameEventHandler(Capture);
            MiWebCam.Start();
        }
        private void CerrarWebCam()
        {
            if (MiWebCam != null && MiWebCam.IsRunning)
            {
                MiWebCam.SignalToStop();
                MiWebCam = null;
            }
        }
        public void Capture(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            var memory = new MemoryStream();
            bitmap.Save(memory, System.Drawing.Imaging.ImageFormat.Png);
            memory.Position = 0;
            var bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.StreamSource = memory;
            bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
            bitmapImage.EndInit();
            bitmapImage.Freeze();
            Dispatcher.BeginInvoke(new ThreadStart(delegate { image1.Source = bitmapImage; }));
            Dispatcher.BeginInvoke(new ThreadStart(delegate { auxiliar = bitmap; }));
        }
    }
}
