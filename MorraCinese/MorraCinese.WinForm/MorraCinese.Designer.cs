
namespace MorraCinese.WinForm
{
    partial class MorraCinese
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
            this.btnCarta = new System.Windows.Forms.Button();
            this.btnSasso = new System.Windows.Forms.Button();
            this.btnForbici = new System.Windows.Forms.Button();
            this.imgSceltaUtente = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgSceltaUtente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCarta
            // 
            this.btnCarta.Location = new System.Drawing.Point(60, 67);
            this.btnCarta.Name = "btnCarta";
            this.btnCarta.Size = new System.Drawing.Size(122, 60);
            this.btnCarta.TabIndex = 0;
            this.btnCarta.Text = "Carta";
            this.btnCarta.UseVisualStyleBackColor = true;
            this.btnCarta.Click += new System.EventHandler(this.btnCarta_Click);
            // 
            // btnSasso
            // 
            this.btnSasso.Location = new System.Drawing.Point(59, 147);
            this.btnSasso.Name = "btnSasso";
            this.btnSasso.Size = new System.Drawing.Size(122, 59);
            this.btnSasso.TabIndex = 1;
            this.btnSasso.Text = "Sasso";
            this.btnSasso.UseVisualStyleBackColor = true;
            this.btnSasso.Click += new System.EventHandler(this.btnSasso_Click);
            // 
            // btnForbici
            // 
            this.btnForbici.Location = new System.Drawing.Point(60, 231);
            this.btnForbici.Name = "btnForbici";
            this.btnForbici.Size = new System.Drawing.Size(121, 59);
            this.btnForbici.TabIndex = 2;
            this.btnForbici.Text = "Forbici";
            this.btnForbici.UseVisualStyleBackColor = true;
            this.btnForbici.Click += new System.EventHandler(this.btnForbici_Click);
            // 
            // imgSceltaUtente
            // 
            this.imgSceltaUtente.Location = new System.Drawing.Point(204, 43);
            this.imgSceltaUtente.Name = "imgSceltaUtente";
            this.imgSceltaUtente.Size = new System.Drawing.Size(404, 386);
            this.imgSceltaUtente.TabIndex = 3;
            this.imgSceltaUtente.TabStop = false;
            // 
            // MorraCinese
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 547);
            this.Controls.Add(this.imgSceltaUtente);
            this.Controls.Add(this.btnForbici);
            this.Controls.Add(this.btnSasso);
            this.Controls.Add(this.btnCarta);
            this.Name = "MorraCinese";
            this.Text = "Morra Cinese";
            ((System.ComponentModel.ISupportInitialize)(this.imgSceltaUtente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCarta;
        private System.Windows.Forms.Button btnSasso;
        private System.Windows.Forms.Button btnForbici;
        private System.Windows.Forms.PictureBox imgSceltaUtente;
    }
}

