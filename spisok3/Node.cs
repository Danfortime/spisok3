namespace spisok3
{
    public class Node
    {
        public double Value { get; set; }
        public Node Next { get; set; }
        public Node Prev { get; set; } // Добавляем ссылку на предыдущий узел

        public Node(double value)
        {
            Value = value;
            Next = null;
            Prev = null;
        }
    }
}
