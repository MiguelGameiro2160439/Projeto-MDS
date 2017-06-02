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
    public partial class FormRescheduleMedicalAppointment : Form
    {
        Model1Container container;
        public FormRescheduleMedicalAppointment()
        {
            InitializeComponent();

            container = new Model1Container();

            listBoxReschedule.Items.Clear();
            listBoxReschedule.Items.AddRange(container.ConsultaSet.ToArray());
        }




        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            Consulta consultaselecionada = (Consulta)listBoxReschedule.SelectedItem;

            if (consultaselecionada != null)
            {
                consultaselecionada.Data = dateTimePicker1.Value;
                consultaselecionada.Descricao = textBoxDescricao.Text;

                container.SaveChanges();
            }

            MessageBox.Show("Alterado com Sucesso.");


            textBoxDescricao.Text = "";

            listBoxReschedule.Items.Clear();
            listBoxReschedule.Items.AddRange(container.ConsultaSet.ToArray());
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            Consulta consultaselecionada = (Consulta)listBoxReschedule.SelectedItem;

            container.ConsultaSet.Remove(consultaselecionada);

            container.SaveChanges();

            MessageBox.Show("Apagado com Sucesso.");


            listBoxReschedule.Items.Clear();
            listBoxReschedule.Items.AddRange(container.ConsultaSet.ToArray());
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            foreach (Consulta item in container.ConsultaSet)
            {

                if (item.Descricao.ToUpper() == textBoxDescricao.Text.ToUpper())
                {

                    listBoxReschedule.Items.Clear();
                    listBoxReschedule.Items.Add(item);


                }



            }
        }
    }
    

}

