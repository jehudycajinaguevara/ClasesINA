﻿namespace ClasesINA.Formularios
{
    partial class Constantes
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
            this.lblValorConstante = new System.Windows.Forms.Label();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // lblValorConstante
            // 
            this.lblValorConstante.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblValorConstante.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblValorConstante.Location = new System.Drawing.Point(26, 155);
            this.lblValorConstante.Name = "lblValorConstante";
            this.lblValorConstante.Size = new System.Drawing.Size(370, 56);
            this.lblValorConstante.TabIndex = 0;
            this.lblValorConstante.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(26, 96);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(273, 36);
            this.materialButton1.TabIndex = 2;
            this.materialButton1.Text = "Mostrar valor de la constante";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // Constantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.lblValorConstante);
            this.Name = "Constantes";
            this.Text = "Constantes";
            this.Load += new System.EventHandler(this.Constantes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValorConstante;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}