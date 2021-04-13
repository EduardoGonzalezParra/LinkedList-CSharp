using System;
using System.Collections.Generic;

namespace Array_LinkedListCSharp
{
    class Program
    {
        public static void Main(String[] args)
        {
            List<int> list = new LinkedList<int>();
            List<float> list2 = new LinkedList<float>();
            List<char> list3 = new LinkedList<char>();
            List<string> list4 = new LinkedList<string>();

            list.add(1);
            list.add(4);
            list.add(3);
            list.add(7);

            list2.add(1.4f);
            list2.add(5.74f);
            list2.add(9.324f);
            list2.add(0.4565f);

            list3.add('1');
            list3.add('A');
            list3.add('g');
            list3.add('+');

            list4.add("Programación");
            list4.add("Orientada");
            list4.add("A...");
            list4.add("Objetos");

            Iterator<int> it = list.getIterator();
            Iterator<int> it2 = list.getReverseIterator();
            Iterator<float> itFloat = list2.getIterator();
            Iterator<char> itChar = list3.getIterator();
            Iterator<string> itString = list4.getIterator();

            Console.WriteLine("El tamaño de la lista es: " + list.getSize());

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Recorrido inverso:");

            while (it2.hasNext())
            {
                int element = it2.next();

                Console.WriteLine("Dato: " + element);
            }


            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Recorrido normal:");

            //while(it.hasNext()){
            //    LinkedList.ForwardIterator backupIt = list.new ForwardIterator(it);
            //    int element = it.next();
            //
            //    if(element == 3){
            //        list.insert(10, Position.BEFORE, backupIt);
            //    }
            //
            //    if(element == 7){
            //        list.insert(15, Position.AFTER, backupIt);
            //    }
            //
            //    System.out.println("Dato: " + element);
            //}

            //System.out.println("-------------------------------------");
            //System.out.println("Lista con datos agregados:");

            it = list.getIterator();

            while (it.hasNext())
            {
                int element = it.next();

                Console.WriteLine("Dato: " + element);
            }
            Console.WriteLine("El tamaño de la lista es: " + list.getSize());

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Lista de flotantes:");

            itFloat = list2.getIterator();

            while (itFloat.hasNext())
            {
                float element = itFloat.next();

                Console.WriteLine("Dato: " + element);
            }

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Lista de caracteres:");

            itChar = list3.getIterator();

            while (itChar.hasNext())
            {
                char element = itChar.next();

                Console.WriteLine("Dato: " + element);
            }

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Lista de strings:");

            itString = list4.getIterator();

            while (itString.hasNext())
            {
                String element = itString.next();

                Console.WriteLine("Dato: " + element);
            }
        }
        //
    }
}
