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
        public _CallHistory()
        {
            this.head_call = null;
            this.end_call = null;
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
        }

        public void RemoveCallFromHistory(int RecordID)
        {
            _Call tempCall = this.head_call;
            _Call prevTempCall = this.head_call;
            while (tempCall != null)
            {
                if (tempCall.RecordID == RecordID)
                {
                    prevTempCall.NextCall = tempCall.NextCall;
                    tempCall.NextCall = null;
                    break;
                }
                prevTempCall = tempCall;
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
        private _CallHistory calls;
    }
}
