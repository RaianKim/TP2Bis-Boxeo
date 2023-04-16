Dictionary<string,Boxeador> listBoxeador = new Dictionary<string, Boxeador>();
string Box1 = "Box1";
string Box2 = "Box2";
bool box1 = false ,box2 = false ,pel = false;
Console.WriteLine("1. Cargar Boxeador N°1");
Console.WriteLine("2. Cargar Boxeador N°2");
Console.WriteLine("3. Pelea!!");
Console.WriteLine("4. Fin");
int respuesta = Funciones.IngresarEnteroEnRango("Escriba 1,2,3  o 4",1,5);

switch(respuesta)
{

case 1:
    if(box1 == true)
    {
        Console.WriteLine("No se puede ingresar de nuevo el boxeador N°1");
    }   
    else
    {
        ObtenerBox1(Box1);
    }
    
    
break;
    
case 2:
    if(box2 == true)
    {
        Console.WriteLine("No se puede ingresar de nuevo el boxeador N°2");
    }   
    else
    {
        ObtenerBox2(Box2);
    }
break;
    
case 3:
    if(box1 == false || box1 == false)
    {
        Console.WriteLine("No se puede hacer la pelea. Ingrese de acordar los datos de los dos boxeadores");
    } 
    else
    {
        Pelea(Box1,Box2);
    }
    
break;


}

void ObtenerBox1(string Box1){
string nombre = Funciones.IngresarTexto("Ingrese el nombre del boxeador"); 
string pais = Funciones.IngresarTexto("Ingresar el nombre del pais donde nacio");
int peso = Funciones.IngresarEntero("Ingresar el peso");
int potgol = Funciones.numeroAleatorio(1,101);
int velopi = Funciones.numeroAleatorio(1,101);
Boxeador boxeador1 = new Boxeador(nombre,pais,peso,potgol,velopi);
listBoxeador.Add(Box1,boxeador1);
 Console.WriteLine($"Se ha creado la persona {nombre} y se ha agregado como el Boxeador N°1.");
}
void ObtenerBox2(string Box2){
string nombre = Funciones.IngresarTexto("Ingrese el nombre del boxeador"); 
string pais = Funciones.IngresarTexto("Ingresar el nombre del pais donde nacio");
int peso = Funciones.IngresarEntero("Ingresar el peso");
int potgol = Funciones.numeroAleatorio(1,101);
int velopi = Funciones.numeroAleatorio(1,101);
Boxeador boxeador2 = new Boxeador(nombre,pais,peso,potgol,velopi);
listBoxeador.Add(Box2,boxeador2);
 Console.WriteLine($"Se ha creado la persona {nombre} y se ha agregado como el Boxeador N°2.");
}
string Pelea(string Box1, string Box2){
    string ganador = "";
    double boxer1,boxer2;
    boxer1 = listBoxeador[Box1].ObtenerSkill();
    boxer2 = listBoxeador[Box1].ObtenerSkill();
    return ganador;
}