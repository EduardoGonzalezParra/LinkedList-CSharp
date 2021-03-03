using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class ReverseIterator
    {
        private Node currentNode;

        public ReverseIterator(Node currentNode)
        {
            this.currentNode = currentNode;
        }

        public ReverseIterator(ReverseIterator iterator)
        {
            currentNode = iterator.currentNode;
        }

        public Boolean hasNext()
        {
            return currentNode != null;
        }

        public int next()
        {
            int data = currentNode.getData();

            currentNode = currentNode.getPrevious();

            return data;
        }
    }
}
