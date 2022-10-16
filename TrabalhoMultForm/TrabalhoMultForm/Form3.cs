//Autores: Andinis Carvalho, Eduardo Cavalcante, Nathan Grecco e Rafael Ventura
//Ultima Atualização: 14/10/2022
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoMultForm
{
    public partial class Form3 : Form
    {

        Form5 cad_fornecedor = new Form5();
        Form4 cad_cliente = new Form4();
        Form6 cad_produto = new Form6();
        Form7 sobre = new Form7();//Instaciamento a objeto 
        public Form3()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Sair do Programa
            if (MessageBox.Show("Deseja sair??", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cad_cliente.Show();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cad_fornecedor.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cad_cliente.Show();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cad_fornecedor.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair??", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cad_produto.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cad_produto.Show();
        }

        private void perfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sobre.Show();
        }
    }
}
