using System;

namespace CelularPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string IMEI, int memoria) : base(numero, modelo, IMEI, memoria)
        {}

        public override string InstalarAplicativo(string nomeApp)
        {
            return $"Instalando {nomeApp} no Iphone";
        }
    }

}