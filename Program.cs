using ListadoDeTareas;
using System.Collections.Generic;
using System.IO;
using System.Text;


/*string respuesta = "";
string descripcion;
int i = 0;
List<Tarea> ListaTareas = new List<Tarea>();
do
{
    Random random = new Random();
    Tarea NTarea = new Tarea();
    Console.WriteLine("Ingrese la descripcion de la tarea:");
    NTarea.Id = i++;
    NTarea.Descripcion = Console.ReadLine();
    NTarea.Duracion = random.Next(10, 101);
    NTarea.Estado = EstadoTarea.Pendiente;
    ListaTareas.Add(NTarea);
    Console.WriteLine("Desea ingresar una nueva tarea? (s/n)");
    respuesta = Console.ReadLine();
} while (respuesta != "n");

foreach (Tarea tareaX in ListaTareas)
{
    Console.WriteLine(tareaX.Id + " - " + tareaX.Descripcion + " - " + tareaX.Estado + " - " + tareaX.Duracion);
}

do
{
    Console.WriteLine("Ingrese el ID de la tarea que desea realizar:");
    i = int.Parse(Console.ReadLine());
    ListaTareas[i].Estado = EstadoTarea.Realizada;
    Console.WriteLine("Tarea realizada \nDesea cambiar alguna otra tarea? (s/n)");
    respuesta = Console.ReadLine();
} while (respuesta != "n");

foreach (Tarea tareaX in ListaTareas)
{
    Console.WriteLine(tareaX.Id + " - " + tareaX.Descripcion + " - " + tareaX.Estado + " - " + tareaX.Duracion);
}

Console.WriteLine("Que tarea desea buscar?");
descripcion = Console.ReadLine();
int bandera = 0;

foreach (Tarea tareaX in ListaTareas)
{
    if (tareaX.Descripcion == descripcion)
    {
        Console.WriteLine(tareaX.Id + " - " + tareaX.Descripcion + " - " + tareaX.Estado + " - " + tareaX.Duracion);
        bandera = 1;
    }
}

if (bandera == 0)
{
    Console.WriteLine("No se encontró la tarea requerida");
}

string ubicacion = @"C:\RepoTaller\tl1_tp8_2023-Gianiber\empleado.txt";
int tiempo = 0;

if (File.Exists(ubicacion))
{
    foreach (Tarea item in ListaTareas)
    {
        if (item.Estado == EstadoTarea.Realizada)
        {
            tiempo = tiempo + item.Duracion;
        }
    }
    int cantLineas = File.ReadAllLines(ubicacion).Length;
    using StreamWriter sr = new StreamWriter(ubicacion,true);
    sr.WriteLine("Empleado " + (cantLineas+1) + " - Trabajó " + tiempo);
}
else
{
    using FileStream fs = File.Create(ubicacion);
    using StreamWriter sr = new StreamWriter(fs);
    foreach (Tarea item in ListaTareas)
    {
        if (item.Estado == EstadoTarea.Realizada)
        {
            tiempo = tiempo + item.Duracion;
        }
    }

    sr.WriteLine("Empleado 0 - Trabajó " + tiempo + "hs");
}
*/

string? ruta;
Console.WriteLine("Ingrese el directorio que desea analizar:");
ruta = Console.ReadLine();

if (Directory.Exists(ruta))
{
    string[] archivos = Directory.GetFiles(ruta);
    string csvPath = Path.Combine(ruta, "index.csv");
    StringBuilder csvBuilder = new StringBuilder();
    //using FileStream fs = File.Create(String.Concat(ruta, @"\index.csv"));
    //using StreamWriter sr = new StreamWriter(fs);
    for (int i = 0; i < archivos.Length; i++)
    {
        string archivo = archivos[i];
        string nombre = Path.GetFileNameWithoutExtension(archivo);
        string ext = Path.GetExtension(archivo);
        //sr.WriteLine(i + " - " + nombre + " - " + ext + ";");
        string linea = $"{i + 1},{nombre},{ext}";
        csvBuilder.AppendLine(linea);
        Console.WriteLine(linea);
    }
    File.WriteAllText(csvPath, csvBuilder.ToString());
}