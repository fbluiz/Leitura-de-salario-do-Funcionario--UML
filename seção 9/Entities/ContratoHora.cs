using System;


namespace seção_9.Entities
{
    internal class ContratoHora
    {
        public double ValorPorHora { get; set; }
        public DateTime DataDoContrato { get; set; }
        public int HorasDeTrabalho { get; set; }



        public ContratoHora()
        { 
        }

        public ContratoHora(double valorPorHora, DateTime dataDoContrato, int horasDeTrabalho)
        {
            ValorPorHora = valorPorHora;
            DataDoContrato = dataDoContrato;
            HorasDeTrabalho = horasDeTrabalho;
        }




        public double ValorTotal()
        {
            return ValorPorHora * HorasDeTrabalho;
        }











        }
}
