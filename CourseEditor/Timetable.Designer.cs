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
            this.loadButton = new System.Windows.Forms.Button();
            this.fileInput = new System.Windows.Forms.TextBox();
            this.numInput = new System.Windows.Forms.TextBox();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.idInput = new System.Windows.Forms.TextBox();
            this.ectsInput = new System.Windows.Forms.TextBox();
            this.lecInput = new System.Windows.Forms.TextBox();
            this.tutInput = new System.Windows.Forms.TextBox();
            this.labInput = new System.Windows.Forms.TextBox();
            this.dateInput = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.semInput = new System.Windows.Forms.TextBox();
            this.semLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.debugLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.fileOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(12, 9);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(54, 15);
            this.authorLabel.TabIndex = 0;
            this.authorLabel.Text = "AUTHOR";
            // 
            // numLabel
            // 
            this.numLabel.AutoSize = true;
            this.numLabel.Location = new System.Drawing.Point(18, 165);
            this.numLabel.Name = "numLabel";
            this.numLabel.Size = new System.Drawing.Size(23, 15);
            this.numLabel.TabIndex = 1;
            this.numLabel.Text = "No";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(121, 165);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(41, 15);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "NAME";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(435, 165);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(18, 15);
            this.idLabel.TabIndex = 3;
            this.idLabel.Text = "ID";
            // 
            // ectsLabel
            // 
            this.ectsLabel.AutoSize = true;
            this.ectsLabel.Location = new System.Drawing.Point(515, 165);
            this.ectsLabel.Name = "ectsLabel";
            this.ectsLabel.Size = new System.Drawing.Size(33, 15);
            this.ectsLabel.TabIndex = 4;
            this.ectsLabel.Text = "ECTS";
            // 
            // lecLabel
            // 
            this.lecLabel.AutoSize = true;
            this.lecLabel.Location = new System.Drawing.Point(554, 165);
            this.lecLabel.Name = "lecLabel";
            this.lecLabel.Size = new System.Drawing.Size(66, 15);
            this.lecLabel.TabIndex = 5;
            this.lecLabel.Text = "LECTURE H";
            // 
            // tutLabel
            // 
            this.tutLabel.AutoSize = true;
            this.tutLabel.Location = new System.Drawing.Point(626, 165);
            this.tutLabel.Name = "tutLabel";
            this.tutLabel.Size = new System.Drawing.Size(71, 15);
            this.tutLabel.TabIndex = 6;
            this.tutLabel.Text = "TUTORIAL H";
            // 
            // labLabel
            // 
            this.labLabel.AutoSize = true;
            this.labLabel.Location = new System.Drawing.Point(703, 165);
            this.labLabel.Name = "labLabel";
            this.labLabel.Size = new System.Drawing.Size(91, 15);
            this.labLabel.TabIndex = 7;
            this.labLabel.Text = "LABORATORY H";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(800, 165);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(82, 15);
            this.dateLabel.TabIndex = 8;
            this.dateLabel.Text = "DATE GRADED";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(888, 165);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(50, 15);
            this.weightLabel.TabIndex = 9;
            this.weightLabel.Text = "WEIGHT";
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(1270, 12);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 10;
            this.loadButton.Text = "Load XML";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // fileInput
            // 
            this.fileInput.Location = new System.Drawing.Point(1164, 12);
            this.fileInput.Name = "fileInput";
            this.fileInput.Size = new System.Drawing.Size(100, 23);
            this.fileInput.TabIndex = 11;
            // 
            // numInput
            // 
            this.numInput.Location = new System.Drawing.Point(18, 127);
            this.numInput.Name = "numInput";
            this.numInput.Size = new System.Drawing.Size(23, 23);
            this.numInput.TabIndex = 12;
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(121, 127);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(308, 23);
            this.nameInput.TabIndex = 13;
            // 
            // idInput
            // 
            this.idInput.Location = new System.Drawing.Point(435, 127);
            this.idInput.Name = "idInput";
            this.idInput.Size = new System.Drawing.Size(75, 23);
            this.idInput.TabIndex = 14;
            // 
            // ectsInput
            // 
            this.ectsInput.Location = new System.Drawing.Point(515, 127);
            this.ectsInput.Name = "ectsInput";
            this.ectsInput.Size = new System.Drawing.Size(33, 23);
            this.ectsInput.TabIndex = 15;
            // 
            // lecInput
            // 
            this.lecInput.Location = new System.Drawing.Point(554, 127);
            this.lecInput.Name = "lecInput";
            this.lecInput.Size = new System.Drawing.Size(66, 23);
            this.lecInput.TabIndex = 16;
            // 
            // tutInput
            // 
            this.tutInput.Location = new System.Drawing.Point(626, 127);
            this.tutInput.Name = "tutInput";
            this.tutInput.Size = new System.Drawing.Size(71, 23);
            this.tutInput.TabIndex = 17;
            // 
            // labInput
            // 
            this.labInput.Location = new System.Drawing.Point(703, 127);
            this.labInput.Name = "labInput";
            this.labInput.Size = new System.Drawing.Size(91, 23);
            this.labInput.TabIndex = 18;
            // 
            // dateInput
            // 
            this.dateInput.Location = new System.Drawing.Point(800, 127);
            this.dateInput.Name = "dateInput";
            this.dateInput.Size = new System.Drawing.Size(82, 23);
            this.dateInput.TabIndex = 19;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(888, 127);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(50, 23);
            this.addButton.TabIndex = 20;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // semInput
            // 
            this.semInput.Location = new System.Drawing.Point(54, 127);
            this.semInput.Name = "semInput";
            this.semInput.Size = new System.Drawing.Size(61, 23);
            this.semInput.TabIndex = 21;
            // 
            // semLabel
            // 
            this.semLabel.AutoSize = true;
            this.semLabel.Location = new System.Drawing.Point(54, 165);
            this.semLabel.Name = "semLabel";
            this.semLabel.Size = new System.Drawing.Size(61, 15);
            this.semLabel.TabIndex = 22;
            this.semLabel.Text = "SEMESTER";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(703, 15);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 15);
            this.errorLabel.TabIndex = 23;
            // 
            // debugLabel
            // 
            this.debugLabel.AutoSize = true;
            this.debugLabel.Location = new System.Drawing.Point(1100, 95);
            this.debugLabel.Name = "debugLabel";
            this.debugLabel.Size = new System.Drawing.Size(38, 15);
            this.debugLabel.TabIndex = 24;
            this.debugLabel.Text = "label1";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(1270, 41);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 25;
            this.saveButton.Text = "Save as";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // fileOutput
            // 
            this.fileOutput.Location = new System.Drawing.Point(1164, 42);
            this.fileOutput.Name = "fileOutput";
            this.fileOutput.Size = new System.Drawing.Size(100, 23);
            this.fileOutput.TabIndex = 26;
            // 
            // Timetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 641);
            this.Controls.Add(this.fileOutput);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.debugLabel);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.semLabel);
            this.Controls.Add(this.semInput);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.dateInput);
            this.Controls.Add(this.labInput);
            this.Controls.Add(this.tutInput);
            this.Controls.Add(this.lecInput);
            this.Controls.Add(this.ectsInput);
            this.Controls.Add(this.idInput);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.numInput);
            this.Controls.Add(this.fileInput);
            this.Controls.Add(this.loadButton);
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
        private Button loadButton;
        private TextBox fileInput;
        private TextBox numInput;
        private TextBox nameInput;
        private TextBox idInput;
        private TextBox ectsInput;
        private TextBox lecInput;
        private TextBox tutInput;
        private TextBox labInput;
        private TextBox dateInput;
        private Button addButton;
        private TextBox semInput;
        private Label semLabel;
        private Label errorLabel;
        private Label debugLabel;
        private Button saveButton;
        private TextBox fileOutput;
    }
}