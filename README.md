# Jogo da Forca

![](https://i.imgur.com/qxVqYaT.gif)

## Sobre o projeto

Este projeto é o clássico **Jogo da Forca**. O jogador deve adivinhar a palavra secreta escolhida aleatoriamente a partir de uma lista de palavras relacionadas a frutas. A cada erro, uma parte do boneco da forca é desenhado, e o jogo termina quando o jogador acerta a palavra ou comete mais de 5 erros.

## Funcionalidades

- **Escolha Aleatória de Palavra**: O jogo seleciona uma palavra aleatória de uma lista.
- **Exibição da Forca**: O boneco da forca é atualizado conforme o número de erros do jogador.
- **Exibição da Palavra**: O jogo exibe a palavra parcialmente descoberta e permite que o jogador tente adivinhar letra por letra.
- **Condições de Vitória e Derrota**: O jogo termina quando o jogador acerta a palavra ou ultrapassa o limite de tentativas.

## Como Jogar

- O jogo exibirá uma palavra secreta oculta.
- O jogador deve inserir uma letra por vez.
- Se a letra estiver na palavra, ela será revelada na posição correta.
- Se a letra não estiver na palavra, um erro será contabilizado e o boneco da forca começará a ser desenhado.
- O jogo termina quando o jogador adivinha toda a palavra ou ultrapassa o limite de 5 erros.


## Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para compilação e execução do projeto.

## Como usar

1. Clone o repositório:

```
git clone https://github.com/estevaosantosribeiro/jogo-da-forca-2025.git
```

2. Navegue até a pasta raiz do projeto:

```
cd JogoDaForca
```

3. Restaure as dependências:

```
dotnet restore
```

4. Navegue até a pasta do projeto:

```
cd JogoDaForca.ConsoleApp
```

5. Execute o projeto:

```
dotnet run
```

