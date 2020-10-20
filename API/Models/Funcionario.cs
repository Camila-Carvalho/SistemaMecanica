using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Cpf { get; set; }
        public int Telefone { get; set; }
        public string Email { get; set; }

        //CONSTRUTORES
        public Funcionario() { }

        public Funcionario(int id, string nome, int cpf, int telefone, string email)
        {
            this.Id = id;
            this.Nome = nome;
            this.Cpf = cpf;
            this.Telefone = telefone;
            this.Email = email;
        }

    }
}