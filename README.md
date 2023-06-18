# Exemplo de uso do BenchmarkDotNet para Valida��o de CPF

Este projeto � um exemplo de como utilizar o BenchmarkDotNet para medir o desempenho da valida��o de CPF em C#.

O BenchmarkDotNet � uma biblioteca poderosa para realizar benchmarks no .NET, permitindo comparar o desempenho de diferentes trechos de c�digo.

## Pr�-requisitos

- .NET 6 SDK

## Instala��o

1. Clone este reposit�rio ou fa�a o download dos arquivos.
2. Abra o terminal e navegue at� o diret�rio do projeto (`BechmarckDotNet`).

## Executando o Benchmark

Para executar o benchmark e obter os resultados, siga as etapas abaixo:

1. No terminal, execute o seguinte comando:

   ```plaintext
   dotnet run --configuration Release
   ```

   Isso executar� o benchmark e mostrar� os resultados no terminal.

2. Analise os resultados do benchmark, que incluir�o o tempo m�dio de execu��o e outras m�tricas relevantes para cada m�todo de valida��o de CPF.

## Resultado do Benchmark

Ap�s executar o benchmark, voc� ver� um resultado semelhante ao seguinte:

```plaintext
// * Summary *

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.3086/22H2/2022Update)
Intel Core i7-7700HQ CPU 2.80GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores .NET SDK=7.0.203
[Host]     : .NET 6.0.18 (6.0.1823.26907), X64 RyuJIT AVX2
DefaultJob : .NET 6.0.18 (6.0.1823.26907), X64 RyuJIT AVX2

|            Method |         CPF |      Mean |    Error |   StdDev | Ratio | RatioSD | Rank |
|------------------ |------------ |----------:|---------:|---------:|------:|--------:|-----:|
| ValidarCPFVersao2 | 11111111111 |  30.83 ns | 0.210 ns | 0.186 ns |  0.93 |    0.02 |    1 |
| ValidarCPFVersao1 | 11111111111 |  33.08 ns | 0.678 ns | 0.807 ns |  1.00 |    0.00 |    2 |
|                   |             |           |          |          |       |         |      |
| ValidarCPFVersao2 | 12345678909 |  32.74 ns | 0.164 ns | 0.153 ns |  0.13 |    0.00 |    1 |
| ValidarCPFVersao1 | 12345678909 | 254.31 ns | 3.838 ns | 3.590 ns |  1.00 |    0.00 |    2 |

// * Legends *
  Mean   : Arithmetic mean of all measurements
  Error  : Half of 99.9% confidence interval
  StdDev : Standard deviation of all measurements
  Rank   : Relative position of current benchmark mean among all benchmarks (Arabic style)
  1 ns   : 1 Nanosecond (0.000000001 sec)
```

Esses resultados mostram o tempo m�dio de execu��o, o erro padr�o e o desvio padr�o para cada m�todo de valida��o de CPF.

## Conclus�o

Este projeto de exemplo demonstra como utilizar o BenchmarkDotNet para medir o desempenho da valida��o de CPF em C#. Os resultados obtidos permitem avaliar o tempo de execu��o da valida��o e identificar oportunidades de otimiza��o.

Lembre-se de que o benchmarking deve ser utilizado como uma ferramenta complementar no processo de otimiza��o do c�digo. � importante considerar fatores adicionais, como legibilidade, manutenibilidade e requisitos espec�ficos do projeto, ao tomar decis�es de otimiza��o.

Espero que este exemplo seja �til e que voc� possa aplicar o benchmarking em seus pr�prios projetos para melhorar o desempenho do c�digo em C#.

Para mais informa��es do funcionamento da biblioteca acesse: https://benchmarkdotnet.org/articles/overview.html

---

Sinta-se � vontade para personalizar e adicionar mais informa��es relevantes ao README, como instru��es de instala��o do .NET 6 SDK, explica��o detalhada dos resultados do benchmark, e qualquer outra informa��o �til para os usu�rios do projeto.

