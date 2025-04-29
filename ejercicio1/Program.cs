
public class Tarea
{
    public int TareaID { get; set; }
    public string Descripcion { get; set; }
    public int Duracion { get; set; } //validar que esté entre 10 y 100
                                      // Puedes añadir un constructor y métodos auxiliares si lo consideras necesario
    public Tarea(int id, string descrip, int durac)
    {
        TareaID = id;
        Descripcion = descrip;
        Duracion = durac;
    }
}
class Program
{
    static void Main()
    {
        List<Tarea> tareasPendientes = new List<Tarea>();
        Console.WriteLine("¿Cuántas tareas desea realizar?");
        int cantidad = int.Parse(Console.ReadLine()); //creo cantidad de tareas

        for (int i = 0; i < cantidad; i++)
        {
           
            Console.WriteLine($"Tarea {i + 1}");

            Console.WriteLine("Agregue la descripción de la tarea"); //ingreso descripcion de la tarea
            string descripcion = Console.ReadLine();

            Console.WriteLine("Ingrese la duracion: debe estar entre 10 y 100"); //agrego la duracion
            int duracion = int.Parse(Console.ReadLine());

            if (duracion <= 100 && duracion >= 0)
            {
                Tarea nuevaTarea = new Tarea(i, descripcion, duracion);
                tareasPendientes.Add(nuevaTarea);
            } else 
            {
                Console.WriteLine("Error. Debe ingresar un numero entre 0 y 100");
            }

        }

        Console.WriteLine("Tareas pendientes realizadas: ");
        foreach (var recorrer in tareasPendientes)
        {
            Console.WriteLine($"ID: {recorrer.TareaID}\n Descripción: {recorrer.Descripcion}\n Duracion: {recorrer.Duracion}minutos.");
        }
    }

}


