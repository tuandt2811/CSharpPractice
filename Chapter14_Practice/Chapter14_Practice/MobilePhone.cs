using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter14_Practice
{
    class MobilePhone
    {
        string model;
        string manufacture;
        string price;
        string owner;
        battery batt;
        display Screen;
        /* This solution will use nested class to solve */ 
        class battery
        {
            string model;
            int idle_time;
            int hours_talk;
        }
        class display
        {
            int width;
            int height;
            string color;
        }
        
        /* Constructors*/
        public MobilePhone()
        {

        }
        public MobilePhone(string model, string manufacture, string price, string owner, battery batt, display screen)
        {

        }
    }
}
