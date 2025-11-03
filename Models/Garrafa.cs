namespace Models
{
    public class Garrafa
    {
        public string Material { get; set; }
        public double Capacidade { get; set; }
        public string Cor { get; set; }
        public bool CheiaOuVazia { get; set; }

        public Garrafa() { }

        public Garrafa(string material, double capacidade, string cor, bool cheiaOuVazia)
        {
            Material = material;
            Capacidade = capacidade;
            Cor = cor;
            CheiaOuVazia = cheiaOuVazia;
        }

        public void Encher() { CheiaOuVazia = true; Console.WriteLine($"Garrafa de {Material} com capacidade {Capacidade}L preenchida."); }
        public void Esvaziar() { CheiaOuVazia = false; Console.WriteLine("Garrafa esvaziada."); }
        public void AbrirTampa() { Console.WriteLine("Tampa aberta."); }
        public void FecharTampa() { Console.WriteLine("Tampa fechada."); }
    }
}
