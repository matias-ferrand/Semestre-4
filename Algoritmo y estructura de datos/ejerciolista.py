n = [1, 2, 3, 4, 5]
buscado = 5

for i in range(len(n)):
    if n[i] == buscado:
        print("Número encontrado")
        break
else:
    print("Número no encontrado")

