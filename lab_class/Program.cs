using System;
using System.Collections.Generic;

namespace lab_class {
    class Program {
        public static Random r = new Random();
        static List<Item> polki = new List<Item>();
        static void Main(string[] args) {
            Guy guy = new Guy("Вова");
            Console.WriteLine($"Решил {guy} сходить в магазин, да затариться. Что там с навигатором?");
            Point home = new Point(r.Next(0,100), r.Next(0, 100));
            Point shop = new Point(r.Next(0, 100), r.Next(0, 100));
            Console.WriteLine($"Так, навигатор показывает: из дома ({home}) до магазина ({shop}) на ракетной установке лететь нужно всего {new Line(home,shop).length()} метров!");
            polki.Add(new Book("Война и Мир", "Л.Н.Толстой", "Художественные", 99999, 2014));
            polki.Add(new Book("Пирог и Сыр", "К.Т.Чел", "Кулинария", 20, 2013));
            polki.Add(new Book("Офшор и Кипр", "Р.Н.Парень", "Финансы", 102, 2016));
            polki.Add(new Magazine("fetifashion", "fashion", 20));
            polki.Add(new Magazine("giveusyourmoney", "fashion", 25));
            polki.Add(new Magazine("bemorestupid", "fashion", 30));
            int i = 3;
            while (i-- > 0) {
                guy.take(ref polki, polki[r.Next(0,polki.Count-1)]);
            }
            Console.WriteLine($"Закупился наш Вова, и начал смотреть, что купил.");

            foreach (Item item in guy.inventory) {
                Console.WriteLine((item is Book ? "Книга":"Журнал")+$" '{item.name}'... Качество попалось... {item.q}.");
                item.lookAtItem();
            }
        }
    }
}
