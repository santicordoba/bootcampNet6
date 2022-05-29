/*

Generar un programa que cree un cartón de bingo aleatorio y lo muestre por pantalla

1)    Cartón de 3 filas por 9 columnas
2)    El cartón debe tener 15 números y 12 espacios en blanco
3)    Cada fila debe tener 5 números
4)    Cada columna debe tener 1 o 2 números
5)    Ningún número puede repetirse
6)    La primer columna contiene los números del 1 al 9, la segunda del 10 al 19, la tercera del 20 al 29, así sucesivamente hasta la última columna la cual contiene del 80 al 90
7)    Mostrar el carton por pantalla

*/

int[,] carton = new int[3, 9];

int lengthFilas = carton.GetUpperBound(0) + 1;
int lengthColumnas = carton.GetUpperBound(1) + 1;

Random rand = new Random();;
/**
 * 
  *   Arreglo para poder contar 
  *   cuantas numeros 
  *   hay en cada Columna
  *   
**/
int[] cantNumerosCol = new int[9];

/**
 * 
 * Arreglo donde guardo los numeros 
 * que contiene el carton, de modo
 * tal de evitar numeros repetidos
 * 
 **/

int[] numerosEnCarton = new int[15];

/**
 * 
 * cantidad de numeros guardados
 * 
 * */
int cantGuardados = 0;


/**
 * 
 * Uso dos for para generar los numeros
 * en orden primero los de la fila 0, 
 * luego la 1, la ultima fila la generare por separado.
 * 
 **/

for (int i = 0; i < 2; i++)
{
    int fila = i;
    for (int j = 0; j < 5; j++)
    {
        /**
         * 
         * Genero una columna aleatoria
         * 
         * */
        int randCol = rand.Next(9);

        /**
         * 
         * Si en una posicion ya he guardado 
         * un numero no debo sobreescribirlo o
         * si en esa columna hay 2 numeros o más, 
         * en cualquiera de los dos casos genero
         * una nueva columna
         * 
         * */
        while (carton[fila, randCol] != 0 || cantNumerosCol[randCol] >= 2)
        {
            randCol = rand.Next(9);
        }

        int numeroRandom = 0;

        /**
         * 
         * Switch para generar numeros dependiendo
         * la columna a guardar.
         * 
         * */
        switch (randCol)
        {
            case 0:
                numeroRandom = rand.Next(0, 9);
                /**
                 * 
                 * No debe repetirse el numero 
                 * por lo tanto si ocurre genero
                 * un nuevo numero
                 * 
                 * */
                while (numerosEnCarton.Contains(numeroRandom))
                {
                    numeroRandom = rand.Next(0, 9);
                }
                break;
            case 1:
                numeroRandom = rand.Next(10, 19);
                while (numerosEnCarton.Contains(numeroRandom))
                {
                    numeroRandom = rand.Next(10, 19);
                }
                break;
            case 2:
                numeroRandom = rand.Next(20, 29);
                while (numerosEnCarton.Contains(numeroRandom))
                {
                    numeroRandom = rand.Next(20, 29);
                }
                break;
            case 3:
                numeroRandom = rand.Next(30, 39);
                while (numerosEnCarton.Contains(numeroRandom))
                {
                    numeroRandom = rand.Next(30, 39);
                }
                break;
            case 4:
                numeroRandom = rand.Next(40, 49);
                while (numerosEnCarton.Contains(numeroRandom))
                {
                    numeroRandom = rand.Next(40, 49);
                }
                break;
            case 5:
                numeroRandom = rand.Next(50, 59);
                while (numerosEnCarton.Contains(numeroRandom))
                {
                    numeroRandom = rand.Next(50, 59);
                }
                break;
            case 6:
                numeroRandom = rand.Next(60, 69);
                while (numerosEnCarton.Contains(numeroRandom))
                {
                    numeroRandom = rand.Next(60, 69);
                }
                break;
            case 7:
                numeroRandom = rand.Next(70, 79);
                while (numerosEnCarton.Contains(numeroRandom))
                {
                    numeroRandom = rand.Next(70, 79);
                }
                break;
            case 8:
                numeroRandom = rand.Next(80, 90);
                while (numerosEnCarton.Contains(numeroRandom))
                {
                    numeroRandom = rand.Next(80, 90);
                }
                break;

        }

        /**
         * 
         * Ya tengo la columna que cumple la condicion
         * y genere el numero correspondiente para esa
         * columna y no se repite, entonces lo
         * guardo el en el carton
         * 
         * */
        carton[fila, randCol] = numeroRandom;

        /**
         * 
         * guardo el numero en el array de numeros 
         * para luego poder comparar si existe o no
         * en el carton y sumo un nuevo numero guardado
         * 
         * */
        numerosEnCarton[cantGuardados] = numeroRandom;
        cantGuardados++;

        /**
         * 
         * Contamos un nuevo numero en la columna 
         * de modo de tener control de que no haya
         * mas de 2 por cada columna
         * 
         **/
        cantNumerosCol[randCol]++;
    }

}


