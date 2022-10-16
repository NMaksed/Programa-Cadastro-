//Autores: Andinis Carvalho, Eduardo Cavalcante, Nathan Grecco e Rafael Ventura
//Ultima Atualização: 14/10/2022

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoMultForm
{
    public class CadCliente
    {
        //Atributos
        public string nome;
        public int idade;
        public string cpf;
        public string email;
        public string telefone;
        public string instagram;
        public string cep;
        public string estado;
        public string cidade;
        public string rua;
        public int numero;
        //======================================================================//

        //Metodo Construtor - 1
        public CadCliente()
        {
            this.nome = "";
            this.idade = 0;
            this.cpf = "";
            this.email = "";
            this.telefone = "";
            this.instagram = "";
            this.cep = "";
            this.estado = "";
            this.cidade = "";
            this.rua = "";
            this.numero = 0;
        }
        //======================================================================//

        //Método Construtor - 2 (parâmetro)
        public CadCliente(string p_nome, int p_idade, string p_cpf, string p_email, string p_telefone, string p_instagram, string p_cep, string p_estado, string p_cidade, string p_rua, int p_numero)
        {
            this.nome = p_nome;
            this.idade = p_idade;
            this.cpf = p_cpf;
            this.email = p_email;
            this.telefone = p_telefone;
            this.instagram = p_instagram;
            this.cep = p_cep;
            this.estado = p_estado;
            this.cidade = p_cidade;
            this.rua = p_rua;
            this.numero = p_numero;
        }
        //======================================================================//

        //Get/Set
        public string getNome() { return nome; }
        public void setNome(string p_nome) { this.nome = p_nome; }
        public int getIdade() { return idade; }
        public void setIdade(int p_idade) { this.idade = p_idade; }
        public string getCpf() { return cpf; }
        public void setCpf(string p_cpf) { this.cpf = p_cpf; }
        public string getEmail() { return email; }
        public void setEmail(string p_email) { this.email = p_email; }
        public string getTelefone() { return telefone; }
        public void setTelefone(string p_telefone) { this.telefone = p_telefone; }
        public string getInstagram() { return instagram; }
        public void setInstagram(string p_instagram) { this.instagram = p_instagram; }
        public string getCep() { return cep; }
        public void setCep(string p_cep) { this.cep = p_cep; }
        public string getEstado() { return estado; }
        public void setEstado(string p_estado) { this.estado = p_estado; }
        public string getCidade() { return cidade; }
        public void setCidade(string p_cidade) { this.cidade = p_cidade; }
        public string getRua() { return rua; }
        public void setRua(string p_rua) { this.rua = p_rua; }
        public int getNumero() { return numero; }
        public void setNumero(int p_numero) { this.numero = p_numero; }
        //======================================================================//
    }


}
