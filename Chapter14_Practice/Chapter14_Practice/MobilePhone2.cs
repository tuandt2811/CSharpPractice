using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter14_Practice
{
    class _Battery
    {
        private string model;
        private int idle_time;
        private int hours_talk;

        public string Model
        {
            get { return this.model; }
        }

        public int IdleTime
        {
            get { return this.idle_time; }
        }

        public int HoursTalk
        {
            get { return this.hours_talk; }
        }

        public _Battery() : this(null)
        {

        }
        public _Battery(string model) : this(model, 0)
        {

        }

        public _Battery(string model, int idle_time) : this (model, idle_time, 0)
        {

        }

        public _Battery(string model, int idle_time, int hours_talk)
        {
            this.model = model;
            this.idle_time = idle_time;
            this.hours_talk = hours_talk;
        }
    }

    class _Display
    {
        private int height;
        private int width;
        private string colors;

        public _Display() : this(0)
        {
        }

        public _Display(int height) : this(height, 0)
        {
        }

        public _Display(int height, int width) : this(height, width, null)
        {
        }

        public _Display(int height, int width, string colors)
        {
            this.height = height;
            this.width = width;
            this.colors = colors;
        }

        public int Height
        {
            get { return this.height; }
        }

        public int Width
        {
            get { return this.width; }
        }

        public string Colors
        {
            get { return this.colors; }
        }
    }

    class _Call
    {
        private static int RecordCounter = 0;
        private int id_of_record = 0;
        private string date;
        private string time_of_start;
        private int duration_of_call;
        private _Call next_call;

        public string Date
        {
            get { return this.date; }
        }

        public string TimeOfStart
        {
            get { return this.time_of_start; }
        }

        public int DurationOfCall
        {
            get { return this.duration_of_call; }
        }

        public int RecordID
        {
            get { return this.id_of_record; }
        }

        public _Call NextCall
        {
            set { this.next_call = value; }
            get { return this.next_call; }
        }

        public int GetIdOfCallRecord()
        {
            return id_of_record;
        }

        public _Call(string date, string time_of_start, int duration_of_call)
        {
            this.id_of_record = RecordCounter;
            this.date = date;
            this.time_of_start = time_of_start;
            this.duration_of_call = duration_of_call;
            this.next_call = null;
            RecordCounter ++;
        }
    }

    class _CallHistory
    {
        private _Call head_call;
        private _Call end_call;
        private int number_of_log;

        public int NumOfLog
        {
            get { return this.number_of_log; }
        }

        public _CallHistory()
        {
            this.head_call = null;
            this.end_call = null;
            number_of_log = 0;
        }

        public _Call GetCallRecord(int RecordID)
        {
            _Call tempCall = this.head_call;
            while (tempCall != null)
            {
                if (tempCall.RecordID == RecordID)
                {
                    break;
                }
                tempCall = tempCall.NextCall;
            }
            return tempCall;
        }

        public void AddNewCall(_Call NewCall)
        {
            if (null == this.head_call)
            {
                this.head_call = NewCall;
                this.end_call = NewCall;
            }
            else
            {
                this.end_call.NextCall = NewCall;
                this.end_call = NewCall;
                this.end_call.NextCall = null;
            }
            number_of_log++;
        }

        public void RemoveAllFromHistory()
        {
            _Call tempCall = this.head_call;
            _Call sliceCall = null;
            while (tempCall != null)
            {
                sliceCall = tempCall.NextCall;
                tempCall.NextCall = null;
                tempCall = sliceCall;
            }
            this.head_call = null;
        }

        public void RemoveCallFromHistory(int RecordID)
        {
            _Call tempCall = this.head_call;
            _Call prevTempCall = this.head_call;

            if (tempCall != null)
            {
                if (tempCall.RecordID == RecordID)
                {
                    this.head_call = tempCall.NextCall;
                    tempCall.NextCall = null;
                    number_of_log--;
                }
                else
                {
                    prevTempCall = tempCall;
                    tempCall = tempCall.NextCall;

                    while (tempCall != null)
                    {
                        if (tempCall.RecordID == RecordID)
                        {
                            prevTempCall.NextCall = tempCall.NextCall;
                            tempCall.NextCall = null;
                            number_of_log--;
                            break;
                        }
                        prevTempCall = tempCall;
                        tempCall = tempCall.NextCall;
                    }
                }
            }
        }

        public void PrintAllRecords()
        {
            _Call tempCall = this.head_call;
            while (tempCall != null)
            {
                Console.WriteLine("Record [{0}]", tempCall.RecordID);
                Console.WriteLine(" ---> Call Date {0}", tempCall.Date);
                Console.WriteLine(" ---> Start time {0}", tempCall.TimeOfStart);
                Console.WriteLine(" ---> Duration {0}", tempCall.DurationOfCall);
                tempCall = tempCall.NextCall;
            }
        }
    }

    class MobilePhone2
    {
        private string model;
        private string manufacture;
        private int price;
        private string owner;
        private _Battery battery;
        private _Display display;
        private _CallHistory CallLog;
        /* Properties */
        public string Model
        {
            get { return this.model; }
        }

        public string Manufacture
        {
            get { return this.manufacture; }
        }

        public int Price
        {
            set { this.price = value; }
            get { return this.price; }
        }

        public string Owner
        {
            set { this.owner = value; }
            get { return this.owner; }
        }

        public _Battery Battery
        {
            set { this.battery = value; }
            get { return this.battery; }
        }

        public _Display Display
        {
            set { this.display = value; }
            get { return this.display; }
        }

        /* Constructor */
        public MobilePhone2() 
            : this(null)
        {

        }
        public MobilePhone2(string model) 
            : this(model, null)
        {

        }
        public MobilePhone2(string model, string manufacture) 
            : this(model, manufacture, 0)
        {

        }
        public MobilePhone2(string model, string manufacture, int price) 
            : this(model, manufacture, price, null)
        {

        }
        public MobilePhone2(string model, string manufacture, int price, string owner)
            : this(model, manufacture, price, owner, null)
        {
        }
        public MobilePhone2(string model, string manufacture, int price, string owner, _Battery battery)
            : this(model, manufacture, price, owner, battery, null)
        {
        }
        public MobilePhone2(string model, string manufacture, int price, string owner, _Battery battery, _Display display)
        {
            this.model = model;
            this.manufacture = manufacture;
            this.price = price;
            this.owner = owner;
            this.battery = battery;
            this.display = display;
            this.CallLog = new _CallHistory();
        }

        /* Mobile Features */
        public void Call(string date, string time_of_start, int duration_of_call)
        {
            _Call NewCall = new _Call(date, time_of_start, duration_of_call);
            this.CallLog.AddNewCall(NewCall);
        }

        public void DisplayInformation()
        {
            Console.WriteLine("Mobile Information");
            Console.WriteLine("  *Model : {0}*  ", this.model);
            Console.WriteLine("  *Manufacture : {0}*  ", this.manufacture);
            Console.WriteLine("  *Price : {0}*  ", this.price);
            Console.WriteLine("  *Owner : {0}*  ", this.owner);
            Console.WriteLine("Battery Information");
            Console.WriteLine("  *Model : {0}*  ", this.battery.Model);
            Console.WriteLine("  *Idle Time : {0}*  ", this.battery.IdleTime);
            Console.WriteLine("  *Start hours : {0}*  ", this.battery.HoursTalk);
            Console.WriteLine("Display Information");
            Console.WriteLine("  *Height : {0}*  ", this.display.Height);
            Console.WriteLine("  *Width : {0}*  ", this.display.Width);
            Console.WriteLine("  *Color : {0}*  ", this.display.Colors);
            Console.WriteLine("Size Of Call History : {0}", this.CallLog.NumOfLog);
        }

        public void DisplayLog(int LogID)
        {
            _Call Call = null;
            Call = this.CallLog.GetCallRecord(LogID);
            if (Call != null)
            {
                Console.WriteLine("Record [{0}]", LogID);
                Console.WriteLine(" ---> Call Date {0}", Call.Date);
                Console.WriteLine(" ---> Start time {0}", Call.TimeOfStart);
                Console.WriteLine(" ---> Duration {0}", Call.DurationOfCall);
            }
            else
            {
                Console.WriteLine("***** Cannot find the log with Log Id : {0}", LogID);
            }
        }

        public void DeleteRecord(int LogID)
        {
            this.CallLog.RemoveCallFromHistory(LogID);
        }

        public void DeleteHistory()
        {
            this.CallLog.RemoveAllFromHistory();
        }

        public void DisplayFullLog()
        {
            this.CallLog.PrintAllRecords();
        }

    }
}
