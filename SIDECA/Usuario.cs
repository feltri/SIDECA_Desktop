using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIDECA
{
    class Usuario
    {

        private string nome;
        private string senha;
        private string email;
        private int telefone;
        private string login;
        private int id;
        private byte[] foto;

        public Usuario(string nome, string senha, string email, int telefone, string login, int id, byte[] foto)
        {
            this.Nome = nome;
            this.Senha = senha;
            this.Email = email;
            this.Telefone = telefone;
            this.Login = login;
            this.Id = id;
            this.foto = foto;
        }

        public byte[] Foto { get => foto; set => foto = value; }
        public int Id { get => id; set => id = value; }
        public string Login { get => login; set => login = value; }
        public int Telefone { get => telefone; set => telefone = value; }
        public string Email { get => email; set => email = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Nome { get => nome; set => nome = value; }


    }
}
