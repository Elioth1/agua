using System;
class program
{
 static void Main()
    {
      
        Console.WriteLine("El programón xD");
        int min,mes,dia, minu = 0;
        for (int i = 1; i <= 1; i++)
        {
            Console.WriteLine("¿Cuantos minutos tardas en bañarte?: ");
            min = Convert.ToInt32(Console.ReadLine());
            minu = min * 12;
            Console.WriteLine("¿El agua que gastas al dia equivale a esta cantidad de botellas de agua?: " + minu);
            //Console.ReadKey();

            Console.WriteLine("¿Cual es tu fecha de cumpleaños?: (AÑO,MES,DIA sin espacio) : ");
            var fecha = Console.ReadLine();
            int.TryParse(fecha.Substring(4,2),out mes);
            int.TryParse(fecha.Substring(6,2),out dia);

           System.Console.WriteLine($"día: {dia} mes: {mes}");
            DateTime hoy = DateTime.Today;
            DateTime cumple =  new DateTime(hoy.Year,mes,dia);
            TimeSpan diaEntre;
            
            if( cumple > hoy){
               diaEntre  =   cumple - hoy;

            }else{
               diaEntre =   cumple.AddYears(1) - hoy;

            }
        
            System.Console.WriteLine(diaEntre.TotalDays);
            double  promedio;
            promedio = diaEntre.TotalDays * minu;
            Console.WriteLine("El resultado de botellas que gastarias asta tu cumpleaños es de:" + promedio);
            Console.ReadKey();
            Console.WriteLine("Hecho por Alejandra Lizette Gómez Tamayo y Elioth Marrujo de la Vega");
            

        }
        
    }
}