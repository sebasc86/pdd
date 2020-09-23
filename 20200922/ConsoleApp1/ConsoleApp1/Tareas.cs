using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Tareas
    {
        public string titulo { get; set; }
        public string vencimiento { get; set; }
        public string estimacion { get; set; }
        public Recursos responsable { get; set; }
        public string estado { get; set; }

        public Tareas(string titulo, string vencimiento, string estimacion, Recursos recursos, string estado)
        {
        }

    }
}
