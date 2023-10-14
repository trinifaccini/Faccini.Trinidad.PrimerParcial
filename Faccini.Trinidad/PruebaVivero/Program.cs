using Parcial;

public class Program
{
    private static void Main(string[] args)
    {

        Arbol arbol = new Arbol("Arrayan", 10, EEstacion.Primavera, false, true, 2000, 150,true, EPais.USA, 450089); // ESTE SI
        Arbol arbol1 = new Arbol("Arrayan", 10, EEstacion.Primavera, false, true, 2000, 150,true, EPais.USA, 450089); // ESTE NO
        Arbol arbol2 = new Arbol("Arrayan", 10, EEstacion.Primavera, false, true, 2000, 150,false, EPais.USA, 450089); // ESTE SI


        Vivero vivero = new Vivero("Los arrayanes");

        /*
        Console.WriteLine(arbol == arbol1); // True - son iguales - Aca compara bien
        Console.WriteLine(arbol == arbol2); // False - son diferentes - Aca compara bien
        */


        Console.WriteLine(vivero + arbol);
        Console.WriteLine(vivero + arbol1); 
        Console.WriteLine(vivero + arbol2); // Deberìa agregar - No lo agrega porque entra al == de Planta y toma que tienen el mismo nombre

    }


}