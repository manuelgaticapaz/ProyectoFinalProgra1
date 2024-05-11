using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    class TipodeDocumento
    {
        private string idTDoc;
        private string nombreTDoc;
        private string descripcionTDoc;
        private string factorTDoc;

        public TipodeDocumento(string idTDoc, string nombreTDoc, string descripcionTDoc, string factorTDoc)
        {
            this.IdTDoc = idTDoc;
            this.NombreTDoc = nombreTDoc;
            this.DescripcionTDoc = descripcionTDoc;
            this.FactorTDoc = factorTDoc;
        }

        public string IdTDoc { get => idTDoc; set => idTDoc = value; }
        public string NombreTDoc { get => nombreTDoc; set => nombreTDoc = value; }
        public string DescripcionTDoc { get => descripcionTDoc; set => descripcionTDoc = value; }
        public string FactorTDoc { get => factorTDoc; set => factorTDoc = value; }
    }
}
