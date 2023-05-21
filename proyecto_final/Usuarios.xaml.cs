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
using static System.Net.Mime.MediaTypeNames;

namespace proyecto_final
{
	/// <summary>
	/// Lógica de interacción para Usuarios.xaml
	/// </summary>
	public partial class Usuarios : UserControl
	{
		private Administrador ad;

        public Usuarios(Administrador ad)
		{
			InitializeComponent();
			this.ad = ad; 
			
			CargarUsuarios();
		}

		private void CargarUsuarios()
		{
			DataContext = ad;
			lvUsuarios.ItemsSource = null; // Limpia la lista actual
			lvUsuarios.ItemsSource = ad.usuarios;
		}

		private void Deleteus(object sender, RoutedEventArgs e)
		{
			ad.usuarios.Pop();
			CargarUsuarios();
        }

        private void deleteAllUs(object sender, RoutedEventArgs e)
        {
			ad.usuarios.Clear();
			CargarUsuarios();
        }

        private void Administrador_ScrollChanged(object sender, ScrollChangedEventArgs e)
        {

        }
    }
}
