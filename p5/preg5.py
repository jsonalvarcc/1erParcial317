import multiprocessing
    #formula  Leibniz 
def fnCalculoPi(inicio, fin, resultado, indice):
    suma = 0.0
    for i in range(inicio, fin):
        suma += (-1) ** i / (2 * i + 1)
    resultado[indice] = suma

def main():
    num_procesadores = multiprocessing.cpu_count()

    print(f'cantidad de procesadores disponibles: {num_procesadores}\n')
    n = 1000000

    num_procesos = 3
    
    resultado = multiprocessing.Array('d', num_procesos)#arreglo compartido para procesos
    procesos = []    

    for i in range(num_procesos):
        inicio = i * (n // num_procesos)
        fin = (i + 1) * (n // num_procesos) if i != num_procesos - 1 else n
        p = multiprocessing.Process(target=fnCalculoPi, args=(inicio, fin, resultado, i))
        procesos.append(p)
        p.start()
    
    for p in procesos:
        p.join()
    
    estimacion = 4 * sum(resultado)
    
    print(f'\t\tValor estimado de pi: {estimacion}')

if __name__ == "__main__":
    main()
