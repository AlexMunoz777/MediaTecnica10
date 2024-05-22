/******************************************************************************
Autor: Justin Velasquez Muñoz
Fecha: 2024/05/2024
Descripción: Tony Stark, Iroman, quiere saber cuanto dinero debe tener para comprar X tornillos c/u a $300,
pero en la tienda le dan descuentos según cantidad comprada.
Crear un algoritmo que ayude a calcular su compra:
1 sin descuento,
5 descuento del 30%,
10 descuento del 50%
*******************************************************************************/
using System;

class Program
{
    static void Main(){
        
        int cantidadTornillos;
        int valorTornillos;
        
        Console.WriteLine("Digite la cantidad de tornillos que desea comprar: ");
        cantidadTornillos = Int32.Parse(Console.ReadLine());
        valorTornillos = 300;
        
      
        if( cantidadTornillos>= 60){ 
            Console.WriteLine("Usted pagara por la cantidad de tornillos es: " + (valorTornillos * 0.50));}
            else if( cantidadTornillos > 10){
        
            }
                
            if( cantidadTornillos >= 4){
            Console.WriteLine("Usted pagara por la cantidad de tornillos es: " + (valorTornillos));}
            else if( cantidadTornillos > 1){
            }
            if( cantidadTornillos >= 9){
            Console.WriteLine("Usted pagara por la cantidad de tornillos es: " + (valorTornillos * 0.70));}
            else if( cantidadTornillos > 5){
                
            }
            
            
        }
    }
