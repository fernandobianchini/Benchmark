using Benchmark.Versoes;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Mathematics;
using BenchmarkDotNet.Order;

namespace Benchmark
{
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn(NumeralSystem.Arabic)]
    public class ValidarCPFBenchmark
    {
        [Params("12345678909", "11111111111")]
        public string CPF { get; set; }

        [Benchmark(Baseline = true)]
        public void ValidarCPFVersao1()
        {
            CPFVersao1.ValidarCPF(CPF);
        }
        [Benchmark]
        public void ValidarCPFVersao2()
        {
            CPFVersao2.ValidarCPF(CPF);
        }
    }
}