/**
 * 
 * La ultima fila requiere un control especial
 * primero agregare numeros solo donde no haya
 * ninguno y luego agregare donde haya uno solo
 * 
 **/


int cantNumerosUltimaFila = 0;
int indice = 0;

while (indice < 9 && cantNumerosUltimaFila <= 5)
{
    if(cantNumerosCol[indice] == 0)
    {
        /**
         * 
         * Switch para generar numeros dependiendo
         * la columna a guardar.
         * 
         * */

        int numeroRandom = 0;

        switch (indice)
        {
            case 0:
                numeroRandom = rand.Next(0, 9);
                /**
                 * 
                 * No debe repetirse el numero 
                 * por lo tanto si ocurre genero
                 * un nuevo numero
                 * 
                 * */
                while (numerosEnCarton.Contains(numeroRandom))
                {
                    numeroRandom = rand.Next(0, 9);
                }
                break;
            case 1:
                numeroRandom = rand.Next(10, 19);
                while (numerosEnCarton.Contains(numeroRandom))
                {
                    numeroRandom = rand.Next(10, 19);
                }
                break;
            case 2:
                numeroRandom = rand.Next(20, 29);
                while (numerosEnCarton.Contains(numeroRandom))
                {
                    numeroRandom = rand.Next(20, 29);
                }
                break;
            case 3:
                numeroRandom = rand.Next(30, 39);
                while (numerosEnCarton.Contains(numeroRandom))
                {
                    numeroRandom = rand.Next(30, 39);
                }
                break;
            case 4:
                numeroRandom = rand.Next(40, 49);
                while (numerosEnCarton.Contains(numeroRandom))
                {
                    numeroRandom = rand.Next(40, 49);
                }
                break;
            case 5:
                numeroRandom = rand.Next(50, 59);
                while (numerosEnCarton.Contains(numeroRandom))
                {
                    numeroRandom = rand.Next(50, 59);
                }
                break;
            case 6:
                numeroRandom = rand.Next(60, 69);
                while (numerosEnCarton.Contains(numeroRandom))
                {
                    numeroRandom = rand.Next(60, 69);
                }
                break;
            case 7:
                numeroRandom = rand.Next(70, 79);
                while (numerosEnCarton.Contains(numeroRandom))
                {
                    numeroRandom = rand.Next(70, 79);
                }
                break;
            case 8:
                numeroRandom = rand.Next(80, 90);
                while (numerosEnCarton.Contains(numeroRandom))
                {
                    numeroRandom = rand.Next(80, 90);
                }
                break;

        }

        /**
         * 
         * Ya tengo la columna que cumple la condicion
         * y genere el numero correspondiente para esa
         * columna y no se repite, entonces lo
         * guardo el en el carton
         * 
         * */
        carton[2, indice] = numeroRandom;

        /**
         * 
         * guardo el numero en el array de numeros 
         * para luego poder comparar si existe o no
         * en el carton y sumo un nuevo numero guardado
         * 
         * */
        numerosEnCarton[cantGuardados] = numeroRandom;
        cantGuardados++;

        /**
         * 
         * Contamos un nuevo numero en la columna 
         * de modo de tener control de que no haya
         * mas de 2 por cada columna
         * 
         **/
        cantNumerosCol[indice]++;

        cantNumerosUltimaFila++;
        

    }
    indice++;
}

