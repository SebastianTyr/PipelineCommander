using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.IO;

namespace PipelineCommanderForms
{
    public class SystemProperites
    {
        private string _model = null;
        private string _name = null;
        private string _serialNo = null;

        public string Model
        {
            get => _model;
            set => _model = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string SerialNo
        {
            get => _serialNo;
            set => _serialNo = value;
        }
    }
}
