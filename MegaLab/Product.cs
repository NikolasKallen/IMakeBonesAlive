using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace MegaLab
{
    public class ChangePriceArgs : EventArgs
    {
        public decimal PriceChange;
        public ChangePriceArgs(decimal PriceChange)
        {
            this.PriceChange = PriceChange;
        }
    }

    [Serializable]
    public class Product : IName,IComparable<Product>,ISerializable
    {
        public event EventHandler<ChangePriceArgs> PriceChanged;

        private string name;
        private decimal price = 0;
        public Product() { }        
        public Product(string name="Product", decimal price=0)
        {
            Name = name; Price = price;
        }
        public int CompareTo(object obj)
        {
            if (obj == null)
                return 1;
            Product otherProd = obj as Product;
            if (otherProd != null)
            {
                return CompareTo(otherProd);
            }
            throw new LiteratureException($"Object {obj} is not a {nameof(IComparable)} type");
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        protected virtual void OnPriceChange(ChangePriceArgs e)
        {
            EventHandler<ChangePriceArgs> handler = PriceChanged;
            if(handler != null) handler(this,e);
        }


        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {                
                OnPriceChange(new ChangePriceArgs(value - price));
                if (value < 0)
                    throw new LiteratureException($"Price {value} can`t be negative (You do want to pay someone, who just gives this book away from You?).");
                price = value;
            }
        }
        public override string ToString()
        {
            return $"Name:{Name}, Price:{Price}";
        }

        public int CompareTo(Product other)
        {
            
                if (other.Name.Equals(this.Name))
                {
                    return 0;
                }
                return this.Name.CompareTo(other.Name);
            
        }
        protected Product(SerializationInfo info, StreamingContext context)
        {
            Name = info.GetString("Name");
            Price = info.GetDecimal("Price");
        }
        [SecurityPermissionAttribute(SecurityAction.Demand,SerializationFormatter = true)]
        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name",Name);
            info.AddValue("Price",Price);
        }
    }


    [Serializable]
    public class Literature : Product
    {
        public Literature() { }
        protected Literature(SerializationInfo info, StreamingContext context)
            :base(info,context)
        {
            Language = info.GetString("Language");
            Pages = info.GetInt32("Pages");
            Year = info.GetInt32("Year");
        }
        [SecurityPermissionAttribute(SecurityAction.Demand,SerializationFormatter =true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("Language",Language);
            info.AddValue("Pages", Pages);
            info.AddValue("Year",Year);
        }
        private string language;
        private int pages;
        private int year;

        public string Language
        {
            get
            {
                return language;
            }
            set
            {
                language = value;
            }
        }

        public int Pages
        {
            get
            {
                return pages;
            }
            set
            {
                if(value <= 0)
                {
                    throw new LiteratureException($"Amount of pages {value} can`t be negative.");
                }
                pages = value;
            }
        }

        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                if (value < 1900 || value > DateTime.Now.Year)
                    throw new LiteratureException($"Year {value} is invalid.");
                year = value;
            }
        }
        /// <summary>
        /// Литература
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="price">Цена</param>
        /// <param name="language">Язык книги</param>
        /// <param name="pages">Количество страниц</param>
        /// <param name="year">Год написанаия</param>
        public Literature(string name = "Literature", decimal price = 0.00M, string language = "English", int pages = 1, int year = 2000) : base(name, price)
        {
            Language = language; Pages = pages; Year = year;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Language: {Language}, Year: {Year}, Pages: {Pages}";
        }
    }
    [Serializable]
    public class Fiction : Literature
    {
        public Fiction() { }
        protected Fiction(SerializationInfo info, StreamingContext context)
            :base(info,context)
        {
            authors = info.GetString("Authors");
        }
        [SecurityPermissionAttribute(SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info,context);
            info.AddValue("Authors",Authors);
        }
        public Fiction(string name = "Fiction", decimal price = 0.0M, string language = "Language", int pages = 0, int year = 2000, string authors = "Authors") : base(name, price, language, pages, year)
        {
            Authors = authors;
        }

        private string authors;

        public string Authors
        {
            get
            {
                return authors;
            }
            set
            {
                authors = value;
            }
        }
        protected string GetArray(string[] Array)
        {
            if (Array == null)
                //throw new LiteratureException("Array is initialized by null.");
                return "";
            StringBuilder All = new StringBuilder();
            for (int i = 0; i < Array.Length; i++)
                All.Append($"{Array[i]}, ");
            return All.ToString().Trim(new char[] { ' ', ',' });
        }


        public override string ToString() { return $"{base.ToString()} Authors: {Authors}"; }
    }
    [Serializable]
    public class Magazine : Literature
    {
        private string publisher;
        private string period;
        private int number;

        public Magazine() { }
        protected Magazine(SerializationInfo info, StreamingContext context)
            :base(info,context)
        {
            Publisher = info.GetString("Publisher");
            Period = info.GetString("Period");
            Number = info.GetInt32("Number");
        }
        [SecurityPermissionAttribute(SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("Publisher",Publisher);
            info.AddValue("Period",Period);
            info.AddValue("Number",Number);
        }
        public Magazine(string name = "Magazine", decimal price = 0.00M, string language = "Language", int pages = 1, int year = 2000, int number = 0, string publisher = "Publisher", string period = "Period") : base(name, price, language, pages, year)
        {
            Publisher = publisher; Period = period; Number = number;
        }

        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                if (value < 0)
                {
                    throw new LiteratureException($"Magazine number {value} can`t be negative.");
                }
                number = value;
            }
        }

        public string Publisher
        {
            get
            {
                return publisher;
            }
            set
            {
                publisher = value;
            }
        }

        public string Period
        {
            get
            {
                return period;
            }
            set
            {
                period = value;
            }
        }

        public override string ToString() { return $"{base.ToString()}, № {Number}, Publisher: {Publisher}, Period: {Period}"; }
    }
    [Serializable]
    public class Comic : Fiction
    {
        private string artists, characters;
        private string universe;
        protected Comic(SerializationInfo info, StreamingContext context)
            :base(info,context)
        {
            Artists = info.GetString("Artists");
            Characters = info.GetString("Characters");
            Universe = info.GetString("Universe");
        }
        [SecurityPermissionAttribute(SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("Artists",Artists);
            info.AddValue("Characters",Characters);
            info.AddValue("Universe",Universe);
        }
        public Comic() { }

        public Comic(string name = "Name", decimal price = 0.00M, string language = "Language", int pages = 1, int year = 2000, string authors = "Authors", string artists = "Artists", string universe = "Universe", string characters = "Characters") : base(name, price, language, pages, year, authors)
        {
            Artists = artists; Universe = universe; Characters = characters;
        }
        public string Artists
        {
            get
            {
                return artists;
            }

            set
            {
                artists = value;
            }
        }

        public string Universe
        {
            get
            {
                return universe;
            }
            set
            {
                universe = value;
            }
        }

        public string Characters
        {
            get
            {
                return characters;
            }
            set
            {
                characters = value;
            }
        }
        public override string ToString() { return $"{base.ToString()}, Artists: {Artists}, Universe: {Universe}, Characters: {Characters}"; }
    }
    [Serializable]
    public class Book : Fiction
    {
        protected Book(SerializationInfo info, StreamingContext context)
            :base(info,context)
        {
            Cover = info.GetString("Cover");
            Genre = info.GetString("Genre");
        }
        [SecurityPermissionAttribute(SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("Cover", Cover);
            info.AddValue("Genre", Genre);
        }
        private string cover;
        private string genre;
        public Book()
        {
        }
        public Book(string name = "Book", decimal price = 0.00M, string language = "Language", int pages = 1, int year = 2000, string authors = null, string genre = "Genre", string cover = "Cover")
            : base(name, price, language, pages, year, authors)
        {
            Genre = genre;
            Cover = cover;
        }

        public string Genre
        {
            get
            {
                return genre;
            }
            set
            {
                genre = value;
            }
        }
        public string Cover
        {
            get
            {
                return cover;
            }
            set
            {
                cover = value;
            }
        }
        public override string ToString()
        {
            return $"{base.ToString()}, Genre: {Genre}, Cover: {Cover}";
        }
    }
}