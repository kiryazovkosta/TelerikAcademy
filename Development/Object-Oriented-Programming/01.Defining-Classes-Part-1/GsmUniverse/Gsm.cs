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
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    #endregion

    public class Gsm
    {
        private string model;
        private string manufacturer { get; set; }
        public decimal? price { get; set; }
        public string Owner { get; set; }
        public Battery Battery { get; set; }
        public Display Display { get; set; }

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
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
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
            set
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