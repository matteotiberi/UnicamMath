using System;

namespace UnicamMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questo programma calcola l'ipotenusa e gli angoli interni fornendo la lunghezza di due cateti");

            Console.Write("Inserisci la lunghezza del primo cateto: ");
            string cateto1Testuale = Console.ReadLine();

            Console.Write("Inserisci la lunghezza del secondo cateto: ");
            string cateto2Testuale = Console.ReadLine();

            double.TryParse(cateto1Testuale, out double cateto1);
            double.TryParse(cateto2Testuale, out double cateto2);
            double ipotenusa = Math.Sqrt(Math.Pow(cateto1,2) + Math.Pow(cateto2,2));
            double angolo1 = 90;
            double divisione;
            if(cateto1>cateto2){
            divisione = Math.Sin(cateto2/cateto1);
            }else {
            divisione = Math.Sin(cateto1/cateto2);  
            }
            double angolo2 = ((Math.Asin(divisione)*180)/Math.PI);
            double angolo3 = angolo1 - angolo2;
            Console.WriteLine($"L'ipotenusa misura {Math.Round(ipotenusa,2)}");
            Console.WriteLine($"I tre angoli interni misurano {Math.Round(angolo1,2)} gradi, {Math.Round(angolo2,2)} gradi e {Math.Round(angolo3,2)} gradi.");

            Console.ReadKey();
        }
    }
}
