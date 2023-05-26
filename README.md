# Ejercicio 4

###_¿String es una tipo por valor o un tipo por referencia?_

*_String_* es un tipo de dato por *referencia*, lo que implica que cuando se crea una variable _string_, se almacena una referencia a la ubicación de memoria donde se encuentra el valor de la cadena de caracteres.

###_¿Qué secuencias de escape tiene el tipo string?_

Algunas secuencias de escape que tiene el tipo de dato _string_ son las siguientes:

-\': Comilla simple (apóstrofe)
-\": Comilla doble
-\\: Barra invertida
-\0: Carácter nulo
-\a: Alerta (beep)
-\b: Retroceso
-\f: Avance de página
-\n: Nueva línea
-\r: Retorno de carro
-\t: Tabulación horizontal
-\v: Tabulación vertical
-\uXXXX: Representación Unicode de un carácter (donde XXXX es el valor hexadecimal de 4 dígitos)
-\xXX: Representación hexadecimal de un carácter (donde XX es el valor hexadecimal de 2 dígitos)
-\Uxxxxxxxx: Representación de un carácter Unicode especificado por su valor hexadecimal de 8 dígitos 

##¿Qué sucede cuando utiliza el carácter *@* y *$* antes de una cadena de texto?

El carácter *@* antes de una cadena de texto se utiliza para indicar que la cadena es una cadena literal. Al utilizar @ antes de una cadena, las secuencias de escape como \n, \t, etc. ya no tienen un significado especial y se interpretan literalmente como caracteres normales, manteniendo cualquier caracter especial y caracteres de nueva línea sin realizar el escapado.

El carácter *$* antes de una cadena de texto se utiliza para habilitar la interpolación de cadenas. Esto significa que se pueden incluir expresiones dentro de la cadena de texto utilizando la sintaxis *${expresion}*. Las expresiones se evalúan y se insertan en la cadena en el lugar correspondiente.