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
using PipelineCommanderForms;
using PipelineCommanderForms.libs;
using PipelineCommanderForms.Views;

namespace PipelineCommanderForms
{
    public partial class MainView : Form
    {
        PipelineCommands _commands = new PipelineCommands();

        public MainView()
        {
            InitializeComponent();
        }

        private void executeCommand_Click(object sender, EventArgs e)
        {
            try
            {
                outputCommand.Clear();
                outputCommand.Text = new Execute().ExecuteCommand(inputCommand.Text);
            }
            catch (CommandNotFoundException)
            {
                outputCommand.Text = $@"{inputCommand.Text} : The term '{inputCommand.Text}' is not recognized as the name of a cmdlet, function, script file, or operable program. Checkthe spelling of the name, or if a path was included, verify that the path is correct and try again.";
            }
        }

        private void buttonSerialNumber_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{_commands.GetSerialNumber()}", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void systemInfoButton_Click(object sender, EventArgs e)
        {
            InfoResultView resultView = new InfoResultView();
            resultView.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutView().Show();
        }
    }
}
