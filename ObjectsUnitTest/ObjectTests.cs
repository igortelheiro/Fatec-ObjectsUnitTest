using Xunit;

namespace ObjectsUnitTest;

public class ObjectTests
{
    [Fact] public void EhCaneta()
    {
        var caneta = new Caneta();

        var expectedResult = "� uma caneta";

        Assert.Equal(expectedResult, caneta.Descricao);
    }


    [Fact] public void EhLivro()
    {
        var livro = new Livro();

        var expectedResult = "� um livro";

        Assert.Equal(expectedResult, livro.Descricao);
    }


    [Fact] public void EhCaderno()
    {
        var caderno = new Caderno();

        var expectedResult = "� um caderno";

        Assert.Equal(expectedResult, caderno.Descricao);
    }
}

interface IObject
{
    public string Descricao { get; }
}

class Caneta : IObject
{
    public string Descricao => "� uma caneta";
}

class Caderno : IObject
{
    public string Descricao => "� um caderno";
}

class Livro : IObject
{
    public string Descricao => "� um livro";
}