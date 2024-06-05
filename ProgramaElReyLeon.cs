/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;

class HelloWorld {
    
  static void Main() {
      
    // variables
    int nota = 0;
    int promedio = 0;
    
    // bienvenida a la app
    Console.WriteLine("Bienvenido a miniApp promedio notas.");
    
    // solicitud notas
    for (int i = 0; i <= 3; i++) 
    {
        Console.WriteLine("Docente, favor ingresar la nota " + i + ", luego presionar enter");
        nota = nota + Int32.Parse(Console.ReadLine());
    }
    promedio = nota / 4;
    // mostrar promedio
    Console.WriteLine("El promedio es: " + promedio);
  }
}