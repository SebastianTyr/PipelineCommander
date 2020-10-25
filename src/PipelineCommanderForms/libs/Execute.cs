using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management.Automation;
using System.Collections.ObjectModel;
using System.Management.Automation.Runspaces;
using PipelineCommanderForms.Views;

namespace PipelineCommanderForms.libs
{
    public class Execute : IExecutable
    {
        ///<summary>
        ///Executting single cmdlet command
        ///</summary>
        ///<returns></returns>
        public string ExecuteCommand(string command)
        {
            Runspace _runspace = RunspaceFactory.CreateRunspace();

            _runspace.Open();

            Pipeline _pipeline = _runspace.CreatePipeline();
            _pipeline.Commands.AddScript(command);
            _pipeline.Commands.Add("Out-String");

            Collection<PSObject> _results = _pipeline.Invoke();
            _runspace.Close();

            StringBuilder _output = new StringBuilder();

            foreach (PSObject _object in _results)
            {
                _output.AppendLine(_object.ToString());
            }

            return _output.ToString();
        }

        ///<summary>
        ///Executting system information command
        ///</summary>
        ///<returns></returns>
        public void ExecuteInfoButton()
        {
            SysInfoView sysInfoView = new SysInfoView();
            InfoResultView infoResult = new InfoResultView();
        }
    }
}
