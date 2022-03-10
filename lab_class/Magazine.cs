using System;
using System.Collections.Generic;
using System.Text;

namespace lab_class {
    class Magazine:Item{
        private string category;
        private int price;

        public Magazine(string name, string category, int price):base(name) {
            this.price = price;
            this.category = category;
        }

        public override void lookAtItem() {
            Console.WriteLine("Он посмотрел на журнал и явно стал тупее.");
        }
    }
}
