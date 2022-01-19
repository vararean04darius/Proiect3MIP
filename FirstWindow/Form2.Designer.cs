namespace FirstWindow
{
    partial class Form2
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
            this.garnituribtn = new System.Windows.Forms.Button();
            this.carnebtn = new System.Windows.Forms.Button();
            this.deserturibtn = new System.Windows.Forms.Button();
            this.bauturibtn = new System.Windows.Forms.Button();
            this.cosbtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // garnituribtn
            // 
            this.garnituribtn.Location = new System.Drawing.Point(30, 41);
            this.garnituribtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.garnituribtn.Name = "garnituribtn";
            this.garnituribtn.Size = new System.Drawing.Size(70, 31);
            this.garnituribtn.TabIndex = 0;
            this.garnituribtn.Text = "Garnituri";
            this.garnituribtn.UseVisualStyleBackColor = true;
            this.garnituribtn.Click += new System.EventHandler(this.garnituribtn_Click);
            // 
            // carnebtn
            // 
            this.carnebtn.Location = new System.Drawing.Point(30, 114);
            this.carnebtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.carnebtn.Name = "carnebtn";
            this.carnebtn.Size = new System.Drawing.Size(114, 31);
            this.carnebtn.TabIndex = 1;
            this.carnebtn.Text = "Preparate din carne";
            this.carnebtn.UseVisualStyleBackColor = true;
            this.carnebtn.Click += new System.EventHandler(this.carnebtn_Click);
            // 
            // deserturibtn
            // 
            this.deserturibtn.Location = new System.Drawing.Point(30, 180);
            this.deserturibtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deserturibtn.Name = "deserturibtn";
            this.deserturibtn.Size = new System.Drawing.Size(70, 31);
            this.deserturibtn.TabIndex = 2;
            this.deserturibtn.Text = "Deserturi";
            this.deserturibtn.UseVisualStyleBackColor = true;
            this.deserturibtn.Click += new System.EventHandler(this.deserturibtn_Click);
            // 
            // bauturibtn
            // 
            this.bauturibtn.Location = new System.Drawing.Point(30, 246);
            this.bauturibtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bauturibtn.Name = "bauturibtn";
            this.bauturibtn.Size = new System.Drawing.Size(70, 31);
            this.bauturibtn.TabIndex = 3;
            this.bauturibtn.Text = "Bauturi";
            this.bauturibtn.UseVisualStyleBackColor = true;
            this.bauturibtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // cosbtn
            // 
            this.cosbtn.Location = new System.Drawing.Point(334, 246);
            this.cosbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cosbtn.Name = "cosbtn";
            this.cosbtn.Size = new System.Drawing.Size(100, 31);
            this.cosbtn.TabIndex = 4;
            this.cosbtn.Text = "Vizualizare cos";
            this.cosbtn.UseVisualStyleBackColor = true;
            this.cosbtn.Click += new System.EventHandler(this.cosbtn_Click);
            // 
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(334, 299);
            this.backbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(100, 31);
            this.backbtn.TabIndex = 5;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 340);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.cosbtn);
            this.Controls.Add(this.bauturibtn);
            this.Controls.Add(this.deserturibtn);
            this.Controls.Add(this.carnebtn);
            this.Controls.Add(this.garnituribtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button garnituribtn;
        private System.Windows.Forms.Button carnebtn;
        private System.Windows.Forms.Button deserturibtn;
        private System.Windows.Forms.Button bauturibtn;
        private System.Windows.Forms.Button cosbtn;
        private System.Windows.Forms.Button backbtn;
    }
}