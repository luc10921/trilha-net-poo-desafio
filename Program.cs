using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(
    numero: "123123",
    modelo: "Model 1",
    imei: "123123123123123",
    memoria: 64
);
nokia.Ligar();
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("\nSmartphone Nokia:");
Smartphone iphone = new Iphone(
    numero: "789789",
    modelo: "Model 2",
    imei: "789789789789789",
    memoria: 128
);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Twitter");

