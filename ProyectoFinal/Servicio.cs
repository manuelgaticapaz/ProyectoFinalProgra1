using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    class Servicio
    {
        private string idServicio;
        private string descripcion;
        private double valor;
        private string horainicio;
        private string horafinal;
        private string disponibilidad;
        private string reservas;

        public Servicio(string idServicio, string descripcion, double valor, string horainicio, string horafinal, string disponibilidad, string reservas)
        {
            this.IdServicio = idServicio;
            this.Descripcion = descripcion;
            this.Valor = valor;
            this.Horainicio = horainicio;
            this.Horafinal = horafinal;
            this.Disponibilidad = disponibilidad;
            this.Reservas = reservas;
        }

        public string IdServicio { get => idServicio; set => idServicio = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public double Valor { get => valor; set => valor = value; }
        public string Horainicio { get => horainicio; set => horainicio = value; }
        public string Horafinal { get => horafinal; set => horafinal = value; }
        public string Disponibilidad { get => disponibilidad; set => disponibilidad = value; }
        public string Reservas { get => reservas; set => reservas = value; }
    }
}
