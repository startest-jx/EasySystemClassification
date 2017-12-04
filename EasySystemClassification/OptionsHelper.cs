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
        public Option Option;

        public bool FileExist => File.Exists(_fileName);

        public OptionsHelper(string fileName)
        {
            _fileName = fileName;
            if (!FileExist)
            {
                CreateOptionsTemplate();
            }
            else
            {
                Read(out var readString);
                Deserialze(readString);
            }
        }

        public bool CreateOptionsTemplate()
        {
            Option = new Option
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
            string jsonStr = Serialize();
            return Write(jsonStr);
        }

        public string Serialize()
        {
            return JsonConvert.SerializeObject(Option);
        }

        public void Deserialze(string json)
        {
            Option = JsonConvert.DeserializeObject<Option>(json);
        }

        public bool Write(string str)
        {
            try
            {
                FileStream jsonFile = new FileStream(_fileName, FileMode.Create);
                byte[] data = Encoding.Default.GetBytes(str);
                jsonFile.Write(data, 0, data.Length);
                jsonFile.Flush();
                jsonFile.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool Save()
        {
            return Write(Serialize());
        }

        public void Read(out string str)
        {
            FileStream jsonFile = new FileStream(_fileName, FileMode.Open);
            byte[] data = new byte[jsonFile.Length];
            jsonFile.Read(data, 0, data.Length);
            str = Encoding.Default.GetString(data);
            jsonFile.Flush();
            jsonFile.Close();
        }
    }
}
