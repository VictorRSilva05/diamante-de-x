# DiamanteDeX

![](https://imgur.com/afdottI.gif)

## Projeto

Primeiro desafio como trabalho passado a nós na Academia do programador 2025.

## Detalhes 

O usuário informa um número (explicitamente necessita ser um número ímpar
ou o programa não aceitara) e o programa desenha um diamante com o mesmo
número de linhas e colunas do valor informado

## Funcionamento

```csharp

 public static List<string> CriarDiamante(int tamanho)
        {
            List<string> linhas = new List<string>(); //Lista onde o diamante será armazenado
            int espaco = default; //Variável criada para decrementar o espaçamento de um em um

            for (int i = 1; i <= tamanho; i += 2)
            {
                linhas.Add(("").PadLeft((tamanho + 10) - espaco, ' ') + ("").PadLeft(i, '*'));
                espaco++;
                /*
                O primeiro PadLeft tem o valor de 10 para dar espaço da lateral,
                após isso é diminuído o tamanho menos a variável espaço, ou seja
                no primeiro elemento (*) é deixado 9 espaços (tamanho = 9, espaço 0)
                */
            }
            return linhas;
        }

```

Para desenhar o diamante, achei melhor desenha-lo duas vezes. A maneira que eu
havia pensado anteriormente de juntar uma lista inversa a principal se tornou complexa 
demais.

```csharp
 public static void DesenharDiamante(List<string> linhas)
        {
            Console.Clear();
            for (int i = 0; i < linhas.Count; i++)
            {
                Console.WriteLine(linhas[i]);
            }
            for (int i = linhas.Count - 2; i >= 0; i--)
            {
                Console.WriteLine(linhas[i]);
            }
        }
```
Note porém que ao desenhar a parte debaixo, ignoramos o último (neste caso
o primeiro) elemento, para não repetirmos a linha do meio

## Como usar

**Clone o repositório**

```
git clone https://github.com/academiadoprogramador-fullstack/jogo-da-forca-2025.git
```

**Navegue até a pasta raiz da solução**

```
cd jogo-da-forca-2025
```

**Restaure as dependências**

```
dotnet restore
```

**Navegue até a pasta do projeto**

```
cd JogoDaForca.ConsoleApp
```

**Execute o projeto**

```
dotnet run
```
