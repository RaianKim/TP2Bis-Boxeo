using System;
public static class Funciones
{
    public static string IngresarTexto(string msj)
    {
        string texto = "";
        while (texto == "")
        {
            Console.Write(msj);
            texto = Console.ReadLine();
        }
        return texto;
    }
    public static int IngresarEntero(string msj)
    {
        int entero=-1;
        while (entero <= 0)
        {   
            Console.Write(msj);
            int.TryParse(Console.ReadLine(), out entero);
        }
        return entero;
    }

    public static int IngresarEnteroEnRango(string msj, int minimo, int maximo)
    {
        int entero;
        entero = IngresarEntero(msj);
        while (entero < minimo || entero > maximo)
        {
            entero = IngresarEntero("Error: Numero fuera del rango, " + msj);
        }
        return entero;
    }
    public static int numeroAleatorio(int min, int max){
        Random rnd = new Random();
        int numeroAleatorio = rnd.Next(min, max);
        return numeroAleatorio;
    }

    public static string ganadorBoxeo(double BoxGanador,string NombreBoxGanador)
    {
        string CompGanador = "";
        if(BoxGanador >= 30){
            CompGanador = $"Gano {NombreBoxGanador} por KO";
        }
        else if(BoxGanador >= 10 && BoxGanador < 30){
            CompGanador = $"Gano {NombreBoxGanador} por puntos en fallo unanime";
        }
        else if(BoxGanador < 10){
            CompGanador = $"Gano {NombreBoxGanador} por puntos en fallo dividido";
        }
        return CompGanador;
    }

    public static double MayorNumero(double Boxeadorn1, double Boxeadorn2)
    {
        double aux;
        if(Boxeadorn1 > Boxeadorn2)
        {
            aux = Boxeadorn1;
        }
        else
        {
            aux = Boxeadorn2;
        }
        return aux;

    }
    public static string MayorNumNombre(double Boxeadorn1, double Boxeadorn2,string Box1Nombre, string Box2Nombre)
    {
        string aux;
        if(Boxeadorn1 > Boxeadorn2)
        {
            aux = Box1Nombre;
        }
        else
        {
            aux = Box2Nombre;
        }
        return aux;

    }
}