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

namespace proyecto_final
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    /// 
    public class Usuario
    {
        public string nombre { get; set; }
        public uint numero { get; set; }
        public string sexo { get; set; }

        public Usuario(string nombre, uint numero, string sexo) {
            this.nombre = nombre;
            this.numero = numero;
            this.sexo = sexo == "Hombre" ? "./assets/jefe.png" : "./assets/mujer.png";
        }
    }
    public partial class MainWindow : Window
    {
		readonly Administrador adr = new Administrador();
       
		public MainWindow()
        {
            InitializeComponent();
            MyFrame.NavigationService.Navigate(new Usuarios(adr.usuarios));
        }

        private void frame_Navigated(object sender, NavigationEventArgs e)
        {

        }

		private void AddUse(object sender, RoutedEventArgs e)
		{
            Usuario us = new Usuario(boxname.Text, uint.Parse(boxnum.Text), rd.IsChecked.Value ? "Hombre" : "Mujer");
            adr.usuarios.Push(us);
			MyFrame.NavigationService.Navigate(new Usuarios(adr.usuarios));
		}
	}
}
