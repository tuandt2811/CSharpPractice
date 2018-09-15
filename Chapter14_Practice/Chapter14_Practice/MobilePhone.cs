/* Way 1 : Use nested class to solve the execire*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter14_Practice
{
    enum BatteryType
    {
        LiION, NiMH, NiCD
    }

    class MobilePhone
    {
        string model;
        string manufacture;
        int price;
        string owner;
        Energy battery;
        display screen;
        static MobilePhone nokiaN95 = new MobilePhone("Slice Phone", "Nokia", 1200, "John Smith", new Energy("Recharge", BatteryType.NiMH, 0, 0), new display(10, 10, "RGB"));
        private string MobileInformation;

        /* Nested class */
        public class Energy
        {
            public string model;
            public BatteryType BatType;
            public int idle_time;
            public int hours_talk;
            public Energy(string model, BatteryType BatteryType, int idleTime, int hourTalk)
            {
                this.model = model;
                this.idle_time = idleTime;
                this.hours_talk = hourTalk;
                this.BatType = BatteryType;
            }
        }

        public class display
        {
            public int width;
            public int height;
            public string color;
            public display(int width, int height, string color)
            {
                this.width = width;
                this.height = height;
                this.color = color;
            }
        }
        

        /* Constructors*/
        public MobilePhone() : this(null)
        {

        }

        public MobilePhone(string model) : this(model, null)
        {

        }

        public MobilePhone(string model, string manufacture) : this (model, manufacture, 0)
        {

        }

        public MobilePhone(string model, string manufacture, int price) : this(model, manufacture, price, null)
        {

        }

        public MobilePhone(string model, string manufacture, int price, string owner) 
        {

        }

        public MobilePhone(string model, string manufacture, int price, string owner, Energy batt) : this(model, manufacture, price, owner, batt, null) 
        {
 
        }

        public MobilePhone(string model, string manufacture, int price, string owner, Energy batt, display screen)
        {
            this.model = model;
            this.manufacture = manufacture;
            this.price = price;
            this.owner = owner;
            this.battery = batt;
            this.screen = screen;
        }

        /* static method */
        public static void DemoInformation()
        {
            Console.WriteLine("Demo produce Information");
            Console.WriteLine("Model : {0}", MobilePhone.nokiaN95.model);
            Console.WriteLine("Manufacture : {0}", MobilePhone.nokiaN95.manufacture);
            Console.WriteLine("Price : {0} USD", MobilePhone.nokiaN95.price);
            Console.WriteLine("Owner : {0}", MobilePhone.nokiaN95.owner);
            Console.WriteLine("Battery information:");
            Console.WriteLine("  + Type of Battery : {0}", MobilePhone.nokiaN95.battery.model);
            Console.WriteLine("  + Idle time : {0}", MobilePhone.nokiaN95.battery.idle_time);
            Console.WriteLine("  + Hours call : {0}", MobilePhone.nokiaN95.battery.hours_talk);
            Console.WriteLine("Display information:");
            Console.WriteLine("  + Size of Display : {0} x {1}", MobilePhone.nokiaN95.screen.height, MobilePhone.nokiaN95.screen.width);
            Console.WriteLine("  + Color type : {0}", MobilePhone.nokiaN95.screen.color);
        }

        /* Object methods*/
        public override string  ToString()
        {
            this.MobileInformation = this.model + "," + this.manufacture + "," + "," + this.price + "," + this.owner;
            return this.MobileInformation;
        }
    }
}
