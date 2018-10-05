namespace SpeedUpWork
{
    partial class MainFrame
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ModuleName = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.WorkFolder = new System.Windows.Forms.Label();
            this.PluginButton = new System.Windows.Forms.Button();
            this.checkBoxBuildDep = new System.Windows.Forms.CheckBox();
            this.GitButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.butBrower = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(89, 77);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(162, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // ModuleName
            // 
            this.ModuleName.AutoSize = true;
            this.ModuleName.Location = new System.Drawing.Point(12, 80);
            this.ModuleName.Name = "ModuleName";
            this.ModuleName.Size = new System.Drawing.Size(47, 13);
            this.ModuleName.TabIndex = 1;
            this.ModuleName.Text = "Modules";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(89, 33);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(237, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // WorkFolder
            // 
            this.WorkFolder.AutoSize = true;
            this.WorkFolder.Location = new System.Drawing.Point(12, 36);
            this.WorkFolder.Name = "WorkFolder";
            this.WorkFolder.Size = new System.Drawing.Size(65, 13);
            this.WorkFolder.TabIndex = 3;
            this.WorkFolder.Text = "Work Folder";
            // 
            // PluginButton
            // 
            this.PluginButton.Location = new System.Drawing.Point(49, 153);
            this.PluginButton.Name = "PluginButton";
            this.PluginButton.Size = new System.Drawing.Size(75, 23);
            this.PluginButton.TabIndex = 5;
            this.PluginButton.Text = "Build Plugin";
            this.PluginButton.UseVisualStyleBackColor = true;
            this.PluginButton.Click += new System.EventHandler(this.PluginButton_Click);
            // 
            // checkBoxBuildDep
            // 
            this.checkBoxBuildDep.AutoSize = true;
            this.checkBoxBuildDep.BackColor = System.Drawing.SystemColors.Control;
            this.checkBoxBuildDep.Location = new System.Drawing.Point(88, 119);
            this.checkBoxBuildDep.Name = "checkBoxBuildDep";
            this.checkBoxBuildDep.Size = new System.Drawing.Size(135, 17);
            this.checkBoxBuildDep.TabIndex = 4;
            this.checkBoxBuildDep.Text = "Build with dependecies";
            this.checkBoxBuildDep.UseVisualStyleBackColor = false;
            // 
            // GitButton
            // 
            this.GitButton.Location = new System.Drawing.Point(145, 153);
            this.GitButton.Name = "GitButton";
            this.GitButton.Size = new System.Drawing.Size(75, 23);
            this.GitButton.TabIndex = 6;
            this.GitButton.Text = "Git view";
            this.GitButton.UseVisualStyleBackColor = true;
            this.GitButton.Click += new System.EventHandler(this.GitButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(251, 153);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(21, 198);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(329, 13);
            this.progressBar1.TabIndex = 8;
            // 
            // butBrower
            // 
            this.butBrower.Location = new System.Drawing.Point(332, 31);
            this.butBrower.Name = "butBrower";
            this.butBrower.Size = new System.Drawing.Size(28, 23);
            this.butBrower.TabIndex = 2;
            this.butBrower.Text = "...";
            this.butBrower.UseVisualStyleBackColor = true;
            this.butBrower.Click += new System.EventHandler(this.butBrower_Click);
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 241);
            this.Controls.Add(this.butBrower);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.GitButton);
            this.Controls.Add(this.checkBoxBuildDep);
            this.Controls.Add(this.PluginButton);
            this.Controls.Add(this.WorkFolder);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.ModuleName);
            this.Controls.Add(this.comboBox1);
            this.Name = "MainFrame";
            this.Text = "Virtual View";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label ModuleName;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label WorkFolder;
        private System.Windows.Forms.Button PluginButton;
        private System.Windows.Forms.CheckBox checkBoxBuildDep;
        private System.Windows.Forms.Button GitButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button butBrower;


    }
}

