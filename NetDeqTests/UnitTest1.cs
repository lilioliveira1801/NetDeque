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
    public void DadoInserirRemoverVariosElementosInicioDeveVerificarOrdemCorretaCount0()
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

    [Fact]
    public void DadoRemoverDequeVazioFinalRetornaExcecao()
    {
        //arragne
        var novoDeque = new Deque<string>();
        string esperado = "Deque is empty.";
        //act
        var resultado = () => novoDeque.RemEnd();

        //assert
        var ex = Assert.Throws<InvalidOperationException>(resultado);
        Assert.Equal(esperado, ex.Message);

    }

    [Fact]
    public void DadoInserirRemoverVariosElementosFinalDeveVerificarOrdemCorretaCount0()
    {
        //arragne
        var novoDeque = new Deque<int>();
        var esperado1 = 10;
        var esperado2 = 20;
        var esperado3 = 30;
        novoDeque.AddEnd(esperado1);
        novoDeque.AddEnd(esperado2);
        novoDeque.AddEnd(esperado3);
        novoDeque.RemBeg();


        //act
        var resultado = novoDeque.RemBeg();

        //assert

        Assert.Equal(esperado2, resultado);
        Assert.Equal(1, novoDeque.Count);
    }

    [Fact]
    public void DadoDequeVazioDeveRetornaExcecao()
    {
        //arragne
        var novoDeque = new Deque<string>();
        string esperado = "Deque is empty.";
        //act
        var resultadoBeg = () => novoDeque.PeekBeg();
        var resultadoEnd = () => novoDeque.PeekEnd();

        //assert
        var ex1 = Assert.Throws<InvalidOperationException>(resultadoBeg);
        var ex2 = Assert.Throws<InvalidOperationException>(resultadoEnd);
        Assert.Equal(esperado, ex1.Message);
        Assert.Equal(esperado, ex2.Message);

    }

    [Fact]
    public void DadoDequeDeveRetornaDeveAoConsultarSemAlterar()
    {
        //arragne
        var novoDeque = new Deque<int>();
        var esperado1 = 10;
        var esperado2 = 20;
        var esperado3 = 30;
        novoDeque.AddEnd(esperado1);
        novoDeque.AddEnd(esperado2);
        novoDeque.AddEnd(esperado3);
        

        //act
        var resultadoBeg = novoDeque.PeekBeg();
        var resultadoEnd = novoDeque.PeekEnd();

        //assert

        Assert.Equal(esperado1, resultadoBeg);
        Assert.Equal(esperado3, resultadoEnd);
        Assert.Equal(3, novoDeque.Count);

    }

    [Fact]
    public void DadoInserirNoInicioENoFinalDeveVerificarOrdemCorreta()
    {
        //arragne
        var novoDeque = new Deque<int>();
        var dequeEsperado = new Deque<int>();
        dequeEsperado.AddEnd(8);
        dequeEsperado.AddEnd(6);
        dequeEsperado.AddEnd(4);
        dequeEsperado.AddEnd(2);
        dequeEsperado.AddEnd(0);
        dequeEsperado.AddEnd(1);
        dequeEsperado.AddEnd(3);
        dequeEsperado.AddEnd(5);
        dequeEsperado.AddEnd(7);
        dequeEsperado.AddEnd(9);

        //act
        for (int i = 0; i < 10; i = i +2)
        {
            novoDeque.AddBeg(i);
        }
        for (int i = 1; i < 10; i = i +2)
        {
            novoDeque.AddEnd(i);
        }
       

        //assert
        Assert.Equal(dequeEsperado.Count, novoDeque.Count);
        Assert.Equal(dequeEsperado.PeekBeg(), novoDeque.PeekBeg());
        Assert.Equal(dequeEsperado.PeekEnd(), novoDeque.PeekEnd());

        while (!dequeEsperado.IsEmpty && !novoDeque.IsEmpty)
        {
            Assert.Equal(dequeEsperado.RemBeg(), novoDeque.RemBeg());
        }

        // Garante que os dois esvaziaram juntos
        Assert.True(dequeEsperado.IsEmpty);
        Assert.True(novoDeque.IsEmpty);
    }
        
}