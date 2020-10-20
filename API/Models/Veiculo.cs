using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Veiculo
    {
        public int Id { get; set; }
        public string TipoVeiculo { get; set; }
        public string Placa { get; set; }

        //CONSTRUTORES
        public Veiculo() { }

        public Veiculo(int id, string tipoVeiculo, string placa)
        {
            this.Id = id;
            this.TipoVeiculo = tipoVeiculo;
            this.Placa = placa;
        }
    }
}
