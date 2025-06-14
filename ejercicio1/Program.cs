using System.Data.Common;
using EspacioTareas;

var TareasPendientes = new List<Tarea>();
int FinishTarea = -1;
int id = 0;

do
{
    Console.WriteLine("Agregue una descripcion de la tarea: ");
    string descripcion = Console.ReadLine();

    Console.WriteLine("Agregue la duracion de la tarea: ");
    int duracion = int.Parse(Console.ReadLine());

    Tarea tarea = new Tarea(id, descripcion, duracion);
    TareasPendientes.Add(tarea);

    id++;

    Console.WriteLine("¿Desea crear otra tarea?");
    Console.WriteLine("[0]. NO.");
    Console.WriteLine("[1]. SI.");
    FinishTarea = int.Parse(Console.ReadLine());
} while (FinishTarea == 1);

//---MUESTRO LAS TAREAS---
foreach (var tareas in TareasPendientes)
{
    Console.WriteLine(tareas.ShowTarea());
}
