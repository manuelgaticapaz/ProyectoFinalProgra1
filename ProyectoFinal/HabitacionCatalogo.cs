using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    class HabitacionCatalogo
    {
        private int id;
        private int habIdTipoHabitacion;
        private string nivel;
        private string comentario;
        private bool disponible;

        public HabitacionCatalogo(int id, int habIdTipoHabitacion, string nivel, string comentario, bool disponible)
        {
            this.Id = id;
            this.HabIdTipoHabitacion = habIdTipoHabitacion;
            this.Nivel = nivel;
            this.Comentario = comentario;
            this.Disponible = disponible;
        }


        public int HabIdTipoHabitacion { get => habIdTipoHabitacion; set => habIdTipoHabitacion = value; }
        public string Nivel { get => nivel; set => nivel = value; }
        public string Comentario { get => comentario; set => comentario = value; }
        public bool Disponible { get => disponible; set => disponible = value; }
        public int Id { get => id; set => id = value; }
    }
}
