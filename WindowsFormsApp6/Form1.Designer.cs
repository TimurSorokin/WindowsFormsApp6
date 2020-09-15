namespace WindowsFormsApp6
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
            this.show = new System.Windows.Forms.Button();
            this.addimage = new System.Windows.Forms.Button();
            this.find = new System.Windows.Forms.Button();
            this.addfolder = new System.Windows.Forms.Button();
            this.console = new System.Windows.Forms.RichTextBox();
            this.console2 = new System.Windows.Forms.RichTextBox();
            this.stats = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.findTextBox = new System.Windows.Forms.TextBox();
            this.findOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // show
            // 
            this.show.Location = new System.Drawing.Point(187, 277);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(75, 23);
            this.show.TabIndex = 0;
            this.show.Text = "Show Images";
            this.show.UseVisualStyleBackColor = true;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // addimage
            // 
            this.addimage.Location = new System.Drawing.Point(25, 277);
            this.addimage.Name = "addimage";
            this.addimage.Size = new System.Drawing.Size(75, 23);
            this.addimage.TabIndex = 1;
            this.addimage.Text = "Add Image";
            this.addimage.UseVisualStyleBackColor = true;
            this.addimage.Click += new System.EventHandler(this.add_Click);
            // 
            // find
            // 
            this.find.Location = new System.Drawing.Point(268, 277);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(75, 23);
            this.find.TabIndex = 2;
            this.find.Text = "Find Image";
            this.find.UseVisualStyleBackColor = true;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // addfolder
            // 
            this.addfolder.Location = new System.Drawing.Point(106, 277);
            this.addfolder.Name = "addfolder";
            this.addfolder.Size = new System.Drawing.Size(75, 23);
            this.addfolder.TabIndex = 4;
            this.addfolder.Text = "Add Folder";
            this.addfolder.UseVisualStyleBackColor = true;
            this.addfolder.Click += new System.EventHandler(this.addfolder_Click);
            // 
            // console
            // 
            this.console.BackColor = System.Drawing.Color.LightSteelBlue;
            this.console.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.console.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.console.ForeColor = System.Drawing.Color.Black;
            this.console.Location = new System.Drawing.Point(12, 12);
            this.console.Name = "console";
            this.console.Size = new System.Drawing.Size(879, 256);
            this.console.TabIndex = 5;
            this.console.Text = "";
            this.console.TextChanged += new System.EventHandler(this.console_TextChanged);
            // 
            // console2
            // 
            this.console2.Location = new System.Drawing.Point(738, 274);
            this.console2.Name = "console2";
            this.console2.Size = new System.Drawing.Size(153, 96);
            this.console2.TabIndex = 6;
            this.console2.Text = "";
            // 
            // stats
            // 
            this.stats.AutoSize = true;
            this.stats.Location = new System.Drawing.Point(687, 277);
            this.stats.Name = "stats";
            this.stats.Size = new System.Drawing.Size(45, 13);
            this.stats.TabIndex = 7;
            this.stats.Text = "STATS:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // findTextBox
            // 
            this.findTextBox.Location = new System.Drawing.Point(268, 306);
            this.findTextBox.Name = "findTextBox";
            this.findTextBox.Size = new System.Drawing.Size(100, 20);
            this.findTextBox.TabIndex = 8;
            // 
            // findOk
            // 
            this.findOk.Location = new System.Drawing.Point(374, 303);
            this.findOk.Name = "findOk";
            this.findOk.Size = new System.Drawing.Size(40, 23);
            this.findOk.TabIndex = 9;
            this.findOk.Text = "Find";
            this.findOk.UseVisualStyleBackColor = true;
            this.findOk.Click += new System.EventHandler(this.findOk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 388);
            this.Controls.Add(this.findOk);
            this.Controls.Add(this.findTextBox);
            this.Controls.Add(this.addfolder);
            this.Controls.Add(this.find);
            this.Controls.Add(this.show);
            this.Controls.Add(this.stats);
            this.Controls.Add(this.addimage);
            this.Controls.Add(this.console2);
            this.Controls.Add(this.console);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button show;
        private System.Windows.Forms.Button addimage;
        private System.Windows.Forms.Button find;
        private System.Windows.Forms.RichTextBox console;
        private System.Windows.Forms.RichTextBox console2;
        private System.Windows.Forms.Label stats;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button addfolder;
        private System.Windows.Forms.TextBox findTextBox;
        private System.Windows.Forms.Button findOk;
    }
}

