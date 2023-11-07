namespace calculator
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
            label1 = new Label();
            label2 = new Label();
            tbG1 = new TextBox();
            label3 = new Label();
            tbG2 = new TextBox();
            btnAdd = new Button();
            btnMinus = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            btnPower = new Button();
            btnRoot = new Button();
            label4 = new Label();
            tbRes = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("AniMe Matrix - MB_EN", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(357, 9);
            label1.Name = "label1";
            label1.Size = new Size(111, 34);
            label1.TabIndex = 0;
            label1.Text = "clac";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Khaki;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(543, 125);
            label2.Name = "label2";
            label2.Size = new Size(88, 37);
            label2.TabIndex = 1;
            label2.Text = "getal 1";
            // 
            // tbG1
            // 
            tbG1.BackColor = SystemColors.WindowText;
            tbG1.ForeColor = Color.WhiteSmoke;
            tbG1.Location = new Point(637, 131);
            tbG1.Name = "tbG1";
            tbG1.Size = new Size(151, 27);
            tbG1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.SpringGreen;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("MingLiU-ExtB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(543, 180);
            label3.Name = "label3";
            label3.Size = new Size(88, 22);
            label3.TabIndex = 3;
            label3.Text = "getal 2";
            // 
            // tbG2
            // 
            tbG2.BackColor = SystemColors.WindowText;
            tbG2.ForeColor = Color.White;
            tbG2.Location = new Point(637, 177);
            tbG2.Name = "tbG2";
            tbG2.Size = new Size(151, 27);
            tbG2.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LightSeaGreen;
            btnAdd.BackgroundImage = (Image)resources.GetObject("btnAdd.BackgroundImage");
            btnAdd.BackgroundImageLayout = ImageLayout.Stretch;
            btnAdd.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = SystemColors.ControlLightLight;
            btnAdd.Location = new Point(12, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(123, 124);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = Color.Lime;
            btnMinus.BackgroundImage = (Image)resources.GetObject("btnMinus.BackgroundImage");
            btnMinus.BackgroundImageLayout = ImageLayout.Stretch;
            btnMinus.Font = new Font("Segoe UI", 50F, FontStyle.Regular, GraphicsUnit.Point);
            btnMinus.ForeColor = SystemColors.ControlLightLight;
            btnMinus.Location = new Point(141, 12);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(126, 124);
            btnMinus.TabIndex = 6;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = Color.MediumVioletRed;
            btnMultiply.BackgroundImage = (Image)resources.GetObject("btnMultiply.BackgroundImage");
            btnMultiply.BackgroundImageLayout = ImageLayout.Stretch;
            btnMultiply.Font = new Font("Segoe UI", 60F, FontStyle.Regular, GraphicsUnit.Point);
            btnMultiply.ForeColor = SystemColors.ControlLightLight;
            btnMultiply.Location = new Point(12, 142);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(123, 112);
            btnMultiply.TabIndex = 7;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = Color.LightCoral;
            btnDivide.BackgroundImage = (Image)resources.GetObject("btnDivide.BackgroundImage");
            btnDivide.BackgroundImageLayout = ImageLayout.Stretch;
            btnDivide.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
            btnDivide.ForeColor = SystemColors.ControlLight;
            btnDivide.Location = new Point(141, 142);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(126, 112);
            btnDivide.TabIndex = 8;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnPower
            // 
            btnPower.BackColor = Color.SeaGreen;
            btnPower.BackgroundImage = (Image)resources.GetObject("btnPower.BackgroundImage");
            btnPower.BackgroundImageLayout = ImageLayout.Stretch;
            btnPower.Font = new Font("Segoe UI", 50F, FontStyle.Regular, GraphicsUnit.Point);
            btnPower.ForeColor = SystemColors.ControlText;
            btnPower.Location = new Point(12, 260);
            btnPower.Name = "btnPower";
            btnPower.Size = new Size(123, 106);
            btnPower.TabIndex = 9;
            btnPower.Text = "^";
            btnPower.UseVisualStyleBackColor = false;
            btnPower.Click += btnPower_Click;
            // 
            // btnRoot
            // 
            btnRoot.BackColor = Color.DarkViolet;
            btnRoot.BackgroundImage = (Image)resources.GetObject("btnRoot.BackgroundImage");
            btnRoot.BackgroundImageLayout = ImageLayout.Zoom;
            btnRoot.Font = new Font("Segoe UI", 50F, FontStyle.Regular, GraphicsUnit.Point);
            btnRoot.ForeColor = SystemColors.ControlLightLight;
            btnRoot.Location = new Point(141, 260);
            btnRoot.Name = "btnRoot";
            btnRoot.Size = new Size(126, 106);
            btnRoot.TabIndex = 10;
            btnRoot.Text = "√";
            btnRoot.UseVisualStyleBackColor = false;
            btnRoot.Click += btnRoot_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.SlateBlue;
            label4.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(534, 260);
            label4.Name = "label4";
            label4.Size = new Size(97, 25);
            label4.TabIndex = 11;
            label4.Text = "resultaat";
            // 
            // tbRes
            // 
            tbRes.BackColor = SystemColors.WindowText;
            tbRes.ForeColor = SystemColors.Window;
            tbRes.Location = new Point(637, 258);
            tbRes.Multiline = true;
            tbRes.Name = "tbRes";
            tbRes.Size = new Size(151, 180);
            tbRes.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.Screenshot_20230828_160824_Reddit;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(tbRes);
            Controls.Add(label4);
            Controls.Add(btnRoot);
            Controls.Add(btnPower);
            Controls.Add(btnDivide);
            Controls.Add(btnMultiply);
            Controls.Add(btnMinus);
            Controls.Add(btnAdd);
            Controls.Add(tbG2);
            Controls.Add(label3);
            Controls.Add(tbG1);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "UltraSigmaCalculator";
            TransparencyKey = Color.Cyan;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbG1;
        private Label label3;
        private TextBox tbG2;
        private Button btnAdd;
        private Button btnMinus;
        private Button btnMultiply;
        private Button btnDivide;
        private Button btnPower;
        private Button btnRoot;
        private Label label4;
        private TextBox tbRes;
    }
}