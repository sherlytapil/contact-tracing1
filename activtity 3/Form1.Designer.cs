namespace activtity_3
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
            this.button1 = new System.Windows.Forms.Button();
            this.nhdb = new System.Windows.Forms.ListBox();
            this.File = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Output";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // nhdb
            // 
            this.nhdb.FormattingEnabled = true;
            this.nhdb.ItemHeight = 20;
            this.nhdb.Location = new System.Drawing.Point(167, 56);
            this.nhdb.Name = "nhdb";
            this.nhdb.Size = new System.Drawing.Size(467, 44);
            this.nhdb.TabIndex = 1;
            // 
            // File
            // 
            this.File.Location = new System.Drawing.Point(177, 148);
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(124, 39);
            this.File.TabIndex = 2;
            this.File.Text = "File";
            this.File.UseVisualStyleBackColor = true;
            this.File.Click += new System.EventHandler(this.File_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(377, 148);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 39);
            this.button2.TabIndex = 3;
            this.button2.Text = "Folder";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.File);
            this.Controls.Add(this.nhdb);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox nhdb;
        private System.Windows.Forms.Button File;
        private System.Windows.Forms.Button button2;
    }
}

