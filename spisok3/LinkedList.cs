namespace spisok3
{
    using System.Collections.Generic;

    public class LinkedList
    {
        private Node head;
        private Node tail; // Указатель на хвост

        public void Add(double value)
        {
            Node newNode = new Node(value);

            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                newNode.Prev = tail;
                tail = newNode;
            }
        }

        public void RemoveWhereFractionGreaterThan05()
        {
            Node current = head;

            while (current != null)
            {
                Node nextNode = current.Next;

                if ((current.Value - (int)current.Value) > 0.5) // Проверяем дробную часть
                {
                    if (current.Prev != null)
                        current.Prev.Next = current.Next;
                    else
                        head = current.Next; // Если удаляемый узел — голова, двигаем head

                    if (current.Next != null)
                        current.Next.Prev = current.Prev;
                    else
                        tail = current.Prev; // Если удаляемый узел — хвост, двигаем tail
                }

                current = nextNode;
            }
        }

        public List<double> ToList()
        {
            List<double> numbers = new List<double>();
            Node current = head;

            while (current != null)
            {
                numbers.Add(current.Value);
                current = current.Next;
            }

            return numbers;
        }

        public List<double> ToReverseList()
        {
            List<double> numbers = new List<double>();
            Node current = tail; // Начинаем с конца

            while (current != null)
            {
                numbers.Add(current.Value);
                current = current.Prev;
            }

            return numbers;
        }
    }
}
