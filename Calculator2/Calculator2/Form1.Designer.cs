
namespace Calculator2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblNameCalculator = new System.Windows.Forms.Label();
            this.tbGetal1 = new System.Windows.Forms.TextBox();
            this.tbGetal2 = new System.Windows.Forms.TextBox();
            this.lblGetal1 = new System.Windows.Forms.Label();
            this.lblGetal2 = new System.Windows.Forms.Label();
            this.tbResultaat = new System.Windows.Forms.TextBox();
            this.lblResultaat = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNameCalculator
            // 
            this.lblNameCalculator.AutoSize = true;
            this.lblNameCalculator.BackColor = System.Drawing.Color.Transparent;
            this.lblNameCalculator.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNameCalculator.Location = new System.Drawing.Point(186, 9);
            this.lblNameCalculator.Name = "lblNameCalculator";
            this.lblNameCalculator.Size = new System.Drawing.Size(366, 54);
            this.lblNameCalculator.TabIndex = 0;
            this.lblNameCalculator.Text = "Brugge\'s Calculator";
            // 
            // tbGetal1
            // 
            this.tbGetal1.Location = new System.Drawing.Point(573, 93);
            this.tbGetal1.Name = "tbGetal1";
            this.tbGetal1.Size = new System.Drawing.Size(165, 27);
            this.tbGetal1.TabIndex = 1;
            // 
            // tbGetal2
            // 
            this.tbGetal2.Location = new System.Drawing.Point(573, 150);
            this.tbGetal2.Name = "tbGetal2";
            this.tbGetal2.Size = new System.Drawing.Size(165, 27);
            this.tbGetal2.TabIndex = 2;
            // 
            // lblGetal1
            // 
            this.lblGetal1.AutoSize = true;
            this.lblGetal1.BackColor = System.Drawing.Color.Transparent;
            this.lblGetal1.Location = new System.Drawing.Point(458, 100);
            this.lblGetal1.Name = "lblGetal1";
            this.lblGetal1.Size = new System.Drawing.Size(94, 20);
            this.lblGetal1.TabIndex = 3;
            this.lblGetal1.Text = "Eerste getal: ";
            // 
            // lblGetal2
            // 
            this.lblGetal2.AutoSize = true;
            this.lblGetal2.BackColor = System.Drawing.Color.Transparent;
            this.lblGetal2.Location = new System.Drawing.Point(458, 151);
            this.lblGetal2.Name = "lblGetal2";
            this.lblGetal2.Size = new System.Drawing.Size(101, 20);
            this.lblGetal2.TabIndex = 4;
            this.lblGetal2.Text = "Tweede getal:";
            // 
            // tbResultaat
            // 
            this.tbResultaat.Location = new System.Drawing.Point(573, 313);
            this.tbResultaat.Name = "tbResultaat";
            this.tbResultaat.Size = new System.Drawing.Size(178, 27);
            this.tbResultaat.TabIndex = 5;
            // 
            // lblResultaat
            // 
            this.lblResultaat.AutoSize = true;
            this.lblResultaat.BackColor = System.Drawing.Color.Transparent;
            this.lblResultaat.Location = new System.Drawing.Point(468, 314);
            this.lblResultaat.Name = "lblResultaat";
            this.lblResultaat.Size = new System.Drawing.Size(77, 20);
            this.lblResultaat.TabIndex = 6;
            this.lblResultaat.Text = "Resultaat: ";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(39, 100);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(66, 77);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(148, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 77);
            this.button1.TabIndex = 8;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblResultaat);
            this.Controls.Add(this.tbResultaat);
            this.Controls.Add(this.lblGetal2);
            this.Controls.Add(this.lblGetal1);
            this.Controls.Add(this.tbGetal2);
            this.Controls.Add(this.tbGetal1);
            this.Controls.Add(this.lblNameCalculator);
            this.Name = "Form1";
            this.Text = "Brugge\'s Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameCalculator;
        private System.Windows.Forms.TextBox tbGetal1;
        private System.Windows.Forms.TextBox tbGetal2;
        private System.Windows.Forms.Label lblGetal1;
        private System.Windows.Forms.Label lblGetal2;
        private System.Windows.Forms.TextBox tbResultaat;
        private System.Windows.Forms.Label lblResultaat;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button1;
    }
}

