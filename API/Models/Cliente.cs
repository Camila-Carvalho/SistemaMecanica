using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public int Cpf { get; set; }
        public int Telefone { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string EstadoCivil { get; set; }
        //public enum Situacao { get; set; } //trocar para enum

        public char Sexo { get; set; }
        public DateTime DataNascimento { get; set; }


        //CONSTRUTORES
        public Cliente() { }

        public Cliente(int id, string nome, int cpf, int telefone, string email, string endereco, string estadoCivil, /*string situacao,*/ char sexo, DateTime dataNascimento)
        {
            this.Id = id;
            this.Nome = nome;
            this.Cpf = cpf;
            this.Telefone = telefone;
            this.Email = email;
            this.Endereco = endereco;
            this.EstadoCivil = estadoCivil;
            //this.Situacao = situacao;
            this.Sexo = sexo;
            this.DataNascimento = dataNascimento;
        }
    }
}
