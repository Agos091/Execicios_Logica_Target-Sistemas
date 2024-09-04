Exercícios de Lógica de Programação
Este projeto contém uma série de exercícios de lógica de programação implementados em C#. O objetivo é fornecer soluções para problemas comuns de programação e cálculo, incluindo soma, verificação de sequência de Fibonacci, análise de faturamento, cálculo de percentuais por estado, e manipulação de strings.

Funcionalidades
O programa apresenta um menu interativo onde o usuário pode escolher qual exercício deseja executar. As funcionalidades incluem:

Cálculo de SOMA: Calcula a soma de valores de 1 até 13.
Verificação de Fibonacci: Verifica se um número informado pertence à sequência de Fibonacci.
Análise de Faturamento Diário: Calcula o menor, maior e média de faturamento diário a partir de dados em formato JSON.
Cálculo Percentual de Faturamento por Estado: Calcula o percentual de faturamento de cada estado com base nos valores inseridos pelo usuário.
Inversão de String: Inverte os caracteres de uma string fornecida pelo usuário.
Tecnologias Utilizadas
Linguagem: C#
Biblioteca para manipulação de JSON: Newtonsoft.Json
Requisitos
.NET SDK (pelo menos a versão 5.0 ou superior)
Visual Studio ou outro IDE compatível com C#
Pacote Newtonsoft.Json para manipulação de dados JSON. Se não estiver instalado, siga as instruções abaixo.
Instalação
Clone o repositório:

bash
Copiar código
git clone https://github.com/seuusuario/Execicios_Logica.git
Instale o pacote Newtonsoft.Json:

No Visual Studio: Vá até Gerenciar Pacotes NuGet e procure por Newtonsoft.Json, depois clique em Instalar.
Via terminal com o NuGet CLI:
bash
Copiar código
Install-Package Newtonsoft.Json
Compile o projeto: Abra o projeto no Visual Studio e clique em Build para compilar o projeto.

Como Executar
Após a instalação e compilação, execute o programa.
O menu será exibido com as seguintes opções:
1: Cálculo de SOMA
2: Verificar número na sequência de Fibonacci
3: Cálculo de faturamento diário
4: Cálculo de percentual de faturamento por estado
5: Inversão de uma string
6: Sair
Digite o número da opção que deseja executar e siga as instruções para fornecer os inputs necessários.
Exemplo de Uso
Verificação de Fibonacci
Escolha a opção 2.
Informe um número, como 21.
O programa retornará se o número pertence ou não à sequência de Fibonacci.
Análise de Faturamento
Escolha a opção 3.
Insira um JSON com os valores de faturamento diário. Exemplo:
json
Copiar código
[
  { "dia": 1, "valor": 1000 },
  { "dia": 2, "valor": 0 },
  { "dia": 3, "valor": 3000 }
]
O programa retornará o menor e maior valor de faturamento, e quantos dias ficaram acima da média.