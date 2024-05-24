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
        private int cantidadPersonas;
        private DateTime fechaInicio;
        private DateTime fechaFinal;

        public Reservacion(int id, string idHuesped, int cantidadPersonas, DateTime fechaInicio, DateTime fechaFinal)
        {
            this.Id = id;
            this.IdHuesped = idHuesped;
            this.cantidadPersonas = cantidadPersonas;
            this.FechaInicio = fechaInicio;
            this.FechaFinal = fechaFinal;
        }

        public int Id { get => id; set => id = value; }
        public string IdHuesped { get => idHuesped; set => idHuesped = value; }
        public int CantidadPersonas { get => cantidadPersonas; set => cantidadPersonas = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaFinal { get => fechaFinal; set => fechaFinal = value; }
    }
}
