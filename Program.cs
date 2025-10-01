using System;
using CelularPOO.Models;

namespace CelularPOO{
    class Program{
        public static void Main(string[] args){
            Console.WriteLine("Smartphone Nokia:");
            Smartphone nokia = new Nokia("71983348896","Nokia X","123456789",64);         
            nokia.Ligar();
            Console.WriteLine(nokia.InstalarAplicativo("Telegram"));

            Console.WriteLine("------------------------");

            Console.WriteLine("Smartphone Iphone:");
            Smartphone iphone = new Iphone("71983348896","Iphone 12","987654321",128);
            iphone.ReceberLigacao();
            Console.WriteLine(iphone.InstalarAplicativo("WhatsApp"));
        }
    }
}