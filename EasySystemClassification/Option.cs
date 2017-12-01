using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasySystemClassification
{
    class Option
    {
        public class ImportOptionClass
        {
            public long StartRow { set; get; }
            public long StartColumn { set; get; }
            public string NameRegex { set; get; }
            public string CodeRegex { set; get; }
        }

        public ImportOptionClass ImportOption;

        public class ExportOptionClass
        {
            public long StartRow { set; get; }
            public long StartColumn { set; get; }
            public string ExportFormat { set; get; }
        }

        public ExportOptionClass ExportOption;
    }
}
