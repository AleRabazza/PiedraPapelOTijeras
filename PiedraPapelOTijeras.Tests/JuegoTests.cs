using PiedraPapelOTijeras.Dominio;

namespace PiedraPapelOTijeras.Tests
{
    public class JuegoTests
    {
        private readonly Jugador _jugador1;
        private readonly Jugador _jugador2;

        public JuegoTests()
        {
            _jugador1 = new Jugador("Ana");
            _jugador2 = new Jugador("Luis");
        }

        [Theory]
        [InlineData(1,3,3)]
        [InlineData(2,3,3)]
        [InlineData(4,3,3)]
        public void ObtenerGanadorDeLaPartida(int puntaje2, int puntaje1, int total)
        {
           



        }

    }
}
