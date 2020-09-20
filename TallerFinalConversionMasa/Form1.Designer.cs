namespace TallerFinalConversionMasa
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtKg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGramo = new System.Windows.Forms.Button();
            this.btnMiligramo = new System.Windows.Forms.Button();
            this.btnDecagramo = new System.Windows.Forms.Button();
            this.lblGr = new System.Windows.Forms.Label();
            this.lblDg = new System.Windows.Forms.Label();
            this.lblMg = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.label1.Location = new System.Drawing.Point(242, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conversión de Masa ";
            // 
            // txtKg
            // 
            this.txtKg.Font = new System.Drawing.Font("Microsoft Sans Serif", 29.25F);
            this.txtKg.Location = new System.Drawing.Point(379, 149);
            this.txtKg.Name = "txtKg";
            this.txtKg.Size = new System.Drawing.Size(100, 52);
            this.txtKg.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label2.Location = new System.Drawing.Point(221, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(432, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese los Kg que desea convertir";
            // 
            // btnGramo
            // 
            this.btnGramo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnGramo.Location = new System.Drawing.Point(61, 250);
            this.btnGramo.Name = "btnGramo";
            this.btnGramo.Size = new System.Drawing.Size(110, 50);
            this.btnGramo.TabIndex = 3;
            this.btnGramo.Text = "Gramo";
            this.btnGramo.UseVisualStyleBackColor = true;
            this.btnGramo.Click += new System.EventHandler(this.btnGramo_Click);
            // 
            // btnMiligramo
            // 
            this.btnMiligramo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnMiligramo.Location = new System.Drawing.Point(573, 250);
            this.btnMiligramo.Name = "btnMiligramo";
            this.btnMiligramo.Size = new System.Drawing.Size(148, 50);
            this.btnMiligramo.TabIndex = 4;
            this.btnMiligramo.Text = "Miligramo";
            this.btnMiligramo.UseVisualStyleBackColor = true;
            this.btnMiligramo.Click += new System.EventHandler(this.btnMiligramo_Click);
            // 
            // btnDecagramo
            // 
            this.btnDecagramo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnDecagramo.Location = new System.Drawing.Point(266, 250);
            this.btnDecagramo.Name = "btnDecagramo";
            this.btnDecagramo.Size = new System.Drawing.Size(162, 50);
            this.btnDecagramo.TabIndex = 5;
            this.btnDecagramo.Text = "Decagramo";
            this.btnDecagramo.UseVisualStyleBackColor = true;
            this.btnDecagramo.Click += new System.EventHandler(this.btnDecagramo_Click);
            // 
            // lblGr
            // 
            this.lblGr.AutoSize = true;
            this.lblGr.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblGr.Location = new System.Drawing.Point(55, 333);
            this.lblGr.Name = "lblGr";
            this.lblGr.Size = new System.Drawing.Size(38, 31);
            this.lblGr.TabIndex = 6;
            this.lblGr.Text = "gr";
            this.lblGr.Visible = false;
            // 
            // lblDg
            // 
            this.lblDg.AutoSize = true;
            this.lblDg.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblDg.Location = new System.Drawing.Point(260, 333);
            this.lblDg.Name = "lblDg";
            this.lblDg.Size = new System.Drawing.Size(44, 31);
            this.lblDg.TabIndex = 7;
            this.lblDg.Text = "dg";
            this.lblDg.Visible = false;
            // 
            // lblMg
            // 
            this.lblMg.AutoSize = true;
            this.lblMg.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblMg.Location = new System.Drawing.Point(567, 333);
            this.lblMg.Name = "lblMg";
            this.lblMg.Size = new System.Drawing.Size(51, 31);
            this.lblMg.TabIndex = 8;
            this.lblMg.Text = "mg";
            this.lblMg.Visible = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnLimpiar.Location = new System.Drawing.Point(347, 424);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(162, 50);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 518);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblMg);
            this.Controls.Add(this.lblDg);
            this.Controls.Add(this.lblGr);
            this.Controls.Add(this.btnDecagramo);
            this.Controls.Add(this.btnMiligramo);
            this.Controls.Add(this.btnGramo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKg);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGramo;
        private System.Windows.Forms.Button btnMiligramo;
        private System.Windows.Forms.Button btnDecagramo;
        private System.Windows.Forms.Label lblGr;
        private System.Windows.Forms.Label lblDg;
        private System.Windows.Forms.Label lblMg;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

