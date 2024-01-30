using ConsoleApp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ImprimirInfo
    {
        public void ImprimirSuperHero(ISuperHeroe superHeroe)
        {
            Console.WriteLine($"Id : {superHeroe.Id}");
            Console.WriteLine($"Nombre : {superHeroe.IdentidadSecreta}");
            Console.WriteLine($"Identiedad secreta : {superHeroe.IdentidadSecreta}");

            Console.WriteLine(superHeroe.GetSuperHeroe());
        }

    }
}
