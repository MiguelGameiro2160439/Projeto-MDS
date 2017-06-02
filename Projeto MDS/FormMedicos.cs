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
    public partial class FormMedicos : Form
    {
        Model1Container Projeto;
        public Utilizador novoutilizador { get; private set; }

        public FormMedicos()
        {
            InitializeComponent();
            Projeto = new Model1Container();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             string contribuinte = textBox1.Text;

            string nome = textBox2.Text;

            string morada = textBox3.Text;

            string telemovel = textBox4.Text;

            string email = textBox5.Text;

            DateTime data = dateTimePicker1.Value; 

            string checkin = textBox7.Text;

            string checkout = textBox8.Text;


            Utilizador novoutilizador = new Utilizador
            {

                N_Contribuinte = textBox1.Text,
                Nome = textBox2.Text,
                Morada = textBox3.Text,
                NºTelemovel = textBox4.Text,
                Email = textBox5.Text,
                DataNascimento = dateTimePicker1.Value,
               // HoraEntrada= textBox7.Text,
              //  HoraSaida = textBox8.Text,


            };

     

            Projeto.UtilizadorSet.Add(novoutilizador);

            Projeto.SaveChanges();

      

            listBoxMedicos.Items.Clear();
            listBoxMedicos.Items.AddRange(Projeto.UtilizadorSet.ToArray());

            textBox1.Text = "";
            textBox3.Text = "";
        }
    }
}
