using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeApp
{
    class Grade
    {
        private double physics;
        private double chemistry;
        private double mathematics;

        public Grade(double physics, double chemistry, double mathematics)
        {
            GetPhysics = physics;
            GetChemistry = chemistry;
            Getmathematics = mathematics;
        }
        public double GetPhysics
        {
            set
            {
                physics = value;
            }
            get
            {
                return physics;
            }
        }
        public double GetChemistry
        {
            set
            {
                chemistry = value;
            }
            get
            {
                return chemistry;
            }
        }
        public double Getmathematics
        {
            set
            {
                mathematics = value;
            }
            get
            {
                return mathematics;
            }
        }

        public double getAverage()
        {
            double average = (GetChemistry + GetPhysics + Getmathematics)/3;
            return average;
        }

        public string getCheck()
        {
            string g = "";
            if(getAverage() >= 80)
            {
                
                g +="A+";
            }
            else if(getAverage() >= 70)
            {
                g += "B+";
            }
            else if (getAverage() >= 60)
            {
                g += "C+";
            }
            else if (getAverage() >= 50)
            {
                g += "D+";
            }
            else
            {
                g += "F";
            }

            
            
            return g;

        }
    }
}
