/******************************************************************************
Autor: Justin Muñoz
Fecha: 29-05-2024
Descripcioón:
App con menu

Se solicita crear una minicalculadora que realice:
-Suma
-Resta
-Multiplicacion
-Division
Debe terminar la ejecucuión al ususario elegir opcion "salir"

*******************************************************************************/
using System;
using System.Threading;

class Program {
    static void Main(string[] args) {		
    // 1 Pantalla bienvenida (imagen ASCII)
    Console.WriteLine("                                                    			");
    Console.WriteLine("                       :#*-.                        			");
    Console.WriteLine("                     :%%%%##%%%%*-.                 			");  			
    Console.WriteLine("                   .#*--=-=+#%%%%##%%%#+:           			");
    Console.WriteLine("                  .##-+--===-=+*%%%%%##%%%+:        			");
    Console.WriteLine("                .*#**#%%*=-==:===-:.-+#%%%%+        			");
    Console.WriteLine("               .*####***#%%#=-=-:=-::..:#%*.        			");
    Console.WriteLine("              .*#****###*++*%%#+-=::-:.-%*.         			");
    Console.WriteLine("            .*#%#%**##%##*******+*#%#+%#:           			");
    Console.WriteLine("           .*####**##%**##%*#*****+++*#-            			");
    Console.WriteLine("          *****++##%***##*###*+###*+#=              			");
    Console.WriteLine("         ****#*+#****#*%+**##+#***+#=               			");
    Console.WriteLine("        +**+*++*###****+#*#*=+##%=*+                			");
    Console.WriteLine("       :+#*++**+%#*=+#*%==+*%++*.                   			");
    Console.WriteLine("         .=##+-+##+***+=+#%#-+#.                    			");
    Console.WriteLine("              .-*#+==--*%%*=#:                      			");
    Console.WriteLine("                 .-*#*==*+-#:                       			");
    Console.WriteLine("                    .-*#*=+:    					");           
    Console.WriteLine("                        :=-     					");
    Console.WriteLine("       Bienvenido a la MiniCalculadora ");
    Thread.Sleep(2000); // 3 segundos = 3000 milisegundos
    Console.Clear();
    // 2 Mostrar menú de opciones
    Console.WriteLine("Menú de opciones");
    Console.WriteLine("Seleccionar la opción deseada:");
    Console.WriteLine("1. Suma");
    Console.WriteLine("2. Resta");
    Console.WriteLine("3. Multiplicación");
    Console.WriteLine("4. Divisón");
    Console.WriteLine("5. Salir");
    Console.Write("Digitar numero deseado: ");
    // 3 capturar opción elegida por usuario
    int opcion = Int32.Parse(Console.ReadLine());
    
    if (opcion == 5){
        goto Salir;
    }
    
    Console.Write("\nDigitar numero 1: ");
    int numero1 = Int32.Parse(Console.ReadLine());
    Console.Write("\nDigitar numero 2: ");
    int numero2 = Int32.Parse(Console.ReadLine());
    
    // 4 Validar opción elegida
    if( opcion == 1){
        Console.WriteLine("\nLa suma es: " + (numero1+numero2));
    }
    
     if( opcion == 2){
        Console.WriteLine("\nLa resta es: " + (numero1-numero2));
    }
    
     if( opcion == 3){
        Console.WriteLine("\nLa Multiplicación es: " + (numero1*numero2));
    }
    
     if( opcion == 4){
         if( numero1 !=0 && numero2 !=0){
            Console.WriteLine("\nLa división es: " + (numero1/numero2));  
         }
          else{   
             Console.WriteLine("\nNo se puede dividir por cero.");
          
             
             
         }
        
    
    }
    Salir:
        Console.WriteLine("Saliendo del programa...");
        
    

    // 5 Mostrar resultado o finalizar ejecución
    
    }
}
    
  