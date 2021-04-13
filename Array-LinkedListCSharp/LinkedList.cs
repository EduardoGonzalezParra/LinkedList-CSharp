using System;
using System.Collections.Generic;
using System.Text;

namespace Array_LinkedListCSharp
{
    public class LinkedList<G> : List<G>
    {

        private Node<G> head;
        private Node<G> tail;
        private int size;

        public void add(G data)
        {
            Node<G> node = new Node<G>(data);

            node.setPrevious(tail);

            if (tail != null)
            {
                tail.setNext(node);
            }

            if (head == null)
            {
                head = node;
            }

            tail = node;
            size++;
        }

        public int getSize()
        {
            return size;
        }

        public G get(int index)
        {
            Node<G> currentNode = head;
            int currentIndex = 0;

            while (currentNode != null && currentIndex < index)
            {
                currentNode = currentNode.getNext();
                currentIndex++;
            }

            return currentNode.getData();
        }

        public void delete(int index)
        {
            Node<G> currentNode = head;
            int currentIndex = 0;

            if (index < 0 || index >= size)
            {
                return;
            }

            size--;

            if (size == 0)
            {
                head = null;
                tail = null;
                return;
            }

            if (index == 0)
            {
                head = head.getNext();
                head.setPrevious(null);
            }

            if (index == size - 1)
            {
                tail = tail.getPrevious();
                tail.setNext(null);
            }

            if (index > 0 && index < size - 1)
            {
                while (currentNode != null && currentIndex < index)
                {
                    currentNode = currentNode.getNext();
                    currentIndex++;
                }
                currentNode.getPrevious().setNext(currentNode.getNext());
                currentNode.getNext().setPrevious(currentNode.getPrevious());
            }
        }

        public Iterator<G> getIterator()
        {
            return null; //(new ForwardIterator)
        }
        public Iterator<G> getReverseIterator()
        {
            return null; //(new ReverseIterator)
        }


        internal class ForwardIterator : Iterator<G>
        {
            private Node<G> currentNode;

            public ForwardIterator(ForwardIterator iterator)
            {
                currentNode = iterator.currentNode;
            }

            public bool hasNext()
            {
                return currentNode != null;
            }

            public G next()
            {
                G data = currentNode.getData();

                currentNode = currentNode.getNext();

                return data;
            }

            Node<G> getCurrentNode()
            {
                return currentNode;
            }
        }





        public class ReverseIterator : Iterator<G>
        {
            private Node<G> currentNode;

            public ReverseIterator(ReverseIterator iterator)
            {
                currentNode = iterator.currentNode;
            }

            public bool hasNext()
            {
                return currentNode != null;
            }

            public G next()
            {
                G data = currentNode.getData();

                currentNode = currentNode.getPrevious();

                return data;
            }
        }



        public class Node<T>
        {
            internal T data;
            internal Node<T> previous;
            internal Node<T> next;

            public Node(T data)
            {
                this.data = data;
            }

            public T getData()
            {
                return data;
            }

            public void setData(T data)
            {
                this.data = data;
            }

            public Node<T> getNext()
            {
                return next;
            }

            public void setNext(Node<T> next)
            {
                this.next = next;
            }

            public Node<T> getPrevious()
            {
                return previous;
            }

            public void setPrevious(Node<T> previous)
            {
                this.previous = previous;
            }

        }
        //



    }
}
