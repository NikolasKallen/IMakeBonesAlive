using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaLab
{
    public class LiteratureException:Exception
    {
        public LiteratureException() : base("Literature exception.") { }
        public LiteratureException(string message) : base(message) { }
        public LiteratureException(string message, Exception innerException) : base(message,innerException) { }
    }
    public class CollectionException:Exception
    {
        public CollectionException() : base("Collection exception.") { }
        public CollectionException(string message) : base(message) { }
        public CollectionException(string message, Exception innerException) : base(message,innerException) { }
    }
}
