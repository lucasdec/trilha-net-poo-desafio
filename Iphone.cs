public class Iphone : Smartphone
{
    public Iphone(string numero, string modelo, string imei, int memoria)
    {
        Numero = numero;
        Modelo = modelo;
        IMEI = imei;
        Memoria = memoria;
    }

    public override void Ligar()
    {
        Console.WriteLine("Ligando via iPhone...");
    }

    public override void ReceberLigacao()
    {
        Console.WriteLine("Recebendo ligação no iPhone...");
    }

    public override void InstalarAplicativo(string nome)
    {
        Console.WriteLine($"Instalando o aplicativo {nome} na App Store do iPhone...");
    }
}
