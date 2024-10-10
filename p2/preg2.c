#include <stdio.h>

// func para la suma
float suma(float a, float b) {
    return a + b;
}
// func para la resta
float resta(float a, float b) {
    return a - b;
}
// func para la multiplicacion
float multiplicacion(float a, float b) {
    return a * b;
}
// func para la division
float division(float a, float b) {
    if(a == 0 || b==0){puts("no se puede realizar la division con un numero 0");
    return 0;
    }
    return (float)a / b;
}
int main() {
    float num1=60, num2=20,res;
    printf("num1 = %.2f, num2 = %.2f\n", num1, num2);
    puts("Suma:");
    printf("%.2f\n",suma(num1,num2));
    puts("Resta:");
    printf("%.2f\n",resta(num1,num2));
    puts("Multiplicacion:");
    printf("%.2f\n",multiplicacion(num1,num2));
    puts("Division:");
    printf("%.2f\n",division(num1,num2));

    return 0;
}

