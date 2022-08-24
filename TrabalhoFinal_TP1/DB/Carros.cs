using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFinal_TP1.DB
{
    public class Carros
    {
        public string Placa { get; set; }
        public string InfoCarro { get; set; }
        public double PrecoDiaria { get; set; }
        public bool Disponibilidade { get; set; }

        public Carros(string placa, string infoCarro, double precoDiaria, bool disponibilidade)
        {
            Placa = placa;
            InfoCarro = infoCarro;
            PrecoDiaria = precoDiaria;
            Disponibilidade = disponibilidade;
        }
    }
}
