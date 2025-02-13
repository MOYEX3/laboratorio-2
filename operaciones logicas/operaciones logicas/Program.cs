int num1;
int num2;
Console.WriteLine("Ingrese el primer numero");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese el segundo numero");
num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine("El primer numero es mayor que el segundo");
}
 if (num1 < num2)
{
    Console.WriteLine("El primer numero es menor que el segundo");
}
 if (num1 == num2)
    { Console.WriteLine("Los numeros son iguales");
    }
  
    if (num1 > num2 && num1 > 2)
    {
        Console.WriteLine("El primer numero es mayor que el segundo y mayor que el 2");
    }
if (num1 > num2 || num1 == num2)
{
    Console.WriteLine("El primer numero es mayor que el segundo o igual al segundo");
}
    {
         
        
    }
