namespace Models
{
    public class Cadeira
    {
        public string Material { get; set; }
        public string Cor { get; set; }
        public double Altura { get; set; }
        public bool TemEncosto { get; set; }
        public double PesoSuportado { get; set; }

        public Cadeira() { }

        public Cadeira(string material, string cor, double altura, bool temEncosto, double pesoSuportado)
        {
            Material = material;
            Cor = cor;
            Altura = altura;
            TemEncosto = temEncosto;
            PesoSuportado = pesoSuportado;
        }

        public void Girar() { Console.WriteLine($"Girando a cadeira de {Material}."); }
        public void AjustarAltura()
        {
            Altura += 2.0;
            Console.WriteLine($"Altura ajustada para {Altura} cm.");
        }
        public void Reclinar() { Console.WriteLine("Encosto reclinado."); }
        public void Mover() { Console.WriteLine("Movendo a cadeira para nova posição."); }
    }
}
