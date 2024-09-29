DUPLICACION DE CODIGO
Violación : SonarLint detecta duplicación de código en la creación de productos product1y product2.
Refactorización : Crea un método reutilizable para la creación de productos.

Codigo Anterior:

Product product1 = new Product();
product1.Name = "Laptop";
product1.Price = 1000;
products.Add(product1);

Product product2 = new Product();
product2.Name = "Smartphone";
product2.Price = 500;
products.Add(product2);

Codigo Despues:

void AddProduct(List<Product> products, string name, int price)
{
    Product product = new Product { Name = name, Price = price };
    products.Add(product);
}

AddProduct(products, "Laptop", 1000);
AddProduct(products, "Smartphone", 500);

MAL MAMEJO DE EXCEPCIONES
Violación : El método Convert.ToInt32(Console.ReadLine())puede fallar si el usuario ingresa un valor inválido.
Corrección : Implementa manejo de excepciones para validar la entrada.

Codigo Anterior:
int price = Convert.ToInt32(Console.ReadLine());

Codigo Despues:
int price;
while (!int.TryParse(Console.ReadLine(), out price))
{
    Console.WriteLine("Por favor, ingrese un valor válido.");
}

ENCAPSULAMIENTO DEFICIENTE 
Violación : Los campos públicos Namey Priceen la clase Productrompen el principio de encapsulamiento.
Corrección : Usa propiedades en lugar de campos públicos.

Codigo Anterior:
public string Name;
public int Price;

Codigo Despues:
public string Name { get; set; }
public int Price { get; set; }
