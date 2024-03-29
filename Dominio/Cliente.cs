﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cliente
    {
        public int Id { get; set; }
        public int DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Mail { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public int CodPostal { get; set; }
        public DateTime FechaReg { get; set; }
    }
}
