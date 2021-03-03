using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();

            list.add(1);
            list.add(4);
            list.add(3);
            list.add(7);

            Console.WriteLine("El tamaño de la lista es: " + list.getSize());

            Iterator it = list.getIterator();
            ReverseIterator it2 = list.getReverseIterator();

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Recorrido inverso");

            while (it2.hasNext())
            {
                int element = it2.next();

                Console.WriteLine("Dato: " + element);
            }

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Recorrido normal");

            while (it.hasNext())
            {
                Iterator backupIt = new Iterator(it);
                int element = it.next();

                if (element == 3)
                {
                    list.insert(10, LinkedList.BEFORE, backupIt);
                }

                if (element == 7)
                {
                    list.insert(15, LinkedList.AFTER, backupIt);
                }

                Console.WriteLine("Dato: " + element);
            }


            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Lista con datos agregados");

            it = list.getIterator();

            while (it.hasNext())
            {
                int element = it.next();

                Console.WriteLine("Dato: " + element);
            }

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Recorrido inverso con datos agregados");

            it2 = list.getReverseIterator();

            while (it2.hasNext())
            {
                int element = it2.next();

                Console.WriteLine("Dato: " + element);
            }
        }
    }
}
