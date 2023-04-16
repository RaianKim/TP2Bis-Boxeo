using System;
class Boxeador
{
    // Definicion de Propiedades
    public string Nombre{ get;set;}
    public string Pais{get;set;}
    public int peso{get;set;}
    public int PotenciaGolpes{get; private set;}
    public int VelocidadPiernas{get; private set;}
    
    
// Constructor
public Boxeador()
{

}

public double ObtenerSkill(int VeloPi, int  PotenaGol)
{
    double a = VeloPi * 0.6;
    double b = PotenaGol * 0.8;
    double c = Funciones.numeroAleatorio(1,11);
    return a+b+c;
}
}