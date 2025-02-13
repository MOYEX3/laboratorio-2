int edad;
double sueldo;
string nombre;
bool casado;
string estado;
Console.WriteLine("Ingrese su edad");
edad = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese su sueldo");
sueldo = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ingrese su nombre");
nombre = Console.ReadLine();
Console.WriteLine("Ingrese su estado civil (1 para casado, 2 para soltero)");
string estadoCivil = Console.ReadLine();
casado = estadoCivil == "1";

Console.WriteLine("Su nombre es: " + nombre);
Console.WriteLine("Su edad es: " + edad);
Console.WriteLine("Su sueldo es: " + sueldo);
Console.WriteLine("Su estado civil es: " + (casado ? "casado" : "soltero"));
