namespace Collections
{
    public class BbQueue<T>
    {
        public Node<T>? Rear { get; set; }

        public BbQueue()
        {
            this.Rear = null;
        }

        public void Enqueue(T data)
        {
            Node<T> newRear = new Node<T>(data);
            if (Rear == null)
            {
                newRear.Next = newRear;
            }
            else
            {
                newRear.Next = Rear.Next;
                Rear.Next = newRear;
            }
            Rear = newRear;

        }
        public T Dequeue()
        {
            Node<T> oldFront = Rear.Next;
            if (oldFront == oldFront.Next) Rear = null;
            else
            {
                Rear.Next = oldFront.Next;
            }
            return oldFront.Data;
        }


    }
}