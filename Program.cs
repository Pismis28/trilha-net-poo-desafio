using System.ComponentModel;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero:"12998545632", modelo: "modelo k2", imei:"124578", memoria: 128);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Tinder");
nokia.Ligar();

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero:"1298562341", modelo: "modelo 10", imei:"984563", memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("Maps");


