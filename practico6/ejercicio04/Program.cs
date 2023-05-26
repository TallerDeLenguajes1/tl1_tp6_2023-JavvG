// Granero Javier - Mayo 25

Console.Write("\n > Ingrese una cadena de caracteres: ");
string? input1 = Console.ReadLine();

while(string.IsNullOrEmpty(input1)) {        // IsNullOrEmpty controla si la cadena es o no vacía, retorna un booleano

    Console.Write("\n (!) Ingrese la cadena de caracteres, esta no puede estar vacía: ");
    input1 = Console.ReadLine();

}

Console.Write($"\n >> Esta es la cadena ingresada: \"{input1}\"");
Console.Write($"\n >> La cadena ingresada tiene una longitud de {input1.Length} caracteres");

Console.ReadLine();

Console.Write("\n\n > Ahora, ingrese una segunda cadena de caracteres: ");

string? input2 = Console.ReadLine();

while(string.IsNullOrEmpty(input2)) {

    Console.Write("\n (!) Ingrese la cadena de caracteres, esta no puede estar vacía: ");
    input2 = Console.ReadLine();

}

Console.Write($"\n\ >> Esta es la segunda cadena ingresada: \"{input1}\"");
Console.Write($"\n >> Esta es la concatenación de ambas cadenas ingresadas: \"{input1 + input2}\"");