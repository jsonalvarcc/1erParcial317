#include <stdio.h>
#include <stdlib.h>
#include <mpi.h>

#define MAX 10  // tamanio máximo de la matriz

// Función para imprimir una matriz
void imprimirmatriz(int matriz[MAX][MAX], int filas, int columnas) {
    for (int i = 0; i < filas; i++) {
        for (int j = 0; j < columnas; j++) {
            printf("%d ", matriz[i][j]);
        }
        printf("\n");
    }
}

// Función para multiplicar matrices
void multiplicarMatrices(int A[MAX][MAX], int B[MAX][MAX], int C[MAX][MAX], int filasA, int columnasA, int columnasB) {
    for (int i = 0; i < filasA; i++) {
        for (int j = 0; j < columnasB; j++) {
            C[i][j] = 0; // Inicializa la posición en la matriz C a 0
            for (int k = 0; k < columnasA; k++) {
                C[i][j] += A[i][k] * B[k][j]; // Suma el producto de A y B
            }
        }
    }
}

int main(int argc, char **argv) {
    int rango, tamanio;
    int A[MAX][MAX], B[MAX][MAX], C[MAX][MAX] = {0}; // Inicializa C en 0
    int filasA, columnasA, columnasB;

    MPI_Init(&argc, &argv); // Inicializa el entorno de MPI
    MPI_Comm_rank(MPI_COMM_WORLD, &rango); // Obtiene el rango del proceso
    MPI_Comm_size(MPI_COMM_WORLD, &tamanio); // Obtiene el numero total de procesos

    if (rango == 0) {
        // Inicialización de las matrices A y B en el proceso maestro
        filasA = 3;  // Numero de filas en A
        columnasA = 3;  // Numero de columnas en A y filas en B
        columnasB = 3;  // Numero de columnas en B

        // Inicializar matriz A
        int valor = 1;
        for (int i = 0; i < filasA; i++) {
            for (int j = 0; j < columnasA; j++) {
                A[i][j] = valor++;
            }
        }

        // Inicializar matriz B
        valor = 1;
        for (int i = 0; i < columnasA; i++) {
            for (int j = 0; j < columnasB; j++) {
                B[i][j] = valor++;
            }
        }

        // Mostrar matrices A y B
        printf("matriz A:\n");
        imprimirmatriz(A, filasA, columnasA);
        printf("matriz B:\n");
        imprimirmatriz(B, columnasA, columnasB);
    }

    // Enviar dimensiones de las matrices a todos los procesos
    MPI_Bcast(&filasA, 1, MPI_INT, 0, MPI_COMM_WORLD);
    MPI_Bcast(&columnasA, 1, MPI_INT, 0, MPI_COMM_WORLD);
    MPI_Bcast(&columnasB, 1, MPI_INT, 0, MPI_COMM_WORLD);

    // Enviar las matrices A y B a todos los procesos
    MPI_Bcast(A, MAX * MAX, MPI_INT, 0, MPI_COMM_WORLD);
    MPI_Bcast(B, MAX * MAX, MPI_INT, 0, MPI_COMM_WORLD);

    // Cada proceso calcula su parte de la matriz C
    int filasPorProceso = filasA / tamanio; // Filas asignadas a cada proceso
    int filasRestantes = filasA % tamanio; // Filas restantes que no se dividen

    // Cada proceso calcula las filas que le corresponden
    int inicioFila = rango * filasPorProceso; // Fila de inicio para este proceso
    int finFila = inicioFila + filasPorProceso; // Fila final para este proceso

    // Asegurate de que no excedamos el limite de filasA
    if (rango == tamanio - 1) {
        finFila += filasRestantes; // El ultimo proceso toma las filas restantes
    }

    for (int i = inicioFila; i < finFila; i++) {
        for (int j = 0; j < columnasB; j++) {
            C[i][j] = 0; // Inicializa la posición en la matriz C a 0
            for (int k = 0; k < columnasA; k++) {
                C[i][j] += A[i][k] * B[k][j]; // Suma el producto de A y B
            }
        }
    }

    // Cada proceso envia su resultado al proceso maestro
    if (rango != 0) {
        MPI_Send(&C[inicioFila], (finFila - inicioFila) * columnasB, MPI_INT, 0, 0, MPI_COMM_WORLD); // Envia la parte de C al proceso maestro
    } else {
        // Recibir las matrices de los otros procesos
        for (int proc = 1; proc < tamanio; proc++) {
            int inicio = proc * filasPorProceso;
            int filasARecibir = (proc == tamanio - 1) ? (filasPorProceso + filasRestantes) : filasPorProceso;
            MPI_Recv(&C[inicio], filasARecibir * columnasB, MPI_INT, proc, 0, MPI_COMM_WORLD, MPI_STATUS_IGNORE); // Recibe la matriz C de los procesos
        }

        // Mostrar la matriz C resultante
        printf("\nmatriz C:\n");
        imprimirmatriz(C, filasA, columnasB);
    }

    MPI_Finalize(); 
    return 0;
}
//mpicc -o preg14 preg14.c
//mpirun -np 3 ./preg14
