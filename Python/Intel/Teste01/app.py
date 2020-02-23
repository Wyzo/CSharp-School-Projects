#Hello world
#print("Hello World")

#Print stament
#print("Olá isto é um teste")

#Variáveis e Armazenamento
#Nome = "Francisco"
#Idade = 50
#Masculino = True
#Feminino = False

#print("The once was a man named " + Nome + ",")
#print("he was " + Idade + "years old. ")

#É possível mudar o valor da variável a meio..
#Nome = "Mariana"

#print("He really liked the name " + Nome + ", ")
#print("but didn't like being " + Idade + ".")

#Strings

#print("isto\n"
      #"é\n"
      #"um\n"
      #"teste")

#print("isto \"é fixe \"")

#frase = "Isto é um teste"
#print(frase)

#Contatenação
#teste1 = "olá "
#teste2 = "mundo"

#print(teste1 + teste2)

#funcões strings

#teste = "ISTO É UM TESTE"

#verifica se a frase está toda em maiúscula true = sim || false = não
#print(teste.isupper())

#verifica se a frase está toda em minúscula true = sim || false = não
#print(teste.islower())

#print(teste.upper())
#print(teste.lowwer())

#verificar quantos caracteres
#print(len(teste))
#Escrever através do index da frase
#print(teste[0])

#verificar onde se posiciona tal valor
#frase = "isto é um teste"
#print(frase.index("um"))

#trocar valores de uma frase
#frase = "isto é um teste"
#print(frase.replace("é", "não é"))

#numeros
#print(5 + 2) # 7
#print("5" + "2") # 52
#print(10 % 3) # 1
#print(10 - 8) # 2
#print(2 * 10) # 20
#print(8 / 2) # 4

#funcoes de nums
#from math import sqrt

#Num = 5
#print(sqrt(36))

#teste = input("Numero:")
#print("o numero introduzido foi " + teste)

#Listas
#amigos = ["Francisco", "Alberto", "Mariana"]
#print(amigos[1])

#é possivel colocar vários valores numa lista
#teste = ["teste", 10, True]
#print(teste)

#é possivel aceder aos valores de forma contrária
#teste = ["teste", "teste2", "teste3"]
#           0         1         2
#           -3        -2        -1
#print(teste[0])
#print(teste[-3])

#é possivel mandar escrever tudo que esteja a seguir ao valor dito
#teste = ["teste", "teste2", "teste3", "teste4", "teste5", "teste6"]
#           0         1        2         3         4         5
#neste caso vai escrever da posição 1 até 5
#print(teste[1:])

#é possivel mandar escrever tudo que esteja entre um valor e outro
#teste = ["teste", "teste2", "teste3", "teste4", "teste5", "teste6"]
#           0         1        2         3         4         5
#neste caso vai escrever da posição 1 até 3
#o 2 parametro NÃO CONTA! [1ºvalor;2ºvalor[
#print(teste[1:4])

#é possivel adicionar uma lista a outra lista
#idades = [26, 15, 27, 15, 17]
#nomes = ["francisco", "alberto", "mariana", "joaquim", "rafael"]
#nomes.extend(idades)
#print(nomes)

#adicionar valores a uma lista
#nomes = ["francisco", "alberto", "mariana", "joaquim", "rafael"]
#nomes.append("ricardo")
#print(nomes)