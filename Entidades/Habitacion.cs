using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Habitacion
    {
        public Habitacion( int numeroDeHabitacion, bool estado)
        {
            ListadoDeReservas = new List<Reserva>();
            NumeroDeHabitacion = numeroDeHabitacion;
            Estado = estado;
        }

        public List<Reserva> ListadoDeReservas { get; set; }
        public int NumeroDeHabitacion { get; set; }
        public bool Estado { get; set; } 
    }
}
