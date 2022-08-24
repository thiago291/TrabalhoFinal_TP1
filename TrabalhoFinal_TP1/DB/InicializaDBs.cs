using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFinal_TP1.DB
{
    public class InicializaDBs
    {
        public void db()
        {
            List<Pedidos> pedidos = new();




            List<Carros> carros = new();

            //(string placa, string infoCarro, double precoDiaria, bool disponibilidade)
            carros.Add(new Carros("BOL1230", "Chevrolet Marea 2001/2.0 Manual", 45, true));
            
            #region adição de clientes
            List<Clientes> clientes = new();
            clientes.Add(new Clientes("Emanuel Oliver Juan Almeida", "1782037187", "96986279730", "11/01/1963", "emanuel.oliver.almeida@signa.net.br", "44790367423", "M", "Avenida Clodóvio Coelho 220 Casa 1", "Macapá", "AP", "68902885"));
            clientes.Add(new Clientes("Thiago Raul Márcio Viana", "3749777985", "84998384900", "14/06/1977", "thiago_viana@technocut.com.br", "49710877163", "M", "2ª Travessa Presidente Mascarenhas 554 ", "Natal", "RN", "59037545"));
            clientes.Add(new Clientes("Manuel Emanuel Matheus Moreira", "5465803606", "62996877628", "15/02/1983", "manuel.emanuel.moreira@depotit.com.br", "75693788128", "M", "Praça Solon Amaral 718 Apt 204", "Goiânia", "GO", "74323041"));
            clientes.Add(new Clientes("Enrico Martin Moreira", "5930942803", "51992072315", "05/01/1988", "enrico.martin.moreira@metododerose.org", "88717396917", "M", "Rua Campo Verde 558 ", "Sapucaia do Sul", "RS", "93224400"));
            clientes.Add(new Clientes("Mariah Patrícia Carvalho", "7045527284", "84992942831", "01/08/1966", "mariah_carvalho@monetto.com.br", "21982382684", "F", "Rua São Bernardo II 474 ", "Parnamirim", "RN", "59148405"));
            clientes.Add(new Clientes("Arthur Emanuel Lucca da Mota", "7274162276", "71986274722", "27/02/2002", "arthur_emanuel_damota@poli.ufrj.br", "21269624849", "M", "Rua Major Câmara 212 Casa 1", "Salvador", "BA", "40250410"));
            clientes.Add(new Clientes("Ayla Cláudia Melo", "8949350971", "65984820585", "23/05/1994", "ayla.claudia.melo@umbernardo.com.br", "82143476287", "F", "Rua F 271 Apt 706", "Cuiabá", "MT", "78048735"));
            clientes.Add(new Clientes("Luiza Maria da Cunha", "9260353556", "93989051104", "23/07/1980", "luiza_maria_dacunha@tvglobo.com.br", "33321229520", "F", "Rua Carlos Chagas 429 Casa 1", "Santarém", "PA", "68025090"));
            clientes.Add(new Clientes("Manoel Diego Fogaça", "11856149072", "28992580556", "22/02/1998", "manoel_fogaca@maccropropaganda.com.br", "63000148240", "M", "Rua Nossa Senhora de Fátima 269 Casa 2", "Cachoeiro de Itapemirim", "ES", "29308650"));
            clientes.Add(new Clientes("Marina Fabiana Caroline da Luz", "12954792574", "92998340736", "10/05/1967", "marina_daluz@elevaconsultancy.com.br", "78537337294", "F", "Rua Ducamara 545 ", "Manaus", "AM", "69092305"));
            clientes.Add(new Clientes("Teresinha Julia Priscila Pereira", "21675830100", "61996531868", "05/06/1956", "teresinha_julia_pereira@htmail.com", "64553309788", "F", "Quadra CLN 411 Bloco B 409 Casa 2", "Brasília", "DF", "70866520"));
            clientes.Add(new Clientes("Marcos Hugo das Neves", "23037782986", "95984256290", "11/05/1961", "marcos_hugo_dasneves@vivo.com.br", "22014866563", "M", "Rua Alto Alegre 561 Casa 3", "Boa Vista", "RR", "69318720"));
            clientes.Add(new Clientes("Tomás Thiago Brito", "25799875419", "85997803866", "05/05/1984", "tomas.thiago.brito@digen.com.br", "86825076436", "M", "Rua Francisco Cavalcante 690 Casa 3", "Maranguape", "CE", "61949020"));
            clientes.Add(new Clientes("Regina Betina Luna Viana", "28695172465", "96984613867", "10/07/1953", "regina_betina_viana@agenciaph.com", "75507015165", "F", "Avenida Humberto Góes Pereira 365 ", "Macapá", "AP", "68903874"));
            clientes.Add(new Clientes("Fernanda Patrícia Castro", "32017072281", "83999486699", "13/06/1943", "fernandapatriciacastro@edpbr.com.br", "46257283746", "F", "Rua José Espínola Guedes 716 Casa 2", "João Pessoa", "PB", "58051270"));
            clientes.Add(new Clientes("César Raimundo Dias", "32102591948", "27984757028", "15/04/1992", "cesar -dias81@deltaturismo.com.br", "26360111372", "M", "Rua Beira Rio 887 ", "Viana", "ES", "29138472"));
            clientes.Add(new Clientes("Clarice Adriana Nicole Nunes", "93056380405", "89996921406", "08/07/1999", "clarice -nunes86@cvc.com.br", "20572036745", "F", "Rua Severino Lima da Silva 780 ", "Picos", "PI", "64608036"));
            clientes.Add(new Clientes("Ryan Bruno Barros", "93832943455", "31988488371", "03/03/1984", "ryan_barros@agen-pegeuot.com.br", "65264246010", "M", "Rua Euzébio de Brito 903 ", "Coronel Fabriciano", "MG", "35170170"));
            clientes.Add(new Clientes("Sueli Rafaela Allana Baptista", "97482645802", "68998025540", "01/08/1985", "sueli_rafaela_baptista@sinalmanaus.com.br", "21297996520", "F", "Rua Gregório de Matos 492 Apt 602", "Rio Branco", "AC", "69915350"));
            #endregion
        }
    }
}
