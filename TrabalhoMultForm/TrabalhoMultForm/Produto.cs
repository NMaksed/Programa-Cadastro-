//Autores: Andinis Carvalho, Eduardo Cavalcante, Nathan Grecco e Rafael Ventura
//Ultima Atualização: 14/10/2022
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoMultForm
{
    public class Produto
    {
        //Atributos
        public string nome;
        public int quantidade;
        public string tipo_produto;
        public string tamanho;
        public string fornecedor;
        public string data_vcmt;
        public string cod_produto;
        public string DescricaoProduto;

        //======================================================================//

        //Metodo Construtor - 1
        public Produto()
        {
            this.nome = "";
            this.quantidade = 0;
            this.tipo_produto = "";
            this.tamanho = "";
            this.fornecedor = "";
            this.data_vcmt = "";
            this.cod_produto = "";


        }
        //======================================================================//

        //Método Construtor - 2 
        public Produto(string p_nome, int p_quantidade, string p_tipo_produto, string p_tamanho, string p_fornecedor, string p_data_vcmt, string p_cod_produto)
        {
            this.nome = p_nome;
            this.quantidade = p_quantidade;
            this.tipo_produto = p_tipo_produto;
            this.tamanho = p_tamanho;
            this.fornecedor = p_fornecedor;
            this.data_vcmt = p_data_vcmt;
            this.cod_produto = p_cod_produto;

        }
        //======================================================================//

        //Get/Set
        public string getNome() { return nome; }
        public void setNome(string p_nome) { this.nome = p_nome; }
        public int getQuantidade() { return quantidade; }
        public void setQuantidade(int p_quantidade) { this.quantidade = p_quantidade; }
        public string getTipo_produto() { return tipo_produto; }
        public void setTipo_produto(string p_tipo_produto) { this.tipo_produto = p_tipo_produto; }
        public string getTamanho() { return tamanho; }
        public void setTamanho(string p_tamanho) { this.tamanho = p_tamanho; }
        public string getFornecedor() { return fornecedor; }
        public void setFornecedor(string p_fornecedor) { this.fornecedor = p_fornecedor; }
        public string getData_vcmt() { return data_vcmt; }
        public void setData_vcmt(string p_data_vcmt) { this.data_vcmt = p_data_vcmt; }
        public string getCod_produto() { return cod_produto; }
        public void setCod_produto(string p_cod_produto) { this.cod_produto = p_cod_produto; }
        //======================================================================//
    }
}
