using System;
using seção_9.entities;
using seção_9.entities.Enums;
using seção_9.Entities;

namespace Seção9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite o nome do departamento: ");
            string departamento2 = Console.ReadLine();
            Console.WriteLine("Entre com os dados do trabalhador: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Nível: (Junior / Pleno / Senior) : ");
            NivelDoTrabalhador nivel = Enum.Parse<NivelDoTrabalhador>(Console.ReadLine());
            Console.Write("Salário Base: ");
            double salario = double.Parse(Console.ReadLine());

            Departamento departamento1 = new Departamento(departamento2);
            Trabalhador trabalhador1  = new Trabalhador(nome, nivel, salario, departamento1);

            Console.Write("Quantos contratos para este trabalhador ?");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Entre com os dados do contato#" + i);
                Console.Write("Data (DD/MM/YYYY): ");
                DateTime data = DateTime.Parse(Console.ReadLine());
                Console.Write("Valor por hora: ");
                double valor = double.Parse(Console.ReadLine());
                Console.Write("Quantidade de horas trabalhadas: ");
                int horas = int.Parse(Console.ReadLine());

                ContratoHora contrato1 = new ContratoHora(valor, data, horas);
            }

            Console.WriteLine();
            Console.Write("Entre com o ano para calcular a renda do trabalhador nesse periodo: ");
            int ano = int.Parse(Console.ReadLine());
            Console.Write("Entre com o mes para calcular a renda do trabalhador nesse periodo: ");
            int mes = int.Parse(Console.ReadLine());


            Console.WriteLine("Nome: " + trabalhador1.Nome);
            Console.WriteLine("Departamento: " +  trabalhador1.Departamento.Nome);
            Console.WriteLine("Renda no perído: " + mes + "/" + ano + ": " + trabalhador1.RendaDoFuncionario(ano,mes)); 


















            }
    }
}
