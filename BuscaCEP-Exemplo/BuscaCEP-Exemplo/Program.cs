using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaCEP_Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            CEP cep = new CEP("01001000");

            Console.WriteLine("CEP:" + cep.cep);
            Console.WriteLine("Logradouro:" + cep.logradouro);
            Console.WriteLine("Complemento:" + cep.complemento);
            Console.WriteLine("Bairro:" + cep.bairro);
            Console.WriteLine("Localidade:" + cep.localidade);
            Console.WriteLine("CEP:" + cep.uf);

            Console.ReadKey();

        }
    }
}
