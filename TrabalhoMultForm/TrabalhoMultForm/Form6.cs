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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TrabalhoMultForm
{
    public partial class Form6 : Form
    {
        Produto prod = new Produto();
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            prod.setNome(textBox1.Text);
            prod.setTipo_produto(textBox2.Text);
            prod.setFornecedor(textBox3.Text);
            prod.setCod_produto(textBox4.Text);
            prod.setData_vcmt(textBox5.Text);
            prod.setQuantidade(int.Parse(textBox6.Text));
            prod.setTamanho(textBox7.Text);
            MessageBox.Show("Cadastrado", "Cliente cadastrado com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string vMensagem = "Nome.....: " + prod.getNome() +
                              "\nQuantidade......: " + prod.getQuantidade() +
                              "\nTipo de produto.........:" + prod.getTipo_produto() +
                              "\nTamanho.........:" + prod.getTamanho() +
                              "\n Fornecedor.....:" + prod.getFornecedor() +
                              "\n Data de Vencimento........:" + prod.getData_vcmt() +
                              "\n Codigo do produto........:" + prod.getCod_produto();

            MessageBox.Show(vMensagem, "Consulta de cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
