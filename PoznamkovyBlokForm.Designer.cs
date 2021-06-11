namespace CS050PoznamkovyBlok
{
    partial class PoznamkovyBlokForm
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
            this.poznTextBox = new System.Windows.Forms.TextBox();
            this.ulozitButton = new System.Windows.Forms.Button();
            this.nacistButton = new System.Windows.Forms.Button();
            this.velikostScrollBar = new System.Windows.Forms.HScrollBar();
            this.velikostTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // poznTextBox
            // 
            this.poznTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.poznTextBox.Location = new System.Drawing.Point(12, 77);
            this.poznTextBox.Multiline = true;
            this.poznTextBox.Name = "poznTextBox";
            this.poznTextBox.Size = new System.Drawing.Size(776, 361);
            this.poznTextBox.TabIndex = 0;
            // 
            // ulozitButton
            // 
            this.ulozitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ulozitButton.Location = new System.Drawing.Point(691, 13);
            this.ulozitButton.Name = "ulozitButton";
            this.ulozitButton.Size = new System.Drawing.Size(97, 45);
            this.ulozitButton.TabIndex = 1;
            this.ulozitButton.Text = "Uložit ";
            this.ulozitButton.UseVisualStyleBackColor = true;
            this.ulozitButton.Click += new System.EventHandler(this.ulozitButton_Click);
            // 
            // nacistButton
            // 
            this.nacistButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nacistButton.Location = new System.Drawing.Point(12, 12);
            this.nacistButton.Name = "nacistButton";
            this.nacistButton.Size = new System.Drawing.Size(102, 45);
            this.nacistButton.TabIndex = 2;
            this.nacistButton.Text = "Načíst";
            this.nacistButton.UseVisualStyleBackColor = true;
            this.nacistButton.Click += new System.EventHandler(this.nacistButton_Click);
            // 
            // velikostScrollBar
            // 
            this.velikostScrollBar.Location = new System.Drawing.Point(188, 27);
            this.velikostScrollBar.Maximum = 72;
            this.velikostScrollBar.Minimum = 8;
            this.velikostScrollBar.Name = "velikostScrollBar";
            this.velikostScrollBar.Size = new System.Drawing.Size(135, 21);
            this.velikostScrollBar.TabIndex = 3;
            this.velikostScrollBar.Value = 8;
            this.velikostScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.velikostScrollBar_Scroll);
            this.velikostScrollBar.ValueChanged += new System.EventHandler(this.velikostScrollBar_ValueChanged);
            // 
            // velikostTextBox
            // 
            this.velikostTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.velikostTextBox.Location = new System.Drawing.Point(344, 27);
            this.velikostTextBox.Name = "velikostTextBox";
            this.velikostTextBox.Size = new System.Drawing.Size(47, 29);
            this.velikostTextBox.TabIndex = 4;
            this.velikostTextBox.TextChanged += new System.EventHandler(this.velikostTextBox_TextChanged);
            this.velikostTextBox.Validated += new System.EventHandler(this.velikostTextBox_Validated);
            // 
            // PoznamkovyBlokForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.velikostTextBox);
            this.Controls.Add(this.velikostScrollBar);
            this.Controls.Add(this.nacistButton);
            this.Controls.Add(this.ulozitButton);
            this.Controls.Add(this.poznTextBox);
            this.Name = "PoznamkovyBlokForm";
            this.Text = "CS52 Poznámkový Blok Ukládání - František Krejný";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox poznTextBox;
        private System.Windows.Forms.Button ulozitButton;
        private System.Windows.Forms.Button nacistButton;
        private System.Windows.Forms.HScrollBar velikostScrollBar;
        private System.Windows.Forms.TextBox velikostTextBox;
    }
}

