namespace Checkers_Marek_Ogrodnik
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
            this.CheckersBoard = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // CheckersBoard
            // 
            this.CheckersBoard.BackColor = System.Drawing.SystemColors.GrayText;
            this.CheckersBoard.Location = new System.Drawing.Point(10, 10);
            this.CheckersBoard.Name = "CheckersBoard";
            this.CheckersBoard.Size = new System.Drawing.Size(644, 594);
            this.CheckersBoard.TabIndex = 0;
            this.CheckersBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.CheckersBoard_Paint);
            this.CheckersBoard.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CheckersBoard_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 641);
            this.Controls.Add(this.CheckersBoard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Checkers";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CheckersBoard;
    }
}

