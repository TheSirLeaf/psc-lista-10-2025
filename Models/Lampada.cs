namespace Models
{
    public class Lampada
    {
        public string Tipo { get; set; }
        public double Potencia { get; set; }
        public string CorDaLuz { get; set; }
        public bool Ligada { get; set; }

        public Lampada() { }

        public Lampada(string tipo, double potencia, string corDaLuz, bool ligada)
        {
            Tipo = tipo;
            Potencia = potencia;
            CorDaLuz = corDaLuz;
            Ligada = ligada;
        }

        public void Ligar() { Ligada = true; Console.WriteLine($"Lâmpada {Tipo} ligada. Cor da luz: {CorDaLuz}."); }
        public void Desligar() { Ligada = false; Console.WriteLine("Lâmpada desligada."); }
        public void Trocar() { Console.WriteLine("Lâmpada trocada por uma nova."); }
        public void Piscar() { Console.WriteLine("Lâmpando piscando (simulado)..."); }
    }
}
