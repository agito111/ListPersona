using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListPersona
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <Persona> Persone = new List<Persona>();
            string nome1 = Console.ReadLine(); ;
            int eta1 = int.Parse(Console.ReadLine());
            Persona p1 = new Persona (nome1, eta1);
            string nome2 = Console.ReadLine(); ;
            int eta2 = int.Parse(Console.ReadLine());
            Persona p2 = new Persona(nome2, eta2);
            string nome3 = Console.ReadLine(); ;
            int eta3 = int.Parse(Console.ReadLine());
            Persona p3 = new Persona(nome3, eta3);
            Persone.Add (p1);
            Persone.Add (p2);   
            Persone.Add (p3);
            Console.WriteLine("Le persone maggiorenni sono:");
            int n = 0;
            for (int i = 0; i< Persone.Count; i++)
            {
                if (Persone[i].Eta >=18)
                {
                    Console.WriteLine(Persone[i].Nome);
                    n++;
                }
            }
            if (n == 0)
            {
                Console.WriteLine("Non ci sono persone maggiorenni");
            }
            else { }
            Console.ReadLine();
        }
    }
}
