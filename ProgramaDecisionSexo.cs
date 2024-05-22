/******************************************************************************
Autor: Justin Velasquez Muñoz
Fecha: 2024/05/2024
Objetivo: Programa con decisiones.

*******************************************************************************/
using System;

class HelloWorld {
    
  static void Main() {
    //variables
    bool sexoMasculino;
    //capturar información del usuario
    Console.Write("Digite true si es hombre: ");
    sexoMasculino = Convert.ToBoolean(Console.ReadLine());
    //validación
    if (sexoMasculino == true){ 
     Console.WriteLine("Felicidades, es hombre"); 

    } 
    else{
        Console.WriteLine("Felicidades es mujer");
    }
  }
}
