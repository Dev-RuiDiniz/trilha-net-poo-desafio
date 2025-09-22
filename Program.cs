using System;
using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Smartphone Nokia:");
        Smartphone nokia = new Nokia(numero: "123456789", modelo: "Nokia G21", imei: "111111111111111", memoria: 128);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine("\n-----------------------------");

        Console.WriteLine("Smartphone iPhone:");
        Smartphone iphone = new Iphone(numero: "987654321", modelo: "iPhone 13", imei: "222222222222222", memoria: 256);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Telegram");
    }
}