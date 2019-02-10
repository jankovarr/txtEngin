namespace UniConvert
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.chbHoo = new System.Windows.Forms.CheckBox();
            this.chbHooAddsTest = new System.Windows.Forms.CheckBox();
            this.chbBackToClip = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDuplicates = new System.Windows.Forms.Button();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(1105, -40);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(744, 464);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            this.richTextBox1.MouseEnter += new System.EventHandler(this.richTextBox1_MouseEnter);
            this.richTextBox1.MouseHover += new System.EventHandler(this.richTextBox1_MouseHover);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.richTextBox2.Location = new System.Drawing.Point(1648, 34);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(727, 658);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            this.richTextBox2.MouseEnter += new System.EventHandler(this.richTextBox2_MouseEnter);
            this.richTextBox2.MouseHover += new System.EventHandler(this.richTextBox2_MouseHover);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.chbHoo);
            this.groupBox1.Controls.Add(this.chbHooAddsTest);
            this.groupBox1.Controls.Add(this.chbBackToClip);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(2378, 229);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button2.Location = new System.Drawing.Point(3, 172);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(2372, 54);
            this.button2.TabIndex = 4;
            this.button2.Text = "&Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // chbHoo
            // 
            this.chbHoo.AutoSize = true;
            this.chbHoo.Location = new System.Drawing.Point(692, 37);
            this.chbHoo.Name = "chbHoo";
            this.chbHoo.Size = new System.Drawing.Size(342, 36);
            this.chbHoo.TabIndex = 2;
            this.chbHoo.Text = "MouseHoover ON/OFF";
            this.chbHoo.UseVisualStyleBackColor = true;
            this.chbHoo.CheckStateChanged += new System.EventHandler(this.chbHoo_CheckStateChanged);
            // 
            // chbHooAddsTest
            // 
            this.chbHooAddsTest.AutoSize = true;
            this.chbHooAddsTest.Location = new System.Drawing.Point(723, 79);
            this.chbHooAddsTest.Name = "chbHooAddsTest";
            this.chbHooAddsTest.Size = new System.Drawing.Size(351, 36);
            this.chbHooAddsTest.TabIndex = 1;
            this.chbHooAddsTest.Text = "MouseHoover adds text";
            this.chbHooAddsTest.UseVisualStyleBackColor = true;
            // 
            // chbBackToClip
            // 
            this.chbBackToClip.AutoSize = true;
            this.chbBackToClip.Location = new System.Drawing.Point(236, 37);
            this.chbBackToClip.Name = "chbBackToClip";
            this.chbBackToClip.Size = new System.Drawing.Size(362, 36);
            this.chbBackToClip.TabIndex = 0;
            this.chbBackToClip.Text = "ReturnBack to Clipboard";
            this.chbBackToClip.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBox3);
            this.groupBox2.Controls.Add(this.btnDuplicates);
            this.groupBox2.Controls.Add(this.richTextBox2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 229);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(2378, 695);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ctrl+V or Hoover to Convert";
            this.groupBox2.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.groupBox2_PreviewKeyDown);
            // 
            // btnDuplicates
            // 
            this.btnDuplicates.Location = new System.Drawing.Point(923, 110);
            this.btnDuplicates.Name = "btnDuplicates";
            this.btnDuplicates.Size = new System.Drawing.Size(265, 126);
            this.btnDuplicates.TabIndex = 2;
            this.btnDuplicates.Text = "D&uplicates";
            this.btnDuplicates.UseVisualStyleBackColor = true;
            this.btnDuplicates.Click += new System.EventHandler(this.btnDuplicates_Click);
            // 
            // richTextBox3
            // 
            this.richTextBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.richTextBox3.Location = new System.Drawing.Point(3, 34);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(727, 658);
            this.richTextBox3.TabIndex = 3;
            this.richTextBox3.Text = "";
            this.richTextBox3.TextChanged += new System.EventHandler(this.richTextBox3_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2378, 924);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "UniConv_G2";
            this.Enter += new System.EventHandler(this.Form1_Enter);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseEnter += new System.EventHandler(this.Form1_MouseEnter);
            this.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chbBackToClip;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chbHooAddsTest;
        private System.Windows.Forms.CheckBox chbHoo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDuplicates;
        private System.Windows.Forms.RichTextBox richTextBox3;
    }
}

