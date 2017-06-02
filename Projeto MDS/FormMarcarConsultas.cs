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
    public partial class FormMarcarConsultas : Form
    {
        private Model1Container container;
        public Consulta NovaConsula { get; private set; }

        public FormMarcarConsultas(Model1Container container)
        {
            InitializeComponent();

            this.container = new Model1Container();

            if (container != null)
            {
               comboBoxPaciente.Items.AddRange(container.PacienteSet.ToArray());

            }

            refreshListaPacientes();

        }

        private void buttonRegistarPaciente_Click(object sender, EventArgs e)
        {
            FormRegistarPaciente form = new FormRegistarPaciente();
            DialogResult resultado = form.ShowDialog();
            this.Close();
            if (resultado == DialogResult.OK)
            {
                AdicionarPaciente(form.NovoPaciente);
            }
        }

        private void refreshListaPacientes()
        {
            comboBoxPaciente.Items.Clear();
            comboBoxPaciente.Items.AddRange(container.PacienteSet.ToArray());
        }

        private void AdicionarPaciente(Paciente paciente)
        {
            container.PacienteSet.Add(paciente);
            container.SaveChanges();
        }


        private void buttonMarcarConsulta_Click(object sender, EventArgs e)
        {
            Paciente paciente = null;

            if (comboBoxPaciente.SelectedIndex > -1)
            {
                paciente = (Paciente)comboBoxPaciente.SelectedItem;
            }

            dateTimePickerConsulta.Format = DateTimePickerFormat.Custom;
            dateTimePickerConsulta.CustomFormat = "MM/dd/yyyy hh:mm:ss";

            NovaConsula = new Consulta();
            
            NovaConsula.Data = dateTimePickerConsulta.Value;
            NovaConsula.Descricao = "";
            NovaConsula.Paciente = paciente;       

        }
    }
}
