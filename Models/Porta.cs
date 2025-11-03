namespace Models
{
    public class Porta
    {
        public string Material { get; set; }
        public string Cor { get; set; }
        public double Altura { get; set; }
        public double Largura { get; set; }
        public bool EstaAberta { get; set; }

        public Porta() { }

        public Porta(string material, string cor, double altura, double largura, bool estaAberta)
        {
            Material = material;
            Cor = cor;
            Altura = altura;
            Largura = largura;
            EstaAberta = estaAberta;
        }

        public void Abrir() { EstaAberta = true; Console.WriteLine("Porta aberta."); }
        public void Fechar() { EstaAberta = false; Console.WriteLine("Porta fechada."); }
        public void Trancar() { Console.WriteLine("Porta trancada."); }
        public void Destrancar() { Console.WriteLine("Porta destrancada."); }
    }
}
