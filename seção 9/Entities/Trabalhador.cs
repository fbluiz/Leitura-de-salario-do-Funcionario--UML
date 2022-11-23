using seção_9.entities.Enums;
using seção_9.Entities;
using System.Collections.Generic;
using System;


namespace seção_9.entities
{
    internal class Trabalhador
    {
        public string Nome { get; set; }
        public NivelDoTrabalhador Nivel { get; set; }
        public double SalarioBase { get; set; }
        public Departamento Departamento { get; set; }
        public List<ContratoHora> Contratos { get; set; } = new List<ContratoHora>();


        public Trabalhador()
        {
        }

        public Trabalhador(string nome, NivelDoTrabalhador nivel, double salarioBase, Departamento departamento)
        {
            Nome = nome;
            Nivel = nivel;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        public void AddContrato(ContratoHora contrato)
        {
            Contratos.Add(contrato);
        }

        public void RemoverContrato(ContratoHora contrato)
        {
            Contratos.Remove(contrato);
        }

        public double RendaDoFuncionario (int ano, int mes)
         {
             double soma = SalarioBase;
            foreach (ContratoHora Contrato in Contratos)
            {
                if (Contrato.DataDoContrato.Year == ano && Contrato.DataDoContrato.Month == mes)
                {
                    soma += Contrato.ValorTotal();

                }
                
            }

            return soma;
        }
    }

}
