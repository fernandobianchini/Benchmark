# Exemplo de uso do BenchmarkDotNet para Validação de CPF

Este projeto é um exemplo de como utilizar o BenchmarkDotNet para medir o desempenho da validação de CPF em C#.

O BenchmarkDotNet é uma biblioteca poderosa para realizar benchmarks no .NET, permitindo comparar o desempenho de diferentes trechos de código.

## Pré-requisitos

- .NET 6 SDK

## Instalação

1. Clone este repositório ou faça o download dos arquivos.
2. Abra o terminal e navegue até o diretório do projeto (`BechmarckDotNet`).

## Executando o Benchmark

Para executar o benchmark e obter os resultados, siga as etapas abaixo:

1. No terminal, execute o seguinte comando:

   ```plaintext
   dotnet run --configuration Release
   ```

   Isso executará o benchmark e mostrará os resultados no terminal.

2. Analise os resultados do benchmark, que incluirão o tempo médio de execução e outras métricas relevantes para cada método de validação de CPF.

## Resultado do Benchmark

Após executar o benchmark, você verá um resultado semelhante ao seguinte:

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

Esses resultados mostram o tempo médio de execução, o erro padrão e o desvio padrão para cada método de validação de CPF.

## Conclusão

Este projeto de exemplo demonstra como utilizar o BenchmarkDotNet para medir o desempenho da validação de CPF em C#. Os resultados obtidos permitem avaliar o tempo de execução da validação e identificar oportunidades de otimização.

Lembre-se de que o benchmarking deve ser utilizado como uma ferramenta complementar no processo de otimização do código. É importante considerar fatores adicionais, como legibilidade, manutenibilidade e requisitos específicos do projeto, ao tomar decisões de otimização.

Espero que este exemplo seja útil e que você possa aplicar o benchmarking em seus próprios projetos para melhorar o desempenho do código em C#.

Para mais informações do funcionamento da biblioteca acesse: https://benchmarkdotnet.org/articles/overview.html

---

Sinta-se à vontade para personalizar e adicionar mais informações relevantes ao README, como instruções de instalação do .NET 6 SDK, explicação detalhada dos resultados do benchmark, e qualquer outra informação útil para os usuários do projeto.

