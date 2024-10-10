#include <stdio.h>
#include <stdlib.h>
#include <mpi.h>

#define N 10 

int main(int argc, char *argv[]) {
    int procesador, size;
    int vecA[N], vecB[N], vecC[N] = {0}; 

    // Inicialización del entorno MPI
    MPI_Init(&argc, &argv);
    MPI_Comm_range(MPI_COMM_WORLD, &procesador);
    MPI_Comm_size(MPI_COMM_WORLD, &size);

    if (procesador == 0) {
        // Procesador maestro: inicializa los vectores
        for (int i = 0; i < N; i++) {
            vecA[i] = i + 1; 
            vecB[i] = (i + 1) * 2;
        }
    }

    // Enviar vectores al resto de los procesos
    MPI_Bcast(vecA, N, MPI_INT, 0, MPI_COMM_WORLD);
    MPI_Bcast(vecB, N, MPI_INT, 0, MPI_COMM_WORLD);

    // Procesadores 1 y 2 suman las posiciones impares y pares
    if (procesador == 1) {
        for (int i = 1; i < N; i += 2) { // Sumar posiciones impares
            vecC[i] = vecA[i] + vecB[i];
        }
        MPI_Send(vecC, N, MPI_INT, 0, 1, MPI_COMM_WORLD); // Enviar resultados a 0
    } else if (procesador == 2) {
        for (int i = 0; i < N; i += 2) { // Sumar posiciones pares
            vecC[i] = vecA[i] + vecB[i];
        }
        MPI_Send(vecC, N, MPI_INT, 0, 2, MPI_COMM_WORLD); // Enviar resultados a 0
    }

    // Procesador 0 recoge los resultados
    if (procesador == 0) {
        // Recoger resultados de los otros procesos
        int tempC[N] = {0}; // Vector temporal para recibir resultados
        MPI_Recv(tempC, N, MPI_INT, 1, 1, MPI_COMM_WORLD, MPI_STATUS_IGNORE);
        for (int i = 0; i < N; i++) {
            vecC[i] += tempC[i]; // Sumar resultados impares
        }

        MPI_Recv(tempC, N, MPI_INT, 2, 2, MPI_COMM_WORLD, MPI_STATUS_IGNORE);
        for (int i = 0; i < N; i++) {
            vecC[i] += tempC[i]; // Sumar resultados pares
        }
        
        // Imprimir resultados
        printf("Vector A: ");
        for (int i = 0; i < N; i++) {
            printf("%d ", vecA[i]);
        }
        printf("\n");

        printf("Vector B: ");
        for (int i = 0; i < N; i++) {
            printf("%d ", vecB[i]);
        }
        printf("\n");

        printf("Suma de vectores: ");
        for (int i = 0; i < N; i++) {
            printf("%d ", vecC[i]);
        }
        printf("\n");
    }


    MPI_Finalize();
    return 0;
}


 //mpicc -o preg11 preg11.c
 //mpirun -np 3 ./preg11