for(int pos = cantNumerosUltimaFila; pos < 5; pos++)
{
    /**
     * 
     * Genero una columna aleatoria
     * 
     * */
    int randCol = rand.Next(9);

    /**
     * 
     * Si en una posicion ya he guardado 
     * un numero no debo sobreescribirlo o
     * si en esa columna hay 2 numeros o más, 
     * en cualquiera de los dos casos genero
     * una nueva columna
     * 
     * */
    while (carton[2, randCol] != 0 || cantNumerosCol[randCol] >= 2)
    {
        randCol = rand.Next(9);
    }

    int numeroRandom = 0;

    /**
     * 
     * Switch para generar numeros dependiendo
     * la columna a guardar.
     * 
     * */
    switch (randCol)
    {
        case 0:
            numeroRandom = rand.Next(0, 9);
            /**
             * 
             * No debe repetirse el numero 
             * por lo tanto si ocurre genero
             * un nuevo numero
             * 
             * */
            while (numerosEnCarton.Contains(numeroRandom))
            {
                numeroRandom = rand.Next(0, 9);
            }
            break;
        case 1:
            numeroRandom = rand.Next(10, 19);
            while (numerosEnCarton.Contains(numeroRandom))
            {
                numeroRandom = rand.Next(10, 19);
            }
            break;
        case 2:
            numeroRandom = rand.Next(20, 29);
            while (numerosEnCarton.Contains(numeroRandom))
            {
                numeroRandom = rand.Next(20, 29);
            }
            break;
        case 3:
            numeroRandom = rand.Next(30, 39);
            while (numerosEnCarton.Contains(numeroRandom))
            {
                numeroRandom = rand.Next(30, 39);
            }
            break;
        case 4:
            numeroRandom = rand.Next(40, 49);
            while (numerosEnCarton.Contains(numeroRandom))
            {
                numeroRandom = rand.Next(40, 49);
            }
            break;
        case 5:
            numeroRandom = rand.Next(50, 59);
            while (numerosEnCarton.Contains(numeroRandom))
            {
                numeroRandom = rand.Next(50, 59);
            }
            break;
        case 6:
            numeroRandom = rand.Next(60, 69);
            while (numerosEnCarton.Contains(numeroRandom))
            {
                numeroRandom = rand.Next(60, 69);
            }
            break;
        case 7:
            numeroRandom = rand.Next(70, 79);
            while (numerosEnCarton.Contains(numeroRandom))
            {
                numeroRandom = rand.Next(70, 79);
            }
            break;
        case 8:
            numeroRandom = rand.Next(80, 90);
            while (numerosEnCarton.Contains(numeroRandom))
            {
                numeroRandom = rand.Next(80, 90);
            }
            break;

    }

    /**
     * 
     * Ya tengo la columna que cumple la condicion
     * y genere el numero correspondiente para esa
     * columna y no se repite, entonces lo
     * guardo el en el carton
     * 
     * */
    carton[2, randCol] = numeroRandom;

    /**
     * 
     * guardo el numero en el array de numeros 
     * para luego poder comparar si existe o no
     * en el carton y sumo un nuevo numero guardado
     * 
     * */
    numerosEnCarton[cantGuardados] = numeroRandom;
    cantGuardados++;

    /**
     * 
     * Contamos un nuevo numero en la columna 
     * de modo de tener control de que no haya
     * mas de 2 por cada columna
     * 
     **/
    cantNumerosCol[randCol]++;
}


/**
 * 
 * Recorrido de la matriz y
 * generacion del carton graficamente
 * 
 * */

Console.WriteLine("------------------------------------------------------------------------");
for (int i = 0; i < lengthFilas; i++)
{
    for (int j = 0; j < lengthColumnas; j++)
    {
        int num = carton[i, j];
        if(num > 0 && num < 10)
        {
            Console.Write($"|  0{num}  |");
        } else if (num == 0)
        {
            Console.Write($"|  ▬▬  |");
        }
        else
        {
            Console.Write($"|  {num}  |");
        }
    }
    Console.WriteLine("");
}
Console.WriteLine("------------------------------------------------------------------------");