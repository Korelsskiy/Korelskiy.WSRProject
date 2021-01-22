
namespace Korelskiy.WSRProject
{
    partial class ApplySheduleChangesForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textFileTextBox = new System.Windows.Forms.TextBox();
            this.importButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.successfullChangesLabel = new System.Windows.Forms.Label();
            this.DuplicateRecordsLabel = new System.Windows.Forms.Label();
            this.RecordsWithMissingFieldsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please select the text file with the changes";
            // 
            // textFileTextBox
            // 
            this.textFileTextBox.Location = new System.Drawing.Point(42, 112);
            this.textFileTextBox.Name = "textFileTextBox";
            this.textFileTextBox.Size = new System.Drawing.Size(470, 30);
            this.textFileTextBox.TabIndex = 1;
            // 
            // importButton
            // 
            this.importButton.Location = new System.Drawing.Point(539, 112);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(144, 30);
            this.importButton.TabIndex = 2;
            this.importButton.Text = "Import";
            this.importButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Successfull changes aplied :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Duplicate records discarded:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(340, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Records with missing fields discarded:";
            // 
            // successfullChangesLabel
            // 
            this.successfullChangesLabel.AutoSize = true;
            this.successfullChangesLabel.Location = new System.Drawing.Point(460, 214);
            this.successfullChangesLabel.Name = "successfullChangesLabel";
            this.successfullChangesLabel.Size = new System.Drawing.Size(64, 25);
            this.successfullChangesLabel.TabIndex = 6;
            this.successfullChangesLabel.Text = "label5";
            // 
            // DuplicateRecordsLabel
            // 
            this.DuplicateRecordsLabel.AutoSize = true;
            this.DuplicateRecordsLabel.Location = new System.Drawing.Point(460, 274);
            this.DuplicateRecordsLabel.Name = "DuplicateRecordsLabel";
            this.DuplicateRecordsLabel.Size = new System.Drawing.Size(64, 25);
            this.DuplicateRecordsLabel.TabIndex = 7;
            this.DuplicateRecordsLabel.Text = "label6";
            // 
            // RecordsWithMissingFieldsLabel
            // 
            this.RecordsWithMissingFieldsLabel.AutoSize = true;
            this.RecordsWithMissingFieldsLabel.Location = new System.Drawing.Point(460, 339);
            this.RecordsWithMissingFieldsLabel.Name = "RecordsWithMissingFieldsLabel";
            this.RecordsWithMissingFieldsLabel.Size = new System.Drawing.Size(64, 25);
            this.RecordsWithMissingFieldsLabel.TabIndex = 8;
            this.RecordsWithMissingFieldsLabel.Text = "label7";
            // 
            // ApplySheduleChangesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 454);
            this.Controls.Add(this.RecordsWithMissingFieldsLabel);
            this.Controls.Add(this.DuplicateRecordsLabel);
            this.Controls.Add(this.successfullChangesLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.textFileTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ApplySheduleChangesForm";
            this.Text = "Apply Shedule Changes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textFileTextBox;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label successfullChangesLabel;
        private System.Windows.Forms.Label DuplicateRecordsLabel;
        private System.Windows.Forms.Label RecordsWithMissingFieldsLabel;
    }
}