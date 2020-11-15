using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipelineCommanderForms.Interfaces
{
    public interface IExecutable
    {
        string ExecuteCommand(string command);
    }
}
