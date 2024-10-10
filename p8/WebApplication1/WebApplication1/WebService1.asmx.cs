using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication1
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        // Método web para procesar la expresión infija
        [WebMethod]
        public double ProcesarExpresionInfija(string expresionInfija)
        {
            try
            {
                // Convertir de infijo a postfijo
                string postfijo = infijo_a_Postfijo(expresionInfija);

                // Evaluar la expresión postfija
                double resultado = EvaluarPostfijo(postfijo);

                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al procesar la expresión: " + ex.Message);
            }
        }

        // Métodos auxiliares

        public static bool veriOperador(char c)
        {
            return c == '+' || c == '-' || c == '*' || c == '/';
        }

        public static int Precedencia(char op)
        {
            switch (op)
            {
                case '+':
                case '-':
                    return 1;
                case '*':
                case '/':
                    return 2;
                default:
                    return 0;
            }
        }

        public static string infijo_a_Postfijo(string infijo)
        {
            Stack<char> pila = new Stack<char>();
            string postfijo = "";
            int i = 0;

            while (i < infijo.Length)
            {
                char c = infijo[i];

                if (c == ' ')
                {
                    i++;
                    continue;
                }

                // Leer número completo
                if (char.IsDigit(c))
                {
                    while (i < infijo.Length && (char.IsDigit(infijo[i]) || infijo[i] == '.'))
                    {
                        postfijo += infijo[i];
                        i++;
                    }
                    postfijo += ' '; // Separar número
                    continue; // Saltar al siguiente ciclo
                }

                // Manejar paréntesis
                if (c == '(')
                {
                    pila.Push(c);
                }
                else if (c == ')')
                {
                    while (pila.Count > 0 && pila.Peek() != '(')
                    {
                        postfijo += pila.Pop() + " ";
                    }
                    pila.Pop(); // quitar '('
                }
                else if (veriOperador(c))
                {
                    while (pila.Count > 0 && Precedencia(pila.Peek()) >= Precedencia(c))
                    {
                        postfijo += pila.Pop() + " ";
                    }
                    pila.Push(c);
                }

                i++;
            }

            // Desapilar todos los operadores restantes
            while (pila.Count > 0)
            {
                postfijo += pila.Pop() + " ";
            }

            return postfijo.Trim(); // Remover espacio final
        }

        public static double EvaluarPostfijo(string postfijo)
        {
            Stack<double> pila = new Stack<double>();
            string[] datos = postfijo.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string dato in datos)
            {
                // Usar TryParse para verificar si el dato es un número
                double num;
                if (double.TryParse(dato, out num))
                {
                    pila.Push(num); // agregar el número
                }
                else if (veriOperador(dato[0])) // Manejar operador
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

            return pila.Pop(); // Resultado final
        }

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
                        throw new DivideByZeroException("División por cero.");
                    }
                    return a / b;
                default:
                    throw new InvalidOperationException("Operador desconocido");
            }
        }
    }
}
