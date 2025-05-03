namespace RecordingRenamer
{
    partial class Preferences
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbInputFilePath = new System.Windows.Forms.TextBox();
            this.tbOutputFilePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBackupFilePath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInputFilePath = new System.Windows.Forms.Button();
            this.btnOutputFilePath = new System.Windows.Forms.Button();
            this.btnBackupFilePath = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.cbDoDebug = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(227, 361);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 36);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(370, 361);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 36);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input File Path";
            // 
            // tbInputFilePath
            // 
            this.tbInputFilePath.Location = new System.Drawing.Point(84, 90);
            this.tbInputFilePath.Name = "tbInputFilePath";
            this.tbInputFilePath.Size = new System.Drawing.Size(862, 26);
            this.tbInputFilePath.TabIndex = 3;
            // 
            // tbOutputFilePath
            // 
            this.tbOutputFilePath.Location = new System.Drawing.Point(84, 163);
            this.tbOutputFilePath.Name = "tbOutputFilePath";
            this.tbOutputFilePath.Size = new System.Drawing.Size(861, 26);
            this.tbOutputFilePath.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Output File Path";
            // 
            // tbBackupFilePath
            // 
            this.tbBackupFilePath.Location = new System.Drawing.Point(84, 240);
            this.tbBackupFilePath.Name = "tbBackupFilePath";
            this.tbBackupFilePath.Size = new System.Drawing.Size(861, 26);
            this.tbBackupFilePath.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Backup File Path";
            // 
            // btnInputFilePath
            // 
            this.btnInputFilePath.Location = new System.Drawing.Point(952, 90);
            this.btnInputFilePath.Name = "btnInputFilePath";
            this.btnInputFilePath.Size = new System.Drawing.Size(31, 26);
            this.btnInputFilePath.TabIndex = 8;
            this.btnInputFilePath.Text = "...";
            this.btnInputFilePath.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInputFilePath.UseVisualStyleBackColor = true;
            this.btnInputFilePath.Click += new System.EventHandler(this.btnInputFilePath_Click);
            // 
            // btnOutputFilePath
            // 
            this.btnOutputFilePath.Location = new System.Drawing.Point(951, 163);
            this.btnOutputFilePath.Name = "btnOutputFilePath";
            this.btnOutputFilePath.Size = new System.Drawing.Size(31, 26);
            this.btnOutputFilePath.TabIndex = 9;
            this.btnOutputFilePath.Text = "...";
            this.btnOutputFilePath.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOutputFilePath.UseVisualStyleBackColor = true;
            this.btnOutputFilePath.Click += new System.EventHandler(this.btnOutputFilePath_Click);
            // 
            // btnBackupFilePath
            // 
            this.btnBackupFilePath.Location = new System.Drawing.Point(952, 240);
            this.btnBackupFilePath.Name = "btnBackupFilePath";
            this.btnBackupFilePath.Size = new System.Drawing.Size(31, 26);
            this.btnBackupFilePath.TabIndex = 10;
            this.btnBackupFilePath.Text = "...";
            this.btnBackupFilePath.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBackupFilePath.UseVisualStyleBackColor = true;
            this.btnBackupFilePath.Click += new System.EventHandler(this.btnBackupFilePath_Click);
            // 
            // cbDoDebug
            // 
            this.cbDoDebug.AutoSize = true;
            this.cbDoDebug.Checked = true;
            this.cbDoDebug.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDoDebug.Location = new System.Drawing.Point(84, 300);
            this.cbDoDebug.Name = "cbDoDebug";
            this.cbDoDebug.Size = new System.Drawing.Size(138, 24);
            this.cbDoDebug.TabIndex = 11;
            this.cbDoDebug.Text = "cbTestConvert";
            this.cbDoDebug.UseVisualStyleBackColor = true;
            // 
            // Preferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 460);
            this.Controls.Add(this.cbDoDebug);
            this.Controls.Add(this.btnBackupFilePath);
            this.Controls.Add(this.btnOutputFilePath);
            this.Controls.Add(this.btnInputFilePath);
            this.Controls.Add(this.tbBackupFilePath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbOutputFilePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbInputFilePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Preferences";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Preferences";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInputFilePath;
        private System.Windows.Forms.Button btnOutputFilePath;
        private System.Windows.Forms.Button btnBackupFilePath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        public System.Windows.Forms.TextBox tbInputFilePath;
        public System.Windows.Forms.TextBox tbOutputFilePath;
        public System.Windows.Forms.TextBox tbBackupFilePath;
        public System.Windows.Forms.CheckBox cbDoDebug;
    }
}