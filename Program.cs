using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace ConsoleApp1
{
    class Program
    {
        private static object local;

        static void Main(string[] args)
        {

            Random rnd = new Random();
            string[] Names = { "Jeison Alejandro Recinos", "Paco Anuel Salazar", "Anastacio de la Vega",
                          "Pedro Infante Cardona", "Will Anderson ishcok", "Pamela Rodrigez Anderson", "Paquita Sanchez", "Marvin Cod God", "Luis Mateo Martinez" };

            Random nsd = new Random();
            string[] Alv = { "Martina de la Cruz", "Jeison Alejandro Recinos", "Paco Anuel Salazar", "Anastacio de la Vega","Pedro Infante Cardona", "Will Anderson ishcok", "Pamela Rodrigez Anderson", "Paquita Sanchez", "Marvin Cod God", "Luis Mateo Martinez" };

             string[] Soy = { "Martina de la Cruz", "Jeison Alejandro Recinos", "Paco Anuel Salazar", "Anastacio de la Vega",
                          "Pedro Infante Cardona", "Will Anderson ishcok", "Pamela Rodrigez Anderson", "Paquita Sanchez", "Marvin Cod God", "Luis Mateo Martinez" };
                           
            int mIndex = rnd.Next(Names.Length);
            int fIndex = rnd.Next(Alv.Length);
            
            // mostrando los nombres
              Console.WriteLine("");
                Console.WriteLine("");
            Console.WriteLine("      EXAMEN FINAL DE ALGORITMOS");
            
            Console.WriteLine("======================================");
            Console.WriteLine("Nombres:");
            Console.WriteLine("");
            Console.WriteLine(Names[mIndex]);
            Console.WriteLine(Alv[fIndex]);
           
            Queue<string> Cola = new Queue<string>();
    
            Cola.Enqueue("  Marco Cruz Perez");
            Cola.Enqueue("  Carmelo Santos Rodrigez");
            Cola.Enqueue("  Miguel Garcia Granadas del Campo");
            Cola.Enqueue("  Pedro Antonio");
            Cola.Enqueue("  Maria Rosio Esteban");
            Cola.Enqueue("  Ana Lucia Lopez");
            Cola.Enqueue("  Raul Castillo Bonilla");

            while (Cola.Count>0)
            {
                Console.WriteLine(Cola.Dequeue());
            }
            Console.WriteLine("");
            Console.WriteLine("Oprima cualquier letra para continuar");
            Console.WriteLine("=======================================");
            Console.ReadKey(true);
        }
    }
}