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
    /// Lógica de interacción para vtnDocente.xaml
    /// </summary>
    public partial class vtnDocente : Window
    {
        public vtnDocente()
        {
            InitializeComponent();
        }
        
        static CapaNegocio.Docente docente = new CapaNegocio.Docente();

        private void btnEscribir_Click(object sender, RoutedEventArgs e)
        {
            //Asignar propiedades al objeto docente
            docente.Codigo = txtCodigo.Text.Trim();
            docente.Apellidos = txtApellidos.Text.Trim();
            docente.Nombres = txtNombres.Text.Trim();
            docente.Correo = txtCorreo.Text.Trim();
            docente.Domicilio = txtDomicilio.Text.Trim();
            docente.Afp = txtAfp.Text.Trim();
            docente.Capacitaciones = txtCapacitaciones.Text.Trim();
            

            //Fecha de Nacimiento
            docente.FechaNac = dtpFechaNac.DisplayDate;

            //Lugar de Nacimiento
            if (cboLugarNac.SelectedIndex >= 1)
            {
                docente.LugarNac = cboLugarNac.Text;
            }
            else MessageBox.Show("Seleccione la región conrrecta");

            //Grado Académico
            if (cboGradoAcademico.SelectedIndex >= 1)
            {
                docente.GradoAcademico = cboGradoAcademico.Text;
            }
            else MessageBox.Show("Seleccione su grado académico");
            MessageBox.Show("Los datos del docente fueron registrados correctamente");
        }

        private void btnLeer_Click(object sender, RoutedEventArgs e)
        {
            // Traer los atributos del objeto
            MessageBox.Show("Datos del Docente\n" + "\nCodigo: " + docente.Codigo + "\nApellidos: " + docente.Apellidos + "\nNombres: " + docente.Nombres +
                            "\nCorreo: " + docente.Correo + "\nDomicilio: " + docente.Domicilio + "\nFecha de Nacimiento: " + docente.FechaNac +
                            "\nLugar de Nacimiento: " + docente.LugarNac + "\nAFP: " + docente.Afp + "\nCapacitaciones: " + docente.Capacitaciones +
                            "\nGrado académico: " + docente.GradoAcademico);
        }

        private void btnMetodo1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(docente.Asistir());
        }

        private void btnMetodo2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(docente.Existir());
        }

    }
}
