namespace Models
{
    public class Televisao
    {
        public double TamanhoTela { get; set; }
        public string Marca { get; set; }
        public string Resolucao { get; set; }
        public int CanalAtual { get; set; }
        public int Volume { get; set; }

        public Televisao() { }

        public Televisao(double tamanhoTela, string marca, string resolucao, int canalAtual, int volume)
        {
            TamanhoTela = tamanhoTela;
            Marca = marca;
            Resolucao = resolucao;
            CanalAtual = canalAtual;
            Volume = volume;
        }

        public void Ligar() { Console.WriteLine($"Televisão {Marca} ligada no canal {CanalAtual}."); }
        public void Desligar() { Console.WriteLine("Televisão desligada."); }
        public void MudarCanal()
        {
            CanalAtual++;
            Console.WriteLine($"Canal alterado para {CanalAtual}.");
        }
        public void AumentarVolume() { Volume = System.Math.Min(100, Volume + 1); Console.WriteLine($"Volume: {Volume}"); }
        public void DiminuirVolume() { Volume = System.Math.Max(0, Volume - 1); Console.WriteLine($"Volume: {Volume}"); }
    }
}
