using System.Globalization;
using Microsoft.Win32.SafeHandles;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string n = Console.ReadLine(); // Adicionei a variável (n) para receber o valor digitado.
            veiculos.Add(n); // Variavel (n) sendo adicionada a lista de veiculos.
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas = Convert.ToInt32(Console.ReadLine()); // Adicionei a variável horas e converti pata inteiro diretamente.

                decimal valorTotal = precoInicial + precoPorHora * horas; // Declarei o tipo da variável diretamente.

                foreach (string item in veiculos) // Adicionei um foreach para percorrer a lista.
                {
                    if (placa == item) // If verificando se a placa é compativel com o veiculo adicionado no indice.
                    {
                        veiculos.Remove(placa); // Removendo o veiculo.
                        Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                    }
                    else
                    {
                        Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
                    }
                }

            }


        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (string item in veiculos)
                {
                    Console.WriteLine($"{item}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
