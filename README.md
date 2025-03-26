# DiamanteDeX

![](https://imgur.com/afdottI.gif)

## Projeto

Primeiro desafio como trabalho passado a n�s na Academia do programador 2025.

## Detalhes 

O usu�rio informa um n�mero (explicitamente necessita ser um n�mero �mpar
ou o programa n�o aceitara) e o programa desenha um diamante com o mesmo
n�mero de linhas e colunas do valor informado

## Funcionamento

```csharp

 public static List<string> CriarDiamante(int tamanho)
        {
            List<string> linhas = new List<string>(); //Lista onde o diamante ser� armazenado
            int espaco = default; //Vari�vel criada para decrementar o espa�amento de um em um

            for (int i = 1; i <= tamanho; i += 2)
            {
                linhas.Add(("").PadLeft((tamanho + 10) - espaco, ' ') + ("").PadLeft(i, '*'));
                espaco++;
                /*
                O primeiro PadLeft tem o valor de 10 para dar espa�o da lateral,
                ap�s isso � diminu�do o tamanho menos a vari�vel espa�o, ou seja
                no primeiro elemento (*) � deixado 9 espa�os (tamanho = 9, espa�o 0)
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
Note por�m que ao desenhar a parte debaixo, ignoramos o �ltimo (neste caso
o primeiro) elemento, para n�o repetirmos a linha do meio

## Como usar

**Clone o reposit�rio**

```
git clone https://github.com/academiadoprogramador-fullstack/jogo-da-forca-2025.git
```

**Navegue at� a pasta raiz da solu��o**

```
cd jogo-da-forca-2025
```

**Restaure as depend�ncias**

```
dotnet restore
```

**Navegue at� a pasta do projeto**

```
cd JogoDaForca.ConsoleApp
```

**Execute o projeto**

```
dotnet run
```
