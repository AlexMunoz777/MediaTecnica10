/******************************************************************************

Autor: Justin Velasquez Muñoz
Fecha: 30/05/2024

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
      
    Console.WriteLine("Digite la nota del (1-5), luego enter");
    Console.Write("Opción: ");
    int opcion = Int32.Parse(Console.ReadLine());
    switch (opcion)
    {
        case 1:
        Console.WriteLine("pierde");
        break;
        
        case 2:
        Console.WriteLine("pierde");
        break;
        
        case 3:
        Console.WriteLine("gano");
        break;
        
        case 4:
        Console.WriteLine("alto");
        break;
        
        case 5:
        Console.WriteLine("superior");
        break;
        default:
        Console.WriteLine("Nota invalida.");
        break;
    
        
    }
  }
}