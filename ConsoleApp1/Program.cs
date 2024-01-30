// See https://aka.ms/new-console-template for more information
using System.Runtime.Serialization;
using System.Text;
using ConsoleApp1;
using ConsoleApp1.Models;

var ImprimirInfo = new ImprimirInfo();

SuperPoder poderVolar =new SuperPoder();

poderVolar.Nombre = "Volar";
poderVolar.Descripcion = "Capacidad para volar y planear sobre el aire";
poderVolar.Nivel = NivelPoder.NivelDos;

SuperPoder superFuerza=new SuperPoder();

superFuerza.Nombre = "Super Fuerza";
superFuerza.Nivel = NivelPoder.NivelTres;


SuperPoder regeneracion=new SuperPoder();
regeneracion.Nombre = "Regeneración";
regeneracion.Nivel = NivelPoder.NivelTres;


SuperHeroe superman = new SuperHeroe();

superman.Id = 1;
superman.Nombre = "Superman";
superman.IdentidadSecreta = "Clart Kent";
superman.Ciudad = "Metropolis";
superman.PuedeVolar = true;

ImprimirInfo.ImprimirSuperHero(superman);




List<SuperPoder> poderesSuperman = new List<SuperPoder>();
poderesSuperman.Add(poderVolar);
poderesSuperman.Add(superFuerza);
superman.SuperPoderes = poderesSuperman ;
string resultSuperPoderes=superman.UsarSuperPoderes();
Console.WriteLine(resultSuperPoderes);

string resultSalvarElMundo = superman.SalvarElMundo();

string resultSalvarTierra = superman.SalvarLaTierra();
Console.WriteLine(resultSalvarTierra);

Console.WriteLine(resultSalvarElMundo);

AntiHeroe wolverin = new AntiHeroe();

wolverin.Id = 5;
wolverin.Nombre = "Wolverin";
wolverin.IdentidadSecreta = "Logan";
wolverin.PuedeVolar = false;

ImprimirInfo.ImprimirSuperHero(wolverin);

List<SuperPoder> podereswolverin = new List<SuperPoder>();
podereswolverin.Add(regeneracion);
podereswolverin.Add(superFuerza);
wolverin.SuperPoderes = podereswolverin;
string resultWolverinPoderes= wolverin.UsarSuperPoderes();
Console.WriteLine(resultWolverinPoderes);

string accionAntiHeroe = wolverin.RealizarAccionDeAntiheroe("Ataca la policia");
Console.WriteLine(accionAntiHeroe);

enum NivelPoder
{
    NivelUno,
    NivelDos,
    NivelTres,
}