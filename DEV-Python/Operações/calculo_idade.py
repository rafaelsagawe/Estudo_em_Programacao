'''
# 01 - Calculo de idade -> lançando data atual
nasc_data = input("Data de nascimento: ")
data_atual = input("Data atual: ")
idade = int(data_atual) - int(nasc_data) 
print(idade)

# 02 - Pegando a data atual e convertendo no formato protugues
from datetime import date
data_atual = date.today()
data_texto = data_atual.strftime('%d/%m/%Y')
print(data_texto)
'''

# 03 - calculando idade só lançando ano de nascimento
from datetime import date
nasc_ano = input("Anos de nascimento (XXXX): ")
data_atual = date.today()
data_convertida = data_atual.strftime('%Y')
idade = int(data_convertida) - int(nasc_ano)
print(idade)
if int(idade < 18):
    print(str(idade) + " então menor de idade")
else:
    print(str(idade) + " então maior de idade")