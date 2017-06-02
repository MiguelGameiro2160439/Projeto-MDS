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
    public partial class FormRegistarRececionista : Form
    {
        public Rececionista NovoRececionista { get; private set; }

        public FormRegistarRececionista()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            NovoRececionista = new Rececionista();


            NovoRececionista.Nome = textBoxNome.Text.Trim();
            NovoRececionista.Morada = textBoxMorada.Text.Trim();
            NovoRececionista.NºTelemovel = textBoxN_Telemovel.Text.Trim();
            NovoRececionista.Email = textBoxEmail.Text.Trim();
            NovoRececionista.DataNascimento = dateTimePickerDataNascimento.Value;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
