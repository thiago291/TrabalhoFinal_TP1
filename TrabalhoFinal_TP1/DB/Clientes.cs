using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFinal_TP1.DB
{
    public class Clientes
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Celular { get; set; }
        public string DataDeNascimento { get; set; }
        public string Email { get; set; }
        public string CNH { get; set; }
        public string Genero { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string CEP { get; set; }

        public Clientes(string nome, string cpf, string celular, string datadenascimento, string email, string cnh, string genero,
            string endereco, string cidade, string uf, string cep)
        {
            Nome = nome;
            CPF = cpf;
            Celular = celular;
            DataDeNascimento = datadenascimento;
            Email = email;
            CNH = cnh;
            Genero = genero;
            Endereco = endereco;
            Cidade = cidade;
            UF = uf;
            CEP = cep;
        }

    }
}
