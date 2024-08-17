using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Testando o Nokia");
var nokiaPhone = new Nokia("123456", "modelo 1", "111111", 32);
nokiaPhone.Ligar();
nokiaPhone.InstalarAplicativo("facebook");

Console.WriteLine("\n");

Console.WriteLine("Testando o Iphone");
var Iphone = new Nokia("7891011", "modelo 2", "222222", 64);
Iphone.Ligar();
Iphone.InstalarAplicativo("whatzapp");