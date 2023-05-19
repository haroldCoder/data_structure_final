using proyecto_final;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
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
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Application;

namespace Crud_Wpf.View
{
    /// <summary>
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        MainWindow inicio = new MainWindow();
        //CONSTRUCTOR
        public Login()
        {
            InitializeComponent();

        }


        //MINIMIZAR VENTANA
        private void BtnMinimizar_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        //CERRAR APLICACION
        private void BtnCerrar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        //MOVER VENTANA CON CLICK-SOSTENIDO
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }
        //LOGIN (INGRESO)
        private void BtnIngresar_Click(object sender, RoutedEventArgs e)
        {
            Administrador ad = new Administrador();
			foreach (var i in ad.usuarios)
			{
				if(i.nombre == tblUsuario.Text)
                {
					this.Close();
					inicio.Show();
				}
                else
                {
                    tblMensaje.Text = "Usuario no existe";
                }
			}
		}
    }
}

