using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace test_question
{
    class List<T> : IEnumerable<T>
    {
        private readonly Node<T> Head;

        public List() => Head = null;
        
        public List(T data) => Head = new Node<T>(data);
        
        private List(T data, List<T> old_list)
        {
            var current_input = old_list.Head;

            Node<T> last = null;
            Node<T> temp = null;

            while (last != old_list.Head)
            {
                while(current_input.next != last)
                    current_input = current_input.next;

                temp = new Node<T>(current_input.data, temp);
                last = current_input;
                current_input = old_list.Head;
            }

            Head = new Node<T>(data, temp);
            
        }

        public List<T> Add(T data)
        {
            List<T> output;

            if (Head == null)
                output = new List<T>(data);
            else
                output = new List<T>(data, this);

            return output;
        }

        public List<T> Remove()
        {
            List<T> output = new List<T>();

            var current_input = Head;

            Node<T> last = null;
            
            while (last != Head)
            {
                while (current_input.next != last)
                    current_input = current_input.next;

                if(current_input != Head)
                    output = output.Add(current_input.data);
                
                last = current_input;
                current_input = Head;
            }

            return output;
        }

        public static List<T> Unite(List<T> a, List<T> b)
        {
            List<T> output = new List<T>();

            var current_input = b.Head;

            Node<T> last = null;

            while (last != b.Head)
            {
                while (current_input.next != last)
                    current_input = current_input.next;

                    output = output.Add(current_input.data);

                last = current_input;
                current_input = b.Head;
            }

            current_input = a.Head;

            last = null;

            while (last != a.Head)
            {
                while (current_input.next != last)
                    current_input = current_input.next;

                output = output.Add(current_input.data);

                last = current_input;
                current_input = a.Head;
            }

            return output;
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return new List_Enumerator<T>(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new List_Enumerator<T>(this);
        }

        private class Node<T1>
        {
            public readonly T1 data;

            public readonly Node<T1> next;

            public Node(T1 data)
            {
                this.data = data;
                next = null;
            }

            public Node(T1 data, Node<T1> next)
            {
                this.data = data;
                this.next = next;
            }
        }

        private class List_Enumerator<T2> : IEnumerator<T>
        {
            private readonly List<T> list;

            public T Current { get { return current.data; } }

            object IEnumerator.Current => throw new NotImplementedException();

            private Node<T> current;

            public List_Enumerator(List<T> list) => this.list = list;

            public void Dispose() => Reset();
            
            public bool MoveNext()
            {
                if (current == null)
                {
                    current = list.Head;
                    return true;
                }

                if(current.next != null)
                {
                    current = current.next;
                    return true;
                }
                return false;
            }

            public void Reset() => current = null;
        }
    }
}
