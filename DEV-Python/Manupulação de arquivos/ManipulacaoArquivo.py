'''
Atributos
'r' -> Usado somente para ler
'w' -> Usado somente para escrever 
'r+' -> Usado para ler e escrever
'a' -> Usado para acrecentrar

# \n -> para quebrar as linhas dos valores
'''


valores_celular = [1500, 1620, 5000, 2100]

with open('valores_dos_celulares.txt', 'a') as arquivo:
    for valor in valores_celular:
        arquivo.write(str(valor)+ '\n')