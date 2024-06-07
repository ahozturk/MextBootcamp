using SwitchExamples;

#region If vs. Switch

// int temprature = 20;

// if (temprature < -10)
//     Console.WriteLine("İnanılmaz soğuk bir hava var");
// else if (temprature < 0)
//     Console.WriteLine("Çok soğuk bir hava var");
// else if (temprature < 10)
//     Console.WriteLine("Soğuk bir hava var");
// else if (temprature < 20)
//     Console.WriteLine("Ilık bir hava var");
// else if (temprature < 30)
//     Console.WriteLine("Sıcak bir hava var");
// else
//     Console.WriteLine("Çok sıcak bir hava var");

// Console.Write("Please enter you name: ");
// string name1 = Console.ReadLine();

// switch (name1)
// {
//     case "Hakan":
//         Console.WriteLine("Geçiş izni verildi");
//         break;

//     case "Ahmet":
//         Console.WriteLine("Kısmi izin verildi");
//         break;

//     default:
//         Console.WriteLine("Geçiş izni verilmedi");
//         break;
// }

#endregion

#region Switch Case Example

// Product product = new()
// {
//     Name = "Laptop",
//     Price = 5000,
//     State = ProductState.Discontinued
// };

// switch (product.State)
// {
//     case ProductState.InStock:
//         Console.WriteLine("Ürün stokta");
//         break;

//     case ProductState.OutOfStock:
//         Console.WriteLine("Ürün stokta değil");
//         break;

//     case ProductState.Discontinued:
//         Console.WriteLine("Ürün satıştan kaldırıldı");
//         break;
// }

#endregion

#region If in loop example

// List<int> temperatures = new() { -5, 0, 10, 15, 25, 35 };

// foreach (var temprature in temperatures)
// {
//     if (temprature < -10)
//         Console.WriteLine("İnanılmaz soğuk bir hava var");
//     else if (temprature < 0)
//         Console.WriteLine("Çok soğuk bir hava var");
//     else if (temprature < 10)
//         Console.WriteLine("Soğuk bir hava var");
//     else if (temprature < 20)
//         Console.WriteLine("Ilık bir hava var");
//     else if (temprature < 30)
//         Console.WriteLine("Sıcak bir hava var");
//     else
//         Console.WriteLine("Çok sıcak bir hava var");
// }

#endregion

#region Switch in loop example

List<Product> products = new()
{
    new Product { Name = "Laptop", Price = 5000, State = ProductState.InStock },
    new Product { Name = "Mouse", Price = 50, State = ProductState.OutOfStock },
    new Product { Name = "Keyboard", Price = 100, State = ProductState.Discontinued },
};

foreach (var product in products)
{
    if (product.State == ProductState.InStock)
        Console.WriteLine($"{product.Name} ürünü stokta");
    else if (product.State == ProductState.OutOfStock)
        Console.WriteLine($"{product.Name} ürünü stokta yok");
}

#endregion