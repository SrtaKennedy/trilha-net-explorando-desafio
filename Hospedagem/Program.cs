using System.Text;
using PROJETO_HOSPEDAGEM.Models;

Console.OutputEncoding = Encoding.UTF8;


// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hóspede 1");
Pessoa p2 = new Pessoa(nome: "Hóspede 2");
Pessoa p3 = new Pessoa(nome: "Hóspede 3");
Pessoa p4 = new Pessoa(nome: "Hóspede 4");
Pessoa p5 = new Pessoa(nome: "Hóspede 5");
Pessoa p6 = new Pessoa(nome: "Hóspede 6");
Pessoa p7 = new Pessoa(nome: "Hóspede 7");
Pessoa p8 = new Pessoa(nome: "Hóspede 8");
Pessoa p9 = new Pessoa(nome: "Hóspede 9");
Pessoa p10 = new Pessoa(nome: "Hóspede 10");
Pessoa p11 = new Pessoa(nome: "Hóspede 11");
Pessoa p12 = new Pessoa(nome: "Hóspede 12");
Pessoa p13 = new Pessoa(nome: "Hóspede 13");
Pessoa p14 = new Pessoa(nome: "Hóspede 14");
Pessoa p15 = new Pessoa(nome: "Hóspede 15");
Pessoa p16 = new Pessoa(nome: "Hóspede 16");
Pessoa p17 = new Pessoa(nome: "Hóspede 17");
Pessoa p18 = new Pessoa(nome: "Hóspede 18");
Pessoa p19 = new Pessoa(nome: "Hóspede 19");
Pessoa p20 = new Pessoa(nome: "Hóspede 20");
Pessoa p21 = new Pessoa(nome: "Hóspede 21");
Pessoa p22 = new Pessoa(nome: "Hóspede 22");
Pessoa p23 = new Pessoa(nome: "Hóspede 23");
Pessoa p24 = new Pessoa(nome: "Hóspede 24");
Pessoa p25 = new Pessoa(nome: "Hóspede 25");
Pessoa p26 = new Pessoa(nome: "Hóspede 26");
Pessoa p27 = new Pessoa(nome: "Hóspede 27");
Pessoa p28 = new Pessoa(nome: "Hóspede 28");
Pessoa p29 = new Pessoa(nome: "Hóspede 29");
Pessoa p30 = new Pessoa(nome: "Hóspede 30");

hospedes.Add(p1);
hospedes.Add(p2);
hospedes.Add(p3);
hospedes.Add(p4);
hospedes.Add(p5);
hospedes.Add(p6);
hospedes.Add(p7);
hospedes.Add(p8);
hospedes.Add(p9);
hospedes.Add(p10);
hospedes.Add(p11);
hospedes.Add(p12);
hospedes.Add(p13);
hospedes.Add(p14);
hospedes.Add(p15);
hospedes.Add(p16);
hospedes.Add(p17);
hospedes.Add(p18);
hospedes.Add(p19);
hospedes.Add(p20);
hospedes.Add(p21);
hospedes.Add(p22);
hospedes.Add(p23);
hospedes.Add(p24);
hospedes.Add(p25);
hospedes.Add(p26);
hospedes.Add(p27);
hospedes.Add(p28);
hospedes.Add(p29);
hospedes.Add(p30);

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 30, valorDiaria: 150);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 30);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
