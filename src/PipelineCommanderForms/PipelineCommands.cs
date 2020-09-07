using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management.Automation;
using System.Collections.ObjectModel;
using System.Management.Automation.Runspaces;

namespace PipelineCommanderForms
{
    public class PipelineCommands
    {
        ///<summary>
        ///Creating class for simply cmdlet
        ///</summary>
        ///
        public string ExecuteScript(string script)
        {
            Runspace _runspace = RunspaceFactory.CreateRunspace();
            _runspace.Open();

            Pipeline _pipeline = _runspace.CreatePipeline();
            _pipeline.Commands.AddScript(script);
            _pipeline.Commands.Add("Out-String");

            Collection<PSObject> _results = _pipeline.Invoke();
            _runspace.Close();

            StringBuilder _output = new StringBuilder();

            foreach(PSObject _object in _results)
            {
                _output.AppendLine(_object.ToString());
            }

            return _output.ToString();
        }
    }
}
