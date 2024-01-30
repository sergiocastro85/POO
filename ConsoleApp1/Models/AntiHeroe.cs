using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class AntiHeroe:SuperHeroe
    {
        private string resultado = "";

        public string RealizarAccionDeAntiheroe(string accion)
        {
            return $"El Antiheroe{NombreEIdentidadSecreta} ha realizado : {accion}";
        }

        public override string UsarSuperPoderes()
        {
            //return base.UsarSuperPoderes();

            StringBuilder sb = new StringBuilder();
            foreach (var item in SuperPoderes)
            {
                sb.AppendLine($"*********{NombreEIdentidadSecreta} esta usando el super poder {item.Nombre} !!");
            }

            return sb.ToString();
        }
    }
}
