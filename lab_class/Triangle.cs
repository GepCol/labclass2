using System;
using System.Collections.Generic;
using System.Text;

namespace lab_class {
    class Triangle {
        private double[] borders = new double[3];

        public Triangle(params double[] borders) {
            this.borders = borders;
        }

        public bool possible() {
            for (int i = 0; i < borders.Length; i++) {
                double sum = 0;
                for (int j = 0; j < borders.Length; j++) {
                    if (j != i) sum += borders[j];
                }
                if (sum < borders[i]) return false;
            }
            return true;
        }

        override public string ToString() {
            return $"Triangle({borders[0]}, {borders[1]}, {borders[2]})";
        }

        public double perim() {
            double ret = 0;
            foreach (double d in borders) ret += d;
            return ret;
        }

        public double square() {
            double p = perim() / 2;
            return Math.Sqrt(p*(p-borders[0])*(p - borders[1]) *(p - borders[2]));
        }
    }
}
