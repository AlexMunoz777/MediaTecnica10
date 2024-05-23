using System;

class Program
{
    static void Main()
    {
       
        double nota1, nota2, nota3, nota4;
        
        
        Console.WriteLine("Ingrese la primera nota :");
        nota1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese la segunda nota :");
        nota2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese la tercera nota :");
        nota3 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese la cuarta nota :");
        nota4 = Convert.ToDouble(Console.ReadLine());

        double promedio = (nota1 + nota2 + nota3 + nota4) / 4;

if(promedio<=3){
          Console.WriteLine("perdio" );
      }  

       
      if(promedio>=4.5){
            Console.WriteLine("Felicidades, ganaste una beca" );    
          

      }

      
      if(promedio>=3){
          Console.WriteLine("Ganaste" );
      } 

    }
}
