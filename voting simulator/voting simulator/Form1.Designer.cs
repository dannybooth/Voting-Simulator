
namespace voting_simulator
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.fileUpload = new System.Windows.Forms.Button();
            this.simulate = new System.Windows.Forms.Button();
            this.data = new System.Windows.Forms.TextBox();
            this.fileSystemWatcher = new System.IO.FileSystemWatcher();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.location = new System.Windows.Forms.Label();
            this.inpuLabel = new System.Windows.Forms.Label();
            this.dropdownmenu = new System.Windows.Forms.Panel();
            this.pairwise = new System.Windows.Forms.Button();
            this.method3 = new System.Windows.Forms.Button();
            this.dropdown = new System.Windows.Forms.Button();
            this.method2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.amountCheck = new System.Windows.Forms.CheckBox();
            this.delimiterText = new System.Windows.Forms.TextBox();
            this.delimiterLabel = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.Label();
            this.matrixLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).BeginInit();
            this.dropdownmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileUpload
            // 
            this.fileUpload.Location = new System.Drawing.Point(21, 271);
            this.fileUpload.Name = "fileUpload";
            this.fileUpload.Size = new System.Drawing.Size(280, 35);
            this.fileUpload.TabIndex = 0;
            this.fileUpload.Text = "Upload file";
            this.fileUpload.UseVisualStyleBackColor = true;
            this.fileUpload.Click += new System.EventHandler(this.fileUpload_Click);
            // 
            // simulate
            // 
            this.simulate.Location = new System.Drawing.Point(310, 271);
            this.simulate.Name = "simulate";
            this.simulate.Size = new System.Drawing.Size(294, 35);
            this.simulate.TabIndex = 1;
            this.simulate.Text = "Simulate";
            this.simulate.UseVisualStyleBackColor = true;
            this.simulate.Click += new System.EventHandler(this.simulate_Click);
            // 
            // data
            // 
            this.data.Location = new System.Drawing.Point(18, 25);
            this.data.Multiline = true;
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(586, 210);
            this.data.TabIndex = 2;
            this.data.TextChanged += new System.EventHandler(this.data_TextChanged);
            // 
            // fileSystemWatcher
            // 
            this.fileSystemWatcher.EnableRaisingEvents = true;
            this.fileSystemWatcher.SynchronizingObject = this;
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(21, 412);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(139, 13);
            this.ResultLabel.TabIndex = 3;
            this.ResultLabel.Text = "No data has been simulated";
            // 
            // location
            // 
            this.location.AutoSize = true;
            this.location.Location = new System.Drawing.Point(21, 255);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(16, 13);
            this.location.TabIndex = 4;
            this.location.Text = "...";
            // 
            // inpuLabel
            // 
            this.inpuLabel.AutoSize = true;
            this.inpuLabel.Location = new System.Drawing.Point(10, 5);
            this.inpuLabel.Name = "inpuLabel";
            this.inpuLabel.Size = new System.Drawing.Size(137, 13);
            this.inpuLabel.TabIndex = 5;
            this.inpuLabel.Text = "Test data for votes inputted";
            // 
            // dropdownmenu
            // 
            this.dropdownmenu.Controls.Add(this.pairwise);
            this.dropdownmenu.Controls.Add(this.method3);
            this.dropdownmenu.Controls.Add(this.dropdown);
            this.dropdownmenu.Controls.Add(this.method2);
            this.dropdownmenu.Location = new System.Drawing.Point(21, 312);
            this.dropdownmenu.MaximumSize = new System.Drawing.Size(583, 96);
            this.dropdownmenu.MinimumSize = new System.Drawing.Size(583, 35);
            this.dropdownmenu.Name = "dropdownmenu";
            this.dropdownmenu.Size = new System.Drawing.Size(583, 96);
            this.dropdownmenu.TabIndex = 7;
            // 
            // pairwise
            // 
            this.pairwise.Location = new System.Drawing.Point(0, 74);
            this.pairwise.Name = "pairwise";
            this.pairwise.Size = new System.Drawing.Size(583, 23);
            this.pairwise.TabIndex = 8;
            this.pairwise.Text = "Pairwise";
            this.pairwise.UseVisualStyleBackColor = true;
            this.pairwise.Click += new System.EventHandler(this.pairwise_Click);
            // 
            // method3
            // 
            this.method3.Location = new System.Drawing.Point(0, 53);
            this.method3.Name = "method3";
            this.method3.Size = new System.Drawing.Size(583, 23);
            this.method3.TabIndex = 3;
            this.method3.Text = "Prefrence Order";
            this.method3.UseVisualStyleBackColor = true;
            this.method3.Click += new System.EventHandler(this.method3_Click);
            // 
            // dropdown
            // 
            this.dropdown.Location = new System.Drawing.Point(0, 0);
            this.dropdown.Name = "dropdown";
            this.dropdown.Size = new System.Drawing.Size(583, 35);
            this.dropdown.TabIndex = 2;
            this.dropdown.Text = "Methods";
            this.dropdown.UseVisualStyleBackColor = true;
            this.dropdown.Click += new System.EventHandler(this.dropdown_Click);
            // 
            // method2
            // 
            this.method2.Location = new System.Drawing.Point(0, 32);
            this.method2.Name = "method2";
            this.method2.Size = new System.Drawing.Size(583, 23);
            this.method2.TabIndex = 1;
            this.method2.Text = "First Choice";
            this.method2.UseVisualStyleBackColor = true;
            this.method2.Click += new System.EventHandler(this.method2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // amountCheck
            // 
            this.amountCheck.AutoSize = true;
            this.amountCheck.Location = new System.Drawing.Point(328, 5);
            this.amountCheck.Name = "amountCheck";
            this.amountCheck.Size = new System.Drawing.Size(276, 17);
            this.amountCheck.TabIndex = 8;
            this.amountCheck.Text = "Is the amount of times a vote been casted listed first?";
            this.amountCheck.UseVisualStyleBackColor = true;
            // 
            // delimiterText
            // 
            this.delimiterText.Location = new System.Drawing.Point(78, 237);
            this.delimiterText.MaxLength = 1;
            this.delimiterText.Multiline = true;
            this.delimiterText.Name = "delimiterText";
            this.delimiterText.Size = new System.Drawing.Size(18, 18);
            this.delimiterText.TabIndex = 9;
            this.delimiterText.TextChanged += new System.EventHandler(this.delimiterText_TextChanged);
            // 
            // delimiterLabel
            // 
            this.delimiterLabel.AutoSize = true;
            this.delimiterLabel.Location = new System.Drawing.Point(18, 239);
            this.delimiterLabel.Name = "delimiterLabel";
            this.delimiterLabel.Size = new System.Drawing.Size(50, 13);
            this.delimiterLabel.TabIndex = 10;
            this.delimiterLabel.Text = "Delimiter:";
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Location = new System.Drawing.Point(96, 240);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 13);
            this.error.TabIndex = 11;
            // 
            // matrixLabel
            // 
            this.matrixLabel.AutoSize = true;
            this.matrixLabel.Location = new System.Drawing.Point(431, 412);
            this.matrixLabel.Name = "matrixLabel";
            this.matrixLabel.Size = new System.Drawing.Size(0, 13);
            this.matrixLabel.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 635);
            this.Controls.Add(this.matrixLabel);
            this.Controls.Add(this.error);
            this.Controls.Add(this.delimiterLabel);
            this.Controls.Add(this.delimiterText);
            this.Controls.Add(this.amountCheck);
            this.Controls.Add(this.dropdownmenu);
            this.Controls.Add(this.inpuLabel);
            this.Controls.Add(this.location);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.data);
            this.Controls.Add(this.simulate);
            this.Controls.Add(this.fileUpload);
            this.Name = "Form1";
            this.Text = "Voting Simulatior";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).EndInit();
            this.dropdownmenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fileUpload;
        private System.Windows.Forms.Button simulate;
        private System.Windows.Forms.TextBox data;
        private System.IO.FileSystemWatcher fileSystemWatcher;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Label location;
        private System.Windows.Forms.Label inpuLabel;
        private System.Windows.Forms.Panel dropdownmenu;
        private System.Windows.Forms.Button method2;
        private System.Windows.Forms.Button dropdown;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button method3;
        private System.Windows.Forms.Button pairwise;
        private System.Windows.Forms.CheckBox amountCheck;
        private System.Windows.Forms.Label delimiterLabel;
        private System.Windows.Forms.TextBox delimiterText;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.Label matrixLabel;
    }
}

