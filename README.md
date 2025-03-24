# Jogo de Adivinhação

![](https://i.imgur.com/Cst7Y9l.gif)

## Projeto

Desenvolvido durante o curso Fullstack da [Academia do Programador](https://www.academiadoprogramador.net) 2025

---
## Detalhes

No início do jogo, é gerado um número secreto aleatório entre 1 e 20. Os jogadores devem então tentar adivinhar esse número dentro de um número limitado de tentativas, que varia de acordo com a dificuldade escolhida. A cada tentativa errada, dicas são fornecidas para ajudar a direcionar as próximas tentativas.

Os níveis de dificuldade serão: 

1. Fácil = 15 chances 
2. Médio = 10 chances     
3. Difícil = 5 chances
---
## Tecnologias

[![Tecnologias](https://skillicons.dev/icons?i=git,github,cs,dotnet,visualstudio)](https://skillicons.dev)

---
## Entrada

Os jogadores interagem com o jogo por meio do console, digitando números e recebendo feedback instantâneo sobre suas escolhas. O jogo termina quando o jogador adivinha o número secreto ou quando todas as tentativas são esgotadas.

---
## Funcionalidades

- **Geração de Número Secreto:** No início de cada jogo, um número secreto é gerado aleatoriamente entre 1 e 20.
- **Seleção de Dificuldade:** Os jogadores podem escolher entre três níveis de dificuldade (Fácil, Médio, Difícil), que influenciam o número de tentativas disponíveis.
- **Feedback Instantâneo:** Após cada tentativa, o jogo fornece feedback indicando se o número escolhido é maior ou menor que o número secreto.
---
## Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para compilação e execução do projeto.
---
## Como Usar

#### Clone o Repositório
```
git clone https://github.com/academiadoprogramador-fullstack/jogo-de-adivinhacao-2025.git
```

#### Navegue até a pasta raiz da solução
```
cd jogo-de-adivinhacao-2025
```

#### Restaure as dependências
```
dotnet restore
```

#### Navegue até a pasta do projeto
```
cd JogoDaAdivinhacao.ConsoleApp
```

#### Execute o projeto
```
dotnet run
```
