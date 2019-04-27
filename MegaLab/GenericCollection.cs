using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MegaLab
{
    public abstract class AbstractGenCollection<T>:IEnumerable<T>
        where T:IComparable<T>
    {
        abstract public IEnumerator<T> GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public delegate int SortBy(T a, T b);
        public delegate bool Requiem(T a);
        private void QuickSort(int start, int finish, SortBy SDel)
        {
            int i = start, j = finish;
            T buf;
            T center = this[(start + finish) / 2];
            while (i <= j)
            {
                while (SDel(this[i], center) < 0)//this[i].CompareTo(center) < 0)
                    i++;
                while (SDel(this[j], center) > 0)//this[j].CompareTo(center) > 0)
                    j--;
                if (i <= j)
                {
                    buf = this[i];
                    this[i] = this[j];
                    this[j] = buf;
                    i++;
                    j--;
                }
            }
            if (start < j)
                QuickSort(start, j, SDel);
            if (i < finish)
                QuickSort(i, finish, SDel);
        }
        public IEnumerable<T> Find(Requiem requiements)
        {
            foreach (T item in this)
            {
                if (requiements(item))
                {
                    yield return item;
                    yield break;
                }
            }
            throw new Exception("Collection doesn't have any item that match this requiement");
        }
        public IEnumerable<T> FindAll(Requiem requiements)
        {
            foreach (T item in this)
            {
                if (requiements(item))
                {
                    yield return item;
                }
            }
        }
        public void Sort(SortBy SDeleg)
        {
            QuickSort(0, Length - 1, SDeleg);
        }
        public abstract int Length { get; protected set; }
        public abstract void Add(T product);
        public void Add(T[] products)
        {
            for (int i = 0; i < products.Length; i++)
                Add(products[i]);
        }

        public void Add(AbstractGenCollection<T> products)
        {
            for (int i = 0; i < products.Length; i++)
                Add(products[i]);
        }
        private void QuickSort(int start, int finish)
        {
            int i = start, j = finish;
            T buf;
            T center = this[(start + finish) / 2];
            while (i <= j)
            {
                while (this[i].CompareTo(center) < 0)
                    i++;
                while (this[j].CompareTo(center) > 0)
                    j--;
                if (i <= j)
                {
                    buf = this[i];
                    this[i] = this[j];
                    this[j] = buf;
                    i++;
                    j--;
                }
            }
            if (start < j)
                QuickSort(start, j);
            if (i < finish)
                QuickSort(i, finish);
        }
        public void Sort()
        {
            QuickSort(0, Length - 1);
        }
        public abstract T this[int i] { get; set; }
        public abstract T this[string name] { get; }
        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            if (Length == 0)
            {
                return "";
            }
            for (int i = 0; i < Length; i++)
            {
                s.Append(this[i].ToString() + " ");
            }
            return s.ToString();
        }
    }
    public abstract class AbstractGenList<T> : AbstractGenCollection<T>
        where T: IComparable<T>
    {

        public class Node<U> where U:T
        {
            public Node<U> previous = null;
            public Node<U> next = null;
            public U data;
        }
        int length = 0;
        public override int Length { get { return length; } protected set { length = value; } }
        public abstract void Remove(int index);
        protected abstract Node<T> Find(int i);
        protected abstract Node<T> Find(string product);
        public void Clear()
        {
            while (Length > 0)
                Remove(0);
        }
        public override T this[int i]
        {
            get
            {
                return Find(i).data;
            }
            set
            {
                Find(i).data = value;
            }
        }
        public override T this[string name]
        {
            get
            {
                return Find(name).data;
            }
        }

        ~AbstractGenList()
        {
            Clear();
        }
    }
    /// <summary>
    /// <head>
    /// Двухсвязный контейнер-список с ccылками на начало и конец
    /// </head>
    /// </summary>
    public class GenListContainer<T> : AbstractGenList<T>,IEnumerable<T>
        where T: IComparable<T>
    {
        Node<T> First = null;
        Node<T> Last = null;

        public IEnumerable<T> SubstringInName(string Name)
        {
            for (Node<T> n = First; n != null; n = n.next)
            {
                if (n.data.ToString().Contains(Name))
                {
                    yield return n.data;
                }
            }
        }

        public IEnumerable<T> BottomToTop
        {
            get
            {
                for (Node<T> n = Last; n != null; n = n.previous)
                {
                    yield return n.data;
                }
            }
        }
        public override IEnumerator<T> GetEnumerator()
        {
            GenListIterator<T> genListIterator = new GenListIterator<T>(First);
            return genListIterator;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerable<T> SortCollection()
        {
                GenListContainer<T> gen = new GenListContainer<T>();
                foreach (T item in this)
                {
                    gen.Add(item);
                }
                gen.Sort();
                foreach (T item in gen)
                {
                    yield return item;
                }
        }
        public GenListContainer() { }
        public GenListContainer(T product)
        {
            Add(product);
        }
        public GenListContainer(T[] products)
        {
            Add(products);
        }
        public GenListContainer(AbstractGenCollection<T> products)
        {
            for (int i = 0; i < products.Length; i++)
                Add(products[i]);
        }
        public override void Add(T product)
        {
            Node<T> n = new Node<T>();
            n.data = product;
            if (First == null)
            {
                First = n;
                Last = First;
            }
            else
            {
                Last.next = n;
                n.previous = Last;
            }
            Last = n;
            Length++;
        }

        

        public override void Remove(int index)
        {
            Node<T> n = Find(index);
            if (n.next != null && n.previous != null)
            {
                n.previous.next = n.next;
                n.next.previous = n.previous;
            }
            else
            {
                if (n.previous != null)
                {
                    n.previous.next = null;
                    Last = n.previous;
                }
                else
                {
                    if (n.next != null)
                    {
                        n.next.previous = null;
                        First = n.next;
                    }
                    else
                    {
                        First = null;
                        Last = null;
                    }
                }
            }
            n.next = null;
            n.previous = null;
            Length--;
        }
        protected override Node<T> Find(int i)
        {
            if (i >= 0 && i < Length)
            {
                int k = 0;
                for (Node<T> n = First; n != null; n = n.next, ++k)
                {
                    if (k == i)
                        return n;
                }
            }
            throw new IndexOutOfRangeException($"Index \"{i}\" is out of range of collection {nameof(GenListContainer<T>)}");
        }
        protected override Node<T> Find(string product)
        {
            for (Node<T> n = First; n != null; n = n.next)
            {
             if (n.data.ToString().Equals(product))
                    return n;
            }
            throw new CollectionException($"Name \"{product}\" is not in collection {nameof(GenListContainer<T>)}");
        }
    }
    /// <summary>
    /// <head>
    /// Двухсвязный контейнер-список с началом и концом в виде отдельных элементов
    ///</head> 
    /// </summary>
    public class GenListContainerN<T> : AbstractGenList<T>, IEnumerable<T>
        where T: IComparable<T>
    {
        public IEnumerable<T> SubstringInName(string Name)
        {
            for (Node<T> n = First.next; n.next != null; n = n.next)
            {
                if (n.data.ToString().Contains(Name))
                {
                    yield return n.data;
                }
            }
        }
        public IEnumerable<T> BottomToTop
        {
            get
            {
                for (Node<T> n = Last.previous; n.previous != null; n = n.previous)
                {
                    yield return n.data;
                }
            }
        }
        public IEnumerable<T> SortCollection()
        {
            GenListContainer<T> gen = new GenListContainer<T>();
            foreach (T item in this)
            {
                gen.Add(item);
            }
            gen.Sort();
            foreach (T item in gen)
            {
                yield return item;
            }
        }

        public override IEnumerator<T> GetEnumerator()
        {
            GenListIterator<T> genIterator = new GenListIterator<T>(First.next);
            return genIterator;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        Node<T> First = new Node<T>();
        Node<T> Last = new Node<T>();
        public GenListContainerN() { }
        public GenListContainerN(T product)
        {
            Add(product);
        }
        public GenListContainerN(T[] products)
        {
            Add(products);
        }
        public GenListContainerN(AbstractGenCollection<T> products)
        {
            Add(products);
        }
        public override void Add(T product)
        {
            Node<T> n = new Node<T>();
            n.data = product;
            if (First.next == null)
            {
                First.next = n;
                n.previous = First;
                Last.previous = n;
                n.next = Last;
            }
            else
            {
                Last.previous.next = n;
                n.previous = Last.previous;
                n.next = Last;
            }
            Last.previous = n;
            Length++;
        }
        public override void Remove(int index)
        {
            Node<T> n = Find(index);
            if (n.next != null && n.previous != null)
            {
                n.previous.next = n.next;
                n.next.previous = n.previous;
            }
            n.next = null;
            n.previous = null;
            Length--;
            if (Length == 0)
            {
                First.next = null;
                Last.previous = null;
            }
        }
        protected override Node<T> Find(int i)
        {
            if (i >= 0 && i < Length)
            {
                int k = 0;
                for (Node<T> n = First.next; n != null; n = n.next, ++k)
                {
                    if (k == i)
                        return n;
                }
            }
            throw new IndexOutOfRangeException($"Index \"{i}\" is out of range of collection {nameof(GenListContainerN<T>)}");

        }
        protected override Node<T> Find(string product)
        {
            for (Node<T> n = First.next; n != null; n = n.next)
            {
                if (n.data.ToString().Contains(product))
                {
                    return n;
                }
            }
            throw new CollectionException($"Name \"{product}\" is not in collection {nameof(GenListContainerN<T>)}");
        }
    }
    /// <summary>
    /// <head>
    /// Контейнер на основе массива Product
    /// </head>
    /// </summary>
    public class GenContainer<T> : AbstractGenCollection<T>, IEnumerable<T>
        where T: IComparable<T>
    {
        public IEnumerable<T> SubstringInName(string Name)
        {
            for (int i = 0; i < Length; i++)
            {
                if (this[i].ToString().Contains(Name))
                {
                    yield return this[i];
                }
            }
        }
        public IEnumerable<T> BottomToTop
        {
            get
            {
                for (int i = Length - 1; i >= 0; i--)
                {
                    yield return this[i];
                }
            }
        }
        public IEnumerable<T> SortedContainer()
        {
            GenContainer<T> container = new GenContainer<T>(dat);
            container.Sort();
            foreach (T c in container)
            {
                yield return c;
            }
        }
        public override IEnumerator<T> GetEnumerator()
        {
            GenIterator<T> genIterator = new GenIterator<T>(this);
            return genIterator;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        private int allocLength => dat == null ? 0 : dat.Length;
        private int length;
        private T[] dat = null;
        public GenContainer() { }
        public GenContainer(T product)
        {
            Add(product);
        }
        public GenContainer(T[] products)
        {
            Add(products);
        }
        public GenContainer(AbstractGenCollection<T> products)
        {
            Add(products);
        }
        public GenContainer
            (int size)
        {
            dat = new T[size];
        }
        public override int Length
        {
            get
            {
                return length;
            }
            protected set { length = value; }
        }
        public override void Add(T p)
        {
            if (Length >= allocLength)
            {
                T[] temp = new T[3 * allocLength / 2 + 1];
                for (int i = 0; i < Length; i++)
                {
                    temp[i] = dat[i];
                }
                dat = temp;
            }
            dat[Length++] = p;
        }

        public void Remove(int Index)
        {
            if (Index < 0 || Index >= Length)
            {
                throw new IndexOutOfRangeException($"Index {Index} is out of range of Container");
            }
            for (int i = Index; i < dat.Length; i++)
            {
                dat[i + 1] = dat[i];
            }
        }

        public override T this[int index]
        {
            get
            {
                return dat[index];
            }
            set
            {
                dat[index] = value;
            }
        }
        public override T this[string Name]
        {
            get
            {
                for (int i = 0; i < Length; i++)
                {
                  if(dat[i].ToString().Equals(Name))
                    return dat[i];
                }
                throw new CollectionException($"Name {Name} is not in Container.");
            }
        }
        public void Clear()
        {
            dat = null;
        }
    }
}
