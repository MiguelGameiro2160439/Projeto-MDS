using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_MDS
{
    public partial class FormRegistarPaciente : Form
    {

        public Paciente NovoPaciente { get; private set; }

        public FormRegistarPaciente()
        {
            InitializeComponent();
        }

        private void buttonRegistarPaciente_Click(object sender, EventArgs e)
        {
            NovoPaciente = new Paciente();

          
            NovoPaciente.Nome = textBoxNome.Text.Trim();
            NovoPaciente.Morada = textBoxMorada.Text.Trim();
            NovoPaciente.DataNascimento = dateTimePickerPaciente.Value;
            NovoPaciente.NºTelemovel = textBoxTelemovel.Text.Trim();
            NovoPaciente.N_Contribuinte = textBoxContribuinte.Text.Trim();
            NovoPaciente.Email = textBoxEmail.Text.Trim();

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
