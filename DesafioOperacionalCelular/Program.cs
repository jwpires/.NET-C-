using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Iphone");
Smartphone iphone = new Iphone(numero: "47785", modelo: "Iphone 14 Pro", emei: "145887789", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Grasshopper");

Console.WriteLine("\n");

Console.WriteLine("Nokia");
Smartphone nokia = new Nokia(numero: "33687", modelo: "Nokia C20", emei: "22589664701", memoria: 32);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("dio.me");



// Resultado apresentado:
// Iphone
// Ligando...
// Instalando o aplicativo Grasshopper no Iphone


// Nokia
// Recebendo ligação...
// Instalando o aplicativo dio.me no Nokia! 