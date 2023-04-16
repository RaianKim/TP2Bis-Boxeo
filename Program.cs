Console.WriteLine("1. Cargar Boxeador N°1");
Console.WriteLine("2. Cargar Boxeador N°2");
Console.WriteLine("3. Pelea!!");
Console.WriteLine("4. Fin");
int respuesta = Funciones.IngresarEnteroEnRango("Escriba 1,2,3  o 4",1,3);
switch(respuesta)
{

case 1:
    ObtenerBox1();
break;
    
case 2:
    ObtenerBox2();
break;

case 3:

break;


}

void ObtenerBox1(){
string nombre = Funciones.IngresarTexto("Ingrese el nombre del boxeador"); 
string pais = Funciones.IngresarTexto("Ingresar el nombre del pais donde nacio");
int peso = Funciones.IngresarEntero("Ingresar el peso");
int potgol = Funciones.numeroAleatorio(1,101);
int velopi = Funciones.numeroAleatorio(1,101);
}
void ObtenerBox2(){
string nombre = Funciones.IngresarTexto("Ingrese el nombre del boxeador"); 
string pais = Funciones.IngresarTexto("Ingresar el nombre del pais donde nacio");
int peso = Funciones.IngresarEntero("Ingresar el peso");
int potgol = Funciones.numeroAleatorio(1,101);
int velopi = Funciones.numeroAleatorio(1,101);
}