<h1 align="center">Desafios de código</h1>

<p>Implementações de exercícios de programação do Bootcamp Avanade CodeAnywhere .NET, para práticas de C# e .NET </p>

## :bookmark: Lista de exercícios

Iniciando aritmética em C# | Nível
------------ | -------------
[Média 1](https://github.com/CarolineMano/Desafios_Avanade/tree/master/1%20-%20Iniciando%20Aritmetica%20em%20C%23/Media1) | Intermediário
[Média 2](https://github.com/CarolineMano/Desafios_Avanade/tree/master/1%20-%20Iniciando%20Aritmetica%20em%20C%23/Media2) | Intermediário
[Média 3](https://github.com/CarolineMano/Desafios_Avanade/tree/master/1%20-%20Iniciando%20Aritmetica%20em%20C%23/Media3) | Intermediário

<br />

Desafios matemáticos em C# | Nível
------------ | -------------
[Consumo Médio do Automóvel](https://github.com/CarolineMano/Desafios_Avanade/tree/master/2%20-%20Desafios%20Matematicos%20em%20C%23/Consumo%20Medio%20do%20Automovel) | Básico
[Validação de Notas](https://github.com/CarolineMano/Desafios_Avanade/tree/master/2%20-%20Desafios%20Matematicos%20em%20C%23/Validacao%20de%20Notas) | Intermediário

---
## :memo: Descrição dos exercícios 

## Média 1

**Desafio**  
Leia 2 valores de ponto flutuante de dupla precisão A e B, que correspondem a 2 notas de um aluno. A seguir, calcule a média do aluno, sabendo que a nota A tem peso 3.5 e a nota B tem peso 7.5 (A soma dos pesos portanto é 11). Assuma que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal.  

**Entrada**  
O arquivo de entrada contém 2 valores com uma casa decimal cada um.  

**Saída**  
Calcule e imprima a variável MEDIA conforme exemplo abaixo, com 5 dígitos após o ponto decimal e com um espaço em branco antes e depois da igualdade. Utilize variáveis de dupla precisão (double) e como todos os problemas, não esqueça de imprimir o fim de linha após o resultado, caso contrário, você receberá "Presentation Error".

Exemplo de Entrada | Exemplo de Saída
------------ | -------------
5.0 <br /> 7.1 | MEDIA = 6.43182
0.0 <br /> 7.1 | MEDIA = 4.84091
10.0 <br /> 10.0 | MEDIA = 10.00000


[Visualizar Código](https://github.com/CarolineMano/Desafios_Avanade/blob/master/1%20-%20Iniciando%20Aritmetica%20em%20C%23/Media1/Program.cs)  

---

## Média 2

**Desafio**  
Leia 3 valores, no caso, variáveis A, B e C, que são as três notas de um aluno. A seguir, calcule a média do aluno, sabendo que a nota A tem peso 2, a nota B tem peso 3 e a nota C tem peso 5. Considere que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal.

**Entrada**  
O arquivo de entrada contém 3 valores com uma casa decimal, de dupla precisão (double).  

**Saída**  
Imprima a variável MEDIA conforme exemplo abaixo, com 1 dígito após o ponto decimal e com um espaço em branco antes e depois da igualdade. Assim como todos os problemas, não esqueça de imprimir o fim de linha após o resultado, caso contrário, você receberá "Presentation Error".

Exemplo de Entrada | Exemplo de Saída
------------ | -------------
5.0 <br /> 6.0 <br /> 7.0 | MEDIA = 6.3
5.0 <br /> 10.0 <br /> 10.0 | MEDIA = 9.0
10.0 <br /> 10.0 <br /> 5.0 | MEDIA = 7.5

[Visualizar Código](https://github.com/CarolineMano/Desafios_Avanade/blob/master/1%20-%20Iniciando%20Aritmetica%20em%20C%23/Media2/Program.cs)  

---

## Média 3

**Desafio**  

Leia quatro números (N1, N2, N3, N4), cada um deles com uma casa decimal, correspondente às quatro notas de um aluno. Calcule a média com pesos 2, 3, 4 e 1, respectivamente, para cada uma destas notas e mostre esta média acompanhada pela mensagem "Media: ". Se esta média for maior ou igual a 7.0, imprima a mensagem "Aluno aprovado.". Se a média calculada for inferior a 5.0, imprima a mensagem "Aluno reprovado.". Se a média calculada for um valor entre 5.0 e 6.9, inclusive estas, o programa deve imprimir a mensagem "Aluno em exame.".

No caso do aluno estar em exame, leia um valor correspondente à nota do exame obtida pelo aluno. Imprima então a mensagem "Nota do exame: " acompanhada pela nota digitada. Recalcule a média (some a pontuação do exame com a média anteriormente calculada e divida por 2). e imprima a mensagem "Aluno aprovado." (caso a média final seja 5.0 ou mais ) ou "Aluno reprovado.", (caso a média tenha ficado 4.9 ou menos). Para estes dois casos (aprovado ou reprovado após ter pego exame) apresente na última linha uma mensagem "Media final: " seguido da média final para esse aluno.


**Entrada**  
A entrada contém quatro números de ponto flutuante correspendentes as notas dos alunos. 

**Saída**  
Todas as respostas devem ser apresentadas com uma casa decimal. As mensagens devem ser impressas conforme a descrição do problema. Não esqueça de imprimir o enter após o final de cada linha, caso contrário obterá "Presentation Error".

Exemplo de Entrada | Exemplo de Saída
------------ | -------------
2.0 4.0 7.5 8.0 <br /> 6.4 | Media: 5.4 <br /> Aluno em exame. <br /> Nota do exame: 6.4 <br /> Aluno aprovado. <br /> Media final: 5.9
2.0 6.5 4.0 9.0 | Media: 4.9 <br /> Aluno reprovado.
9.0 4.0 8.5 9.0 | Media: 7.3 <br /> Aluno aprovado.

[Visualizar Código](https://github.com/CarolineMano/Desafios_Avanade/blob/master/1%20-%20Iniciando%20Aritmetica%20em%20C%23/Media3/Program.cs)  

---

## Consumo médio do automóvel

**Desafio**
Você deve calcular o consumo médio de um automóvel onde será informada a distância total percorrida (em Km) e o total de combustível consumido (em litros).

**Entrada**
Você receberá dois valores: um valor inteiro X com a distância total percorrida (em Km), e um valor real Y que representa o total de combustível consumido, com um dígito após o ponto decimal.

**Saída**
Exiba o valor que representa o consumo médio do automóvel (3 casas após a vírgula), incluindo no final a mensagem "km/l".

Exemplo de Entrada | Exemplo de Saída
------------ | -------------
500 <br /> 35.0 | 14.286 km/l
2254 <br /> 124.4 | 18.119 km/l
4554 <br /> 464.6 | 9.802 km/l

[Visualizar código](https://github.com/CarolineMano/Desafios_Avanade/blob/master/2%20-%20Desafios%20Matematicos%20em%20C%23/Consumo%20Medio%20do%20Automovel/Program.cs)

---

## Programa para Validação de Notas

**Desafio**
O calendário escolar está passando bem rápido, devido a isso, as professoras de uma escola estão com dificuldade para calcular as notas dos alunos. Visando em resolver a situação, a diretora da escola contratou você para desenvolver um programa que leia as notas da primeira e da segunda avaliação de um aluno. Calcule e imprima a média semestral.

O programa só aceitará notas válidas (uma nota válida deve pertencer ao intervalo [0,10]). Cada nota deve ser validada separadamente.

No final deve ser impressa a mensagem “novo calculo (1-sim 2-nao)”, solicitando as professoras que informe um código (1 ou 2) indicando se ele deseja ou não executar o algoritmo novamente, (aceitar apenas os código 1 ou 2). Se for informado o código 1 deve ser repetida a execução de todo o programa para permitir um novo cálculo, caso contrário o programa deve ser encerrado.

**Entrada**
O arquivo de entrada contém vários valores reais, positivos ou negativos. Quando forem lidas duas notas válidas, deve ser lido um valor inteiro X . O programa deve parar quando o valor lido para este X for igual a 2.

**Saída**
Se uma nota inválida for lida, deve ser impressa a mensagem “nota invalida”. Quando duas notas válidas forem lidas, deve ser impressa a mensagem “media = ” seguido do valor do cálculo.

Antes da leitura de X deve ser impressa a mensagem "novo calculo (1-sim 2-nao)" e esta mensagem deve ser apresentada novamente se o valor da entrada padrão para X for menor do que 1 ou maior do que 2, conforme o exemplo abaixo.

A média deve ser impressa com dois dígitos após o ponto decimal.

Exemplo de Entrada | Exemplo de Saída
------------ | -------------
-3.5 <br />3.5 <br />11.0 <br />10.0 <br />4 <br />1 <br />8.0 <br />9.0 <br />2 | nota invalida <br />nota invalida <br />media = 6.75 <br />novo calculo <br /> (1-sim 2-nao) <br /> novo calculo <br /> (1-sim 2-nao) <br /> media = 8.50 <br /> novo calculo <br /> (1-sim 2-nao)

[Visualizar código](https://github.com/CarolineMano/Desafios_Avanade/blob/master/2%20-%20Desafios%20Matematicos%20em%20C%23/Validacao%20de%20Notas/Program.cs)