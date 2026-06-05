using EspacioCalculadora;


int opcion = 0;
bool esUnNumeroValido = false;
string ?Num1 = "";
int inicial = 5;
double numero = 1;
Calculadora nuevaCalculadora = new Calculadora(inicial);
do
{
    //menu
    Console.WriteLine("Ingrese una opcion:");
    Console.WriteLine("1 - Sumar");
    Console.WriteLine("2 - Restar");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("4 - Dividir");
    Console.WriteLine("5 - Limpiar");
    Console.WriteLine("6 - mostrar historial");
    Console.WriteLine("0 - salir");
    //ingresa una opcion
    while(!esUnNumeroValido)
    {
        Num1 = Console.ReadLine();
        esUnNumeroValido = int.TryParse(Num1,out opcion);
        if (!esUnNumeroValido)
        {
            Console.WriteLine(Num1 +" no es una opcion valida");
            Console.WriteLine("Ingrese una opcion:");
        }
    }

    esUnNumeroValido = false;
    //ingresa el numero a operar
    if (opcion!=0 && opcion!=6 && opcion!=5)
    {
        
        while(!esUnNumeroValido)
        {
            Console.WriteLine("Ingrese un numero a operar :");
            Num1 = Console.ReadLine();
            esUnNumeroValido = double.TryParse(Num1,out numero);
            if (!esUnNumeroValido)
            {
                Console.WriteLine(Num1 +" no es un numero valido");
            }
        }
    }
    //realiza una accion de las opciones
    switch (opcion)
    {
        case 1:
            nuevaCalculadora.Sumar(numero);
            Console.WriteLine($@"El resultado es: {nuevaCalculadora.Resultado}");
            break;
        case 2:
            nuevaCalculadora.Restar(numero);
            Console.WriteLine($@"El resultado es: {nuevaCalculadora.Resultado}");
            break;
        case 3:
            nuevaCalculadora.Multiplicar(numero);
            Console.WriteLine($@"El resultado es: {nuevaCalculadora.Resultado}");
            break;
        case 4:
            nuevaCalculadora.Dividir(numero);
            Console.WriteLine($@"El resultado es: {nuevaCalculadora.Resultado}");
            break;
        case 5:
            nuevaCalculadora.Limpiar();
            break;
        case 6:
            if (nuevaCalculadora.Operaciones.Count() !=0)
            {
                foreach (var item in nuevaCalculadora.Operaciones)
                {
                    Console.WriteLine($"nuevo valor ingresado :{item.NuevoValor}");
                }
            }else
            {
                Console.WriteLine("El historial esta vacio ");
            }
            break;
        default:
            if (opcion !=0)
            {
                Console.WriteLine("Opcion no valida ");
            }
            break;
    }
    esUnNumeroValido = false;
    //controla para sguir operando
    if (opcion !=0)
    {
        Console.WriteLine("Desea seguir operando?: Si = 1 No = 0");
        while(!esUnNumeroValido)
        {
            Num1 = Console.ReadLine();
            esUnNumeroValido = int.TryParse(Num1,out opcion);
            if (!esUnNumeroValido)
            {
                Console.WriteLine(Num1 +" no es una opcion valida");
                Console.WriteLine("Ingrese una opcion:");
            }
        }
    }
    esUnNumeroValido = false;


} while (opcion != 0);

