using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Nokia", imei: "1234564748", memoria: 256);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "4548", modelo: "Modelo 2", imei: "1212412313213", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");