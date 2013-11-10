using System;

namespace WpfApp.Entities
{
    public class Settings: ICloneable
    {
        public decimal NumericOption { get; set; }
        public string TextOption { get; set; }
        public object Clone()
        {
            return this.MemberwiseClone();//extend with other technick if neccesary for deep complex clone 
        }
    }
}