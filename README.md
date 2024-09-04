Exercícios de Lógica em C#
Este projeto contém uma série de exercícios de lógica implementados em C#. Ele permite ao usuário resolver questões que envolvem soma, sequência de Fibonacci, análise de faturamento, cálculo percentual por estado e manipulação de strings. O projeto foi desenvolvido com uma interface de menu para selecionar e executar cada uma das questões individualmente.

Estrutura do Projeto
Exercicios_Logica/ 

├── Program.cs

├── Exercicios_Logica.sln

├── README.md

├── packages.config


Funcionalidades
Cálculo de SOMA: Realiza a soma dos números de 1 a 13.
Verificação de Fibonacci: Verifica se um número pertence à sequência de Fibonacci.
Análise de Faturamento Diário: Calcula o menor, maior e os dias de faturamento acima da média, recebendo os dados de faturamento em formato JSON.
Cálculo Percentual de Faturamento por Estado: Calcula o percentual de contribuição de cada estado em relação ao faturamento total.
Inversão de String: Inverte os caracteres de uma string fornecida pelo usuário.
Pré-requisitos

.NET SDK (5.0 ou superior)
Pacote Newtonsoft.Json (para manipulação de JSON)
Como Executar
Passo 1: Clonar o repositório
Clone o repositório em sua máquina local:

bash

Copiar código

git clone https://github.com/seuusuario/Exercicios_Logica.git

Navegue até a pasta do projeto:

bash
Copiar código
cd Exercicios_Logica
Passo 2: Instalar dependências
Abra o NuGet Package Manager no Visual Studio e instale o pacote Newtonsoft.Json.

Ou instale via terminal com o seguinte comando:

bash
Copiar código

Install-Package Newtonsoft.Json

Passo 3: Executar o programa

Abra o projeto no Visual Studio.

Compile o projeto clicando em Build.

Execute o projeto. Será exibido um menu no console onde você pode escolher qual exercício executar.

Como Usar

Menu Principal:

O programa apresenta um menu com 6 opções.
O usuário pode escolher entre as opções para calcular a soma, verificar Fibonacci, analisar faturamento ou inverter uma string.
Entrada de Dados:

Algumas questões, como análise de faturamento e Fibonacci, solicitam a entrada de dados pelo usuário.
Exemplo de JSON para Análise de Faturamento:

json

código

[
  { "dia": 1, "valor": 1000 },
  
  { "dia": 2, "valor": 2000 },
  
  { "dia": 3, "valor": 3000 }
]

Estrutura do Código
Program.cs
Contém a lógica principal do projeto, incluindo um menu interativo que chama funções específicas para cada exercício.
As funções implementam os cálculos de SOMA, Fibonacci, faturamento e inversão de string.

Possíveis Erros
Erro de dependência Newtonsoft.Json: Se o pacote Newtonsoft.Json não estiver instalado corretamente, certifique-se de que o pacote foi adicionado ao projeto.
Erro de conversão de JSON: Verifique o formato do JSON fornecido para garantir que ele siga a estrutura esperada.

Autor

Nome: Agos Dalcin Rufino

GitHub: https://github.com/Agos091

LinkedIn: https://www.linkedin.com/in/agos-dalcin-rufino-a9913821a/

Observações
Certifique-se de que as dependências estão instaladas corretamente. O projeto foi testado com .NET 5.0 e Visual Studio 2022. Se você encontrar algum problema, sinta-se à vontade para abrir uma issue ou enviar um pull request no repositório.

Obrigado pela oportunidade.
Att, Agos Dalcin Rufino

