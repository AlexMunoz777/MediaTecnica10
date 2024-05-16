/******************************************************************************
Autor: Justin Muñoz, Kevin Bedoya
Fecha: 16/05/2024
los avengers necesitan un programa en C# para calcular la fuerza necesaria para 
levantar un objeto en el planeta marte. Completa el espacio en blanco para 
solicitar al usuario la masa del objeto a levantar:

Fórmula: fuerza = masa * gravedad

*******************************************************************************/
using System;

class HelloWorld {
  static void Main(string[] args)
  {
    // Definimos la gravedad en Marte en m/s^2
    double gravedad = 3.72076;

    Console.WriteLine("Ingrese la masa del objeto a levantar en kilogramos: ");
    
    double masaObjeto = Convert.ToDouble(Console.ReadLine());
    double fuerza = masaObjeto * gravedad;
    
    Console.WriteLine("La fuerza necesaria para levantar el objeto es aproximadamente " + fuerza + " Newtons");
  }
}
