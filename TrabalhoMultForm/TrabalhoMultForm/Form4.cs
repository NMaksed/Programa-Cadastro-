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
    public partial class Form4 : Form
    {
        CadCliente cad = new CadCliente();
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        //Limpar Tela
        {
            this.LimpaTela();
        }
        
        public void LimpaTela()
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
            textBox10.Clear();
            textBox11.Clear();
        }
        //======================================================================//

        private void button2_Click(object sender, EventArgs e)
        {
            //Instancia Botão SAVE

            cad.setNome(textBox1.Text);
            cad.setIdade(int.Parse(textBox2.Text));
            cad.setCpf(textBox3.Text);
            cad.setEmail(textBox4.Text);
            cad.setCep(textBox5.Text);
            cad.setEstado(textBox6.Text);
            cad.setCidade(textBox7.Text);
            cad.setRua(textBox8.Text);
            cad.setNumero(int.Parse(textBox9.Text));
            cad.setTelefone(textBox10.Text);
            cad.setInstagram(textBox11.Text);

            MessageBox.Show("Dados Salvos com sucesso!!","Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //======================================================================//
        private void button1_Click(object sender, EventArgs e)
        //Consulta
        {
            MessageBox.Show( "Nome: " + cad.getNome() +
                             "\nIdade: " + cad.getIdade() +
                             "\nCPF :" + cad.getCpf() +
                             "\nEmail: " + cad.getEmail() +
                             "\nCEP: " + cad.getCep() +
                             "\nEstado: " + cad.getEstado() +
                             "\nCidade: " + cad.getCidade() +
                             "\nRua: " + cad.getRua() +
                             "\nNumero: " + cad.getNumero() +
                             "\nTelefone: " + cad.getTelefone() +
                             "\nInstagram: " + cad.getInstagram(), "Salvar" + MessageBoxIcon.Information, MessageBoxButtons.OK);

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
        //======================================================================//
    }
}
