using System;
using System.Collections.Generic;
using System.Text;

namespace Array_LinkedListCSharp
{
    public interface List<T>
    {

        void add(T data);

        int getSize();

        T get(int index);

        void delete(int index);

        Iterator<T> getIterator();

        Iterator<T> getReverseIterator();

        //void insert(T data, Position position, Iterator<T> it);
        //
    }
}
