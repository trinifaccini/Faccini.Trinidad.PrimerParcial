using Parcial;

public class Program
{
    private static void Main(string[] args)
    {
        
        Planta arbol = new Arbol("Arrayan", 10, (int)EEstacion.Verano, true, false, 2000, 200,true, EPais.USA, 2000); // ESTE SI
        /*
        Arbol arbol1 = new Arbol("Arrayan", 10, EEstacion.Primavera, false, true, 2500, 150,true, EPais.USA, 450089); // ESTE NO
        Arbol arbol2 = new Arbol("Arrayan", 10, EEstacion.Primavera, false, true, 3000, 150,false, EPais.USA, 450089); // ESTE SI
        Flor flor = new Flor("Lupines", 5, EEstacion.Otonio, false, true, 200, 100, 2000);


        Vivero vivero = new Vivero("Los arrayanes");

        Console.WriteLine(vivero + arbol);
        Console.WriteLine(vivero + arbol1); 
        Console.WriteLine(vivero + arbol2); 
        Console.WriteLine(vivero + flor);

        vivero.MostrarInfoVivero();

        vivero.listaPlantas.Sort(Vivero.OrdenarPorAlturaMaxAsc);

        vivero.MostrarInfoVivero();
        */

        //DESERIALIZAR

        //string path = @"C:\Users\Usuario\source\repos\Faccini.Trinidad.PrimerParcial\Faccini.Trinidad\MOCK_DATA.json";
        //using (System.IO.StreamReader sr = new System.IO.StreamReader(path))
        //{
        //    string json = sr.ReadToEnd();
        //    Console.Write(json);
        //    List<Usuario> usuarios = (List<Usuario>)System.Text.Json.JsonSerializer.Deserialize(json, typeof(List<Usuario>));
        //    Console.WriteLine(usuarios[0].apellido);

        //}7

        string path = @"C:\Users\Usuario\source\repos\Faccini.Trinidad.PrimerParcial\Faccini.Trinidad\PLANTAS_DATA.json";

        List<Planta> plantas = new List<Planta> { arbol };


        //Serializador.SerealizarPlantas(path, plantas);

        var obj_son = System.Text.Json.JsonSerializer.Serialize(plantas);
        Console.WriteLine(obj_son);
        
        //Arbol a = (Arbol)System.Text.Json.JsonSerializer.Deserialize(obj_son, typeof(Arbol));

        //Console.WriteLine(a.PaisOrigen);
        //Console.WriteLine(a.UltimoRiego);
        //Console.WriteLine(a.EstacionTransplante);
        //Console.WriteLine(p);
        






    }


}