using NewTalents;

namespace NewTalentsTestes;

public class NewTalents
{
    public Calculadora ConstruirClasse()
    {
        string data = "25/10/2023";
        Calculadora calc = new Calculadora(data);

        return calc;
    }

    [Theory]
    [InlineData(1,2,3)]
    [InlineData(4,5,9)]
    public void TestarSomar(int val1, int val2, int resultado)
    {   
        //Arrange
        Calculadora calc = ConstruirClasse();

        //Act
        int resultadoCalculadora = calc.somar(val1, val2);

        //Assert
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(3,2,1)]
    [InlineData(7,5,2)]
    public void TestarSubtrair(int val1, int val2, int resultado)
    {   
        //Arrange
        Calculadora calc = ConstruirClasse();

        //Act
        int resultadoCalculadora = calc.subtrair(val1, val2);

        //Assert
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(1,2,2)]
    [InlineData(3,4,12)]
    public void TestarMultiplicar(int val1, int val2, int resultado)
    {   
        //Arrange
        Calculadora calc = ConstruirClasse();

        //Act
        int resultadoCalculadora = calc.multiplicar(val1, val2);

        //Assert
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(4,2,2)]
    [InlineData(18,3,6)]
    public void TestarDividir(int val1, int val2, double resultado)
    {   
        //Arrange
        Calculadora calc = ConstruirClasse();

        //Act
        int resultadoCalculadora = calc.dividir(val1, val2);

        //Assert
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Fact]
    public void TestarDivisaoPorZero()
    {
        //Arrange
        Calculadora calc = ConstruirClasse();

      //Act
      //Assert
      Assert.Throws<DivideByZeroException>(() => calc.dividir(3,0));
    }

    
    [Fact]
    public void TestarHistorico()
    {   
        //Arrange
        Calculadora calc = ConstruirClasse();
        
        //Act

        calc.somar(1,2);
        calc.somar(3,4);
        calc.somar(5,6);
        calc.somar(7,8);

        var lista = calc.historico();
        //Assert
        
        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }
}