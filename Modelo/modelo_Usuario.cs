using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    class modelo_Usuario:modelo_Pessoa
    {
        private int id_usuario;
        private string username;
        private string senha;
        private string tipo;


        public int Id_usuario
        {
            get { return id_usuario; }
            set { id_usuario = value; }
        }

    
      
        public string Username
        {
            get { return this.username; }
            set { this.username = value; }
        }

        

        public string Senha
        {
            get { return this.senha; }
            set { this.senha = value; }
        }

      
        public string Tipo
        {
            get { return this.tipo; }
            set { this.tipo = value; }
        }
    }
}
