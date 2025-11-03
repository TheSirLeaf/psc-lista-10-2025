namespace Models
{
    public class Relogio
    {
        public string Marca { get; set; }
        public string Tipo { get; set; }
        public string HoraAtual { get; set; }
        public bool ResistenteAGua { get; set; }

        public Relogio() { }

        public Relogio(string marca, string tipo, string horaAtual, bool resistenteAGua)
        {
            Marca = marca;
            Tipo = tipo;
            HoraAtual = horaAtual;
            ResistenteAGua = resistenteAGua;
        }

        public void AjustarHora()
        {
            HoraAtual = System.DateTime.Now.ToString("HH:mm");
            Console.WriteLine($"Hora ajustada para {HoraAtual}.");
        }
        public void MostrarHora() { Console.WriteLine($"Hora atual: {HoraAtual}"); }
        public void Cronometro() { Console.WriteLine("Cronômetro iniciado (simulado)..."); }
        public void Alarme() { Console.WriteLine("Alarme ativado (simulado)..."); }
    }
}
