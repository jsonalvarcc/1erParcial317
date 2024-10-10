#include <stdio.h>
//formula de Leibniz
void iterativo(double *pi, int *iteraciones) {
    double suma = 0.0;
    int i;
    for (i = 0; i < *iteraciones; i++) {
        double termino = (i % 2 == 0 ? 1.0 : -1.0) / (2.0 * i + 1.0);
        suma += termino;
    }
    *pi = 4.0 * suma;  
}

void recursivo(double *pi, int *iteracion, int *maxIteraciones, double *resultadoParcial) {
    if (*iteracion >= *maxIteraciones) {
        return;
    }
    double termino = (*iteracion % 2 == 0 ? 1.0 : -1.0) / (2.0 * (*iteracion) + 1.0);
    *resultadoParcial += termino;

    (*iteracion)++;
    
    recursivo(pi, iteracion, maxIteraciones, resultadoParcial);

    *pi = 4.0 * (*resultadoParcial);
}

int main() {
    int iteraciones=1000;
    double piIterativo = 0.0, piRecursivo = 0.0;
    double resultadoParcialRecursivo = 0.0;
    int iteracionRecursiva = 0;

    iterativo(&piIterativo, &iteraciones);
    printf("VALOR DE PI FORMA ITERATIVO: %.15f\n", piIterativo);

    recursivo(&piRecursivo, &iteracionRecursiva, &iteraciones, &resultadoParcialRecursivo);
    printf("VALOR DE PI FORMA RECURSIVA: %.15f\n", piRecursivo);

    return 0;
}
