namespace SterowanieTCP
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Up = new System.Windows.Forms.Button();
            this.Right = new System.Windows.Forms.Button();
            this.Down = new System.Windows.Forms.Button();
            this.Left = new System.Windows.Forms.Button();
            this.Jump = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Up
            // 
            this.Up.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Up.Location = new System.Drawing.Point(179, 83);
            this.Up.Name = "Up";
            this.Up.Size = new System.Drawing.Size(74, 59);
            this.Up.TabIndex = 0;
            this.Up.Text = "↑";
            this.Up.UseVisualStyleBackColor = true;
            this.Up.Click += new System.EventHandler(this.button1_Click);
            // 
            // Right
            // 
            this.Right.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Right.Location = new System.Drawing.Point(250, 141);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(74, 59);
            this.Right.TabIndex = 1;
            this.Right.Text = "→";
            this.Right.UseVisualStyleBackColor = true;
            this.Right.Click += new System.EventHandler(this.Right_Click);
            // 
            // Down
            // 
            this.Down.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Down.Location = new System.Drawing.Point(179, 195);
            this.Down.Name = "Down";
            this.Down.Size = new System.Drawing.Size(74, 59);
            this.Down.TabIndex = 2;
            this.Down.Text = "↓";
            this.Down.UseVisualStyleBackColor = true;
            this.Down.Click += new System.EventHandler(this.Down_Click);
            // 
            // Left
            // 
            this.Left.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Left.Location = new System.Drawing.Point(108, 141);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(74, 59);
            this.Left.TabIndex = 3;
            this.Left.Text = "←";
            this.Left.UseVisualStyleBackColor = true;
            this.Left.Click += new System.EventHandler(this.Left_Click);
            // 
            // Jump
            // 
            this.Jump.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Jump.Location = new System.Drawing.Point(179, 141);
            this.Jump.Name = "Jump";
            this.Jump.Size = new System.Drawing.Size(74, 59);
            this.Jump.TabIndex = 4;
            this.Jump.Text = "JUMP";
            this.Jump.UseVisualStyleBackColor = true;
            this.Jump.Click += new System.EventHandler(this.Jump_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 356);
            this.Controls.Add(this.Jump);
            this.Controls.Add(this.Left);
            this.Controls.Add(this.Down);
            this.Controls.Add(this.Right);
            this.Controls.Add(this.Up);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Sterowanie";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Up;
        private System.Windows.Forms.Button Right;
        private System.Windows.Forms.Button Down;
        private System.Windows.Forms.Button Left;
        private System.Windows.Forms.Button Jump;
    }
}

