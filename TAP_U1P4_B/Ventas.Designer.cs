using System.ComponentModel;

namespace TAP_U1P4_B
{
    partial class Ventas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.panel1 = new System.Windows.Forms.Panel();
            this.totalSale = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.totalQuantitySelled = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.totalSales = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gridVentas = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.price = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.productName = new System.Windows.Forms.Label();
            this.productToSell = new System.Windows.Forms.ComboBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.imgBox = new System.Windows.Forms.PictureBox();
            this.quantityToSell = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelSale = new System.Windows.Forms.Button();
            this.btnConfirmSale = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridVentas)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityToSell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.Controls.Add(this.totalSale);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.totalQuantitySelled);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.totalSales);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.gridVentas);
            this.panel1.Location = new System.Drawing.Point(327, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 369);
            this.panel1.TabIndex = 0;
            // 
            // totalSale
            // 
            this.totalSale.Location = new System.Drawing.Point(228, 343);
            this.totalSale.Name = "totalSale";
            this.totalSale.Size = new System.Drawing.Size(64, 17);
            this.totalSale.TabIndex = 5;
            this.totalSale.Text = ".";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(179, 343);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "Total:";
            // 
            // totalQuantitySelled
            // 
            this.totalQuantitySelled.Location = new System.Drawing.Point(108, 343);
            this.totalQuantitySelled.Name = "totalQuantitySelled";
            this.totalQuantitySelled.Size = new System.Drawing.Size(29, 17);
            this.totalQuantitySelled.TabIndex = 4;
            this.totalQuantitySelled.Text = "S";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(12, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Cantidad vendida:";
            // 
            // totalSales
            // 
            this.totalSales.FormattingEnabled = true;
            this.totalSales.Location = new System.Drawing.Point(179, 308);
            this.totalSales.Name = "totalSales";
            this.totalSales.Size = new System.Drawing.Size(113, 21);
            this.totalSales.TabIndex = 2;
            this.totalSales.SelectedIndexChanged += new System.EventHandler(this.totalSales_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ver ventas totales";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gridVentas
            // 
            this.gridVentas.AllowUserToAddRows = false;
            this.gridVentas.AllowUserToDeleteRows = false;
            this.gridVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVentas.Location = new System.Drawing.Point(0, -3);
            this.gridVentas.Name = "gridVentas";
            this.gridVentas.ReadOnly = true;
            this.gridVentas.Size = new System.Drawing.Size(312, 299);
            this.gridVentas.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel2.Controls.Add(this.price);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.productName);
            this.panel2.Controls.Add(this.productToSell);
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.imgBox);
            this.panel2.Controls.Add(this.quantityToSell);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(30, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(271, 369);
            this.panel2.TabIndex = 1;
            // 
            // price
            // 
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(139, 301);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(120, 24);
            this.price.TabIndex = 10;
            this.price.Text = " $ 0.00";
            this.price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Precio unitario:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // productName
            // 
            this.productName.Location = new System.Drawing.Point(54, 5);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(161, 30);
            this.productName.TabIndex = 8;
            this.productName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // productToSell
            // 
            this.productToSell.FormattingEnabled = true;
            this.productToSell.Location = new System.Drawing.Point(139, 221);
            this.productToSell.Name = "productToSell";
            this.productToSell.Size = new System.Drawing.Size(120, 21);
            this.productToSell.TabIndex = 7;
            this.productToSell.SelectedIndexChanged += new System.EventHandler(this.productToSell_SelectedIndexChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(126, 336);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(60, 24);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = " $ 0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imgBox
            // 
            this.imgBox.Location = new System.Drawing.Point(55, 47);
            this.imgBox.Name = "imgBox";
            this.imgBox.Size = new System.Drawing.Size(161, 150);
            this.imgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBox.TabIndex = 4;
            this.imgBox.TabStop = false;
            // 
            // quantityToSell
            // 
            this.quantityToSell.Location = new System.Drawing.Point(139, 262);
            this.quantityToSell.Name = "quantityToSell";
            this.quantityToSell.Size = new System.Drawing.Size(121, 20);
            this.quantityToSell.TabIndex = 3;
            this.quantityToSell.ValueChanged += new System.EventHandler(this.quantityToSell_ValueChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Selecciona producto:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sistema de ventas";
            // 
            // btnCancelSale
            // 
            this.btnCancelSale.Location = new System.Drawing.Point(30, 416);
            this.btnCancelSale.Name = "btnCancelSale";
            this.btnCancelSale.Size = new System.Drawing.Size(100, 22);
            this.btnCancelSale.TabIndex = 3;
            this.btnCancelSale.Text = "Cancelar";
            this.btnCancelSale.UseVisualStyleBackColor = true;
            this.btnCancelSale.Click += new System.EventHandler(this.btnCancelSale_Click);
            // 
            // btnConfirmSale
            // 
            this.btnConfirmSale.Location = new System.Drawing.Point(201, 416);
            this.btnConfirmSale.Name = "btnConfirmSale";
            this.btnConfirmSale.Size = new System.Drawing.Size(100, 22);
            this.btnConfirmSale.TabIndex = 4;
            this.btnConfirmSale.Text = "Confirmar";
            this.btnConfirmSale.UseVisualStyleBackColor = true;
            this.btnConfirmSale.Click += new System.EventHandler(this.btnConfirmSale_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(99, 50);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(158, 45);
            this.trackBar1.TabIndex = 3;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(666, 450);
            this.Controls.Add(this.btnConfirmSale);
            this.Controls.Add(this.btnCancelSale);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridVentas)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityToSell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label totalSale;

        private System.Windows.Forms.Label totalQuantitySelled;

        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.ComboBox totalSales;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.DataGridView gridVentas;

        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.Label productName;

        private System.Windows.Forms.ComboBox productToSell;

        private System.Windows.Forms.Label lblTotal;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.PictureBox imgBox;

        private System.Windows.Forms.NumericUpDown quantityToSell;

        private System.Windows.Forms.TrackBar trackBar1;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Button btnCancelSale;
        private System.Windows.Forms.Button btnConfirmSale;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}