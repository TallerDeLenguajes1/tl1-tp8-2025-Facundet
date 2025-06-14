namespace EspacioTareas
{
    public class Tarea
    {
        int tareaID;
        string descripcion;
        int duracion;

        public Tarea(int tareaID, string descr, int dura)
        {
            this.tareaID = tareaID;
            this.descripcion = descr;
            this.duracion = dura;
        }

        public int TareaID { get => tareaID; set => tareaID = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Duracion { get => duracion; set => duracion = value; }

        public string ShowTarea()
        {
            return " ID: [" + TareaID + "] | Descripcion: " + Descripcion + " | Duracion: " + Duracion + " minutos.";
        }
    }
}