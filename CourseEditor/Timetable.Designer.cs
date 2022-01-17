namespace CourseEditor
{
    partial class Timetable
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
            this.authorLabel = new System.Windows.Forms.Label();
            this.numLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.ectsLabel = new System.Windows.Forms.Label();
            this.lecLabel = new System.Windows.Forms.Label();
            this.tutLabel = new System.Windows.Forms.Label();
            this.labLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(7, 6);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(54, 15);
            this.authorLabel.TabIndex = 0;
            this.authorLabel.Text = "AUTHOR";
            // 
            // numLabel
            // 
            this.numLabel.AutoSize = true;
            this.numLabel.Location = new System.Drawing.Point(15, 55);
            this.numLabel.Name = "numLabel";
            this.numLabel.Size = new System.Drawing.Size(23, 15);
            this.numLabel.TabIndex = 1;
            this.numLabel.Text = "No";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(59, 55);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(41, 15);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "NAME";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(217, 55);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(18, 15);
            this.idLabel.TabIndex = 3;
            this.idLabel.Text = "ID";
            // 
            // ectsLabel
            // 
            this.ectsLabel.AutoSize = true;
            this.ectsLabel.Location = new System.Drawing.Point(311, 55);
            this.ectsLabel.Name = "ectsLabel";
            this.ectsLabel.Size = new System.Drawing.Size(33, 15);
            this.ectsLabel.TabIndex = 4;
            this.ectsLabel.Text = "ECTS";
            // 
            // lecLabel
            // 
            this.lecLabel.AutoSize = true;
            this.lecLabel.Location = new System.Drawing.Point(371, 55);
            this.lecLabel.Name = "lecLabel";
            this.lecLabel.Size = new System.Drawing.Size(66, 15);
            this.lecLabel.TabIndex = 5;
            this.lecLabel.Text = "LECTURE H";
            // 
            // tutLabel
            // 
            this.tutLabel.AutoSize = true;
            this.tutLabel.Location = new System.Drawing.Point(443, 55);
            this.tutLabel.Name = "tutLabel";
            this.tutLabel.Size = new System.Drawing.Size(71, 15);
            this.tutLabel.TabIndex = 6;
            this.tutLabel.Text = "TUTORIAL H";
            // 
            // labLabel
            // 
            this.labLabel.AutoSize = true;
            this.labLabel.Location = new System.Drawing.Point(520, 55);
            this.labLabel.Name = "labLabel";
            this.labLabel.Size = new System.Drawing.Size(91, 15);
            this.labLabel.TabIndex = 7;
            this.labLabel.Text = "LABORATORY H";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(617, 55);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(82, 15);
            this.dateLabel.TabIndex = 8;
            this.dateLabel.Text = "DATE GRADED";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(731, 55);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(50, 15);
            this.weightLabel.TabIndex = 9;
            this.weightLabel.Text = "WEIGHT";
            // 
            // Timetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 643);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.labLabel);
            this.Controls.Add(this.tutLabel);
            this.Controls.Add(this.lecLabel);
            this.Controls.Add(this.ectsLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.numLabel);
            this.Controls.Add(this.authorLabel);
            this.Name = "Timetable";
            this.Text = "TIMETABLE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label authorLabel;
        private Label numLabel;
        private Label nameLabel;
        private Label idLabel;
        private Label ectsLabel;
        private Label lecLabel;
        private Label tutLabel;
        private Label labLabel;
        private Label dateLabel;
        private Label weightLabel;
    }
}