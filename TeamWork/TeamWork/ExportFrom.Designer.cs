﻿namespace TeamWork
{
    partial class ExportFrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportFrom));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBilgiGetir = new System.Windows.Forms.Button();
            this.TabloAdiTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ExportAlBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(779, 284);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(347, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "SİPARİŞLER";
            // 
            // btnBilgiGetir
            // 
            this.btnBilgiGetir.Location = new System.Drawing.Point(655, 338);
            this.btnBilgiGetir.Name = "btnBilgiGetir";
            this.btnBilgiGetir.Size = new System.Drawing.Size(75, 23);
            this.btnBilgiGetir.TabIndex = 3;
            this.btnBilgiGetir.Text = "Bilgi Getir";
            this.btnBilgiGetir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnBilgiGetir.UseVisualStyleBackColor = true;
            this.btnBilgiGetir.Click += new System.EventHandler(this.btnBilgiGetir_Click);
            // 
            // TabloAdiTB
            // 
            this.TabloAdiTB.Location = new System.Drawing.Point(425, 339);
            this.TabloAdiTB.Name = "TabloAdiTB";
            this.TabloAdiTB.Size = new System.Drawing.Size(211, 23);
            this.TabloAdiTB.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tablo Adı";
            // 
            // ExportAlBtn
            // 
            this.ExportAlBtn.Location = new System.Drawing.Point(561, 368);
            this.ExportAlBtn.Name = "ExportAlBtn";
            this.ExportAlBtn.Size = new System.Drawing.Size(75, 23);
            this.ExportAlBtn.TabIndex = 6;
            this.ExportAlBtn.Text = "Export Al";
            this.ExportAlBtn.UseVisualStyleBackColor = true;
            this.ExportAlBtn.Click += new System.EventHandler(this.ExportAlBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExportFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(790, 505);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ExportAlBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TabloAdiTB);
            this.Controls.Add(this.btnBilgiGetir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ExportFrom";
            this.Text = "Siparisler";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBilgiGetir;
        private System.Windows.Forms.TextBox TabloAdiTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ExportAlBtn;
        private System.Windows.Forms.Button button1;
    }
}