/* Vamos a realizar un ejercicio
// Para ellos vamos a realizar los siguientes pasos:
// 1. El cliente ingresa un primer número  x
// 2. EL cliente ingresa un segundo número y
// 3. El programa captura los valores y los almacena en variables
// 4. El programa se encarga de realizar la operación matemática
// 5. El programa se encarga de imprimir el resultado de la operación
*/

Console.WriteLine("INGRESE EL PRIMER NUMERO");
var primerNumeroString = Console.ReadLine();
var primerNumero = int.Parse(primerNumeroString!);

Console.WriteLine("INGRESE EL SEGUNDO NUMERO");
var segundoNumeroString = Console.ReadLine();
var segundoNumero = int.Parse(segundoNumeroString!);

var operacion = primerNumero +  segundoNumero;
Console.WriteLine($"El resultado es : {operacion}");

/* Algoritmo para evaluar si un texto tiene la nomenclatrua de numero
 * si es posible para evaluar un texto a numero
 * 1.Es declarar una variable resultado posible
 * 2.Condicionar si el texto esta realmente escrito en una nomenclatura numerica
 * 3.En caso de que no sea un numero, entonces termina el programa.
 * 4.En caso de que sea un numero, entoces continua el programa.
 */
