using PiedraPapelOTijeras.Dominio;

namespace PiedraPapelOTijeras.Tests
{
    public class ResultadoRondaTests
    {
        private readonly Jugador _jugador1;
        private readonly Jugador _jugador2;

        public ResultadoRondaTests()
        {
            _jugador1 = new Jugador("Jugador1");
            _jugador2 = new Jugador("Jugador2");
        }

        [Fact]
        public void DeterinarGanador()
        {
            Juego.Jugada jugadaJugador1 = Juego.Jugada.Piedra;
            Juego.Jugada jugadaJugador2 = Juego.Jugada.Tijeras;

            ResultadoRonda result = new ResultadoRonda(_jugador1, jugadaJugador1, _jugador2, jugadaJugador2);

            Assert.Equal(result.Ganador, _jugador1);

        }

        public void DeterinarGanador2()
        {
            Juego.Jugada jugadaJugador1 = Juego.Jugada.Tijeras;
            Juego.Jugada jugadaJugador2 = Juego.Jugada.Piedra;

            ResultadoRonda result = new ResultadoRonda(_jugador1, jugadaJugador1, _jugador2, jugadaJugador2);

            Assert.Equal(result.Ganador, _jugador2);

        }
        public void DeterinarGanador3()
        {
            Juego.Jugada jugadaJugador1 = Juego.Jugada.Tijeras;
            Juego.Jugada jugadaJugador2 = Juego.Jugada.Papel;

            ResultadoRonda result = new ResultadoRonda(_jugador1, jugadaJugador1, _jugador2, jugadaJugador2);

            Assert.Equal(result.Ganador, _jugador1);

        }

        public void DeterinarGanador4()
        {
            Juego.Jugada jugadaJugador1 = Juego.Jugada.Papel;
            Juego.Jugada jugadaJugador2 = Juego.Jugada.Piedra;

            ResultadoRonda result = new ResultadoRonda(_jugador1, jugadaJugador1, _jugador2, jugadaJugador2);

            Assert.Equal(result.Ganador, _jugador2);

        }

        [Theory]
        [InlineData(Juego.Jugada.Tijeras, Juego.Jugada.Tijeras)]
        [InlineData(Juego.Jugada.Piedra, Juego.Jugada.Piedra)]
        [InlineData(Juego.Jugada.Papel, Juego.Jugada.Papel)]

        public void CuandoSonIguales(Juego.Jugada jugada1, Juego.Jugada jugada2)
        {

            ResultadoRonda result = new ResultadoRonda(_jugador1, jugada1, _jugador2, jugada2);

            Assert.Equal(result.Ganador, null);
      
        }



    }
}
