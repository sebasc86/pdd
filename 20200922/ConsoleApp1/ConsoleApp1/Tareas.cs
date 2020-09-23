using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Tareas
    {
        public String titulo { get; set; }
        public String vencimiento { get; set; }
        public int estimacion { get; set; }
        public Recursos responsable { get; set; }
        public String estado { get; set; }
    }
}
