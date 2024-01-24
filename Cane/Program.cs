using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cane
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cane cane = new Cane();  
            Persona padrone=new Persona();
            cane.nome = "Ringhio";
            cane.razza = "Labrador";
            cane.padrone.nome = "Simone";
            Console.WriteLine("{0}",cane.padrone.nome);


            Console.ReadLine();
        }
    }
}
