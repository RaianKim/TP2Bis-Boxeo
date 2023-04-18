using System;
using System.Threading;

Dictionary<string,Boxeador> listBoxeador = new Dictionary<string, Boxeador>();

string Box1 = "Box1";
string Box2 = "Box2";
bool box1 = false ,box2 = false;
int respuesta = 0;
while(respuesta != 4)
{
Console.Clear();
Console.WriteLine("1. Cargar Boxeador N°1");
Console.WriteLine("2. Cargar Boxeador N°2");
Console.WriteLine("3. Pelea!!");
Console.WriteLine("4. Fin");
respuesta = Funciones.IngresarEnteroEnRango("Escriba 1,2,3 o 4: ",1,5);
Console.Clear();
switch(respuesta)
{

case 1:
    if(box1 == true)
    {
        Console.WriteLine("No se puede ingresar de nuevo el boxeador N°1");
        Thread.Sleep(2500);
    }   
    else
    {
        ObtenerBox(Box1);
        box1 = true;
    }
    
    
break;
    
case 2:
    if(box2 == true)
    {
        Console.WriteLine("No se puede ingresar de nuevo el boxeador N°2");
        Thread.Sleep(2500);
    }   
    else
    {
        ObtenerBox(Box2);
        box2 = true; 
    }
break;
    
case 3:
    if(box1 == false || box1 == false)
    {
        Console.WriteLine("No se puede hacer la pelea. Ingrese los datos de los dos boxeadores");
        Thread.Sleep(2500);
    } 
    else
    {
        Pelea();
        
    }
    
break;
    
}
}


void ObtenerBox(string BoxCualquiera){
string aux = "";
if(BoxCualquiera.Contains("1"))
{
    aux = "1";

}
else if (BoxCualquiera.Contains("2"))
{
    aux = "2";

}
string nombre = Funciones.IngresarTexto("Ingrese el nombre del boxeador: "); 
string pais = Funciones.IngresarTexto("Ingresar el nombre del pais donde nacio: ");
int peso = Funciones.IngresarEntero("Ingresar el peso: ");
int potgol = Funciones.numeroAleatorio(1,101);
int velopi = Funciones.numeroAleatorio(1,101);
Boxeador boxeador = new Boxeador(nombre,pais,peso,potgol,velopi);
listBoxeador.Add(BoxCualquiera,boxeador);
Console.Clear();
Console.WriteLine($"Se ha creado la persona {nombre} y se ha agregado como el Boxeador N°{aux}");
Thread.Sleep(3000);
}


void Pelea(){
    double mayorNum = 0;
    string mayorNomb = "";
    double boxer1,boxer2;
    boxer1 = listBoxeador[Box1].ObtenerSkill();
    boxer2 = listBoxeador[Box2].ObtenerSkill();
    if(boxer1 > boxer2){
        mayorNum = boxer1;
        mayorNomb = listBoxeador[Box1].Nombre;
    }
    else{
        mayorNum = boxer2;
        mayorNomb = listBoxeador[Box2].Nombre;
    }

    Console.WriteLine(Funciones.ganador(mayorNum,mayorNomb));
    Thread.Sleep(4000);
    
}