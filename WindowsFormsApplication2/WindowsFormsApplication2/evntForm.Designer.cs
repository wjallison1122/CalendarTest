namespace WindowsFormsApplication2
{
    partial class evntForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.descBox = new System.Windows.Forms.TextBox();
            this.endEvntSelect = new System.Windows.Forms.DateTimePicker();
            this.startTimeSelect = new System.Windows.Forms.DateTimePicker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.startEvntSelect = new System.Windows.Forms.DateTimePicker();
            this.endTimeSelect = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Description";
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(72, 28);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(200, 20);
            this.titleBox.TabIndex = 1;
            // 
            // descBox
            // 
            this.descBox.Location = new System.Drawing.Point(72, 54);
            this.descBox.Multiline = true;
            this.descBox.Name = "descBox";
            this.descBox.Size = new System.Drawing.Size(200, 113);
            this.descBox.TabIndex = 2;
            // 
            // endEvntSelect
            // 
            this.endEvntSelect.Location = new System.Drawing.Point(72, 199);
            this.endEvntSelect.Name = "endEvntSelect";
            this.endEvntSelect.Size = new System.Drawing.Size(200, 20);
            this.endEvntSelect.TabIndex = 2;
            this.endEvntSelect.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // startTimeSelect
            // 
            this.startTimeSelect.CustomFormat = "\"hh:mm\"";
            this.startTimeSelect.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startTimeSelect.Location = new System.Drawing.Point(72, 225);
            this.startTimeSelect.Name = "startTimeSelect";
            this.startTimeSelect.ShowUpDown = true;
            this.startTimeSelect.Size = new System.Drawing.Size(77, 20);
            this.startTimeSelect.TabIndex = 2;
            // 
            // startEvntSelect
            // 
            this.startEvntSelect.Location = new System.Drawing.Point(72, 173);
            this.startEvntSelect.Name = "startEvntSelect";
            this.startEvntSelect.Size = new System.Drawing.Size(200, 20);
            this.startEvntSelect.TabIndex = 2;
            // 
            // endTimeSelect
            // 
            this.endTimeSelect.CustomFormat = "\"hh:mm\"";
            this.endTimeSelect.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endTimeSelect.Location = new System.Drawing.Point(72, 245);
            this.endTimeSelect.Name = "endTimeSelect";
            this.endTimeSelect.ShowUpDown = true;
            this.endTimeSelect.Size = new System.Drawing.Size(77, 20);
            this.endTimeSelect.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Start Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "End Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Start Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "End Time";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(98, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Done";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // evntForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 328);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.endTimeSelect);
            this.Controls.Add(this.startTimeSelect);
            this.Controls.Add(this.startEvntSelect);
            this.Controls.Add(this.endEvntSelect);
            this.Controls.Add(this.descBox);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "evntForm";
            this.Text = "Add Event";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.TextBox descBox;
        private System.Windows.Forms.DateTimePicker endEvntSelect;
        private System.Windows.Forms.DateTimePicker startTimeSelect;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DateTimePicker startEvntSelect;
        private System.Windows.Forms.DateTimePicker endTimeSelect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}