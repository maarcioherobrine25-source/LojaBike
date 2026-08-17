using LojaBike;

Console.WriteLine("============ Sistema da Loja de Bike's ============");
Console.WriteLine();

//Instanciando Objeto Classe Bike
Bike bike = new Bike();

Console.Write("Modelo Bike: ");
bike.Modelo = Console.ReadLine();

Console.Write("Capacidade da Bateria: ");
bike.Bateria = double.Parse(Console.ReadLine());

Console.Write("Peso do Ciclista: ");
bike.PesoCiclista = double.Parse(Console.ReadLine());

Console.Write("Quantidade Estimada de Recargas por Mês: ");
bike.RecargaMes = int.Parse(Console.ReadLine());

//Exibir na Tela o Resultado
Console.WriteLine("\n------RELATÓRIO DE DESEMPENHO DA BIKE------");
Console.WriteLine($"Bicicleta: {bike.Modelo.ToUpper()}");
Console.WriteLine($"Autonomia Estimada {bike.CalcularAutonomia():F1}km por carga");
Console.WriteLine($"Consumo Mensal: {bike.CalcularConsumoMensal()}KWM");
Console.WriteLine($"Custo Mensal: {bike.CalcularCustoMensal():N2}");
Console.WriteLine($"A Bike é Econômica {bike.ModeloEconomico()}");