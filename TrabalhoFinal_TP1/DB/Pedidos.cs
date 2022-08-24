using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFinal_TP1.DB
{
    public class Pedidos
    {
        public int ID_Atendente { get; set; }
        public string Placa { get; set; }
        public string CPF { get; set; }
        public DateTime DataAluguel { get; set; }
        public DateTime DataRetorno { get; set; }
        public int NumDiaria { get; set; }
        public double ValorTotal { get; set; }

        public Pedidos(int iD_Atendente, string placa, string cpf, DateTime dataAluguel, DateTime dataRetorno, int numDiaria, double valorTotal)
        {
            ID_Atendente = iD_Atendente;
            Placa = placa;
            CPF = cpf;
            DataAluguel = dataAluguel;
            DataRetorno = dataRetorno;
            NumDiaria = numDiaria;
            ValorTotal = valorTotal;
        }
    }
}
