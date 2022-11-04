namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string emei, int memoria) : base(numero, modelo, emei, memoria){}

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp) => Console.WriteLine("Instalando o aplicativo " + nomeApp + " no Iphone");
    }
}