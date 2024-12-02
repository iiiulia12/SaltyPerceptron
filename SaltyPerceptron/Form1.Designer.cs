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
            perceptronsNrUpDown = new NumericUpDown();
            hrSizeUpDown = new NumericUpDown();
            lblPerceptronsNr = new Label();
            lblHrSize = new Label();
            lblTotalBranches = new Label();
            lblCorrectPredictions = new Label();
            lblIncorrectPredictions = new Label();
            lblAccuracy = new Label();
            lblMispredictionRate = new Label();
            lblTruePositiveRate = new Label();
            lblTrueNegativeRate = new Label();
            ((System.ComponentModel.ISupportInitialize)perceptronsNrUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hrSizeUpDown).BeginInit();
            SuspendLayout();
            // 
            // AddFileButton
            // 
            AddFileButton.Location = new Point(873, 319);
            AddFileButton.Margin = new Padding(2);
            AddFileButton.Name = "AddFileButton";
            AddFileButton.Size = new Size(90, 27);
            AddFileButton.TabIndex = 0;
            AddFileButton.Text = "Add File";
            AddFileButton.UseVisualStyleBackColor = true;
            AddFileButton.Click += AddFileButton_Click;
            // 
            // extractedInfo
            // 
            extractedInfo.FormattingEnabled = true;
            extractedInfo.Location = new Point(39, 62);
            extractedInfo.Margin = new Padding(2);
            extractedInfo.Name = "extractedInfo";
            extractedInfo.Size = new Size(924, 244);
            extractedInfo.TabIndex = 1;
            // 
            // perceptronsNrUpDown
            // 
            perceptronsNrUpDown.Location = new Point(189, 343);
            perceptronsNrUpDown.Name = "perceptronsNrUpDown";
            perceptronsNrUpDown.Size = new Size(150, 27);
            perceptronsNrUpDown.TabIndex = 2;
            perceptronsNrUpDown.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // hrSizeUpDown
            // 
            hrSizeUpDown.Location = new Point(189, 374);
            hrSizeUpDown.Name = "hrSizeUpDown";
            hrSizeUpDown.Size = new Size(150, 27);
            hrSizeUpDown.TabIndex = 3;
            hrSizeUpDown.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // lblPerceptronsNr
            // 
            lblPerceptronsNr.AutoSize = true;
            lblPerceptronsNr.Location = new Point(39, 343);
            lblPerceptronsNr.Name = "lblPerceptronsNr";
            lblPerceptronsNr.Size = new Size(144, 20);
            lblPerceptronsNr.TabIndex = 4;
            lblPerceptronsNr.Text = "Perceptrons Number";
            // 
            // lblHrSize
            // 
            lblHrSize.AutoSize = true;
            lblHrSize.Location = new Point(39, 376);
            lblHrSize.Name = "lblHrSize";
            lblHrSize.Size = new Size(60, 20);
            lblHrSize.TabIndex = 5;
            lblHrSize.Text = "HR Size";
            // 
            // lblTotalBranches
            // 
            lblTotalBranches.AutoSize = true;
            lblTotalBranches.Location = new Point(385, 343);
            lblTotalBranches.Name = "lblTotalBranches";
            lblTotalBranches.Size = new Size(120, 20);
            lblTotalBranches.TabIndex = 6;
            lblTotalBranches.Text = "Total Branches: 0";
            // 
            // lblCorrectPredictions
            // 
            lblCorrectPredictions.AutoSize = true;
            lblCorrectPredictions.Location = new Point(385, 374);
            lblCorrectPredictions.Name = "lblCorrectPredictions";
            lblCorrectPredictions.Size = new Size(149, 20);
            lblCorrectPredictions.TabIndex = 7;
            lblCorrectPredictions.Text = "Correct Predictions: 0";
            // 
            // lblIncorrectPredictions
            // 
            lblIncorrectPredictions.AutoSize = true;
            lblIncorrectPredictions.Location = new Point(385, 405);
            lblIncorrectPredictions.Name = "lblIncorrectPredictions";
            lblIncorrectPredictions.Size = new Size(159, 20);
            lblIncorrectPredictions.TabIndex = 8;
            lblIncorrectPredictions.Text = "Incorrect Predictions: 0";
            // 
            // lblAccuracy
            // 
            lblAccuracy.AutoSize = true;
            lblAccuracy.Location = new Point(612, 343);
            lblAccuracy.Name = "lblAccuracy";
            lblAccuracy.Size = new Size(114, 20);
            lblAccuracy.TabIndex = 9;
            lblAccuracy.Text = "Accuracy: 0.00%";
            // 
            // lblMispredictionRate
            // 
            lblMispredictionRate.AutoSize = true;
            lblMispredictionRate.Location = new Point(612, 374);
            lblMispredictionRate.Name = "lblMispredictionRate";
            lblMispredictionRate.Size = new Size(176, 20);
            lblMispredictionRate.TabIndex = 10;
            lblMispredictionRate.Text = "MispredictionRate: 0.00%";
            // 
            // lblTruePositiveRate
            // 
            lblTruePositiveRate.AutoSize = true;
            lblTruePositiveRate.Location = new Point(612, 405);
            lblTruePositiveRate.Name = "lblTruePositiveRate";
            lblTruePositiveRate.Size = new Size(171, 20);
            lblTruePositiveRate.TabIndex = 11;
            lblTruePositiveRate.Text = "True Positive Rate: 0.00%";
            // 
            // lblTrueNegativeRate
            // 
            lblTrueNegativeRate.AutoSize = true;
            lblTrueNegativeRate.Location = new Point(612, 438);
            lblTrueNegativeRate.Name = "lblTrueNegativeRate";
            lblTrueNegativeRate.Size = new Size(181, 20);
            lblTrueNegativeRate.TabIndex = 12;
            lblTrueNegativeRate.Text = "True Negative Rate: 0.00%";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 517);
            Controls.Add(lblTrueNegativeRate);
            Controls.Add(lblTruePositiveRate);
            Controls.Add(lblMispredictionRate);
            Controls.Add(lblAccuracy);
            Controls.Add(lblIncorrectPredictions);
            Controls.Add(lblCorrectPredictions);
            Controls.Add(lblTotalBranches);
            Controls.Add(lblHrSize);
            Controls.Add(lblPerceptronsNr);
            Controls.Add(hrSizeUpDown);
            Controls.Add(perceptronsNrUpDown);
            Controls.Add(extractedInfo);
            Controls.Add(AddFileButton);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)perceptronsNrUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)hrSizeUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddFileButton;
        private ListBox extractedInfo;
        private NumericUpDown perceptronsNrUpDown;
        private NumericUpDown hrSizeUpDown;
        private Label lblPerceptronsNr;
        private Label lblHrSize;
        private Label lblTotalBranches;
        private Label lblCorrectPredictions;
        private Label lblIncorrectPredictions;
        private Label lblAccuracy;
        private Label lblMispredictionRate;
        private Label lblTruePositiveRate;
        private Label lblTrueNegativeRate;
    }
}
