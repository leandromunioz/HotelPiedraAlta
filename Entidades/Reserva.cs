namespace Entidades
{
    public class Reserva
    {
        public Reserva(Persona huesped, DateTime fechaDeLlegada, DateTime diasDePesca, DateTime fechaDePartida, int cantidadPersonas, int cantidadLanchaYGuia, int cantidadDeHabitaciones, double costoDelPaquete, bool confirmado, double senia)
        {
            Huesped = huesped;
            FechaDeLlegada = fechaDeLlegada;
            DiasDePesca = diasDePesca;
            FechaDePartida = fechaDePartida;
            CantidadPersonas = cantidadPersonas;
            CantidadLanchaYGuia = cantidadLanchaYGuia;
            CantidadDeHabitaciones = cantidadDeHabitaciones;
            CostoDelPaquete = costoDelPaquete;
            Confirmado = confirmado;
            Senia = senia;
        }

        public Persona Huesped { get; set; }
        public DateTime FechaDeLlegada { get; set; }
        public DateTime DiasDePesca { get; set; }
        public DateTime FechaDePartida { get; set; }
        public int CantidadPersonas { get; set; }
        public int CantidadLanchaYGuia { get; set; }
        public int CantidadDeHabitaciones { get; set; }
        public double CostoDelPaquete { get; set; }
        public bool Confirmado { get; set; }
        public double Senia { get; set; }

    }


}