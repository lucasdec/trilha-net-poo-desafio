namespace DesafioPOO
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string IMEI { get; set; }
        public int Memoria { get; set; }

        public abstract void Ligar();
        public abstract void ReceberLigacao();
        public abstract void InstalarAplicativo(string nome);
    }
}
