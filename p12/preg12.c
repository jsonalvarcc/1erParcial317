#include <stdio.h>
#include <omp.h>

int main() {
    int n = 13; 
     int  fib[n]; 

    fib[0] = 0;
    fib[1] = 1;
int i;

    #pragma omp parallel shared(fib, n) private(i)
    {    
        #pragma omp for
        for (int i = 2; i < n; i++) {
            fib[i] = fib[i - 1] + fib[i - 2];
        }
    }

    printf("Serie Fibonacci hasta %d:\n", n);
    for (int i = 0; i < n; i++) {
        printf("%d ", fib[i]);
    }
    printf("\n");

    return 0;
    }
//gcc -fopenmp -o preg12 preg12.c
//./preg12