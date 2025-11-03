namespace Models
{
    public class Computador
    {
        public string Processador { get; set; }
        public int MemoriaRAM { get; set; }
        public int Armazenamento { get; set; }
        public string SistemaOperacional { get; set; }
        public bool Ligado { get; set; }

        public Computador() { }

        public Computador(string processador, int memoriaRAM, int armazenamento, string sistemaOperacional, bool ligado)
        {
            Processador = processador;
            MemoriaRAM = memoriaRAM;
            Armazenamento = armazenamento;
            SistemaOperacional = sistemaOperacional;
            Ligado = ligado;
        }

        public void Ligar() { Ligado = true; Console.WriteLine($"Computador com {Processador} ligado."); }
        public void Desligar() { Ligado = false; Console.WriteLine("Computador desligado."); }
        public void AbrirPrograma() { Console.WriteLine($"Abrindo programa no {SistemaOperacional}..."); }
        public void Reiniciar() { Console.WriteLine("Reiniciando computador..."); }
        public void Atualizar() { Console.WriteLine("Verificando atualizações e aplicando se houver..."); }
    }
}
