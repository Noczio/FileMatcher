namespace AppGetSameFiles
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnLeft = new System.Windows.Forms.Button();
            this.lbLeft = new System.Windows.Forms.ListBox();
            this.lbRight = new System.Windows.Forms.ListBox();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnMatch = new System.Windows.Forms.Button();
            this.gpLeft = new System.Windows.Forms.GroupBox();
            this.gpRight = new System.Windows.Forms.GroupBox();
            this.gpMatch = new System.Windows.Forms.GroupBox();
            this.lblMatch = new System.Windows.Forms.Label();
            this.gpLeft.SuspendLayout();
            this.gpRight.SuspendLayout();
            this.gpMatch.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLeft
            // 
            this.btnLeft.AutoSize = true;
            this.btnLeft.Location = new System.Drawing.Point(16, 22);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(83, 23);
            this.btnLeft.TabIndex = 0;
            this.btnLeft.Text = "Open folder";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.bntLeft_Click);
            // 
            // lbLeft
            // 
            this.lbLeft.FormattingEnabled = true;
            this.lbLeft.HorizontalScrollbar = true;
            this.lbLeft.Location = new System.Drawing.Point(16, 51);
            this.lbLeft.Name = "lbLeft";
            this.lbLeft.Size = new System.Drawing.Size(305, 290);
            this.lbLeft.TabIndex = 1;
            // 
            // lbRight
            // 
            this.lbRight.FormattingEnabled = true;
            this.lbRight.HorizontalScrollbar = true;
            this.lbRight.Location = new System.Drawing.Point(17, 51);
            this.lbRight.Name = "lbRight";
            this.lbRight.Size = new System.Drawing.Size(305, 290);
            this.lbRight.TabIndex = 3;
            // 
            // btnRight
            // 
            this.btnRight.AutoSize = true;
            this.btnRight.Location = new System.Drawing.Point(17, 22);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(83, 23);
            this.btnRight.TabIndex = 0;
            this.btnRight.Text = "Open folder";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnMatch
            // 
            this.btnMatch.AutoSize = true;
            this.btnMatch.Location = new System.Drawing.Point(161, 19);
            this.btnMatch.Name = "btnMatch";
            this.btnMatch.Size = new System.Drawing.Size(83, 23);
            this.btnMatch.TabIndex = 4;
            this.btnMatch.Text = "Match files";
            this.btnMatch.UseVisualStyleBackColor = true;
            this.btnMatch.Click += new System.EventHandler(this.btnMatch_Click);
            // 
            // gpLeft
            // 
            this.gpLeft.Controls.Add(this.lbLeft);
            this.gpLeft.Controls.Add(this.btnLeft);
            this.gpLeft.Location = new System.Drawing.Point(21, 37);
            this.gpLeft.Name = "gpLeft";
            this.gpLeft.Size = new System.Drawing.Size(348, 358);
            this.gpLeft.TabIndex = 5;
            this.gpLeft.TabStop = false;
            this.gpLeft.Text = "Wanted";
            // 
            // gpRight
            // 
            this.gpRight.Controls.Add(this.lbRight);
            this.gpRight.Controls.Add(this.btnRight);
            this.gpRight.Enabled = false;
            this.gpRight.Location = new System.Drawing.Point(389, 37);
            this.gpRight.Name = "gpRight";
            this.gpRight.Size = new System.Drawing.Size(348, 358);
            this.gpRight.TabIndex = 6;
            this.gpRight.TabStop = false;
            this.gpRight.Text = "Search";
            // 
            // gpMatch
            // 
            this.gpMatch.Controls.Add(this.lblMatch);
            this.gpMatch.Controls.Add(this.btnMatch);
            this.gpMatch.Enabled = false;
            this.gpMatch.Location = new System.Drawing.Point(176, 410);
            this.gpMatch.Name = "gpMatch";
            this.gpMatch.Size = new System.Drawing.Size(405, 62);
            this.gpMatch.TabIndex = 7;
            this.gpMatch.TabStop = false;
            // 
            // lblMatch
            // 
            this.lblMatch.AutoSize = true;
            this.lblMatch.Location = new System.Drawing.Point(178, 45);
            this.lblMatch.Name = "lblMatch";
            this.lblMatch.Size = new System.Drawing.Size(49, 13);
            this.lblMatch.TabIndex = 5;
            this.lblMatch.Text = "results";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(772, 487);
            this.Controls.Add(this.gpMatch);
            this.Controls.Add(this.gpRight);
            this.Controls.Add(this.gpLeft);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GFC";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gpLeft.ResumeLayout(false);
            this.gpLeft.PerformLayout();
            this.gpRight.ResumeLayout(false);
            this.gpRight.PerformLayout();
            this.gpMatch.ResumeLayout(false);
            this.gpMatch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.ListBox lbLeft;
        private System.Windows.Forms.ListBox lbRight;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnMatch;
        private System.Windows.Forms.GroupBox gpLeft;
        private System.Windows.Forms.GroupBox gpRight;
        private System.Windows.Forms.GroupBox gpMatch;
        private System.Windows.Forms.Label lblMatch;
    }
}

