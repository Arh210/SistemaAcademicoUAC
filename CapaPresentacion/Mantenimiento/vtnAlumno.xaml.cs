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

namespace CapaPresentacion.Mantenimiento
{
    /// <summary>
    /// Lógica de interacción para vtnAlumno.xaml
    /// </summary>
    public partial class vtnAlumno : Window
    {
        public vtnAlumno()
        {
            InitializeComponent();
            
        }

        private void btnIngresante_Click(object sender, RoutedEventArgs e)
        {
            Alumno.vtnIngresante vtn = new Alumno.vtnIngresante();
            vtn.Show();

        }

        private void btnRegular_Click(object sender, RoutedEventArgs e)
        {
            Alumno.vtnRegular vtn = new Alumno.vtnRegular();
            vtn.Show();
        }
    }
}
