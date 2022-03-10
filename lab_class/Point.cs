using System;
using System.Collections.Generic;
using System.Text;

namespace lab_class {
    class Point {
        public int x, y;

        public Point(int x, int y) {
            this.x = x;
            this.y = y;
        }

        public double dist(Point p) {
            return Math.Sqrt((p.x - x) * (p.x - x) + (p.y - y) * (p.y - y));
        }

        public override string ToString() {
            return $"Точка({x}, {y})";
        }
    }
}
