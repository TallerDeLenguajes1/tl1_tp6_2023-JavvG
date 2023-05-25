// Granero Javier - Mayo 27

Console.WriteLine("\n\t\t --- CALCULADORA ---");

string? input1, input2, input3, option2;     // string? indica que el dato puede ser una cadena o NULL, a diferencia de 'string' que no puede ser NULL

int option1;

double number1, number2, result = 0;

do {

    Console.WriteLine("\n > Ingrese dos números: ");

    Console.Write("\n - Primer número: ");
    input1 = Console.ReadLine();

    while(!double.TryParse(input1, out number1)) {

        Console.Write("\n (!) Ha ingresado un caracter inválido.\n > Por favor, ingrese un número: ");
        input1 = Console.ReadLine();

    }

    Console.Write("\n - Segundo número: ");
    input2 = Console.ReadLine();

    while(!double.TryParse(input2, out number2)) {

        Console.Write("\n (!) Ha ingresado un caracter inválido.\n > Por favor, ingrese un número: ");
        input2 = Console.ReadLine();

    }

    Console.WriteLine("\n\n ¿Qué operación desea realizar?");
    Console.Write("\n [1] - Suma \n [2] - Resta \n [3] - Multiplicación \n [4] - División \n");

    Console.Write("\n\n >> Su elección: ");
    input3 = Console.ReadLine();

    while(!int.TryParse(input3, out option1) || option1 < 1 || option1 > 4) {

        Console.Write("\n\n (!) Ha ingresado una opción inválida.\n > Ingrese nuevamente: ");
        input3 = Console.ReadLine();

    }

    switch(option1) {

        case 1:

            result = number1 + number2;

        break;

        case 2:

            result = number1 - number2;

        break;

        case 3:

            result = number1 * number2;

        break;

        case 4:

            result = number1 / number2;

        break;

    }

    Console.WriteLine("\n >> El resultado es " + result.ToString("N3"));

    Console.WriteLine("\n ¿Desea realizar otra operación?");
    Console.Write("\n [Y] - SI \n [N] - NO \n\n >> Su respuesta: ");
    option2 = Console.ReadLine();

    while(option2 != "y" && option2 != "Y" && option2 != "n" && option2 != "N") {

        Console.Write("\n (!) Ha ingresado un caracter inválido\n > Por favor, ingrese nuevamente: ");
        option2 = Console.ReadLine();

    }

} while(option2 == "Y" || option2 == "y");

Console.WriteLine("\n\t\t --- Programa finalizado ---");