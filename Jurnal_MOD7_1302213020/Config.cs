using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jurnal_MOD7_1302213020
{
    internal class Config
    {

        public string lang { get; set; }
        public int threshold { get; set; }
        public int low_fee { get; set; }
        public int high_fee { get; set; }
        public string[] methods;
        public string en;
        public string id;

        public Config() { }

        public Config(string lang, int threshold, int low_fee, int high_fee, string[] methods, string en, string id)
        {
            this.lang = lang;
            this.threshold = threshold;
            this.low_fee = low_fee;
            this.high_fee = high_fee;
            this.methods = methods;
            this.en = en;
            this.id = id;
        }
    }
}
