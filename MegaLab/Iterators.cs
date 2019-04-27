using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaLab
{
    class Iterator : IEnumerator
    {
        private readonly Container aggregate;
        int current = -1;
        public object Current { get { return aggregate[current]; } }
        public Iterator(Container aggregate)
        {
            this.aggregate = aggregate;
        }
        public bool MoveNext()
        {
            current++;
            return current < aggregate.Length;
        }
         public void Reset()
        {
            current = -1;
        }
    }

    class ListIterator : IEnumerator
    {
        private AbstractList.Node current;
        private AbstractList.Node head;
        public object Current { get { return current.data; } }
        public ListIterator(AbstractList.Node head)
        {
            current = head;
            this.head = head;
        }
        public object First()
        {
            return head.data;
        }
        bool StayHere = true;
        public bool MoveNext()
        {
            if (StayHere == true)
            {
                StayHere = false;
                return head != null;
            }
            current = current.next;
            if (current == null)
                return false;
            if (current.data == null)
                return false;
            return true;
        }
        public void Reset()
        {
            current = head;
            StayHere = true;
        }
    }

    class GenIterator<T>: IEnumerator<T>
        where T: IComparable<T>
    {
        private readonly GenContainer<T> aggregate;
        int current = -1;
        object IEnumerator.Current { get { return this.Current; } }        
        public T Current {
            get
            {
                if (aggregate[current] == null)
                    throw new Exception($"{aggregate[current].ToString()} is not an {nameof(T)} type");
                return aggregate[current];
            }
        }

        public GenIterator(GenContainer<T> aggregate)
        {
            this.aggregate = aggregate;
        }
        public bool MoveNext()
        {
            current++;
            return current < aggregate.Length;
        }
        public void Reset()
        {
            current = -1;
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~GenIterator() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }

    class GenListIterator<T> : IEnumerator<T>
        where T : IComparable<T>
    {
        
        private AbstractGenList<T>.Node<T> current;
        private AbstractGenList<T>.Node<T> head;
        object IEnumerator.Current { get { return this.Current; } }
        
        public T Current
        {
            get
            {
                return current.data;
            }
        }

        public GenListIterator(GenListContainer<T>.Node<T> head)
        {
            current = head;
            this.head = head;
        }
        bool StayHere = true;
        public bool MoveNext()
        {
            if(StayHere == true)
            {
                StayHere = false;
                return head!=null;
            }
            current = current.next;
            if (current == null)
                return false;
            return true;
        }
        public void Reset()
        {
            current = head;
            StayHere = true;
        }
        public void Dispose()
        {}
    }
}
