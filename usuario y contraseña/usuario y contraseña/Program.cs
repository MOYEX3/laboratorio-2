string usuario = "admin";
string contraseña = "admin";
bool correcto = false;
while (!correcto)
{
    Console.WriteLine("Ingrese su usuario");
    string usuarioIngresado = Console.ReadLine();
    Console.WriteLine("Ingrese su contraseña");
    string contraseñaIngresada = Console.ReadLine();
    if (usuarioIngresado == usuario && contraseñaIngresada == contraseña)
    {
        Console.WriteLine("Bienvenido");
        correcto = true;
    }
    if (usuarioIngresado == usuario && contraseñaIngresada != contraseña)
    {
        Console.WriteLine("Contraseña incorrecta");
    }
    if (usuarioIngresado != usuario && contraseñaIngresada == contraseña)
    {
        Console.WriteLine("Usuario incorrecto");
    }
    if (usuarioIngresado != usuario && contraseñaIngresada != contraseña)
    {
        Console.WriteLine("Usuario y contraseña incorrectos");
    }
}

