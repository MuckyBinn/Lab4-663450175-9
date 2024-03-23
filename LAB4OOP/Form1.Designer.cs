namespace LAB4OOP
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BlackCoffee = new System.Windows.Forms.Button();
            this.Mocha = new System.Windows.Forms.Button();
            this.Latte = new System.Windows.Forms.Button();
            this.Chocolate = new System.Windows.Forms.Button();
            this.Material = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
             
            // pictureBox1
          
            this.pictureBox1.Image = global::LAB4OOP.Properties.Resources.Taobin;
            this.pictureBox1.Location = new System.Drawing.Point(102, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(491, 632);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
       
            // BlackCoffee
           
            this.BlackCoffee.Location = new System.Drawing.Point(292, 145);
            this.BlackCoffee.Name = "BlackCoffee";
            this.BlackCoffee.Size = new System.Drawing.Size(120, 37);
            this.BlackCoffee.TabIndex = 1;
            this.BlackCoffee.Text = "กาแฟดำ";
            this.BlackCoffee.UseVisualStyleBackColor = true;
            this.BlackCoffee.Click += new System.EventHandler(this.BlackCoffee_Click);
           
            // Mocha
           
            this.Mocha.Location = new System.Drawing.Point(292, 188);
            this.Mocha.Name = "Mocha";
            this.Mocha.Size = new System.Drawing.Size(120, 37);
            this.Mocha.TabIndex = 1;
            this.Mocha.Text = "มอคค่า";
            this.Mocha.UseVisualStyleBackColor = true;
            this.Mocha.Click += new System.EventHandler(this.Mocha_Click);
             
            // Latte
            
            this.Latte.Location = new System.Drawing.Point(292, 231);
            this.Latte.Name = "Latte";
            this.Latte.Size = new System.Drawing.Size(120, 37);
            this.Latte.TabIndex = 1;
            this.Latte.Text = "ลาเต้";
            this.Latte.UseVisualStyleBackColor = true;
            this.Latte.Click += new System.EventHandler(this.Latte_Click);
             
            // Chocolate
            
            this.Chocolate.Location = new System.Drawing.Point(292, 274);
            this.Chocolate.Name = "Chocolate";
            this.Chocolate.Size = new System.Drawing.Size(120, 37);
            this.Chocolate.TabIndex = 1;
            this.Chocolate.Text = "ช็อคโกแล็ต";
            this.Chocolate.UseVisualStyleBackColor = true;
            this.Chocolate.Click += new System.EventHandler(this.Chocolate_Click);
             
            // Material
             
            this.Material.Location = new System.Drawing.Point(182, 128);
            this.Material.Name = "Material";
            this.Material.Size = new System.Drawing.Size(95, 47);
            this.Material.TabIndex = 1;
            this.Material.Text = "เติมวัตถุดิบ";
            this.Material.UseVisualStyleBackColor = true;
            this.Material.Click += new System.EventHandler(this.Material_Click);
             
            // Form1
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 704);
            this.Controls.Add(this.Chocolate);
            this.Controls.Add(this.Latte);
            this.Controls.Add(this.Mocha);
            this.Controls.Add(this.Material);
            this.Controls.Add(this.BlackCoffee);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BlackCoffee;
        private System.Windows.Forms.Button Mocha;
        private System.Windows.Forms.Button Latte;
        private System.Windows.Forms.Button Chocolate;
        private System.Windows.Forms.Button Material;
    }
}

