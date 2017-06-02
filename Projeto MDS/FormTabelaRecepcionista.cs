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
    public partial class FormTabelaRecepcionista : Form
    {
        private Model1Container container;
        private Rececionista rececionistaSelecionado;

        public FormTabelaRecepcionista()
        {
            InitializeComponent();

            container = new Model1Container();

            refreshListaRececionista();
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            FormRegistarRececionista form = new FormRegistarRececionista();
            DialogResult resultado = form.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                AdicionarRececionista(form.NovoRececionista);
            }
        }

        private void refreshListaRececionista()
        {
            listBoxRececionista.Items.Clear();
            listBoxRececionista.Items.AddRange(container.UtilizadorSet.OfType<Rececionista>().ToArray());
        }

        private void AdicionarRececionista(Rececionista rececionista)
        {

            container.UtilizadorSet.Add(rececionista);
            container.SaveChanges();
            refreshListaRececionista();

        }

       
        private void listBoxRececionista_SelectedIndexChanged(object sender, EventArgs e)
             {
                    rececionistaSelecionado = (Rececionista)listBoxRececionista.SelectedItem;
              }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            rececionistaSelecionado = (Rececionista)listBoxRececionista.SelectedItem;

            if (rececionistaSelecionado != null)
            {
                //remover
                rececionistaSelecionado = (Rececionista)listBoxRececionista.SelectedItem;

                container.UtilizadorSet.Remove(rececionistaSelecionado);

                container.SaveChanges();


                listBoxRececionista.Items.AddRange(container.UtilizadorSet.OfType<Rececionista>().ToArray());

                //insere
                FormRegistarRececionista form = new FormRegistarRececionista();
                DialogResult resultado = form.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    AdicionarRececionista(form.NovoRececionista);
                }

            }
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            rececionistaSelecionado = (Rececionista)listBoxRececionista.SelectedItem;

            container.UtilizadorSet.Remove(rececionistaSelecionado);

            container.SaveChanges();


            listBoxRececionista.Items.AddRange(container.UtilizadorSet.OfType<Rececionista>().ToArray());
        }
    }
}
