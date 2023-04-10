using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jurnal_MOD7_1302213020
{
    internal class BankTransferCoonfig
    {

        public Config config;

        public const String filePath = @"bank_transfer_config.jspn";


        private Config ReadConfigFile()
        {
            String configJson = File.ReadAllText(filePath);
            config = JsonSerializer.Deserialize<Config>(configJson);

        }

        private void WriteNewConfigFile()
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true;
            };
            String jsonString = JsonSerializer.Serialize(config, options);
            File.WriteAllText(filepath, jsonString);
        }

        public BankTransferCoonfig()
        {
            try
            {
                ReadConfigFile();
            } cactch (Exception) {
                SetDefault();
                WriteConfigFile();
            }
        }

}
}
