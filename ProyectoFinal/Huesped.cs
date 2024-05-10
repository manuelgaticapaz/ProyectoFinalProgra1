using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    class Huesped
    {
        private string idHuesped;
        private string nombresHuesped;
        private string apellidosHuesped; 
        private long numIdentificacionHuesped;
        private string direccionHuesped;
        private string emailHuesped;
        private int telefonoHuesped;
        private string tipoHuesped;

        

        public Huesped(string idHuesped, string nombresHuesped, string apellidosHuesped, long numIdentificacionHuesped, string direccionHuesped, string emailHuesped, int telefonoHuesped, string tipoHuesped)
        {
            this.IdHuesped = idHuesped;
            this.NombresHuesped = nombresHuesped;
            this.ApellidosHuesped = apellidosHuesped;
            this.NumIdentificacionHuesped = numIdentificacionHuesped;
            this.DireccionHuesped = direccionHuesped;
            this.EmailHuesped = emailHuesped;
            this.TelefonoHuesped = telefonoHuesped;
            this.TipoHuesped = tipoHuesped;
        }

        public string IdHuesped { get => idHuesped; set => idHuesped = value; }
        public string NombresHuesped { get => nombresHuesped; set => nombresHuesped = value; }
        public string ApellidosHuesped { get => apellidosHuesped; set => apellidosHuesped = value; }
        public long NumIdentificacionHuesped { get => numIdentificacionHuesped; set => numIdentificacionHuesped = value; }
        public string DireccionHuesped { get => direccionHuesped; set => direccionHuesped = value; }
        public string EmailHuesped { get => emailHuesped; set => emailHuesped = value; }
        public int TelefonoHuesped { get => telefonoHuesped; set => telefonoHuesped = value; }
        public string TipoHuesped { get => tipoHuesped; set => tipoHuesped = value; }
    }
}
