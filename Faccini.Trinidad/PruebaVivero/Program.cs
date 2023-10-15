using Parcial;

public class Program
{
    private static void Main(string[] args)
    {
        
        Planta arbol = new Arbol("Arrayan", 10, (int)EEstacion.Verano, true, false, 2000, 200,true, EPais.USA, 2000); // ESTE SI
        Planta arbol1 = new Arbol("Arrayan", 10, (int)EEstacion.Verano, true, false, 2000, 200,true, EPais.USA, 2000); // ESTE SI
        Arbol arbol2 = new Arbol("Arrayan", 10, EEstacion.Primavera, false, true, 3000, 150,false, EPais.USA, 450089); // ESTE SI
      
        Flor flor = new Flor("Lupines", 5, EEstacion.Otonio, false, true, 200, 100, "rosa", true, 200);
        Flor flor1 = new Flor("Lupines", 5, EEstacion.Otonio, false, true, 200, 100, "rosa", true, 200);
        Flor flor2 = new Flor("Retama", 5, EEstacion.Otonio, false, true, 200, 100, "rosa", true, 200);

        Vivero vivero = new Vivero("Los arrayanes");

        vivero += arbol;
        vivero += arbol1;
        vivero += arbol2;
        vivero += flor;
        vivero += flor1;
        vivero += flor2;

        Console.WriteLine(vivero.listaPlantas[0]);
        Console.WriteLine(vivero.listaPlantas[1]);
        Console.WriteLine(vivero.listaPlantas[2]);
        Console.WriteLine(vivero.listaPlantas[3]);

        string path = @"C:\Users\Usuario\source\repos\Faccini.Trinidad.PrimerParcial\Faccini.Trinidad\PLANTAS_DATA.xml";

        Serializador.SerealizarPlantas(path, vivero.listaPlantas);

        List<Planta> plantas = Serializador.DeserealizarPlantas(path);
        
    }


}