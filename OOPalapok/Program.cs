using System;
using System.Security.Cryptography.X509Certificates;

namespace OOPalapok
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Random random = new Random();
            Console.WriteLine("Milyen magas vagy?  [m]");
            double magassag = Math.Round(random.NextDouble()+1,2);
            Console.WriteLine(magassag);
            Console.WriteLine("Milyen súlyú vagy? [kg]");
			double suly = Math.Round(random.NextDouble()*100);
            Console.WriteLine(suly);
            Ember decemeber = new Ember(suly,magassag);


			
			 if (decemeber.NormalTTi(decemeber.TestTomegIndex()) == true)
			{
                Console.WriteLine("Jó formába vagy");

            } else { Console.WriteLine("Gatya"); }
            Console.WriteLine(decemeber);

			
        }
		
	}
}
