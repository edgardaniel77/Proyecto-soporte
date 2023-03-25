﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Tickets
    {
        public DateTime Fecha { get; set; }
        public string Usuario { get; set; }
        public string Cliente { get; set; }
        public string TipoSoporte { get; set; }
        public string DescripcionSolicitud { get; set; }
        public string DescripcionRespuesta{ get; set; }
        public Decimal Precio { get; set; }
        public decimal Impuesto { get;set; }
        public decimal Descuento { get;set; }
        public decimal total { get; set; }
        public Tickets() 
        {

        }
        public Tickets(DateTime fecha, string usuario, string cliente, string tipoSoporte, string descripcionSolicitud, string descripcionRespuesta, decimal precio, decimal impuesto, decimal descuento, decimal total)
        {
            Fecha = fecha;
            Usuario = usuario;
            Cliente = cliente;
            TipoSoporte = tipoSoporte;
            DescripcionSolicitud = descripcionSolicitud;
            DescripcionRespuesta = descripcionRespuesta;
            Precio = precio;
            Impuesto = impuesto;
            Descuento = descuento;
            this.total = total;
        }
    }
}
