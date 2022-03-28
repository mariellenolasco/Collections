using Xunit;
using Collections;
namespace CollectionsTest;

public class StackTest
{
    [Fact]
    public void StackShouldPush()
    {
        //arrange
        Stak<string> shortStak = new Stak<string>();
        //act
        shortStak.Push("pancake");
        //assert
        Assert.Equal(shortStak.Top.Data, "pancake");
    }

    [Fact]
    public void StackShouldPeek()
    {
        //arrange 
        Stak<string> shortStak = new Stak<string>();
        shortStak.Top = new Node<string>("pancake");
        //act
        //assert
        Assert.Equal(shortStak.Peek(), "pancake");
    }

    [Fact]
    public void StackShouldPop()
    {
        Stak<string> shortStak = new Stak<string>();
        shortStak.Top = new Node<string>("pancake");
        Assert.Equal(shortStak.Pop(), "pancake");
    }
}