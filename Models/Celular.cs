namespace Models
{
    public class Celular
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Bateria { get; set; }
        public string SistemaOperacional { get; set; }
        public string Camera { get; set; }

        public Celular() { }

        public Celular(string marca, string modelo, int bateria, string sistemaOperacional, string camera)
        {
            Marca = marca;
            Modelo = modelo;
            Bateria = bateria;
            SistemaOperacional = sistemaOperacional;
            Camera = camera;
        }

        public void Ligar() { Console.WriteLine($"{Marca} {Modelo} ligado. Bateria: {Bateria}%"); }
        public void TirarFoto() { Console.WriteLine($"Tirando foto com a câmera {Camera}..."); }
        public void FazerLigacao() { Console.WriteLine($"Fazendo ligação... bateria em {Bateria}%"); }
        public void EnviarMensagem() { Console.WriteLine("Mensagem enviada."); }
        public void Carregar() { Bateria = 100; Console.WriteLine("Carregando... bateria em 100%."); }
    }
}
