//Autores: Andinis Carvalho, Eduardo Cavalcante, Nathan Grecco e Rafael Ventura
//Ultima Atualização: 14/10/2022

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoMultForm
{
    public class Login
    {
        //Atributo - Login

        public string login;


        //Método Construtor 1

        public Login()
        {
        this.login = "";
        }


        //Método Construtor 2

        public Login( string p_login)
        {
            this.login = p_login;
        }

        //GET - SET

        public string getLogin() { return login; }
        public void setLogin(string p_login) { this.login = p_login; }

    }
}
