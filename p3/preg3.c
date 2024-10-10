#include <stdio.h>

// func para la suma con punteros
float suma(float *a, float *b) {
    return *a + *b;
}
// func para la resta con punteros
float resta(float *a, float *b) {
    return *a - *b;
}
// func para la multiplicacion con punteros
float multiplicacion(float *a, float *b) {
    return *a * *b;
}
// func para la division con punteros
float division(float *a, float *b) {
    if (*b == 0) {
        puts("No se puede realizar la división con el divisor igual a 0.");
        return 0;
    }
    return *a / *b;
}

int main() {
    float num1 = 60, num2 = 20, res;
    float *ptr_num1 = &num1;
    float *ptr_num2 = &num2;

    printf("num1 = %.2f, num2 = %.2f\n", *ptr_num1, *ptr_num2);

    puts("Suma:");
    printf("%.2f\n", suma(ptr_num1, ptr_num2));

    puts("Resta:");
    printf("%.2f\n", resta(ptr_num1, ptr_num2));

    puts("Multiplicacion:");
    printf("%.2f\n", multiplicacion(ptr_num1, ptr_num2));

    puts("Division:");
    printf("%.2f\n", division(ptr_num1, ptr_num2));

    return 0;
}
