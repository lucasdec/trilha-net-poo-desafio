using DesafioPOO.Models;  // Adiciona o using para o namespace correto

Console.WriteLine("Testando Nokia:");

Smartphone nokia = new Nokia("123456789", "Nokia 6", "001", 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\nTestando iPhone:");

Smartphone iphone = new Iphone("987654321", "iPhone 13", "002", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
