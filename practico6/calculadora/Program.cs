// Granero Javier - Mayo 27

Console.WriteLine("\n\t\t --- CALCULADORA ---");

string? input1, option2;     // string? indica que el dato puede ser una cadena o NULL, a diferencia de 'string' que no puede ser NULL

double number1 = 0, number2 = 0;

do {

    Console.Write("\n > Ingrese una operación simple (ejemplo \"12 - 10\"): ");

    input1 = Console.ReadLine();

    while(string.IsNullOrEmpty(input1)) {

        Console.Write("\n (!) Ingrese la operación (no puede estar vacía, ejemplo \"12 + 10\"): ");
        input1 = Console.ReadLine();

    }

    int option1 = 0;

    string[] operators;

    if(input1.IndexOf('+') != -1) {

        option1 = 1;

        operators = input1.Split('+', StringSplitOptions.RemoveEmptyEntries);

        double.TryParse(operators[0], out number1);
        double.TryParse(operators[1], out number2);

    }
    else {
        if(input1.IndexOf('-') != -1) {
            
            option1 = 2;

            operators = input1.Split('-', StringSplitOptions.RemoveEmptyEntries);

            double.TryParse(operators[0], out number1);
            double.TryParse(operators[1], out number2);

        }
        else {
            if(input1.IndexOf('*') != -1) {
                
                option1 = 3;

                operators = input1.Split('*', StringSplitOptions.RemoveEmptyEntries);

                double.TryParse(operators[0], out number1);
                double.TryParse(operators[1], out number2);

            }
            else {
                if(input1.IndexOf("/") != -1) {
                    
                    option1 = 4;

                    operators = input1.Split('/', StringSplitOptions.RemoveEmptyEntries);

                    double.TryParse(operators[0], out number1);
                    double.TryParse(operators[1], out number2);

                }
            }
        }
    }

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

    Console.ReadLine();

    Console.WriteLine("\n ¿Desea ejecutar nuevamente el programa?");
    Console.Write("\n [Y] - SI \n [N] - NO \n\n >> Su respuesta: ");
    option2 = Console.ReadLine();

    while(option2 != "y" && option2 != "Y" && option2 != "n" && option2 != "N") {

        Console.Write("\n (!) Ha ingresado un caracter inválido\n > Por favor, ingrese nuevamente: ");
        option2 = Console.ReadLine();

    }

} while(option2 == "Y" || option2 == "y");

Console.WriteLine("\n\t\t --- Programa finalizado ---");