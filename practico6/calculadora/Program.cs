// Granero Javier - Mayo 27

Console.WriteLine("\n\t\t --- CALCULADORA ---");

string? input1, input2, option2;     // string? indica que el dato puede ser una cadena o NULL, a diferencia de 'string' que no puede ser NULL

int option1;

double number1, number2;

do {

    Console.WriteLine("\n > Ingrese una operación simple: ");

    input1 = Console.ReadLine();

    while(string.IsNullOrEmpty(input1)) {

        Console.Write("\n (!) Ingrese la operación (no puede estar vacía): ");
        input1 = Console.ReadLine();

    }

    if()

    switch(option1) {

        case 1:

            Console.WriteLine($"\n >> El resultado de {number1} + {number2} es {(number1 + number2).ToString("N3")}");

        break;

        case 2:

            Console.WriteLine($"\n >> El resultado de {number1} - {number2} es {(number1 - number2).ToString("N3")}");

        break;

        case 3:

            Console.WriteLine($"\n >> El resultado de {number1} * {number2} es {(number1 * number2).ToString("N3")}");

        break;

        case 4:

            Console.WriteLine($"\n >> El resultado de {number1} / {number2} es {(number1 / number2).ToString("N3")}");

        break;

    }

    Console.ReadLine();     // Pausa del sistema, esperando interacción del usuario

    // Mejoras de calculadora (V2)

    Console.Write("\n > Ahora, ingrese un nuevo número: ");
    input1 = Console.ReadLine();

    while (!double.TryParse(input1, out number1)) {
        Console.Write("\n (!) Ha ingresado un caracter inválido. Por favor, ingrese un número: ");
        input1 = Console.ReadLine();
    }

    Console.WriteLine("\n\n ¿Qué operación desea realizar?");
    Console.Write("\n [1] - Valor absoluto \n [2] - Cuadrado \n [3] - Raíz cuadrada \n [4] - Seno \n [5] - Coseno \n [6] - Obtener la parte entera de un número real \n");

    Console.Write("\n\n >> Su elección: ");
    input1 = Console.ReadLine();

    while(!int.TryParse(input1, out option1) || option1 < 1 || option1 > 6) {

        Console.Write("\n\n (!) Ha ingresado una opción inválida.\n > Ingrese nuevamente: ");
        input1 = Console.ReadLine();

    }

    switch(option1) {

        case 1:

            Console.WriteLine($"\n\t >> Valor absoluto de {number1}: " + Math.Abs(number1));

        break;

        case 2:

            Console.WriteLine($"\n\t >> Cuadrado de {number1}: " + (number1 * number1).ToString("N3"));

        break;

        case 3:

            if (number1 >= 0) {
                Console.WriteLine($"\n\t >> Raíz cuadrada {number1}: " + (Math.Sqrt(number1)).ToString("N3"));      // 'number'.ToString("N3") indica que el número se escribe como string con tres decimales
            }
            else {
                Console.WriteLine("\n\t (!) El número ingresado es negativo. No es posible calcular la raíz cuadrada");
            }

        break;

        case 4:

            Console.WriteLine($"\n\t >> Seno({number1}) = " + (Math.Sin(number1)).ToString("N3"));

        break;

        case 5:

            Console.WriteLine($"\n\t >> Coseno({number1}) = " + (Math.Cos(number1)).ToString("N3"));

        break;

        case 6:

            Console.WriteLine($"\n\t >> Parte entera de {number1}: " + Math.Truncate(number1));        // Math.Truncate devuelve la parte entera de un número real sin redondearlo

        break;

    }

    Console.ReadLine();

    Console.WriteLine("\n\n > Ahora, ingrese dos nuevos números");

    Console.Write("\n - Primer número: ");
    
    input1 = Console.ReadLine();

    while(!double.TryParse(input1, out number1)) {

        Console.Write("\n (!) Ha ingresado un caracter inválido\n > Por favor, ingrese un número: ");
        input1 = Console.ReadLine();

    }

    Console.Write("\n - Segundo número: ");
    input2 = Console.ReadLine();

    while(!double.TryParse(input2, out number2)) {

        Console.Write("\n (!) Ha ingresado un caracter inválido. Por favor, ingrese un número: ");
        input2 = Console.ReadLine();

    }

    if(number1 > number2) {
        Console.Write($"\n\n\t >> El número máximo es {number1} y el mínimo es {number2}");
    }
    else {
        if(number1 == number2) {
            Console.Write("\n\n\t >> Los números son iguales, por lo que no hay máximo ni mínimo");
        }
        else {
            Console.Write($"\n\n\t >> El número máximo es {number2} y el mínimo {number1}");
        }
    }

    Console.ReadLine();

    Console.WriteLine("\n\n\n ¿Desea ejecutar nuevamente el programa?");
    Console.Write("\n [Y] - SI \n [N] - NO \n\n >> Su respuesta: ");
    option2 = Console.ReadLine();

    while(option2 != "y" && option2 != "Y" && option2 != "n" && option2 != "N") {

        Console.Write("\n (!) Ha ingresado un caracter inválido\n > Por favor, ingrese nuevamente: ");
        option2 = Console.ReadLine();

    }

} while(option2 == "Y" || option2 == "y");

Console.WriteLine("\n\t\t --- Programa finalizado ---");