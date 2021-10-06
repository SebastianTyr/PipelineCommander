namespace PipelineCommanderForms
{
    partial class MainView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageOS = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.systemInfoButton = new System.Windows.Forms.Button();
            this.buttonSerialNumber = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPagePipeline = new System.Windows.Forms.TabPage();
            this.outputCommand = new System.Windows.Forms.TextBox();
            this.labelCommand = new System.Windows.Forms.Label();
            this.executeCommand = new System.Windows.Forms.Button();
            this.inputCommand = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPageOS.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPagePipeline.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageOS);
            this.tabControl.Controls.Add(this.tabPagePipeline);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Location = new System.Drawing.Point(12, 128);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(781, 465);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageOS
            // 
            this.tabPageOS.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageOS.Controls.Add(this.groupBox2);
            this.tabPageOS.Controls.Add(this.groupBox1);
            this.tabPageOS.Location = new System.Drawing.Point(4, 25);
            this.tabPageOS.Name = "tabPageOS";
            this.tabPageOS.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOS.Size = new System.Drawing.Size(773, 436);
            this.tabPageOS.TabIndex = 0;
            this.tabPageOS.Text = "OS Info";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(396, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 373);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Scripter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Śmieszny obrazek";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 285);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(338, 63);
            this.button3.TabIndex = 0;
            this.button3.Text = "Generate Script";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(338, 63);
            this.button2.TabIndex = 0;
            this.button2.Text = "Run Script";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(338, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Script";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.systemInfoButton);
            this.groupBox1.Controls.Add(this.buttonSerialNumber);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(19, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 373);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OS Info";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 285);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(324, 63);
            this.button6.TabIndex = 5;
            this.button6.Text = "Computer Management";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // systemInfoButton
            // 
            this.systemInfoButton.Location = new System.Drawing.Point(6, 189);
            this.systemInfoButton.Name = "systemInfoButton";
            this.systemInfoButton.Size = new System.Drawing.Size(324, 63);
            this.systemInfoButton.TabIndex = 4;
            this.systemInfoButton.Text = "System Info";
            this.systemInfoButton.UseVisualStyleBackColor = true;
            this.systemInfoButton.Click += new System.EventHandler(this.systemInfoButton_Click);
            // 
            // buttonSerialNumber
            // 
            this.buttonSerialNumber.Location = new System.Drawing.Point(6, 93);
            this.buttonSerialNumber.Name = "buttonSerialNumber";
            this.buttonSerialNumber.Size = new System.Drawing.Size(324, 63);
            this.buttonSerialNumber.TabIndex = 3;
            this.buttonSerialNumber.Text = "Srefial Number";
            this.buttonSerialNumber.UseVisualStyleBackColor = true;
            this.buttonSerialNumber.Click += new System.EventHandler(this.buttonSerialNumber_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Śmieszny obrazek";
            // 
            // tabPagePipeline
            // 
            this.tabPagePipeline.BackColor = System.Drawing.SystemColors.Control;
            this.tabPagePipeline.Controls.Add(this.outputCommand);
            this.tabPagePipeline.Controls.Add(this.labelCommand);
            this.tabPagePipeline.Controls.Add(this.executeCommand);
            this.tabPagePipeline.Controls.Add(this.inputCommand);
            this.tabPagePipeline.Location = new System.Drawing.Point(4, 25);
            this.tabPagePipeline.Name = "tabPagePipeline";
            this.tabPagePipeline.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePipeline.Size = new System.Drawing.Size(773, 436);
            this.tabPagePipeline.TabIndex = 1;
            this.tabPagePipeline.Text = "Shell";
            // 
            // outputCommand
            // 
            this.outputCommand.BackColor = System.Drawing.SystemColors.HotTrack;
            this.outputCommand.ForeColor = System.Drawing.SystemColors.Window;
            this.outputCommand.Location = new System.Drawing.Point(19, 63);
            this.outputCommand.Multiline = true;
            this.outputCommand.Name = "outputCommand";
            this.outputCommand.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.outputCommand.Size = new System.Drawing.Size(732, 356);
            this.outputCommand.TabIndex = 3;
            // 
            // labelCommand
            // 
            this.labelCommand.AutoSize = true;
            this.labelCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCommand.Location = new System.Drawing.Point(16, 28);
            this.labelCommand.Name = "labelCommand";
            this.labelCommand.Size = new System.Drawing.Size(63, 17);
            this.labelCommand.TabIndex = 2;
            this.labelCommand.Text = "Commad";
            // 
            // executeCommand
            // 
            this.executeCommand.Location = new System.Drawing.Point(676, 25);
            this.executeCommand.Name = "executeCommand";
            this.executeCommand.Size = new System.Drawing.Size(75, 23);
            this.executeCommand.TabIndex = 1;
            this.executeCommand.Text = "Execute";
            this.executeCommand.UseVisualStyleBackColor = true;
            this.executeCommand.Click += new System.EventHandler(this.executeCommand_Click);
            // 
            // inputCommand
            // 
            this.inputCommand.Location = new System.Drawing.Point(85, 25);
            this.inputCommand.Name = "inputCommand";
            this.inputCommand.Size = new System.Drawing.Size(575, 22);
            this.inputCommand.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(773, 436);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "AD Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(823, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(25, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(628, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pipeline Commader   v. 1.0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 605);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "MainView";
            this.Text = "Pipeline Commader";
            this.tabControl.ResumeLayout(false);
            this.tabPageOS.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPagePipeline.ResumeLayout(false);
            this.tabPagePipeline.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageOS;
        private System.Windows.Forms.TabPage tabPagePipeline;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button systemInfoButton;
        private System.Windows.Forms.Button buttonSerialNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox outputCommand;
        private System.Windows.Forms.Label labelCommand;
        private System.Windows.Forms.Button executeCommand;
        private System.Windows.Forms.TextBox inputCommand;
        private System.Windows.Forms.TabPage tabPage1;
    }
}

