Console.Write(" > Ingrese un número: ");
string? input = Console.ReadLine();

if(int.TryParse(input, out int number)) {       // Se verifica si el caracter ingresado puede ser convertido a un número entero, en caso afirmativo se sigue adelante con la inversión, caso contrario se muestra un mensaje de error

    if(number > 0) {

        if(number < 10) {
            Console.Write(" >> Número invertido:  " + number);
        }
        else {

            int reversedNumber = 0, digit = 0;

            while(number != 0) {

                digit = number % 10;
                number = number / 10;       // También puede escribirse 'number /= 10'
                reversedNumber = reversedNumber * 10 + digit;

            }

            Console.Write(" >> Número invertido: " + reversedNumber);

        }

    }
    else {
        Console.WriteLine(" (!) El número debe ser positivo");
    }

}
else {
    Console.WriteLine(" (!) Ingresó un caracter no válido");
}