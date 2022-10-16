//Dev: Rafael, Nathan, Eduardo, Andynis
//Last Update: 12/10/2022
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
    public partial class Form5 : Form
    {
        Fornecedorr forn = new Fornecedorr();
        public Form5()
        {
            InitializeComponent();
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
            textBox8.Clear();
            textBox9.Clear();
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            forn.setNome((textBox1.Text));
            forn.setEmail(textBox2.Text);
            forn.setCnpj(textBox4.Text);
            forn.setTelefone(textBox3.Text);
            forn.setCep(textBox5.Text);
            forn.setEstado(textBox6.Text);
            forn.setCidade(textBox7.Text);
            forn.setRua(textBox8.Text);
            forn.setNumero(textBox9.Text);

            MessageBox.Show("Dados armazenados com sucesso!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Consultar 
            MessageBox.Show("\nNome:" + forn.getNome() +
                              "\nEmail:" + forn.getEmail() +
                              "\nCnpj:" + forn.getCnpj() +
                              "\nTelefone:" + forn.getTelefone() +
                              "\nCep:" + forn.getCep() +
                              "\nEstado:" + forn.getEstado() +
                              "\nCidade:" + forn.getCidade() +
                              "\nRua:" + forn.getRua() +
                              "\nNumero:" + forn.getNumero());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
