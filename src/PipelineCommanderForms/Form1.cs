using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management.Automation;
using System.Management.Automation.Runspaces;

namespace PipelineCommanderForms
{
    public partial class Form1 : Form
    {
        PipelineCommands _commands = new PipelineCommands();

        public Form1()
        {
            InitializeComponent();
        }

        private void executeCommand_Click(object sender, EventArgs e)
        {
            try
            {
                outputCommand.Clear();
                outputCommand.Text = _commands.ExecuteScript(inputCommand.Text);
            }
            catch (CommandNotFoundException)
            {
                outputCommand.Text = $@"{inputCommand.Text} : The term '{inputCommand.Text}' is not recognized as the name of a cmdlet, function, script file, or operable program. Checkthe spelling of the name, or if a path was included, verify that the path is correct and try again.";
            }
        }
    }
}
