// Granero Javier - Mayo 25

Console.WriteLine("\t\t\t --- Manipulación de Strings --- \n");

Console.Write("\n > Ingrese una cadena de caracteres: ");
string? input1 = Console.ReadLine();

while(string.IsNullOrEmpty(input1)) {        // IsNullOrEmpty controla si la cadena es o no vacía, retorna un booleano

    Console.Write("\n (!) Ingrese una cadena de caracteres, esta no puede estar vacía: ");
    input1 = Console.ReadLine();

}

Console.Write($"\n >> Esta es la cadena ingresada: \"{input1}\"");
Console.Write($"\n >> La cadena ingresada tiene una longitud de {input1.Length} caracteres");

Console.ReadLine();

Console.Write("\n\n > Ahora, ingrese una segunda cadena de caracteres: ");

string? input2 = Console.ReadLine();

while(string.IsNullOrEmpty(input2)) {

    Console.Write("\n (!) Ingrese una cadena de caracteres, esta no puede estar vacía: ");
    input2 = Console.ReadLine();

}

Console.Write($"\n >> Esta es la segunda cadena ingresada: \"{input2}\"");
Console.Write($"\n\n >> Esta es la concatenación de ambas cadenas ingresadas: \"{input1 + input2}\"");

Console.ReadLine();

string? sub_string = input2.Substring((input2.Length / 2));     // string subcadena = texto.Substring(indiceInicio, longitud); 'indiceInicio' es el índice del primer carácter de la subcadena. 'longitud' (opcional) es la cantidad de caracteres que deseas incluir en la subcadena. Si no se especifica, la subcadena se extenderá hasta el final de la cadena original.

Console.Write($"\n >> Esta es la subcadena obtenida a partir de la segunda cadena ingresada anteriormente: \"{sub_string}\"");

Console.ReadLine();

Console.Write("\n > Ingrese una nueva cadena de caracteres: ");
input1 = Console.ReadLine();

while(string.IsNullOrEmpty(input1)) {

    Console.Write("\n (!) Ingrese una cadena de caracteres, esta no puede estar vacía: ");
    input1 = Console.ReadLine();

}

Console.WriteLine("\n >> Se muestra la cadena ingresada caracter por caracter: \n\n");

foreach(char c in input1) {    // En cada iteración, la variable 'c' tomará el valor del siguiente caracter de la cadena 'input1'

    Console.WriteLine("\t\t\t" + c);

}

Console.ReadLine();

Console.Write("\n > Ingrese una nueva cadena de caracteres: ");
input1 = Console.ReadLine();

while(string.IsNullOrEmpty(input1)) {

    Console.Write("\n (!) Ingrese una cadena de caracteres, esta no puede estar vacía: ");
    input1 = Console.ReadLine();

}

Console.Write("\n > Ingrese la palabra que desea buscar en la cadena de caracteres ingresada: ");
input2 = Console.ReadLine();

while(string.IsNullOrEmpty(input2)) {

    Console.Write("\n (!) Ingrese una palabra (no puede estar vacía): ");
    input2 = Console.ReadLine();

}

int index = input1.IndexOf(input2, StringComparison.OrdinalIgnoreCase);     // Esto devuelve el índice (index) de la primera ocurrencia de la subcadena buscada (input2) en la cadena principal (input1). El parámetro 'StringComparison.OrdinalIgnoreCase' se usa para realziar la búsqueda sin distinción de mayúsculas y minúsculas

if(index != -1) {       // Si la ocurrencia se encuentra, 'IndexOf()' devuelve la posición (índice) de la ocurrencia, caso contrario retorna '-1'
    Console.Write($"\n >> La palabra \"{input2}\" se encuentra en la cadena en la posición {index}.");
}
else {
    Console.Write($"\n >> La palabra \"{input2}\" no se encuentra en la cadena ingresada.");
}

Console.ReadLine();

Console.Write("\n > Ingrese una nueva cadena de caracteres: ");
input1 = Console.ReadLine();

while(string.IsNullOrEmpty(input1)) {

    Console.Write("\n (!) Ingrese una cadena de caracteres, esta no puede estar vacía: ");
    input1 = Console.ReadLine();

}

Console.Write($"\n >> Esta es la cadena modificada (caracteres a mayúsculas): \"{input1.ToUpper()}\"");
Console.Write($"\n >> Esta es la cadena modificada (caracteres a minúsculas): \"{input1.ToLower()}\"");

Console.ReadLine();

Console.Write("\n > Ingrese una nueva cadena de caracteres (el caracter de separación considerado será ';'): ");
input1 = Console.ReadLine();

while(string.IsNullOrEmpty(input1)) {

    Console.Write("\n (!) Ingrese una cadena de caracteres, esta no puede estar vacía: ");
    input1 = Console.ReadLine();

}

string[] sub_Strings = input1.Split(';', StringSplitOptions.RemoveEmptyEntries);       // 'Split()' separará la cadena 'input1' donde encuentre un ';', y retorna un arreglo de strings. 'StringSplitOptions.RemoveEmptyEntries' quita los espacios en blanco de las cadenas resultantes

Console.WriteLine("\n\n >> Estas son las separaciones de la cadena ingresada: \n");

foreach(string sub_String in sub_Strings) {     // Para cada string 'sub_String' del arreglo 'sub_Strings'

    Console.WriteLine(sub_String);      

}

Console.ReadLine();