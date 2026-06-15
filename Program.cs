using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia nokia1 = new Nokia("123456", "modeloA", "45454545", 128);
nokia1.Ligar();
nokia1.ReceberLigacao();
nokia1.InstalarAplicativo("Whatsapp");

Iphone iphone1 = new Iphone("9876544", "modeloX", "78451244", 125);
iphone1.Ligar();
iphone1.ReceberLigacao();
iphone1.InstalarAplicativo("Telegram");