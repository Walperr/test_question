using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace test_question
{

    class List<T> : IEnumerable<T>
    {
        private Node<T> Head { get; set; }

        public List()
        {
            Head = null;
        }

        public List(T data)
        {
            Head = new Node<T>(data);
        }

        public void Add(T data)
        {
            if (Head == null)
            {
                Head = new Node<T>(data);
                return;
            }

            var temp = new Node<T>(Head.data);

            temp.next = Head.next;

            Head.next = temp;

            Head.data = data;
        }

        public void Remove()
        {
            if (Head == null) return;

            if (Head.next != null)
            {
                Head.data = Head.next.data;
                Head.next = Head.next.next;
            }
            else
                Head = null;
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return new ListEnumerator<T>(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new ListEnumerator<T>(this);
        }

        class Node<T1>
        {
            public T1 data;

            public Node<T1> next;

            public Node(T1 data)
            {
                this.data = data;
                next = null;
            }
        }
        class ListEnumerator<T2> : IEnumerator<T2>
        {
            private List<T2> list;

            T2 IEnumerator<T2>.Current { get { return current.data; } }

            object IEnumerator.Current { get { return current.data; } }

            private List<T2>.Node<T2> current;

            public ListEnumerator(List<T2> list)
            {
                this.list = list;
                current = null;
            }

            public bool MoveNext()
            {
                if (list.Head == null)
                    return false;

                if (current == null)
                {
                    current = list.Head;
                    return true;
                }
                if (current.next != null)
                {
                    current = current.next;
                    return true;
                }
                else return false;
            }
            public void Reset()
            {
                current = list.Head;
            }
            void IDisposable.Dispose()
            {
                Reset();
            }

        }
    }
}