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
    public partial class FormEscolheMenu : Form
    {
        private Model1Container container;

        public FormEscolheMenu()
        {
            InitializeComponent();

            this.container = new Model1Container();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //FormMarcarConsultas form = new FormMarcarConsultas(this.container);
            //DialogResult resultado = form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //FormAdicionarDetalhesConsulta form = new FormAdicionarDetalhesConsulta();
         //   DialogResult resultado = form.ShowDialog();
        }
    }
}
