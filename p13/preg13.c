#include <mpi.h>
#include <stdio.h>
#include <string.h>

#define TAMANIO 10  

int main(int argc, char *argv[]) {
    int procesador, num_procesadores; 
    char vector[TAMANIO][20];           //cadenas

    // Inicializar MPI
    MPI_Init(&argc, &argv);
    MPI_Comm_rank(MPI_COMM_WORLD, &procesador);
    MPI_Comm_size(MPI_COMM_WORLD, &num_procesadores); 

    if (procesador == 0) {
        // Proceso 0: Inicializa el vector
        for (int i = 0; i < TAMANIO; i++) {
            sprintf(vector[i], "Cadena %d", i);  // Crea cadenas "Cadena 0", "Cadena 1", ...
        }

        // Envia las cadenas a los procesos 1 y 2
        for (int i = 1; i < num_procesadores; i++) {
            MPI_Send(vector, TAMANIO * sizeof(vector[0]), MPI_BYTE, i, 0, MPI_COMM_WORLD);
        }
    } else {
        // Procesos 1 y 2: Reciben el vector
        MPI_Recv(vector, TAMANIO * sizeof(vector[0]), MPI_BYTE, 0, 0, MPI_COMM_WORLD, MPI_STATUS_IGNORE);
    }

    // Cada proceso despliega su parte
    if (procesador == 1) {
        printf("Proceso 1 (Posiciones pares):\n");
        for (int i = 0; i < TAMANIO; i += 2) {
            printf("%s\n", vector[i]);
        }
    } else if (procesador == 2) {
        printf("Proceso 2 (Posiciones impares):\n");
        for (int i = 1; i < TAMANIO; i += 2) {
            printf("%s\n", vector[i]);
        }
    }


    MPI_Finalize();
    return 0;
}

//mpicc -o preg13 preg13.c
//mpirun -np 3 ./preg13
