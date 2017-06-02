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
    public partial class FormTabelaPaciente : Form
    {
        private Model1Container container;
        private Paciente pacienteSelecionado;

        public FormTabelaPaciente()
        {
            InitializeComponent();

            container = new Model1Container();

            refreshListaPacientes();
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            FormRegistarPaciente form = new FormRegistarPaciente();
            DialogResult resultado = form.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                AdicionarPaciente(form.NovoPaciente);
            }

        }


        private void refreshListaPacientes()
        {
            listBoxPacientes.Items.Clear();
            listBoxPacientes.Items.AddRange(container.PacienteSet.ToArray());
        }
        private void AdicionarPaciente(Paciente paciente)
        {
    
                container.PacienteSet.Add(paciente);
                container.SaveChanges();
                refreshListaPacientes();
   
        }

        private void listBoxPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            pacienteSelecionado = (Paciente)listBoxPacientes.SelectedItem;
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            pacienteSelecionado = (Paciente)listBoxPacientes.SelectedItem;

            if (pacienteSelecionado != null)
            {
                //remover
                pacienteSelecionado = (Paciente)listBoxPacientes.SelectedItem;

                container.PacienteSet.Remove(pacienteSelecionado);

                container.SaveChanges();


                listBoxPacientes.Items.AddRange(container.PacienteSet.ToArray());

                //insere
                FormRegistarPaciente form = new FormRegistarPaciente();
                DialogResult resultado = form.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    AdicionarPaciente(form.NovoPaciente);
                }

            }
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            pacienteSelecionado = (Paciente)listBoxPacientes.SelectedItem;

            container.PacienteSet.Remove(pacienteSelecionado);

            container.SaveChanges();


            listBoxPacientes.Items.AddRange(container.PacienteSet.ToArray());
        }
    }
}
