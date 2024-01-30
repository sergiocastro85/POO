using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interfaces
{
    internal interface ISuperHeroe
    {
        int Id { get; set; }

        string Nombre { get; set; }

        string IdentidadSecreta { get; set; }

        string GetSuperHeroe()
        {
            StringBuilder sb = new StringBuilder(); ;
            sb.AppendLine($"Id : {Id}");
            sb.AppendLine($"Nombre : {Nombre}");
            sb.AppendLine($"Identidad Secreta : {IdentidadSecreta}");

            return sb.ToString();
        }
    }
}
