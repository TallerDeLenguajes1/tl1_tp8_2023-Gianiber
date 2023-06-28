namespace ListadoDeTareas
{
    enum EstadoTarea
    {
        Pendiente,
        Realizada
    }
    public class Tarea
    {
        int id;
        string? descripcion;
        int duracion;
        EstadoTarea estado;

        public int Id { get => id; set => id = value; }
        public string? Descripcion { get => descripcion; set => descripcion = value; }
        public int Duracion { get => duracion; set => duracion = value; }
        internal EstadoTarea Estado { get => estado; set => estado = value; }
    }
}