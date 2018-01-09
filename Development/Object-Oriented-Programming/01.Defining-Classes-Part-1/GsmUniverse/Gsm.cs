// <copyright file=Gsm company="Business Management Systems Ltd">
//   Copyright (c) 2018 All Rights Reserved
// </copyright>
// <author>Kosta Kiryazov</author>
// <date>1/5/2018 11:03:53 AM</date>
// <summary>Class representing a Gsm entity</summary>

namespace GsmUniverse
{
    #region Usings
    using System;
    using System.Collections.Generic;
    using System.Text;
    #endregion

    public class Gsm
    {
        private static Gsm iPhone4S = new Gsm("IPhone 4S", "Apple", 900, "Az", 
            new Battery("A99-ZL", 400, 180, BatteryType.LiIon), 
            new Display(5, 2000000000));

        private string model;

        private string manufacturer;

        private decimal? price;

        private List<Call> callHistory;

        public Gsm(string modelParam, string manufacturerParam)
            : this(modelParam, manufacturerParam, null, null, null, null)
        {
        }

        public Gsm(string modelParam, string manufacturerParam, decimal? priceParam, string ownerParam,
            Battery batteryParam, Display displayParam)
        {
            this.Model = modelParam;
            this.Manufacturer = manufacturerParam;
            this.Price = priceParam;
            this.Owner = ownerParam;
            this.Battery = batteryParam;
            this.Display = displayParam;
            this.callHistory = new List<Call>();
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(nameof(this.model));
                }

                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(nameof(this.manufacturer));
                }

                this.manufacturer = value;
            }
        }

        public decimal? Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value.HasValue && value.Value < 0)
                {
                    throw new ArgumentException(nameof(price));
                }

                this.price = value;
            }
        }

        public static Gsm IPhone4S
        {
            get
            {
                return iPhone4S;
            }
        }

        public string Owner { get; set; }
        public Battery Battery { get; set; }
        public Display Display { get; set; }

        public List<Call> CallHoistory
        {
            get
            {
                return this.callHistory;
            }
        }

        public void AddCall(Call callParam)
        {
            this.CallHoistory.Add(callParam);
        }

        public void AddRangeCall(List<Call> callsParam)
        {
            this.CallHoistory.AddRange(callsParam);
        }

        public bool RemoveCall(Call callParam)
        {
            return this.CallHoistory.Remove(callParam);
        }

        public void ClearCalls()
        {
            this.CallHoistory.Clear();
        }

        public void PrintCallHistory()
        {
            Console.WriteLine("Calls");
            foreach (Call call in this.CallHoistory)
            {
                Console.WriteLine(call.ToString());
            }
        }

        public decimal CalculateTotalCallPrice(decimal pricePerMinute)
        {
            decimal result = 0.0m;
            int totalDurration = 0;
            foreach (Call call in this.CallHoistory)
            {
                totalDurration += call.Duration;
            }

            result = (totalDurration / 60.00m) * pricePerMinute;
            Console.WriteLine($"{totalDurration}");
            return result;
        }

        public override string ToString()
        {
            StringBuilder gsm = new StringBuilder();
            gsm.AppendLine("Gsm");
            gsm.AppendLine($"\tModel: {this.Model}");
            gsm.AppendLine($"\tManufacturer: {this.Manufacturer}");
            gsm.AppendLine($"\tPrice: {this.Price}");
            gsm.AppendLine($"\tOwner: {this.Owner}");
            gsm.AppendLine("\tBattery");
            gsm.AppendLine($"\t\tModel: {this.Battery?.Model}");
            gsm.AppendLine($"\t\tIdleHours: {this.Battery?.IdleHours}");
            gsm.AppendLine($"\t\tTalkHours: {this.Battery?.TalkHours}");
            gsm.AppendLine($"\t\tBatteryType: {this.Battery?.BatteryType.ToString("G")}");
            gsm.AppendLine("\tDisplay");
            gsm.AppendLine($"\t\tSize: {this.Display?.Size}");
            gsm.AppendLine($"\t\tNumber of color: {this.Display?.NumberOfColors}");
            return gsm.ToString();
        }
    }
}