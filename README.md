# Jogo da Forca

![](https://i.imgur.com/qxVqYaT.gif)

## Sobre o projeto

Este projeto � o cl�ssico **Jogo da Forca**. O jogador deve adivinhar a palavra secreta escolhida aleatoriamente a partir de uma lista de palavras relacionadas a frutas. A cada erro, uma parte do boneco da forca � desenhado, e o jogo termina quando o jogador acerta a palavra ou comete mais de 5 erros.

## Funcionalidades

- **Escolha Aleat�ria de Palavra**: O jogo seleciona uma palavra aleat�ria de uma lista.
- **Exibi��o da Forca**: O boneco da forca � atualizado conforme o n�mero de erros do jogador.
- **Exibi��o da Palavra**: O jogo exibe a palavra parcialmente descoberta e permite que o jogador tente adivinhar letra por letra.
- **Condi��es de Vit�ria e Derrota**: O jogo termina quando o jogador acerta a palavra ou ultrapassa o limite de tentativas.

## Como Jogar

- O jogo exibir� uma palavra secreta oculta.
- O jogador deve inserir uma letra por vez.
- Se a letra estiver na palavra, ela ser� revelada na posi��o correta.
- Se a letra n�o estiver na palavra, um erro ser� contabilizado e o boneco da forca come�ar� a ser desenhado.
- O jogo termina quando o jogador adivinha toda a palavra ou ultrapassa o limite de 5 erros.


## Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para compila��o e execu��o do projeto.

## Como usar

1. Clone o reposit�rio:

```
git clone https://github.com/estevaosantosribeiro/jogo-da-forca-2025.git
```

2. Navegue at� a pasta raiz do projeto:

```
cd JogoDaForca
```

3. Restaure as depend�ncias:

```
dotnet restore
```

4. Navegue at� a pasta do projeto:

```
cd JogoDaForca.ConsoleApp
```

5. Execute o projeto:

```
dotnet run
```

