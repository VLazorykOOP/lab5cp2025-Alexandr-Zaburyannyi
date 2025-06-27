namespace KochFractal
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGenerateFractal = new System.Windows.Forms.Button();
            this.txtFractalOrder = new System.Windows.Forms.TextBox();
            this.lblFractalOrder = new System.Windows.Forms.Label();
            this.txtSideLength = new System.Windows.Forms.TextBox();
            this.lblSideLength = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();

            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(776, 550);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnGenerateFractal);
            this.panel1.Controls.Add(this.txtFractalOrder);
            this.panel1.Controls.Add(this.lblFractalOrder);
            this.panel1.Controls.Add(this.txtSideLength);
            this.panel1.Controls.Add(this.lblSideLength);
            this.panel1.Location = new System.Drawing.Point(12, 568);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 82);
            this.panel1.TabIndex = 1;
            this.btnGenerateFractal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateFractal.Location = new System.Drawing.Point(512, 22);
            this.btnGenerateFractal.Name = "btnGenerateFractal";
            this.btnGenerateFractal.Size = new System.Drawing.Size(170, 39);
            this.btnGenerateFractal.TabIndex = 4;
            this.btnGenerateFractal.Text = "Generate Fractal";
            this.btnGenerateFractal.UseVisualStyleBackColor = true;
            this.btnGenerateFractal.Click += new System.EventHandler(this.btnGenerateFractal_Click);
            this.txtFractalOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFractalOrder.Location = new System.Drawing.Point(358, 28);
            this.txtFractalOrder.Name = "txtFractalOrder";
            this.txtFractalOrder.Size = new System.Drawing.Size(100, 26);
            this.txtFractalOrder.TabIndex = 3;
            this.txtFractalOrder.Text = "3";
            this.lblFractalOrder.AutoSize = true;
            this.lblFractalOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFractalOrder.Location = new System.Drawing.Point(249, 31);
            this.lblFractalOrder.Name = "lblFractalOrder";
            this.lblFractalOrder.Size = new System.Drawing.Size(103, 20);
            this.lblFractalOrder.TabIndex = 2;
            this.lblFractalOrder.Text = "Order (K) = ";
            this.txtSideLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSideLength.Location = new System.Drawing.Point(118, 28);
            this.txtSideLength.Name = "txtSideLength";
            this.txtSideLength.Size = new System.Drawing.Size(100, 26);
            this.txtSideLength.TabIndex = 1;
            this.txtSideLength.Text = "300";
            this.lblSideLength.AutoSize = true;
            this.lblSideLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSideLength.Location = new System.Drawing.Point(3, 31);
            this.lblSideLength.Name = "lblSideLength";
            this.lblSideLength.Size = new System.Drawing.Size(109, 20);
            this.lblSideLength.TabIndex = 0;
            this.lblSideLength.Text = "Side (D) px =";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 662);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox);
            this.Name = "MainForm";
            this.Text = "Koch Fractal Generator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSideLength;
        private System.Windows.Forms.Label lblSideLength;
        private System.Windows.Forms.Button btnGenerateFractal;
        private System.Windows.Forms.TextBox txtFractalOrder;
        private System.Windows.Forms.Label lblFractalOrder;
    }
}
