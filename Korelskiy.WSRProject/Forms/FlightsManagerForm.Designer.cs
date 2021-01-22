
namespace Korelskiy.WSRProject
{
    partial class FlightsManagerForm
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
            this.flightsManagerDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.selectFromComboBox = new System.Windows.Forms.ComboBox();
            this.selectToComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.selectSortStyleComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.outboundTextBox = new System.Windows.Forms.TextBox();
            this.flightNumberTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.applyButton = new System.Windows.Forms.Button();
            this.cancelFlightButton = new System.Windows.Forms.Button();
            this.editFlightButton = new System.Windows.Forms.Button();
            this.importChangesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.flightsManagerDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flightsManagerDataGridView
            // 
            this.flightsManagerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.flightsManagerDataGridView.Location = new System.Drawing.Point(44, 242);
            this.flightsManagerDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flightsManagerDataGridView.Name = "flightsManagerDataGridView";
            this.flightsManagerDataGridView.RowHeadersWidth = 51;
            this.flightsManagerDataGridView.RowTemplate.Height = 24;
            this.flightsManagerDataGridView.Size = new System.Drawing.Size(1114, 411);
            this.flightsManagerDataGridView.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.applyButton);
            this.groupBox1.Controls.Add(this.flightNumberTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.outboundTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.selectSortStyleComboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.selectToComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.selectFromComboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(44, 38);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1114, 195);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter by";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // selectFromComboBox
            // 
            this.selectFromComboBox.FormattingEnabled = true;
            this.selectFromComboBox.Location = new System.Drawing.Point(93, 33);
            this.selectFromComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.selectFromComboBox.Name = "selectFromComboBox";
            this.selectFromComboBox.Size = new System.Drawing.Size(194, 33);
            this.selectFromComboBox.TabIndex = 1;
            // 
            // selectToComboBox
            // 
            this.selectToComboBox.FormattingEnabled = true;
            this.selectToComboBox.Location = new System.Drawing.Point(447, 34);
            this.selectToComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.selectToComboBox.Name = "selectToComboBox";
            this.selectToComboBox.Size = new System.Drawing.Size(180, 33);
            this.selectToComboBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "To";
            // 
            // selectSortStyleComboBox
            // 
            this.selectSortStyleComboBox.FormattingEnabled = true;
            this.selectSortStyleComboBox.Location = new System.Drawing.Point(784, 30);
            this.selectSortStyleComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.selectSortStyleComboBox.Name = "selectSortStyleComboBox";
            this.selectSortStyleComboBox.Size = new System.Drawing.Size(180, 33);
            this.selectSortStyleComboBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(696, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sort by";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Outbound";
            // 
            // outboundTextBox
            // 
            this.outboundTextBox.Location = new System.Drawing.Point(140, 112);
            this.outboundTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.outboundTextBox.Name = "outboundTextBox";
            this.outboundTextBox.Size = new System.Drawing.Size(148, 30);
            this.outboundTextBox.TabIndex = 7;
            // 
            // flightNumberTextBox
            // 
            this.flightNumberTextBox.Location = new System.Drawing.Point(478, 116);
            this.flightNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flightNumberTextBox.Name = "flightNumberTextBox";
            this.flightNumberTextBox.Size = new System.Drawing.Size(148, 30);
            this.flightNumberTextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(326, 120);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Flight Number";
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(700, 106);
            this.applyButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(266, 47);
            this.applyButton.TabIndex = 10;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            // 
            // cancelFlightButton
            // 
            this.cancelFlightButton.Location = new System.Drawing.Point(44, 680);
            this.cancelFlightButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancelFlightButton.Name = "cancelFlightButton";
            this.cancelFlightButton.Size = new System.Drawing.Size(200, 47);
            this.cancelFlightButton.TabIndex = 11;
            this.cancelFlightButton.Text = "Cancel Flight";
            this.cancelFlightButton.UseVisualStyleBackColor = true;
            // 
            // editFlightButton
            // 
            this.editFlightButton.Location = new System.Drawing.Point(252, 680);
            this.editFlightButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editFlightButton.Name = "editFlightButton";
            this.editFlightButton.Size = new System.Drawing.Size(213, 47);
            this.editFlightButton.TabIndex = 12;
            this.editFlightButton.Text = "Edit Flight";
            this.editFlightButton.UseVisualStyleBackColor = true;
            // 
            // importChangesButton
            // 
            this.importChangesButton.Location = new System.Drawing.Point(892, 680);
            this.importChangesButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.importChangesButton.Name = "importChangesButton";
            this.importChangesButton.Size = new System.Drawing.Size(266, 47);
            this.importChangesButton.TabIndex = 13;
            this.importChangesButton.Text = "Import Changes";
            this.importChangesButton.UseVisualStyleBackColor = true;
            // 
            // FlightsManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 745);
            this.Controls.Add(this.importChangesButton);
            this.Controls.Add(this.editFlightButton);
            this.Controls.Add(this.cancelFlightButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flightsManagerDataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FlightsManagerForm";
            this.Text = "Flights Manager";
            ((System.ComponentModel.ISupportInitialize)(this.flightsManagerDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView flightsManagerDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.TextBox flightNumberTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox outboundTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox selectSortStyleComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox selectToComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox selectFromComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelFlightButton;
        private System.Windows.Forms.Button editFlightButton;
        private System.Windows.Forms.Button importChangesButton;
    }
}