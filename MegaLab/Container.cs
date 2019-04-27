using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MegaLab
{
    [Serializable]
    public abstract class AbstractCollection:IEnumerable
    {
     //   public IEnumerable<Product> Cheaper = 
        public abstract IEnumerator GetEnumerator();
        public decimal SumPrice
        {
            get
            {
                return sum;
            }
        }


        public delegate int SortBy(Product a, Product b);
        public delegate bool Requiem(Product a);
        protected decimal sum = 0;
        public abstract int Length { get; protected set; }
        public abstract Product this[int i] { get; set; }
        public abstract Product this[string name] { get; }
        private void OnPriceChange(object sender, ChangePriceArgs e)
        {
            sum += e.PriceChange;
        }
        public virtual void Add(Product product)
        {
            sum += product.Price;
            product.PriceChanged += OnPriceChange;
        }
        public virtual void Remove(int index)
        {
            sum -= this[index].Price;
            this[index].PriceChanged -= OnPriceChange;
        }
        public void Add(Product[] products)
        {
            for (int i = 0; i < products.Length; i++)
                Add(products[i]);
        }
        public void Add(AbstractCollection products)
        {
            for (int i = 0; i < products.Length; i++)
                Add(products[i]);
        }

        private void QuickSort(int start, int finish,SortBy SDel)
        {
            int i = start, j = finish;
            Product buf;
            Product center = this[(start + finish) / 2];
            while (i <= j)
            {
                while (SDel(this[i] , center)<0)//this[i].CompareTo(center) < 0)
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
        public IEnumerable Find(Requiem requiements)
        {
            foreach (Product item in this)
            {
                if (requiements(item))
                {
                    yield return item;
                    yield break;
                }
            }
            throw new Exception("Collaction hasn`t any item that match this requiement");
        }
        public IEnumerable FindAll(Requiem requiements)
        {
            foreach(Product item in this)
            {
                if(requiements(item))
                {
                    yield return item;
                }
            }
        }
        public void Sort(SortBy SDeleg)
        {
            QuickSort(0, Length - 1,SDeleg);
        }
        private void QuickSort(int start, int finish)
        {
            int i = start, j = finish;
            Product buf;
            Product center = this[(start + finish) / 2];
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
    [Serializable]
    public abstract class AbstractList:AbstractCollection
    {
        public class Node
        {
            public Node previous = null;
            public Node next = null;
            public Product data;
        }
        int length = 0;
        public override int Length { get { return length; } protected set { length = value; } }

        public override void Add(Product product)
        {
            base.Add(product);
        }
        public override void Remove(int index)
        {
            base.Remove(index);
        }
        protected abstract Node Find(int i);
        protected abstract Node Find(string product);
        public void Clear()
        {
            while (Length > 0)
                Remove(0);
        }
        public override Product this[int i]
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
        public override Product this[string name]
        {
            get
            {
                return Find(name).data;
            }
        }
        
        ~AbstractList()
        {
            System.Diagnostics.Trace.WriteLine("Вызван деструктор AbstractList");
            Clear();
        }
    }
    /// <summary>
    /// <head>
    /// Двухсвязный контейнер-список с ccылками на начало и конец
    /// </head>
    /// </summary>
    [Serializable]
    public class ListContainer:AbstractList
    {
        public IEnumerator SubstringInName(string Name)
        {
            for (Node n = First; n != null; n = n.next)
            {
                if (n.data.ToString().Contains(Name))
                {
                    yield return n.data;
                }
            }
        }
        public IEnumerator BottomToTop
        {
            get
            {
                for (Node n = Last; n != null; n = n.previous)
                {
                    yield return n.data;
                }
            }
        }
        public override IEnumerator GetEnumerator()
        {
            ListIterator iterator = new ListIterator(First);
            return iterator;
        }
        Node First = null;
        Node Last = null;
        public ListContainer() { }
        public ListContainer(Product product)
        {
            Add(product);
        }
        public ListContainer(Product[] products)
        {
            Add(products);
        }
        public ListContainer(AbstractCollection products)
        {
            for(int i = 0; i < products.Length;i++)
                Add(products[i]);
        }
        public override void Add(Product product)
        {
            base.Add(product);
            Node n = new Node();
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
        public override void Remove (int index)
        {
            base.Remove(index);
            Node n = Find(index);
            if(n.next != null && n.previous!=null)
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
        protected override Node Find(int i)
        {
            if (i >= 0 && i < Length)
            {
                int k = 0;
                for (Node n = First; n != null; n = n.next, ++k)
                {
                    if (k == i)
                        return n;
                }
            }
            throw new IndexOutOfRangeException($"Index \"{i}\" is out of range of collection {nameof(ListContainer)}");
        }
        protected override Node Find(string product)
        {
            for (Node n = First; n != null; n = n.next)
            {
                    if (n.data.ToString().Equals(product))
                        return n;
            }
            throw new CollectionException($"Name \"{product}\" is not in collection {nameof(ListContainer)}");
        }
    }
    /// <summary>
    /// <head>
    /// Двухсвязный контейнер-список с началом и концом в виде отдельных элементов
    ///</head> 
    /// </summary>
    [Serializable]
    public class ListContainerN:AbstractList
    {
        public IEnumerator SubstringInName(string Name)
        {
            for (Node n = First.next; n.next != null; n = n.next)
            {
                if (n.data.ToString().Contains(Name))
                {
                    yield return n.data;
                }
            }
        }
        public IEnumerator BottomToTop
        {
            get
            {
                for (Node n = Last.previous; n.previous != null; n = n.previous)
                {
                    yield return n.data;
                }
            }
        }
        public override IEnumerator GetEnumerator()
        {
            ListIterator iterator = new ListIterator(First.next);
            return iterator;
        }
        Node First = new Node();
        Node Last = new Node();
        public ListContainerN() { }
        public ListContainerN(Product product)
        {
            Add(product);
        }
        public ListContainerN(Product[] products)
        {
            Add(products);
        }
        public ListContainerN(AbstractCollection products)
        {
            Add(products);
        }
        public override void Add(Product product)
        {
            base.Add(product);
            Node n = new Node();
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
            base.Remove(index);
            Node n = Find(index);
            if (n.next != null && n.previous != null)
            {
                n.previous.next = n.next;
                n.next.previous = n.previous;
            }
            n.next = null;
            n.previous = null;
            Length--;
            if(Length == 0)
            {
                First.next = null;
                Last.previous = null;
            }
        }
        protected override Node Find(int i)
        {
            if(i >= 0 && i < Length )
            {
                int k = 0;
                for (Node n = First.next; n != null; n = n.next, ++k)
                {
                    if (k == i)
                        return n;
                }
            }
            throw new IndexOutOfRangeException($"Index \"{i}\" is out of range of collection {nameof(ListContainerN)}");

        }
        protected override Node Find(string product)
        {
            for (Node n = First.next; n != null; n = n.next)
            {
                if(n.data.ToString().Equals(product))
                {
                    return n;
                }
            }
            throw new CollectionException($"Name \"{product}\" is not in collection {nameof(ListContainerN)}");
        }
    }
    /// <summary>
    /// <head>
    /// Контейнер на основе массива типа Product
    /// </head>
    /// </summary>
    [Serializable]
    public class Container : AbstractCollection
    {

        public IEnumerable SubstringInName(string Name)
        {
            for (int i = 0; i < Length; i++)
            {
                if (this[i].ToString().Contains(Name))
                {
                    yield return this[i];
                }
            }
        }
        public IEnumerable BottomToTop
        {
            get
            {
                for (int i = Length - 1; i >= 0; i--)
                {
                    yield return this[i];
                }
            }
        }
        public IEnumerable SortedContainer()
        {
            Container container = new Container(dat);
            container.Sort();
            foreach(Product c in container)
            {
                yield return c;
            }
        }
        public override IEnumerator GetEnumerator()
        {
            Iterator iterator = new Iterator(this);
            return iterator;
        }
        private int allocLength => dat == null ? 0 : dat.Length;
        private int length;
        private Product[] dat = null;
        public Container() { }
        public Container(Product product)
        {
            Add(product);
        }
        public Container(Product[] products)
        {
            Add(products);
        }
        public Container(AbstractCollection products)
        {
            Add(products);
        }
        public Container(int size)
        {
            dat = new Product[size];
        }
        public override int Length
        {
            get
            {
                return length;
            }
            protected set { length = value; }
        }
        public override void Add(Product p)
        {
            base.Add(p);
            if (Length >= allocLength)
            {
                //      1 * 3 / 2 = 1
                Product[] temp = new Product[3 * allocLength / 2 + 1];
                for (int i = 0; i < Length; i++)
                {
                    temp[i] = dat[i];
                }
                dat = temp;
            }
            dat[Length++] = p;
        }

        public override void Remove(int Index)
        {
            base.Remove(Index);
            if (Index < 0 || Index >= Length)
            {
                throw new IndexOutOfRangeException($"Index {Index} is out of range of Container");
            }
            for(int i = Index; i < Length; i++)
            {
                dat[i] = dat[i + 1];
            }
            Length--;
        }

        public override Product this[int index]
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
        public override Product this[string Name]
        {
            get
            {
                for (int i = 0; i < Length; i++)
                {
                  if (dat[i].ToString().Equals(Name))
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
