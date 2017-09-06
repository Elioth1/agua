using System;
class program
{
 static void Main()
    {
      
        Console.WriteLine("el programon");
        int min, fecha, minu = 0;
        for (int i = 1; i <= 1; i++)
        {
            Console.WriteLine("¿Cuantos minutos tardas en bañarte?: ");
            min = Convert.ToInt32(Console.ReadLine());
            minu = min * 12;
            Console.WriteLine("¿El agua que gastas al dia equivale a esta cantidad de botellas de agua?: " + minu);
            Console.ReadKey();

            Console.WriteLine("¿Cual es tu fecha de cumpleaños?: (AÑO,MES,DIA sin espacio) : ");
            fecha = Convert.ToInt32(Console.ReadLine());
           
            DateTime hoy = DateTime.Today;
            DateTime cumple =  new DateTime(2018,01,19);
            TimeSpan diaEntre = cumple - hoy;
            System.Console.WriteLine(diaEntre.TotalDays);
            double  promedio;
            promedio = diaEntre.TotalDays * minu;
            Console.WriteLine("El resultado de botellas que gastarias asta tu cumpleaños es de:" + promedio);
            Console.ReadKey();
            Console.WriteLine("Hecho por Alejandra Lizette Gómez Tamayo y Elioth Marrujo de la Vega");

        }
        
    }
}