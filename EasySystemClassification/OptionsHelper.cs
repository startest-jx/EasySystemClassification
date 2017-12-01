using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace EasySystemClassification
{
    class OptionsHelper
    {
        private readonly string _fileName;

        public bool FileExist => File.Exists(_fileName);

        public OptionsHelper(string fileName)
        {
            _fileName = fileName;
            if (!FileExist)
            {
                CreateOptionsTemplate();
            }
        }

        public void CreateOptionsTemplate()
        {
            var optionTemplate = new Option
            {
                ImportOption = new Option.ImportOptionClass
                {
                    StartRow = 2,
                    StartColumn = 1,
                    NameRegex = @".+(?=\$)",
                    CodeRegex = @"(?<=\$)(\w+)"
                },
                ExportOption = new Option.ExportOptionClass
                {
                    StartRow = 2,
                    StartColumn = 1,
                    ExportFormat = @"%NAME%$%CODE%"
                }
            };
            string jsonStr = JsonConvert.SerializeObject(optionTemplate);
            Write(jsonStr);
        }

        public void Write(string str)
        {
            FileStream jsonFile = new FileStream(_fileName, FileMode.Create);
            byte[] data = Encoding.Default.GetBytes(str);
            jsonFile.Write(data, 0, data.Length);
            jsonFile.Flush();
            jsonFile.Close();
        }
    }
}
