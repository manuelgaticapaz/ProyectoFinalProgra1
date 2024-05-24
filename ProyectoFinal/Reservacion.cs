using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    class Reservacion
    {
        private int id;
        private string idHuesped;
        private int idHabitacion;
        private int cantidadPersonas;
        private DateTime fechaInicio;
        private DateTime fechaFinal;
        private int cantNoches;
        private double precio;
        private double precioFinal;

        public Reservacion(int id, string idHuesped, int cantidadPersonas, DateTime fechaInicio, DateTime fechaFinal)
        {
            this.Id = id;
            this.IdHuesped = idHuesped;
            this.cantidadPersonas = cantidadPersonas;
            this.FechaInicio = fechaInicio;
            this.FechaFinal = fechaFinal;
        }

        public Reservacion(int id, string idHuesped, int idHabitacion, int cantidadPersonas, DateTime fechaInicio, DateTime fechaFinal, int cantNoches, double precio, double precioFinal)
        {
            this.id = id;
            this.idHuesped = idHuesped;
            this.idHabitacion = idHabitacion;
            this.cantidadPersonas = cantidadPersonas;
            this.fechaInicio = fechaInicio;
            this.fechaFinal = fechaFinal;
            this.CantNoches = cantNoches;
            this.Precio = precio;
            this.PrecioFinal = precioFinal;
        }

        public int Id { get => id; set => id = value; }
        public string IdHuesped { get => idHuesped; set => idHuesped = value; }
        public int CantidadPersonas { get => cantidadPersonas; set => cantidadPersonas = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaFinal { get => fechaFinal; set => fechaFinal = value; }
        public int CantNoches { get => cantNoches; set => cantNoches = value; }
        public double Precio { get => precio; set => precio = value; }
        public double PrecioFinal { get => precioFinal; set => precioFinal = value; }
        public int IdHabitacion { get => idHabitacion; set => idHabitacion = value; }
    }
}
