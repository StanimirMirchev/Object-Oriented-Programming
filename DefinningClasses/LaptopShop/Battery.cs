using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Battery
    {
        private string battery;
        private double batteryLife;

        public Battery(string battery = "",double batteryLife = 0)
        {
            this.BatteryInfo = battery;
            this.Batterylife = batteryLife;
        }
        public string BatteryInfo 
        {
            get
            {
                return this.battery;
            }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid battery type!");
                }
                else
                {
                    this.battery = value;
                }
            }
        }
        public double Batterylife 
        {
            get 
            {
                return this.batteryLife;
            }
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentException("Invalid value of batteryLife!");
                }
                else
                {
                    this.batteryLife = value;
                }
            }
        }
        public override string ToString()
        {
            return String.Format(" {0} \nBattery life: {1}",this.battery,this.batteryLife);
        }
        
    }

