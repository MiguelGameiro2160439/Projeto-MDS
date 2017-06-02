using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMDS
{
    public partial class medico : Form
    {
       public Model1Container Projeto;

    
        public medico()
        {
            InitializeComponent();

            Projeto = new Model1Container();



          




        }

        private void button1_Click(object sender, EventArgs e)
        {

            string contribuinte = textBox1.Text;

            string nome = textBox2.Text;

            string checkin = textBox7.Text;

            string checkout = textBox8.Text;



            Médico novomedico = new Médico
            {

                N_Contribuinte = textBox1.Text,
                Nome = textBox2.Text,
                
           
        //Checkin = textBox7.Text,
        //  checkout = textBox8.Text


            };

            Projeto.UtilizadorSet.Add(novomedico);

  
            Projeto.SaveChanges();

            MessageBox.Show("Adicionado");

            listBox1.Items.Clear();
            listBox1.Items.AddRange(Projeto.UtilizadorSet.OfType<Médico>().ToArray());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Médico medicoselecionado = (Médico)listBox1.SelectedItem;

            Projeto.UtilizadorSet.Remove(medicoselecionado);

            Projeto.SaveChanges();

            MessageBox.Show("Remover");


            listBox1.Items.Clear();
            listBox1.Items.AddRange(Projeto.UtilizadorSet.ToArray());
        }

        private void button3_Click(object sender, EventArgs e)
        {

           Médico utilizadorselecionado = (Médico)listBox1.SelectedItem;
        
             

            if (utilizadorselecionado != null)
            {
                utilizadorselecionado.N_Contribuinte = textBox1.Text;
                utilizadorselecionado.Nome = textBox2.Text;

             //   utilizadorselecionado.checkin = textBox7.Text;
           //     utilizadorselecionado.checkout = textBox8.Text;




                Projeto.SaveChanges();
            }


            MessageBox.Show("Editado");

            listBox1.Items.Clear();
            listBox1.Items.AddRange(Projeto.UtilizadorSet.ToArray());
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         Médico   medicoselecionado   = (Médico)listBox1.SelectedItem;

            if (medicoselecionado != null)
            {

                textBox1.Text = medicoselecionado.N_Contribuinte;
                textBox2.Text = medicoselecionado.Nome;

              //  textBox7.Text = utilizadorselecionado.checkin;
               // textBox8.Text = utilizadorselecionado.checkout;

            }
        }

  
    }
}
