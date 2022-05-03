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
    /// Lógica de interacción para vtnRegular.xaml
    /// </summary>
    public partial class vtnRegular : Window
    {
        public vtnRegular()
        {
            InitializeComponent();
            
        }
        static CapaNegocio.Regular regular = new CapaNegocio.Regular();

        private void btnEscribir_Click(object sender, RoutedEventArgs e)
        {
            //Asignar propiedades al objeto alumno regular
            regular.Codigo = txtCodigo.Text.Trim();
            regular.Apellidos = txtApellidos.Text.Trim();
            regular.Nombres = txtNombres.Text.Trim();
            regular.Correo = txtCorreo.Text.Trim();
            regular.Domicilio = txtDomicilio.Text.Trim();
            regular.Escuela = txtEscuela.Text.Trim();
            regular.Seguro = txtSeguro.Text.Trim();
            regular.Ciclo = txtCiclo.Text.Trim();
            regular.Convalidaciones = txtConvalidaciones.Text.Trim();
            regular.Creditos = txtCreditos.Text.Trim();

            //Fecha de Nacimiento
            regular.FechaNac = dtpFechaNac.DisplayDate;
            MessageBox.Show("Los datos del alumno regular fueron registrados correctamente");

            //Lugar de Nacimiento
            if (cboLugarNac.SelectedIndex >= 1)
            {
                regular.LugarNac = cboLugarNac.Text;
            }
            else MessageBox.Show("Seleccione la región conrrecta");
        }

        private void btnLeer_Click(object sender, RoutedEventArgs e)
        {
            // Traer los atributos del objeto
            MessageBox.Show("Datos del Alumno Regular" + "\nCódigo: " + regular.Codigo + "\nApellidos: " +regular.Apellidos +
                            "\nNombres: " + regular.Nombres + "\nCorreo: " + regular.Correo +
                            "\nDomicilo: " + regular.Domicilio + "\nEscuela " + regular.Escuela +
                            "\nFecha de nacimiento: " + regular.FechaNac + "\nLugar de Nacimiento: " + regular.LugarNac +
                            "\nSeguro: " + regular.Seguro + "\nCiclo: " + regular.Ciclo +
                            "\nConvalidaciones: " + regular.Convalidaciones + "\nCréditos: " + regular.Creditos);
        }

        private void btnMetodo1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(regular.Existir());
        }

        private void btnMetodo2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(regular.Asistir());
        }

        private void btnMetodo3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(regular.Estudiar());
        }

        private void btnMetodo4_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(regular.Trabajar());
        }

        private void btnMetodo5_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(regular.Mejorar());
        }

        private void btnMetodo6_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(regular.Ponderar());
        }
    }
}
