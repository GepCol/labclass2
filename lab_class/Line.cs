using System;
using System.Collections.Generic;
using System.Text;

namespace lab_class {
    class Line {
        private Point p1, p2;

        public Line(Point p1, Point p2) {
            this.p1 = p1;
            this.p2 = p2;
        }

        public double length() {
            return p1.dist(p2);
        }

        public override string ToString() {
            return $"Линия({p1}, {p2})";
        }
    }
}
