namespace PhotoCopier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.kaynakbox = new System.Windows.Forms.TextBox();
            this.kaynakbutton = new System.Windows.Forms.Button();
            this.hedefbox = new System.Windows.Forms.TextBox();
            this.hedefbutton = new System.Windows.Forms.Button();
            this.run = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Isim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.creation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kaynakbox
            // 
            this.kaynakbox.Enabled = false;
            this.kaynakbox.Location = new System.Drawing.Point(13, 13);
            this.kaynakbox.Name = "kaynakbox";
            this.kaynakbox.Size = new System.Drawing.Size(220, 20);
            this.kaynakbox.TabIndex = 1;
            // 
            // kaynakbutton
            // 
            this.kaynakbutton.Location = new System.Drawing.Point(240, 9);
            this.kaynakbutton.Name = "kaynakbutton";
            this.kaynakbutton.Size = new System.Drawing.Size(92, 23);
            this.kaynakbutton.TabIndex = 2;
            this.kaynakbutton.Text = "Kaynak Klasör";
            this.kaynakbutton.UseVisualStyleBackColor = true;
            this.kaynakbutton.Click += new System.EventHandler(this.KaynakbuttonClick);
            // 
            // hedefbox
            // 
            this.hedefbox.Enabled = false;
            this.hedefbox.Location = new System.Drawing.Point(13, 40);
            this.hedefbox.Name = "hedefbox";
            this.hedefbox.Size = new System.Drawing.Size(220, 20);
            this.hedefbox.TabIndex = 3;
            // 
            // hedefbutton
            // 
            this.hedefbutton.Location = new System.Drawing.Point(240, 36);
            this.hedefbutton.Name = "hedefbutton";
            this.hedefbutton.Size = new System.Drawing.Size(92, 23);
            this.hedefbutton.TabIndex = 4;
            this.hedefbutton.Text = "Hedef Klasör";
            this.hedefbutton.UseVisualStyleBackColor = true;
            this.hedefbutton.Click += new System.EventHandler(this.HedefbuttonClick);
            // 
            // run
            // 
            this.run.Location = new System.Drawing.Point(13, 271);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(319, 39);
            this.run.TabIndex = 5;
            this.run.Text = "Kopyalamaya Başla";
            this.run.UseVisualStyleBackColor = true;
            this.run.Click += new System.EventHandler(this.RunClick);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Isim,
            this.creation});
            this.listView1.Location = new System.Drawing.Point(13, 66);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(319, 199);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListView1MouseClick);
            // 
            // Isim
            // 
            this.Isim.Text = "Dosya";
            this.Isim.Width = 176;
            // 
            // creation
            // 
            this.creation.Text = "Olusturma";
            this.creation.Width = 137;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 313);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(344, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(48, 17);
            this.toolStripStatusLabel1.Text = "0 Dosya";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 335);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.run);
            this.Controls.Add(this.hedefbutton);
            this.Controls.Add(this.hedefbox);
            this.Controls.Add(this.kaynakbutton);
            this.Controls.Add(this.kaynakbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Fotograf Duzenleyici";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox kaynakbox;
        private System.Windows.Forms.Button kaynakbutton;
        private System.Windows.Forms.TextBox hedefbox;
        private System.Windows.Forms.Button hedefbutton;
        private System.Windows.Forms.Button run;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Isim;
        private System.Windows.Forms.ColumnHeader creation;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

