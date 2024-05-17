using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    class Habitacion
    {
        private int idHabitacion;
        private string nombre;
        private string descripcion;
        private int capacidadP;
        private double precio;

        public Habitacion(int idHabitacion, string nombre, string descripcion, int capacidadP, double precio)
        {
            this.IdHabitacion = idHabitacion;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.CapacidadP = capacidadP;
            this.Precio = precio;
        }

        public int IdHabitacion { get => idHabitacion; set => idHabitacion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int CapacidadP { get => capacidadP; set => capacidadP = value; }
        public double Precio { get => precio; set => precio = value; }
    }
}
