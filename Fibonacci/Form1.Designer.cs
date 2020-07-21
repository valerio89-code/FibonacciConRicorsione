namespace Fibonacci
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbx_numeriDaMostrare = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvw_fibonacci = new System.Windows.Forms.ListView();
            this.btn_mostra = new System.Windows.Forms.Button();
            this.tbx_numeroDaVerificare = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_verificaNumero = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbx_numeriDaMostrare
            // 
            this.tbx_numeriDaMostrare.Location = new System.Drawing.Point(32, 89);
            this.tbx_numeriDaMostrare.Name = "tbx_numeriDaMostrare";
            this.tbx_numeriDaMostrare.Size = new System.Drawing.Size(136, 26);
            this.tbx_numeriDaMostrare.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quanti numeri vuoi vedere?";
            // 
            // lvw_fibonacci
            // 
            this.lvw_fibonacci.HideSelection = false;
            this.lvw_fibonacci.Location = new System.Drawing.Point(247, 89);
            this.lvw_fibonacci.Name = "lvw_fibonacci";
            this.lvw_fibonacci.Size = new System.Drawing.Size(669, 196);
            this.lvw_fibonacci.TabIndex = 3;
            this.lvw_fibonacci.UseCompatibleStateImageBehavior = false;
            // 
            // btn_mostra
            // 
            this.btn_mostra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mostra.Location = new System.Drawing.Point(32, 147);
            this.btn_mostra.Name = "btn_mostra";
            this.btn_mostra.Size = new System.Drawing.Size(136, 138);
            this.btn_mostra.TabIndex = 4;
            this.btn_mostra.Text = "Mostra numeri";
            this.btn_mostra.UseVisualStyleBackColor = true;
            this.btn_mostra.Click += new System.EventHandler(this.btn_mostra_Click);
            // 
            // tbx_numeroDaVerificare
            // 
            this.tbx_numeroDaVerificare.Location = new System.Drawing.Point(408, 412);
            this.tbx_numeroDaVerificare.Name = "tbx_numeroDaVerificare";
            this.tbx_numeroDaVerificare.Size = new System.Drawing.Size(136, 26);
            this.tbx_numeroDaVerificare.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(364, 184);
            this.label3.TabIndex = 7;
            this.label3.Text = "Verifica se il numero fa parte della sequenza di fibonacci";
            // 
            // btn_verificaNumero
            // 
            this.btn_verificaNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_verificaNumero.Location = new System.Drawing.Point(632, 352);
            this.btn_verificaNumero.Name = "btn_verificaNumero";
            this.btn_verificaNumero.Size = new System.Drawing.Size(136, 138);
            this.btn_verificaNumero.TabIndex = 8;
            this.btn_verificaNumero.Text = "Verifica";
            this.btn_verificaNumero.UseVisualStyleBackColor = true;
            this.btn_verificaNumero.Click += new System.EventHandler(this.btn_verificaNumero_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 594);
            this.Controls.Add(this.btn_verificaNumero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbx_numeroDaVerificare);
            this.Controls.Add(this.btn_mostra);
            this.Controls.Add(this.lvw_fibonacci);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_numeriDaMostrare);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_numeriDaMostrare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvw_fibonacci;
        private System.Windows.Forms.Button btn_mostra;
        private System.Windows.Forms.TextBox tbx_numeroDaVerificare;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_verificaNumero;
    }
}

