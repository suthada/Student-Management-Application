using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_Application
{
    internal class Student_Management
    {
        private double Max = 0;
        private double Min = 4;
        private double sum = 0;
        private string alldata = "";
        private string Maxname = "";
        private string Minname = "";
        private int n = 0;

        public void addList(string Name, double GPA)
        {
            this.sum += GPA;
            this.n++;
            this.alldata += Name + " " + GPA + Environment.NewLine;

            if (this.Max < GPA)
            {
                this.Max = GPA;
                this.Maxname = Name;


            }
            if (this.Min > GPA)
            {
                this.Min = GPA;
                this.Minname = Name;

            }
        }
        internal void addGPA(double dInpu, string name)
        {
            throw new NotImplementedException();
        }

        public double getGPA()
        {
            double result = this.sum / this.n;
            return result;
        }
        public string getAlldata()
        {
            return alldata;
        }
        public double getMax()
        {
            return this.Max;
        }
        public string getMaxname()
        {
            return Maxname;
        }
        public double getMin()
        {
            return this.Min;
        }

        public string getMinname()
        {
            return Minname;
        }
    }
}
