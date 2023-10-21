// See https://aka.ms/new-console-template for more information


Console.WriteLine("Hello, World!");

var frutas = new string[] {
    "Sandia", "Fresa", "Mango", "Mango de azúcar", "Mango Tomy"
};

var MangoList = frutas.Where(item => item.StartsWith("Mango")).ToList();
MangoList.ForEach(item => Console.WriteLine(item));

Console.WriteLine(MangoList);



