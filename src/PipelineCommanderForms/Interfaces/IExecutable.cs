using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipelineCommanderForms.libs
{
    public interface IExecutable
    {
        string ExecuteCommand(string command);
    }
}
