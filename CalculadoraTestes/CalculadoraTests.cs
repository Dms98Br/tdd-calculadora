using Calculadora.Services;
namespace CalculadoraTestes;

public class CalculadoraTests
{
    private CalculadoraImpl _calc;

    public CalculadoraTests()
    {
        _calc = new CalculadoraImpl();
    }

    [Theory]
    [InlineData(1, 2, 3)]
    public void TesteSomar(int num1, int num2, int resultadoCalculadora)
    {
        int resultado = _calc.Somar(num1, num2);
        Assert.Equal(resultado, resultadoCalculadora);
    }
    [Theory]
    [InlineData(2, 1, 1)]
    public void TesteSubtrair(int num1, int num2, int resultadoCalculadora)
    {
        int resultado = _calc.Subtrair(num1, num2);
        Assert.Equal(resultado, resultadoCalculadora);
    }
    [Theory]
    [InlineData(1, 2, 2)]
    public void TesteMultiplicar(int num1, int num2, int resultadoCalculadora)
    {
        int resultado = _calc.Multiplicar(num1, num2);
        Assert.Equal(resultado, resultadoCalculadora);
    }
    [Theory]
    [InlineData(2, 2, 1)]
    public void TesteDividir(int num1, int num2, int resultadoCalculadora)
    {
        int resultado = _calc.Dividir(num1, num2);
        Assert.Equal(resultado, resultadoCalculadora);
    }
    [Theory]
    [InlineData(25, 200, 50)]
    [InlineData(10, 450, 45)]
    [InlineData(50, 1000, 500)]
    [InlineData(7.5, 800, 60)]


    public void TestePorcentagem(double percentual, double numero, double resultadoCalculadora)
    {
        double resultado = _calc.Porcentagem(percentual, numero);
        Assert.Equal(resultado, resultadoCalculadora);
    }
}