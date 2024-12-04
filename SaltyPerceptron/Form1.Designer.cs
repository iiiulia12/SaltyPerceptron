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
            extractedBranches = new ListBox();
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
            predictions = new ListBox();
            label1 = new Label();
            label2 = new Label();
            simulateButton = new Button();
            ((System.ComponentModel.ISupportInitialize)perceptronsNrUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hrSizeUpDown).BeginInit();
            SuspendLayout();
            // 
            // AddFileButton
            // 
            AddFileButton.Location = new Point(1091, 399);
            AddFileButton.Margin = new Padding(2);
            AddFileButton.Name = "AddFileButton";
            AddFileButton.Size = new Size(112, 34);
            AddFileButton.TabIndex = 0;
            AddFileButton.Text = "Add File";
            AddFileButton.UseVisualStyleBackColor = true;
            AddFileButton.Click += AddFileButton_Click;
            // 
            // extractedBranches
            // 
            extractedBranches.FormattingEnabled = true;
            extractedBranches.ItemHeight = 25;
            extractedBranches.Location = new Point(49, 78);
            extractedBranches.Margin = new Padding(2);
            extractedBranches.Name = "extractedBranches";
            extractedBranches.Size = new Size(587, 304);
            extractedBranches.TabIndex = 1;
            // 
            // perceptronsNrUpDown
            // 
            perceptronsNrUpDown.Location = new Point(236, 429);
            perceptronsNrUpDown.Margin = new Padding(4);
            perceptronsNrUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            perceptronsNrUpDown.Name = "perceptronsNrUpDown";
            perceptronsNrUpDown.Size = new Size(188, 31);
            perceptronsNrUpDown.TabIndex = 2;
            perceptronsNrUpDown.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // hrSizeUpDown
            // 
            hrSizeUpDown.Location = new Point(236, 468);
            hrSizeUpDown.Margin = new Padding(4);
            hrSizeUpDown.Name = "hrSizeUpDown";
            hrSizeUpDown.Size = new Size(188, 31);
            hrSizeUpDown.TabIndex = 3;
            hrSizeUpDown.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // lblPerceptronsNr
            // 
            lblPerceptronsNr.AutoSize = true;
            lblPerceptronsNr.Location = new Point(49, 429);
            lblPerceptronsNr.Margin = new Padding(4, 0, 4, 0);
            lblPerceptronsNr.Name = "lblPerceptronsNr";
            lblPerceptronsNr.Size = new Size(175, 25);
            lblPerceptronsNr.TabIndex = 4;
            lblPerceptronsNr.Text = "Perceptrons Number";
            // 
            // lblHrSize
            // 
            lblHrSize.AutoSize = true;
            lblHrSize.Location = new Point(49, 470);
            lblHrSize.Margin = new Padding(4, 0, 4, 0);
            lblHrSize.Name = "lblHrSize";
            lblHrSize.Size = new Size(72, 25);
            lblHrSize.TabIndex = 5;
            lblHrSize.Text = "HR Size";
            // 
            // lblTotalBranches
            // 
            lblTotalBranches.AutoSize = true;
            lblTotalBranches.Location = new Point(481, 429);
            lblTotalBranches.Margin = new Padding(4, 0, 4, 0);
            lblTotalBranches.Name = "lblTotalBranches";
            lblTotalBranches.Size = new Size(143, 25);
            lblTotalBranches.TabIndex = 6;
            lblTotalBranches.Text = "Total Branches: 0";
            // 
            // lblCorrectPredictions
            // 
            lblCorrectPredictions.AutoSize = true;
            lblCorrectPredictions.Location = new Point(481, 468);
            lblCorrectPredictions.Margin = new Padding(4, 0, 4, 0);
            lblCorrectPredictions.Name = "lblCorrectPredictions";
            lblCorrectPredictions.Size = new Size(180, 25);
            lblCorrectPredictions.TabIndex = 7;
            lblCorrectPredictions.Text = "Correct Predictions: 0";
            // 
            // lblIncorrectPredictions
            // 
            lblIncorrectPredictions.AutoSize = true;
            lblIncorrectPredictions.Location = new Point(481, 506);
            lblIncorrectPredictions.Margin = new Padding(4, 0, 4, 0);
            lblIncorrectPredictions.Name = "lblIncorrectPredictions";
            lblIncorrectPredictions.Size = new Size(192, 25);
            lblIncorrectPredictions.TabIndex = 8;
            lblIncorrectPredictions.Text = "Incorrect Predictions: 0";
            // 
            // lblAccuracy
            // 
            lblAccuracy.AutoSize = true;
            lblAccuracy.Location = new Point(765, 429);
            lblAccuracy.Margin = new Padding(4, 0, 4, 0);
            lblAccuracy.Name = "lblAccuracy";
            lblAccuracy.Size = new Size(140, 25);
            lblAccuracy.TabIndex = 9;
            lblAccuracy.Text = "Accuracy: 0.00%";
            // 
            // lblMispredictionRate
            // 
            lblMispredictionRate.AutoSize = true;
            lblMispredictionRate.Location = new Point(765, 468);
            lblMispredictionRate.Margin = new Padding(4, 0, 4, 0);
            lblMispredictionRate.Name = "lblMispredictionRate";
            lblMispredictionRate.Size = new Size(213, 25);
            lblMispredictionRate.TabIndex = 10;
            lblMispredictionRate.Text = "MispredictionRate: 0.00%";
            // 
            // lblTruePositiveRate
            // 
            lblTruePositiveRate.AutoSize = true;
            lblTruePositiveRate.Location = new Point(765, 506);
            lblTruePositiveRate.Margin = new Padding(4, 0, 4, 0);
            lblTruePositiveRate.Name = "lblTruePositiveRate";
            lblTruePositiveRate.Size = new Size(207, 25);
            lblTruePositiveRate.TabIndex = 11;
            lblTruePositiveRate.Text = "True Positive Rate: 0.00%";
            // 
            // lblTrueNegativeRate
            // 
            lblTrueNegativeRate.AutoSize = true;
            lblTrueNegativeRate.Location = new Point(765, 548);
            lblTrueNegativeRate.Margin = new Padding(4, 0, 4, 0);
            lblTrueNegativeRate.Name = "lblTrueNegativeRate";
            lblTrueNegativeRate.Size = new Size(217, 25);
            lblTrueNegativeRate.TabIndex = 12;
            lblTrueNegativeRate.Text = "True Negative Rate: 0.00%";
            // 
            // predictions
            // 
            predictions.FormattingEnabled = true;
            predictions.ItemHeight = 25;
            predictions.Location = new Point(679, 78);
            predictions.Margin = new Padding(2);
            predictions.Name = "predictions";
            predictions.Size = new Size(587, 304);
            predictions.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 39);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 14;
            label1.Text = "Branches";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(679, 39);
            label2.Name = "label2";
            label2.Size = new Size(99, 25);
            label2.TabIndex = 15;
            label2.Text = "Predictions";
            // 
            // simulateButton
            // 
            simulateButton.Location = new Point(1091, 461);
            simulateButton.Margin = new Padding(2);
            simulateButton.Name = "simulateButton";
            simulateButton.Size = new Size(112, 34);
            simulateButton.TabIndex = 16;
            simulateButton.Text = "Simulate";
            simulateButton.UseVisualStyleBackColor = true;
            simulateButton.Click += simulateButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1330, 646);
            Controls.Add(simulateButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(predictions);
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
            Controls.Add(extractedBranches);
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
        private ListBox extractedBranches;
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
        private ListBox predictions;
        private Label label1;
        private Label label2;
        private Button simulateButton;
    }
}
