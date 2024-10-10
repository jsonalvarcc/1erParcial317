def fibonacci(n):

    fib = [0, 1]

    for i in range(2, n):    
        sig_termino = fib[i - 1] + fib[i - 2]
        fib.append(sig_termino)

    return fib

n = 100  
print( fibonacci(n))
