using Calculadora.Services;
namespace CalculadoraTestes;

public class CalculadoraTests
{

    private CalculadoraImp _calc;
    public CalculadoraTests() {
        _calc = new CalculadoraImp();
    }


    [Fact]
    public void DeveSomar5com10Retornar15()
    {
        //Arrange
        double num1 = 5;
        double num2 = 10;

        //Act
        double resultado = _calc.Somar(num1, num2);

        //Assert
        Assert.Equal(15, resultado);

    }
    
    [Fact] 
    public void DeveRetornar10De5Menos10(){
        //Arrange
        double num1 = 5;
        double num2 = 10;
        //Act 
        double resultado = _calc.Subtrair(num2, num1);
        //Assert
        Assert.Equal(5, resultado);
    }

    [Fact] 
    public void DeveMultiplicar2Vezes10Retornar20(){
        //Arrange
        double num1 = 2;
        double num2 = 10;
        //Act 
        double resultado = _calc.Multiplicar(num2, num1);
        //Assert
        Assert.Equal(20, resultado);
    }
    
    [Fact] 
    public void DeveDividir10Por2Retornar5(){
        //Arrange
        double num1 = 2;
        double num2 = 10;
        //Act 
        double resultado = _calc.Dividir(num2, num1);
        //Assert
        Assert.Equal(5, resultado);
    }

     [Fact] 
    public void HistoricoVazio(){
        //Arrange
        _calc.Somar(1,2);

        //Act 
        var lista = _calc.Historico();
        //Assert
        Assert.NotEmpty(lista);
    }



}