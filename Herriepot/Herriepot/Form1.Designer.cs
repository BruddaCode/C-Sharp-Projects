namespace Herriepot
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
            rtbText1 = new RichTextBox();
            btnPlay = new Button();
            SuspendLayout();
            // 
            // rtbText1
            // 
            rtbText1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rtbText1.Location = new Point(126, 12);
            rtbText1.Name = "rtbText1";
            rtbText1.RightToLeft = RightToLeft.No;
            rtbText1.Size = new Size(535, 171);
            rtbText1.TabIndex = 0;
            rtbText1.Text = "";
            // 
            // btnPlay
            // 
            btnPlay.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            btnPlay.Location = new Point(291, 189);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(214, 127);
            btnPlay.TabIndex = 1;
            btnPlay.Text = "Play";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPlay);
            Controls.Add(rtbText1);
            Name = "Form1";
            Text = "Boops";
            Load += Form1_Load;
            KeyPress += Form1_KeyPress;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtbText1;
        private Button btnPlay;
    }
}