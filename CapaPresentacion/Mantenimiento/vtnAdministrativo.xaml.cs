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
    /// Lógica de interacción para vtnAdministrativo.xaml
    /// </summary>
    public partial class vtnAdministrativo : Window
    {
        public vtnAdministrativo()
        {
            InitializeComponent();
        }
        static CapaNegocio.Administrativo administrativo = new CapaNegocio.Administrativo();

        private void btnEscribir_Click(object sender, RoutedEventArgs e)
        {
            administrativo.Codigo = txtCodigo.Text.Trim();
            administrativo.Apellidos = txtApellidos.Text.Trim();
            administrativo.Nombres = txtNombres.Text.Trim();
            administrativo.Correo = txtCorreo.Text.Trim();
            administrativo.Domicilio = txtDomicilio.Text.Trim();

            //Fecha de Nacimiento
            administrativo.FechaNac = dtpFechaNac.DisplayDate;

            //Lugar de Nacimiento
            if (cboLugarNac.SelectedIndex >= 1)
            {
                administrativo.LugarNac = cboLugarNac.Text;
            }
            else MessageBox.Show("Seleccione la región conrrecta");

            //Experiencia
            if (cboExperiencia.SelectedIndex >= 1)
            {
                administrativo.Experiencia = cboExperiencia.Text;
            }
            else MessageBox.Show("Seleccione los años correctos");

            //Especialidad
            if (cboEspecialidad.SelectedIndex >= 1)
            {
                administrativo.Especialidad = cboEspecialidad.Text;
            }
            else MessageBox.Show("Seleccione la especialidad correcta");
            //Turno
            if (cboTurno.SelectedIndex >= 1)
            {
                administrativo.Turno = cboTurno.Text;
            }
            else MessageBox.Show("Seleccione el turno correcto");

            MessageBox.Show("Los datos del docente fueron registrados correctamente");

        }

        private void btnLeer_Click(object sender, RoutedEventArgs e)
        {
            //Traer los atributos del objeto
            MessageBox.Show("Datos del Administrativo" + "\nCódigo: " + administrativo.Codigo + "\nApellidos: " + administrativo.Apellidos + 
                            "\nNombres: " + administrativo.Nombres + "\nCorreo: " + administrativo.Correo + "\nDomicilio: " + administrativo.Domicilio +
                            "\nFecha de Nacimiento: " + administrativo.FechaNac + "\nLugar de Nacimiento: " + administrativo.LugarNac + 
                            "\nExperiencia: " + administrativo.Experiencia + "\nEspecialidad: " + administrativo.Especialidad + 
                            "\nTurno: " + administrativo.Turno);
        }

        private void btnMetodo1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(administrativo.Asistir());
        }

        private void btnMetodo2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(administrativo.Existir());
        }
    }
}
