using Xunit;
using Collections;
namespace CollectionsTest
{
    public class AnotherQueueTest
    {
        [Fact]
        public void QueueShouldEnqueue()
        {
            //arrange
            KamoteQ<string> turoturo = new KamoteQ<string>();

            //act
            turoturo.Enqueue("kamotecue");
            turoturo.Enqueue("bananacue");
            turoturo.Enqueue("bbq");

            //assert
            Assert.Equal(turoturo.Front.Data, "kamotecue");
            Assert.Equal(turoturo.Rear.Data, "bbq");
        }

        [Fact]
        public void QueueShouldDequeue()
        {
            //arrange
            KamoteQ<string> merienda = new KamoteQ<string>();
            merienda.Enqueue("suman");
            merienda.Enqueue("tikoy");
            merienda.Enqueue("yakgua");
            merienda.Enqueue("odeng");
            merienda.Enqueue("burgers");

            //act & assert
            Assert.Equal(merienda.Front.Data, "suman");
            Assert.Equal(merienda.Dequeue(), "suman");
            Assert.Equal(merienda.Front.Data, "tikoy");
        }
    }
}