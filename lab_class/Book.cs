using System;
using System.Collections.Generic;
using System.Text;

namespace lab_class {
    class Book : Item{
        private string author, category;
        private int pages, year;

        private static int price;

        public Book(string name, string author):base(name) {
            setBook(author, "Другое", 0, 0);
        }

        public Book(string name, string author, string category, int pages, int year):base(name) {
            setBook(author, category, pages, year);
        }

        public void show() {
            Console.WriteLine($"[{name}] by {author}, {pages} стр.");
            Console.WriteLine($"Год печати: {year};");
            Console.WriteLine($"Категория: {category};");
            Console.WriteLine($"Все книги можно арендовывать по {price}р/день, либо по {price*7}р/неделю.");
        }

        public void setBook(string author, string category, int pages, int year) {
            this.author = author;
            this.category = category;
            this.pages = pages;
            this.year = year;
        }

        public override void lookAtItem() {
            Console.WriteLine("Он посмотрел на книгу и явно стал умнее.");
        }

        static Book() {
            price = 10;
        }
    }
}
