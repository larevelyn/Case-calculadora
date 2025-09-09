def operacoes(valorA_f, operador_f, valorB_f):
    
    if operador_f == '+':
        resultado = valorA_f + valorB_f
    
    elif operador_f == '-':
        resultado = valorA_f - valorB_f

    elif operador_f == '*':
        resultado = valorA_f * valorB_f

    elif operador_f == '/':
        resultado = valorA_f / valorB_f
    
    return f'{valorA_f} {operador_f} {valorB_f} = {resultado}'

valoresA = [14, 5, 2147483647, 18]
operadores =  ['-', '*', '+', '/']
valoresB = [8, 6, 2, 3]

# o zip costura e iguala as 3 listas e o enumerate mostra a posição atual da fila
for i, (a, op, b) in enumerate(zip(valoresA, operadores, valoresB)):
    print(f'Operação: {op}')
    print(operacoes(a, op, b))
    print(30*'-')

    # Mostrar as próximas operações
    # o i funciona como guia na hora de mostrar em qual lista estamos
    if i + 1 < 4:
        print("Próximas operações:")

        # serve para mostrar as operações restantes na lista
        for j in range(i + 1, 4):
            print(f"  - {valoresA[j]} {operadores[j]} {valoresB[j]}")
        
        print(30*'-')
    else:
        print("Nenhuma operação restante.\n")
