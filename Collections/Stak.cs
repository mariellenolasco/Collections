namespace Collections
{
    public class Stak<T>
    {
        // you can implement stack 2 ways: node, array
        public Node<T>? Top { get; set; }
        public Stak()
        {
            Top = null;
        }
        public void Push(T data)
        {
            Node<T> newTop = new Node<T>(data);
            newTop.Next = Top;
            Top = newTop;
        }

        public T Peek()
        {
            if (Top == null)
            {
                throw new InvalidOperationException();
            }
            else
            {
                return Top.Data;
            }
        }

        public T Pop()
        {
            if (Top == null) throw new InvalidOperationException();
            Node<T> poppedTop = Top;
            Top = poppedTop.Next;
            return poppedTop.Data;
        }
    }
}