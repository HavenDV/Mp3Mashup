namespace Mp3Mashup
{
    partial class MainForm
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
            System.Windows.Forms.Label OutputLabel;
            System.Windows.Forms.Button ProcessButton;
            System.Windows.Forms.Button BrowseInput1Button;
            System.Windows.Forms.Button BrowseInput2Button;
            System.Windows.Forms.Label Input1Label;
            System.Windows.Forms.Label Input2Label;
            System.Windows.Forms.Button BrowseOutputButton;
            this.Input1TextBox = new System.Windows.Forms.TextBox();
            this.Input2TextBox = new System.Windows.Forms.TextBox();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            OutputLabel = new System.Windows.Forms.Label();
            ProcessButton = new System.Windows.Forms.Button();
            BrowseInput1Button = new System.Windows.Forms.Button();
            BrowseInput2Button = new System.Windows.Forms.Button();
            Input1Label = new System.Windows.Forms.Label();
            Input2Label = new System.Windows.Forms.Label();
            BrowseOutputButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OutputLabel
            // 
            OutputLabel.AutoSize = true;
            OutputLabel.Location = new System.Drawing.Point(12, 74);
            OutputLabel.Name = "OutputLabel";
            OutputLabel.Size = new System.Drawing.Size(65, 13);
            OutputLabel.TabIndex = 9;
            OutputLabel.Text = "Output .mp3";
            // 
            // ProcessButton
            // 
            ProcessButton.Location = new System.Drawing.Point(12, 98);
            ProcessButton.Name = "ProcessButton";
            ProcessButton.Size = new System.Drawing.Size(776, 23);
            ProcessButton.TabIndex = 2;
            ProcessButton.Text = "Process";
            ProcessButton.UseVisualStyleBackColor = true;
            ProcessButton.Click += new System.EventHandler(this.ProcessButton_Click);
            // 
            // BrowseInput1Button
            // 
            BrowseInput1Button.Location = new System.Drawing.Point(713, 12);
            BrowseInput1Button.Name = "BrowseInput1Button";
            BrowseInput1Button.Size = new System.Drawing.Size(75, 23);
            BrowseInput1Button.TabIndex = 0;
            BrowseInput1Button.Text = "...";
            BrowseInput1Button.UseVisualStyleBackColor = true;
            BrowseInput1Button.Click += new System.EventHandler(this.BrowseInput1Button_Click);
            // 
            // BrowseInput2Button
            // 
            BrowseInput2Button.Location = new System.Drawing.Point(713, 41);
            BrowseInput2Button.Name = "BrowseInput2Button";
            BrowseInput2Button.Size = new System.Drawing.Size(75, 23);
            BrowseInput2Button.TabIndex = 1;
            BrowseInput2Button.Text = "...";
            BrowseInput2Button.UseVisualStyleBackColor = true;
            BrowseInput2Button.Click += new System.EventHandler(this.BrowseInput2Button_Click);
            // 
            // Input1TextBox
            // 
            this.Input1TextBox.Location = new System.Drawing.Point(96, 14);
            this.Input1TextBox.Name = "Input1TextBox";
            this.Input1TextBox.Size = new System.Drawing.Size(611, 20);
            this.Input1TextBox.TabIndex = 3;
            // 
            // Input2TextBox
            // 
            this.Input2TextBox.Location = new System.Drawing.Point(96, 43);
            this.Input2TextBox.Name = "Input2TextBox";
            this.Input2TextBox.Size = new System.Drawing.Size(611, 20);
            this.Input2TextBox.TabIndex = 4;
            // 
            // Input1Label
            // 
            Input1Label.AutoSize = true;
            Input1Label.Location = new System.Drawing.Point(12, 17);
            Input1Label.Name = "Input1Label";
            Input1Label.Size = new System.Drawing.Size(55, 13);
            Input1Label.TabIndex = 5;
            Input1Label.Text = "First .mp3:";
            // 
            // Input2Label
            // 
            Input2Label.AutoSize = true;
            Input2Label.Location = new System.Drawing.Point(12, 46);
            Input2Label.Name = "Input2Label";
            Input2Label.Size = new System.Drawing.Size(70, 13);
            Input2Label.TabIndex = 6;
            Input2Label.Text = "Second .mp3";
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Location = new System.Drawing.Point(96, 71);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(611, 20);
            this.OutputTextBox.TabIndex = 8;
            // 
            // BrowseOutputButton
            // 
            BrowseOutputButton.Location = new System.Drawing.Point(713, 69);
            BrowseOutputButton.Name = "BrowseOutputButton";
            BrowseOutputButton.Size = new System.Drawing.Size(75, 23);
            BrowseOutputButton.TabIndex = 7;
            BrowseOutputButton.Text = "...";
            BrowseOutputButton.UseVisualStyleBackColor = true;
            BrowseOutputButton.Click += new System.EventHandler(this.BrowseOutputButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 130);
            this.Controls.Add(OutputLabel);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(BrowseOutputButton);
            this.Controls.Add(Input2Label);
            this.Controls.Add(Input1Label);
            this.Controls.Add(this.Input2TextBox);
            this.Controls.Add(this.Input1TextBox);
            this.Controls.Add(ProcessButton);
            this.Controls.Add(BrowseInput2Button);
            this.Controls.Add(BrowseInput1Button);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Mp3 Mashup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Input1TextBox;
        private System.Windows.Forms.TextBox Input2TextBox;
        private System.Windows.Forms.TextBox OutputTextBox;
    }
}

