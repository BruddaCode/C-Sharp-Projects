namespace tekstverwerker
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
            btnLoad = new Button();
            btnSave = new Button();
            btnClear = new Button();
            rtbTekst = new RichTextBox();
            SuspendLayout();
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.Transparent;
            btnLoad.FlatAppearance.BorderSize = 3;
            btnLoad.FlatStyle = FlatStyle.Flat;
            btnLoad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLoad.ForeColor = SystemColors.WindowText;
            btnLoad.Location = new Point(12, 346);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(104, 43);
            btnLoad.TabIndex = 0;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Transparent;
            btnSave.FlatAppearance.BorderSize = 3;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = SystemColors.WindowText;
            btnSave.Location = new Point(12, 395);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(104, 43);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Transparent;
            btnClear.FlatAppearance.BorderSize = 3;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.ForeColor = SystemColors.WindowText;
            btnClear.Location = new Point(122, 395);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(104, 43);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // rtbTekst
            // 
            rtbTekst.BackColor = Color.White;
            rtbTekst.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rtbTekst.Location = new Point(12, 12);
            rtbTekst.Name = "rtbTekst";
            rtbTekst.Size = new Size(776, 160);
            rtbTekst.TabIndex = 3;
            rtbTekst.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(rtbTekst);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(btnLoad);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Tekst Verwerker";
            ResumeLayout(false);
        }

        #endregion

        private Button btnLoad;
        private Button btnSave;
        private Button btnClear;
        private RichTextBox rtbTekst;
    }
}