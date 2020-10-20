# A ideia é fazer uma árvore de descição escrevendo o meu nome
''''
acao = int(input("Digite 1 para verdadeiro e 2 para falso"))
if(acao==1):
    print("Verdade")
else:
    if(acao==2):
        print("Falso")
    else:
        print("Valor não valido")
'''

pNome = "Rafael"
sNome = " Sagawe"
uNome = " Favero"
nomeTodo = pNome + sNome + uNome
umaLetra = str(input("Digite a primeira letra do meu nome: "))
if(umaLetra == "r"):
    print(pNome)
else:
    if(umaLetra == "s"):
       print(sNome)
    if(umaLetra == "f"):
        print(uNome)
    else:
        print("Letra fora do nome")