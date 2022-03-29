using Xunit;
using Collections;
namespace CollectionsTest
{
    public class QueueTest
    {
        [Fact]
        public void QueueShouldEnqueue()
        {
            BbQueue<string> Inihaw = new BbQueue<string>();
            Inihaw.Enqueue("isaw");
            Inihaw.Enqueue("chicken feet");
            Inihaw.Enqueue("betamax");

            //front of queue
            Assert.Equal(Inihaw.Rear.Next.Data, "isaw");

            //rear of queue
            Assert.Equal(Inihaw.Rear.Data, "betamax");
        }

        [Fact]
        public void QueueShouldDequeue()
        {
            BbQueue<string> Inihaw = new BbQueue<string>();
            Inihaw.Rear = new Node<string>("isaw");
            Inihaw.Rear.Next = Inihaw.Rear;
            Assert.Equal(Inihaw.Dequeue(), "isaw");
            Assert.Null(Inihaw.Rear);
        }
    }
}