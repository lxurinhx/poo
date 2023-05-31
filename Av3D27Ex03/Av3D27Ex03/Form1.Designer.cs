namespace Av3D27Ex03
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtanos = new System.Windows.Forms.TextBox();
            this.txtmeses = new System.Windows.Forms.TextBox();
            this.txtdias = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtanos
            // 
            this.txtanos.Location = new System.Drawing.Point(92, 66);
            this.txtanos.Name = "txtanos";
            this.txtanos.Size = new System.Drawing.Size(100, 20);
            this.txtanos.TabIndex = 0;
            // 
            // txtmeses
            // 
            this.txtmeses.Location = new System.Drawing.Point(99, 103);
            this.txtmeses.Name = "txtmeses";
            this.txtmeses.Size = new System.Drawing.Size(100, 20);
            this.txtmeses.TabIndex = 1;
            // 
            // txtdias
            // 
            this.txtdias.Location = new System.Drawing.Point(88, 143);
            this.txtdias.Name = "txtdias";
            this.txtdias.Size = new System.Drawing.Size(100, 20);
            this.txtdias.TabIndex = 2;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(53, 69);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(33, 13);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "anos:";
            this.lbl1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(53, 106);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(40, 13);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "meses:";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(53, 146);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(29, 13);
            this.lbl3.TabIndex = 5;
            this.lbl3.Text = "dias:";
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Location = new System.Drawing.Point(123, 262);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(13, 13);
            this.lblresult.TabIndex = 6;
            this.lblresult.Text = "0";
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(88, 200);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(85, 23);
            this.btncalcular.TabIndex = 7;
            this.btncalcular.Text = "idade em dias";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "informe a sua idade";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 321);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtdias);
            this.Controls.Add(this.txtmeses);
            this.Controls.Add(this.txtanos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtanos;
        private System.Windows.Forms.TextBox txtmeses;
        private System.Windows.Forms.TextBox txtdias;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label label5;
    }
}

