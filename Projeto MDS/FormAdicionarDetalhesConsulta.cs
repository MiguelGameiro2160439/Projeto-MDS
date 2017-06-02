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
    public partial class FormAdicionarDetalhesConsulta : Form
    {
        private Model1Container container;
        private Consulta consultaSelecionada;

        public FormAdicionarDetalhesConsulta()
        {
            InitializeComponent();
            container = new Model1Container();
            refreshList();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (listBoxConsultas.SelectedIndex >= 0)
            {
                    consultaSelecionada = (Consulta)listBoxConsultas.SelectedItem;

                if (listBoxConsultas.SelectedIndex >= 0)
                {

                    consultaSelecionada = (Consulta)listBoxConsultas.SelectedItem;
                    textBoxDetalhes.Text = consultaSelecionada.Descricao;

                    container.SaveChanges();

                    textBoxDetalhes.Text = "";
                }
  
               

                else
                {
                    MessageBox.Show("Seleccione uma Consulta");
                }
            }
           
        }

        private void refreshList()
        {
            listBoxConsultas.Items.Clear();

            listBoxConsultas.Items.AddRange(container.ConsultaSet.ToArray());
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormMenuPrincipal form = new FormMenuPrincipal();
            DialogResult resultado = form.ShowDialog();
        }
    }
}
