using System.Security.Cryptography.X509Certificates;

int dia;
bool correcto = false; 

    while (!correcto)
{
    Console.WriteLine("Introduce un número del 1 al 7");
    dia = Convert.ToInt32(Console.ReadLine());

    switch (dia)
    {
        case 1:
            Console.WriteLine("Lunes");
            correcto = true;
            break;
        case 2:
            Console.WriteLine("Martes");
            correcto = true;
            break;
        case 3:
            Console.WriteLine("Miércoles");
            correcto = true;
            break;
        case 4:
            Console.WriteLine("Jueves");
            correcto = true;
            break;
        case 5:
            Console.WriteLine("Viernes");
            correcto = true;
            break;
        case 6:
            Console.WriteLine("Sábado");
            correcto = true;
            break;
        case 7:
            Console.WriteLine("Domingo");
            correcto = true;
            break;
        default:
            Console.WriteLine("Día no válido");
            correcto = false;
            break;
    }
}