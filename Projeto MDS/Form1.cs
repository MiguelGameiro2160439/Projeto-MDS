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
    public partial class Form1 : Form
    {
        Model1Container container;
        public Form1()
        {
            InitializeComponent();
            container = new Model1Container();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* Container consultaselecionada = (Tournament)listBox1.SelectedItem;

            if (torneioselecionado != null)
            {
                torneioselecionado.Name = textBoxName.Text;
                torneioselecionado.Description = textBoxDescription.Text;
                torneioselecionado.Date = dateTimePicker1.Value;
                Projeto.SaveChanges();
            }

            MessageBox.Show("Editado com Sucesso.");

            textBoxName.Text = "";
            textBoxDescription.Text = "";

            listBox1.Items.Clear();
            listBox1.Items.AddRange(Projeto.TournamentSet.ToArray());*/
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*Tournament torneioselecionado = (Tournament)listBox1.SelectedItem;

            if (torneioselecionado != null)
            {

                textBoxName.Text = torneioselecionado.Name;
                textBoxDescription.Text = torneioselecionado.Description;
                dateTimePicker1.Value = torneioselecionado.Date;

            }*/
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
