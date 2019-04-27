using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MegaLab
{
    public class GenProduct<T> : IName<T>
        where T : IComparable
    {

        private T name;
        private decimal price;
        public GenProduct() {}   
        public GenProduct(T name, decimal price=0)
        {
            Name = name; Price = price;
        }
        public int CompareTo(object obj)
        {
            if (obj == null)
                return 1;
            IName<T> otherProd = obj as IName<T>;
            if (otherProd != null)
            {
                if(otherProd.Name.Equals(this.Name))
                {
                    return 0;
                }
                return this.Name.CompareTo(otherProd.Name);
            }
            throw new LiteratureException($"Object {obj} is not a {nameof(IName<T>)} type");
        }
        public T Name
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

        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value < 0)
                    throw new LiteratureException($"Price {value} can`t be negative (You do want to pay someone, who just gives this book away from You?).");
                price = value;
            }
        }
        public override string ToString()
        {
            return $"Name:{Name}, Price:{Price}";
        }
    }
    


    public class GenLiterature<T> : GenProduct<T>
        where T: IComparable
    {
        public GenLiterature() { }

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
        public GenLiterature(T name, decimal price = 0.00M, string language = "English", int pages = 0, int year = 2000) : base(name, price)
        {
            Language = language; Pages = pages; Year = year;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Language: {Language}, Year: {Year}, Pages: {Pages}";
        }
    }

    public class GenFiction<T> : GenLiterature<T>
        where T: IComparable
    {
        public GenFiction() { }
        public GenFiction(T name, decimal price = 0.0M, string language = "Language", int pages = 0, int year = 2000, string[] authors = null) : base(name, price, language, pages, year)
        {
            Authors = authors;
        }

        private string[] authors;

        public string[] Authors
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
            if(Array == null)
                throw new LiteratureException("Array is initialized by null.");
            StringBuilder All = new StringBuilder();
            for (int i = 0; i < Array.Length; i++)
                All.Append($"{Array[i]}, ");
            return All.ToString().Trim(new char[] { ' ', ',' });
        }


        public override string ToString() { return $"{base.ToString()} Authors: {GetArray(Authors)}"; }
    }
    public class GenMagazine<T> : GenLiterature<T>
        where T: IComparable
    {
        private string publisher;
        private string period;
        private int number;

        public GenMagazine() { }

        public GenMagazine(T name, decimal price = 0.00M, string language = "Language", int pages = 0, int year = 2000, int number = 0, string publisher = "Publisher", string period = "Period") : base(name, price, language, pages, year)
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
    public class GenComics<T> : GenFiction<T>
        where T: IComparable
    {
        private string[] artists, characters;
        private string universe;

        public GenComics() { }

        public GenComics(T name, decimal price = 0.00M, string language = "Language", int pages = 0, int year = 2000, string[] authors = null, string[] artists = null, string universe = "Universe", string[] characters = null) : base(name, price, language, pages, year, authors)
        {
            Artists = artists; Universe = universe; Characters = characters;
        }
        public string[] Artists
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

        public string[] Characters
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
        public override string ToString() { return $"{base.ToString()}, Artists: {GetArray(Artists)}, Universe: {Universe}, Characters: {GetArray(Characters)}"; }
    }
    public class GenBook<T> : GenFiction<T>
        where T:IComparable
    {
        private string cover;
        private string genre;
        public GenBook() { }
        public GenBook(T name, decimal price = 0.00M, string language = "Language", int pages = 0, int year = 2000, string[] authors = null, string genre = "Genre", string cover = "Cover")
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