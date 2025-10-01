using System;

namespace CelularPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }


        public Smartphone(string numero, string modelo, string IMEI, int memoria)
        {
            this.Numero = numero;
            this.Modelo = modelo;
            this.IMEI = IMEI;
            this.Memoria = memoria;
        }
        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract string InstalarAplicativo(string nomeAplicativo);
    }
}