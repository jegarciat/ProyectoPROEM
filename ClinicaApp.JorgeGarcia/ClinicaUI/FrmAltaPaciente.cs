using Entidades;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ClinicaUI
{
    public partial class FrmAltaPaciente : Form
    {
        public FrmAltaPaciente()
        {
            InitializeComponent();
        }

        private void FrmAltaPaciente_Load(object sender, EventArgs e)
        {
            this.cmbObraSocial.DataSource = Enum.GetValues(typeof(EObraSocial));
        }

        /// <summary>
        /// Se encarga de validar y agregar un paciente a la lista de espera.
        /// Si hay errores en los datos se muestra un mensaje con el error.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validador.SoloLetras(txtNombre.Text) && Validador.SoloLetras(txtApellido.Text) && Validador.DniValido(txtDni.Text) && Validador.EdadValida(txtEdad.Text))
                {
                    Paciente nuevoPaciente = new Paciente(int.Parse(txtDni.Text), txtNombre.Text, txtApellido.Text, int.Parse(txtEdad.Text), (EObraSocial)cmbObraSocial.SelectedItem);

                    if (Clinica.PacientesEnEspera.ToList().TrueForAll((x) => x != nuevoPaciente))
                    {
                        Clinica.PacientesEnEspera.Enqueue(nuevoPaciente);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Ya existe un paciente con el DNI ingresado. Vuelva a intentarlo", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (PersonaException ex)
            {
                MessageBox.Show(ex.Message, "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
