using System;

namespace CelularPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string IMEI, int memoria) : base(numero, modelo, IMEI, memoria)
        {}
        public override string InstalarAplicativo(string nomeApp)
        {
            return $"Instalando {nomeApp} no Nokia";
        }
    }

}