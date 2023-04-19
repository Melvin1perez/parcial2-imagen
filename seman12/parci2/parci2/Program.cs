//examen parcial 2 melvin perez

int dato1 = 16;
string dato2 = "25g";

try
{
    int resultado = dato1 + Convert.ToInt32(dato2);
    Console.WriteLine(resultado);

}
catch (Exception)
{
    Console.WriteLine("Lo sentimos no se pudo realizar la operación solicitada");
}
//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
