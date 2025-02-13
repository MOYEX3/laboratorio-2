int edad;
string nombre;
Console.WriteLine("Escribe tu nombre");
nombre = Console.ReadLine();
Console.WriteLine("Escribe tu edad");
edad = Convert.ToInt32(Console.ReadLine());

if (edad < 12)
{
    Console.WriteLine(nombre);
    Console.WriteLine("Es un niño");
}
if (edad >= 12 && edad <= 17)
{
    Console.WriteLine(nombre);
    Console.WriteLine("Es un adolescente");
}
if (edad >= 18 && edad <= 59)
{
    Console.WriteLine(nombre);
    Console.WriteLine("Es un adulto");
}
if (edad >= 60)
{
    Console.WriteLine(nombre);
    Console.WriteLine("Es un adulto mayor");
}
