using System;
using System.Collections.Generic;
using System.Text;

namespace lab_class {
    abstract class Item {
        public Quality q;
        public string name;

        public Item(string name, Quality q) {
            this.name = name;
            this.q = q;
        }
        public Item(string name) {
            this.name = name;
            q = randomQuality();
        }

        public abstract void lookAtItem();

        public static Quality randomQuality() {
            Array qs = Enum.GetValues(typeof(Quality));
            return (Quality)qs.GetValue(Program.r.Next(0, qs.Length - 1));
        }
    }
}
