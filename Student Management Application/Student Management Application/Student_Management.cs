using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_Application
{
    internal class Student_Management
    {
        private double GPA = 0;
        private double GPAx = 0;
        private double Max = 0;
        private double Min = 0;
        private double sum = 0;
        private int n = 0;

        public void addList(int Id, string Name, double GPA)
        {
            this.sum += GPA;
            if (this.Max < GPA)
            {
                this.Max = GPA;

            }
            if (this.Max > GPA)
            {
                this.Min = GPA;

            }
        }

        public double getGPA()
        {
            double result = this.sum / this.n;
            return result;
        }
        public double getMax()
        {
            return this.Max;
        }
        public double getMin()
        {
            return this.Min;
        }

    }
}
