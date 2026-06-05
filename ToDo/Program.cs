
using tarea;

//genera lista de tareas pendientes
List<Tarea> tareasPendientes = new List<Tarea>();
//genera lista de tareas realizadas
List<Tarea> tareasRealizadas = new List<Tarea>();


int control = 1;
int idtarea = 0;
int id = 1;
bool hayDigito = false;
string? datos = "";
Console.WriteLine("Ingrese una opcion ");
do
{
    Console.WriteLine("1 = generar Lista");
    Console.WriteLine("2 = mover tareas");
    Console.WriteLine("3 = buscar tarea por descripcion");
    Console.WriteLine("4 = mostrar listas");
    Console.WriteLine("0 = salir");
    while(!hayDigito)
    {
        datos = Console.ReadLine();
        hayDigito = int.TryParse(datos,out control);
        if (!hayDigito)
        {
            Console.WriteLine(datos +" no es un numero valido");
            Console.WriteLine("Ingrese una opcion:");
        }
    }
    hayDigito = false;
    switch (control)
    {
        case 1:
        //numero aleatorio de listas
            generaTareas(tareasPendientes,id);
            break;
        case 2:
        //mueve tareas 
            if (tareasPendientes.Count !=0)
            {
                
                Console.WriteLine("Ingrese el id de la tarea a mover: ");
                
                while(!hayDigito)
                {
                    datos = Console.ReadLine();
                    hayDigito = int.TryParse(datos,out idtarea);
                    if (!hayDigito)
                    {
                        Console.WriteLine(datos +" no es un numero valido");
                        Console.WriteLine("Ingrese un numero:");
                    }
                }
                moverTarea(tareasPendientes,tareasRealizadas,idtarea);
            }
            else
            {
                Console.WriteLine("Lista vacia");
            }
            break;
        case 3:
        //busca por palabra clave
            if (tareasPendientes.Count !=0)
            {
                Console.WriteLine("Ingrese la palabra clave a buscar: ");
                datos = Console.ReadLine();
                Console.WriteLine("Tareas encontradas\n");
                buscarTareas(tareasPendientes,datos);
            }
            else
            {
                Console.WriteLine("Lista vacia");
            }
            break;
        case 4:
        //muestra las listas
            Console.WriteLine("\nTareas pendientes\n");
            mostraListaTarea(tareasPendientes);
            Console.WriteLine("\nTarea realizadas\n");
            mostraListaTarea(tareasRealizadas);
            break;
        default:
            if (control!=0)
            {
                
                Console.WriteLine("\nOpcion no disponible\n");
            }
            break;
    }
    if (control!=0)
    {
        
        Console.WriteLine("\nDesea seguir? presione 5 de lo contrario presione 0");
        while(!hayDigito)
        {
            datos = Console.ReadLine();
            hayDigito = int.TryParse(datos,out control);
            if (!hayDigito)
            {
                Console.WriteLine(datos +" no es un numero valido");
                Console.WriteLine("Ingrese un numero:");
            }
        }
    }
    hayDigito = false;
} while (control !=0);


static void generaTareas(List<Tarea> pendientes,int id)
{
    Random aleatorio = new Random();
    int N = aleatorio.Next(1,5);
    int duracion;
    string ?descripcion = "";
    Console.WriteLine($"Cantidad de tareas {N}");
    while (N>0)
    {

        duracion = aleatorio.Next(10,101);
        Console.WriteLine($"Ingrese la descripcion de la tarea con ID {id}");
        descripcion = Console.ReadLine();
        pendientes.Add(new Tarea(id,descripcion,duracion));
        id+=1;
        N-=1;
    }
}

static void moverTarea(List<Tarea> pendientes,List<Tarea> realizadas,int id)
{
    Tarea tareaAux = null;
    
    foreach (Tarea item in pendientes)
    {
        if (item.TareaID == id)
        {
            tareaAux = item;
            break;
        }
    }
    if (tareaAux != null)
    {
        realizadas.Add(tareaAux);
        pendientes.Remove(tareaAux);
        Console.WriteLine("Se movio la tarea");
    }
    else
    {
        Console.WriteLine("No se encontro la tarea");
            
    }
    
}

static void mostraListaTarea(List<Tarea> tareas)
{
    if(tareas.Count!= 0){
        
        foreach (Tarea item in tareas)
        { 
            Console.WriteLine($"ID: {item.TareaID} - Descripcion: {item.Descripcion} - Duracion {item.Duracion}");
        }
        }
    else
    {
        Console.WriteLine("Lista vacia");
    }
}

static void buscarTareas(List<Tarea> tareas,string descrip)
{
    int band = 0;
    foreach (Tarea tarea in tareas)
    {
        if ( tarea.Descripcion.IndexOf(descrip)!=-1)
        {
            band = 1;
            Console.WriteLine($"ID: {tarea.TareaID} - Descripcion: {tarea.Descripcion} - Duracion {tarea.Duracion}");
        }
    }
    if (band==0)
    {
        Console.WriteLine("No hay coincidencias");
    }
    
}