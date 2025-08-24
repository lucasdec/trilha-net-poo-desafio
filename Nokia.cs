public class Nokia : Smartphone
{
    public Nokia(string numero, string modelo, string imei, int memoria)
    {
        Numero = numero;
        Modelo = modelo;
        IMEI = imei;
        Memoria = memoria;
    }

    public override void Ligar()
    {
        Console.WriteLine("Ligando via Nokia...");
    }

    public override void ReceberLigacao()
    {
        Console.WriteLine("Recebendo ligação no Nokia...");
    }

    public override void InstalarAplicativo(string nome)
    {
        Console.WriteLine($"Instalando o aplicativo {nome} no Nokia...");
    }
}
