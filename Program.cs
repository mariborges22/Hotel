using Hotel.Models;

List<Pessoa> hospedes= new List<Pessoa>();



Pessoa hospede1= new Pessoa(nome:"Mariana", sobrenome:"Borges");
Pessoa hospede2= new Pessoa(nome:"Amanda", sobrenome:"Miami");

hospedes.Add(hospede1);
hospedes.Add(hospede2);

Suite suite= new Suite(tiposuite:"duplo", capacidade:2, valordiaria:120);

Reserva reserva= new Reserva(diasreservados:7, suite);
reserva.CadastrarSuites(suite);
reserva.CadastrarHospedes(hospedes);
  int QuantidadedeHospedes=reserva.QuantidadedeHospedes();
  Console.WriteLine($" Hóspedes: {QuantidadedeHospedes}");
  Console.WriteLine($"Valor estadia: {reserva.CalcularPrecoTotal}");
  




