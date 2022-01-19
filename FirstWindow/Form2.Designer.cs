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
            this.garnituribtn.Location = new System.Drawing.Point(40, 51);
            this.garnituribtn.Name = "garnituribtn";
            this.garnituribtn.Size = new System.Drawing.Size(94, 38);
            this.garnituribtn.TabIndex = 0;
            this.garnituribtn.Text = "Garnituri";
            this.garnituribtn.UseVisualStyleBackColor = true;
            this.garnituribtn.Click += new System.EventHandler(this.garnituribtn_Click);
            // 
            // carnebtn
            // 
            this.carnebtn.Location = new System.Drawing.Point(40, 140);
            this.carnebtn.Name = "carnebtn";
            this.carnebtn.Size = new System.Drawing.Size(152, 38);
            this.carnebtn.TabIndex = 1;
            this.carnebtn.Text = "Preparate din carne";
            this.carnebtn.UseVisualStyleBackColor = true;
            this.carnebtn.Click += new System.EventHandler(this.carnebtn_Click);
            // 
            // deserturibtn
            // 
            this.deserturibtn.Location = new System.Drawing.Point(40, 222);
            this.deserturibtn.Name = "deserturibtn";
            this.deserturibtn.Size = new System.Drawing.Size(94, 38);
            this.deserturibtn.TabIndex = 2;
            this.deserturibtn.Text = "Deserturi";
            this.deserturibtn.UseVisualStyleBackColor = true;
            this.deserturibtn.Click += new System.EventHandler(this.deserturibtn_Click);
            // 
            // bauturibtn
            // 
            this.bauturibtn.Location = new System.Drawing.Point(40, 303);
            this.bauturibtn.Name = "bauturibtn";
            this.bauturibtn.Size = new System.Drawing.Size(94, 38);
            this.bauturibtn.TabIndex = 3;
            this.bauturibtn.Text = "Bauturi";
            this.bauturibtn.UseVisualStyleBackColor = true;
            this.bauturibtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // cosbtn
            // 
            this.cosbtn.Location = new System.Drawing.Point(446, 303);
            this.cosbtn.Name = "cosbtn";
            this.cosbtn.Size = new System.Drawing.Size(134, 38);
            this.cosbtn.TabIndex = 4;
            this.cosbtn.Text = "Vizualizare cos";
            this.cosbtn.UseVisualStyleBackColor = true;
            // 
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(446, 368);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(134, 38);
            this.backbtn.TabIndex = 5;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 418);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.cosbtn);
            this.Controls.Add(this.bauturibtn);
            this.Controls.Add(this.deserturibtn);
            this.Controls.Add(this.carnebtn);
            this.Controls.Add(this.garnituribtn);
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