using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e 

Console.WriteLine("SmartPhone Nokia: ");
Smartphone nokia = new Nokia(numero:"123456789", modelo:"modelo 100", imei:"111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("SmartPhone Iphone:");
Smartphone iphone = new Iphone(numero:"987654321", modelo:"modelo 400", imei:"222222", memoria: 64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");