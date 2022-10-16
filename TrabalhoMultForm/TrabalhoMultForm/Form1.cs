using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//Autores: Andinis Carvalho, Eduardo Cavalcante, Nathan Grecco e Rafael Ventura
//Ultima Atualização: 14/10/2022
namespace TrabalhoMultForm
{
    public partial class Form1 : Form
    {
        Form2 login = new Form2(); //Instaciamento a OBJ
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); //Esconde o programa
            login.ShowDialog(); //Abre o Form2
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
