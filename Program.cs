using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "11111-1111", modelo: "Nokia A", imei: "11111111", memoria: 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("iFood");

Console.WriteLine("");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "99999-9999", modelo: "iphone Z", imei: "9999999", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("iFood");