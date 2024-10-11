namespace AlgoritmoDeStrassen
{
    partial class Form1
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
            this.tbA11 = new System.Windows.Forms.TextBox();
            this.tbA12 = new System.Windows.Forms.TextBox();
            this.tbB22 = new System.Windows.Forms.TextBox();
            this.tbB21 = new System.Windows.Forms.TextBox();
            this.tbB12 = new System.Windows.Forms.TextBox();
            this.tbB11 = new System.Windows.Forms.TextBox();
            this.tbA22 = new System.Windows.Forms.TextBox();
            this.tbA21 = new System.Windows.Forms.TextBox();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // tbA11
            // 
            this.tbA11.Location = new System.Drawing.Point(207, 12);
            this.tbA11.Name = "tbA11";
            this.tbA11.Size = new System.Drawing.Size(72, 20);
            this.tbA11.TabIndex = 0;
            // 
            // tbA12
            // 
            this.tbA12.Location = new System.Drawing.Point(285, 12);
            this.tbA12.Name = "tbA12";
            this.tbA12.Size = new System.Drawing.Size(72, 20);
            this.tbA12.TabIndex = 1;
            // 
            // tbB22
            // 
            this.tbB22.Location = new System.Drawing.Point(285, 116);
            this.tbB22.Name = "tbB22";
            this.tbB22.Size = new System.Drawing.Size(72, 20);
            this.tbB22.TabIndex = 2;
            // 
            // tbB21
            // 
            this.tbB21.Location = new System.Drawing.Point(207, 116);
            this.tbB21.Name = "tbB21";
            this.tbB21.Size = new System.Drawing.Size(72, 20);
            this.tbB21.TabIndex = 3;
            // 
            // tbB12
            // 
            this.tbB12.Location = new System.Drawing.Point(285, 90);
            this.tbB12.Name = "tbB12";
            this.tbB12.Size = new System.Drawing.Size(72, 20);
            this.tbB12.TabIndex = 4;
            // 
            // tbB11
            // 
            this.tbB11.Location = new System.Drawing.Point(207, 90);
            this.tbB11.Name = "tbB11";
            this.tbB11.Size = new System.Drawing.Size(72, 20);
            this.tbB11.TabIndex = 5;
            // 
            // tbA22
            // 
            this.tbA22.Location = new System.Drawing.Point(285, 39);
            this.tbA22.Name = "tbA22";
            this.tbA22.Size = new System.Drawing.Size(72, 20);
            this.tbA22.TabIndex = 6;
            // 
            // tbA21
            // 
            this.tbA21.Location = new System.Drawing.Point(207, 38);
            this.tbA21.Name = "tbA21";
            this.tbA21.Size = new System.Drawing.Size(72, 20);
            this.tbA21.TabIndex = 7;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(31, 29);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(170, 13);
            this.lblA.TabIndex = 8;
            this.lblA.Text = "Ingrese los numeros de la matriz A:";
            this.lblA.Click += new System.EventHandler(this.lblA_Click);
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(31, 106);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(170, 13);
            this.lblB.TabIndex = 9;
            this.lblB.Text = "Ingrese los numeros de la matriz B:";
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(147, 155);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(94, 33);
            this.btnMultiply.TabIndex = 10;
            this.btnMultiply.Text = "Multiplicar";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // dgvResult
            // 
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Location = new System.Drawing.Point(75, 194);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.Size = new System.Drawing.Size(242, 90);
            this.dgvResult.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 328);
            this.Controls.Add(this.dgvResult);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.tbA21);
            this.Controls.Add(this.tbA22);
            this.Controls.Add(this.tbB11);
            this.Controls.Add(this.tbB12);
            this.Controls.Add(this.tbB21);
            this.Controls.Add(this.tbB22);
            this.Controls.Add(this.tbA12);
            this.Controls.Add(this.tbA11);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbA11;
        private System.Windows.Forms.TextBox tbA12;
        private System.Windows.Forms.TextBox tbB22;
        private System.Windows.Forms.TextBox tbB21;
        private System.Windows.Forms.TextBox tbB12;
        private System.Windows.Forms.TextBox tbB11;
        private System.Windows.Forms.TextBox tbA22;
        private System.Windows.Forms.TextBox tbA21;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.DataGridView dgvResult;
    }
}

