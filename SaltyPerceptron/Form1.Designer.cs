namespace SaltyPerceptron
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AddFileButton = new Button();
            extractedInfo = new ListBox();
            SuspendLayout();
            // 
            // AddFileButton
            // 
            AddFileButton.Location = new Point(1053, 449);
            AddFileButton.Name = "AddFileButton";
            AddFileButton.Size = new Size(112, 34);
            AddFileButton.TabIndex = 0;
            AddFileButton.Text = "Add File";
            AddFileButton.UseVisualStyleBackColor = true;
            AddFileButton.Click += AddFileButton_Click;
            // 
            // extractedInfo
            // 
            extractedInfo.FormattingEnabled = true;
            extractedInfo.ItemHeight = 25;
            extractedInfo.Location = new Point(49, 77);
            extractedInfo.Name = "extractedInfo";
            extractedInfo.Size = new Size(1154, 304);
            extractedInfo.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1330, 544);
            Controls.Add(extractedInfo);
            Controls.Add(AddFileButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button AddFileButton;
        private ListBox extractedInfo;
    }
}
