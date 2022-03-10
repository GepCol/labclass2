using System;
using System.Collections.Generic;
using System.Text;

namespace lab_class {
    class Guy {
        public string name;
        public List<Item> inventory = new List<Item>();

        public Guy(string name) {
            this.name = name;
        }
        
        public void take(ref List<Item> from, Item item) {
            inventory.Add(item);
            from.Remove(item);
        }

        public override string ToString() {
            return name;
        }
    }
}
