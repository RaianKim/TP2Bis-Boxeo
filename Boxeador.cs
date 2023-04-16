using System;
class Boxeador
{
    // Definicion de Propiedades
    public string Nombre{get;set;}
    public string Pais{get;set;}
    public int Peso{get;set;}
    public int PotenciaGolpes{get; set;}
    public int VelocidadPiernas{get; set;}
    
    
// Constructor
public Boxeador()
{

}
public Boxeador(string nom, string pais, int peso, int potgol, int velopi)
{
    Nombre = nom;
    Pais = pais;
    Peso = peso;
    PotenciaGolpes = potgol;
    VelocidadPiernas = velopi;
}
public double ObtenerSkill()
{
    double a = PotenciaGolpes * 0.6;
    double b = VelocidadPiernas * 0.8;
    double c = Funciones.numeroAleatorio(1,11);
    return a+b+c;
}
}