using NetDeque;

namespace NetDeqTests;

public class UnitTest1
{
    [Fact]
    public void DadoNovoDequeEntaoDeveCountDoDequeRetornar0EVazio()
    {
        //arragne
        var novoDeque = new Deque<int>();

        //act
        int count = novoDeque.Count;

        //assert
        Assert.Equal(0, count);
        Assert.True(novoDeque.IsEmpty);      


    }

    [Fact]
    public void DadoInserirUmNovoNoInicioElementoEntaoDeveRetornarElementoInserido()
    {
        //arragne
        var novoDeque = new Deque<int>();
        var esperado = 10;
        novoDeque.AddBeg(esperado);

        //act
        var resultado = novoDeque.PeekBeg();

        //assert
        Assert.Equal(esperado, resultado);

    }
    [Fact]
    public void DadoInserirVariosElementoNoInicioEntaoDeveRetornarUltimoElementoInserido()
    {
        //arragne
        var novoDeque = new Deque<int>();
        var esperado1 = 10;
        var esperado2 = 20;
        novoDeque.AddBeg(esperado1);
        novoDeque.AddBeg(esperado2);

        //act
        var resultado = novoDeque.PeekBeg();

        //assert
        Assert.Equal(esperado2, resultado);

    }

    [Fact]
    public void DadoInserirUmNovoElementoNoFinalEntaoDeveRetornarElementoInserido()
    {
        //arragne
        var novoDeque = new Deque<int>();
        var esperado = 10;
        novoDeque.AddEnd(esperado);

        //act
        var resultado = novoDeque.PeekEnd();

        //assert
        Assert.Equal(esperado, resultado);

    }
    [Fact]
    public void DadoInserirVariosElementoNoFinalEntaoDeveRetornarUltimoElementoInserido()
    {
        //arragne
        var novoDeque = new Deque<int>();
        var esperado1 = 10;
        var esperado2 = 20;
        novoDeque.AddEnd(esperado1);
        novoDeque.AddEnd(esperado2);

        //act
        var resultado = novoDeque.PeekEnd();

        //assert
        Assert.Equal(esperado2, resultado);

    }
    [Fact]
    public void DadoRemoverDequeVazioRetornaExcecao()
    {
        //arragne
        var novoDeque = new Deque<string>();
        string esperado = "Deque is empty.";
        //act
       var resultado = () => novoDeque.RemBeg();

        //assert
        var ex = Assert.Throws<InvalidOperationException>(resultado);
        Assert.Equal(esperado, ex.Message);

    }
    [Fact]
    public void DadoInserirRemovesVariosElementosInicioDeveVerificarOrdemCorretaCount0()
    {
        //arragne
        var novoDeque = new Deque<int>();
        var esperado1 = 10;
        var esperado2 = 20;
        var esperado3 = 30;
        novoDeque.AddBeg(esperado1);
        novoDeque.AddBeg(esperado2);
        novoDeque.AddBeg(esperado3);
        novoDeque.RemBeg();
      

        //act
        var resultado = novoDeque.RemBeg(); 

        //assert
        
        Assert.Equal(esperado2, resultado);
        Assert.Equal(1, novoDeque.Count);

    }
}