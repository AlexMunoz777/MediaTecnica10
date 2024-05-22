/******************************************************************************
Autor: Justin Velasquez Muñoz
Fecha: 2024/05/2024
Descripción: Programa con decisiones para habilitar votacion de personas y 
descuento matricula estudio.

*******************************************************************************/
using System;

class Programa {
    
  static void Main() {
    //variables
    int edad;
    int valorMatricula;
    
    //peticion de datos
    Console.WriteLine("Digite su edad: ");
    edad = Int32.Parse(Console.ReadLine());
    
    Console.WriteLine("Digite su valor de matricula: ");
    valorMatricula = Int32.Parse(Console.ReadLine());
    
    //validación
    if( edad >= 18){
        Console.WriteLine("Felicidades usted puede votar");
        Console.WriteLine("Usted pagará de matricula: " + (valorMatricula * 0.85));
    }
  }
}
