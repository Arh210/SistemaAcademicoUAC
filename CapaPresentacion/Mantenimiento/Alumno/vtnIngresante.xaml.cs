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

namespace CapaPresentacion.Mantenimiento.Alumno
{
    /// <summary>
    /// Lógica de interacción para vtnIngresante.xaml
    /// </summary>
    public partial class vtnIngresante : Window
    {
        public vtnIngresante()
        {
            InitializeComponent();
        }

        //Declarar un objeto
        static CapaNegocio.Ingresante ingresante = new CapaNegocio.Ingresante();

        private void btnEscribir_Click(object sender, RoutedEventArgs e)
        {
            //Asignar las propiedades al objeto alumno ingresante
            ingresante.Codigo = txtCodigo.Text.Trim();
            ingresante.Apellidos = txtApellidos.Text.Trim();
            ingresante.Nombres = txtNombres.Text.Trim();
            ingresante.Correo = txtCorreo.Text.Trim();
            ingresante.Domicilio = txtDomicilio.Text.Trim();
            ingresante.Escuela = txtEscuela.Text.Trim();
            ingresante.Seguro = txtSeguro.Text.Trim();
            ingresante.Colegio = txtColegio.Text.Trim();
            ingresante.Puesto = txtPuesto.Text.Trim();

            //Fecha de Nacimiento
            ingresante.FechaNac = dtpFechaNac.DisplayDate;
            MessageBox.Show("Los datos del alumno ingresante fueron registrados correctamente");

            //Lugar de Nacimiento
            if (cboLugarNac.SelectedIndex >= 1)
            {
                ingresante.LugarNac = cboLugarNac.Text;
            }
            else MessageBox.Show("Seleccione la región conrrecta");


        }
        private void btnLeer_Click(object sender, RoutedEventArgs e)
        {
            // Traer los atributos del objeto
            MessageBox.Show("Datos del Alumno Ingresante" + "\nCódigo: " + ingresante.Codigo + "\nApellidos: " + ingresante.Apellidos +
                            "\nNombres: " + ingresante.Nombres + "\nCorreo: " + ingresante.Correo +
                            "\nDomicilo: " + ingresante.Domicilio + "\nEscuela " + ingresante.Escuela +
                            "\nFecha de nacimiento: " + ingresante.FechaNac + "\nLugar de Nacimiento: " + ingresante.LugarNac +
                            "\nSeguro: " + ingresante.Seguro + "\nColegio: " + ingresante.Colegio +
                            "\nPuesto: " + ingresante.Puesto);
        }

        private void btnMetodo1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(ingresante.Existir());
        }

        private void btnMetodo2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(ingresante.Asistir());
        }

        private void btnMetodo3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(ingresante.Estudiar());
        }

        private void btnMetodo4_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(ingresante.Trabajar());
        }

        private void btnMetodo5_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(ingresante.Adaptar());
        }

        private void btnMetodo6_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(ingresante.Mantener());
        }
    }
}
