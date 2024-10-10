using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class EvaluarPostfijo
    {
             // metodo para evaluar la expre en notacion postfija
        public  double evaluar(string postfijo)
        {
            Stack<double> pila = new Stack<double>();
            string[] datos = postfijo.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string dato in datos)
            {
                // Usar TryParse para verificar si el dato es un nume
                double num;
                if (double.TryParse(dato, out num))
                {
                    pila.Push(num); // agregar el num
                }
                else if (Verificaciones.veriOperador(dato[0])) // Manejar operador
                {
                    if (pila.Count < 2)
                    {
                        throw new InvalidOperationException("No hay suficientes operandos en la pila para realizar la operación.");
                    }

                    double b = pila.Pop(); // El segundo operando
                    double a = pila.Pop(); // El primer operando
                    double res = AplicarOperacion(a, b, dato[0]);
                    pila.Push(res); // Apilar el resultado
                }
                else
                {
                    throw new InvalidOperationException("Token desconocido: " + pila);
                }
            }

            if (pila.Count != 1)
            {
                throw new InvalidOperationException("La expresión postfija es invalida.");
            }

            return pila.Pop(); //resultaod final
        }

        // meto para realizar la operacion
        public static double AplicarOperacion(double a, double b, char op)
        {
            switch (op)
            {
                case '+':
                    return a + b;
                case '-':
                    return a - b;
                case '*':
                    return a * b;
                case '/':
                    if (b == 0)
                    {
                        throw new DivideByZeroException("Division por cero.");
                    }
                    return a / b;
                default:
                    throw new InvalidOperationException("Operador desconocido");
            }


        }
    }   
    
}
