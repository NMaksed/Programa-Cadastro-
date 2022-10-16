//Autores: Andinis Carvalho, Eduardo Cavalcante, Nathan Grecco e Rafael Ventura
//Ultima Atualização: 14/10/2022

public class Fornecedorr
{
    //Atributos
    public string nome;
    public string email;
    public string telefone;
    public string cnpj;
    public string cep;
    public string estado;
    public string cidade;
    public string rua;
    public string numero;
    //======================================================================//

    //Metodo Construtor - 1
    public Fornecedorr()
    {
        this.nome = "";
        this.email = "";
        this.telefone = "";
        this.cnpj = "";
        this.cep = "";
        this.estado = "";
        this.cidade = "";
        this.rua = "";
        this.numero = "";
    }
    //======================================================================//

    //Método Construtor - 2 (parâmetro)
    public Fornecedorr(string p_nome, string p_email, string p_telefone, string p_cnpj, string p_cep, string p_estado, string p_cidade, string p_rua, string p_numero)
    {
        this.nome = p_nome;
        this.email = p_email;
        this.telefone = p_telefone;
        this.cnpj = p_cnpj;
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
    public string getEmail() { return email; }
    public void setEmail(string p_email) { this.email = p_email; }
    public string getTelefone() { return telefone; }
    public void setTelefone(string p_telefone) { this.telefone = p_telefone; }
    public string getCnpj() { return cnpj; }
    public void setCnpj(string p_cnpj) { this.cnpj = p_cnpj; }
    public string getCep() { return cep; }
    public void setCep(string p_cep) { this.cep = p_cep; }
    public string getEstado() { return estado; }
    public void setEstado(string p_estado) { this.estado = p_estado; }
    public string getCidade() { return cidade; }
    public void setCidade(string p_cidade) { this.cidade = p_cidade; }
    public string getRua() { return rua; }
    public void setRua(string p_rua) { this.rua = p_rua; }
    public string getNumero() { return numero; }
    public void setNumero(string p_numero) { this.numero = p_numero; }
}