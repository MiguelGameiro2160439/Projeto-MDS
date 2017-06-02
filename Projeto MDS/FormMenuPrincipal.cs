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
    public partial class FormMenuPrincipal : Form
    {
        private Model1Container container;

        public FormMenuPrincipal()
        {
            InitializeComponent();

            this.container = new Model1Container();
        }

        private void resgistarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMarcarConsultas form = new FormMarcarConsultas(this.container);
            DialogResult resultado = form.ShowDialog();
        }
    }
}
