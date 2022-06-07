
namespace MyWinForm
{
    partial class Form1
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
            this.Out = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.plus_1 = new System.Windows.Forms.Button();
            this.plus_5 = new System.Windows.Forms.Button();
            this.plus_10 = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.minus_1 = new System.Windows.Forms.Button();
            this.minus_5 = new System.Windows.Forms.Button();
            this.minus_10 = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Out
            // 
            this.Out.Cursor = System.Windows.Forms.Cursors.No;
            this.Out.Location = new System.Drawing.Point(12, 12);
            this.Out.Name = "Out";
            this.Out.ReadOnly = true;
            this.Out.Size = new System.Drawing.Size(258, 31);
            this.Out.TabIndex = 0;
            this.Out.Text = "0";
            this.Out.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Out.WordWrap = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.plus_1);
            this.panel2.Controls.Add(this.plus_5);
            this.panel2.Controls.Add(this.plus_10);
            this.panel2.Controls.Add(this.Plus);
            this.panel2.Location = new System.Drawing.Point(12, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(124, 192);
            this.panel2.TabIndex = 0;
            // 
            // plus_1
            // 
            this.plus_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.plus_1.Location = new System.Drawing.Point(0, 92);
            this.plus_1.Name = "plus_1";
            this.plus_1.Size = new System.Drawing.Size(124, 29);
            this.plus_1.TabIndex = 3;
            this.plus_1.Text = "+1";
            this.plus_1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.plus_1.UseVisualStyleBackColor = true;
            this.plus_1.Visible = false;
            this.plus_1.Click += new System.EventHandler(this.plus_1_Click);
            // 
            // plus_5
            // 
            this.plus_5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.plus_5.Location = new System.Drawing.Point(0, 127);
            this.plus_5.Name = "plus_5";
            this.plus_5.Size = new System.Drawing.Size(124, 29);
            this.plus_5.TabIndex = 2;
            this.plus_5.Text = "+5";
            this.plus_5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.plus_5.UseVisualStyleBackColor = true;
            this.plus_5.Visible = false;
            this.plus_5.Click += new System.EventHandler(this.plus_5_Click);
            // 
            // plus_10
            // 
            this.plus_10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.plus_10.Location = new System.Drawing.Point(0, 162);
            this.plus_10.Name = "plus_10";
            this.plus_10.Size = new System.Drawing.Size(124, 29);
            this.plus_10.TabIndex = 1;
            this.plus_10.Text = "+10";
            this.plus_10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.plus_10.UseVisualStyleBackColor = true;
            this.plus_10.Visible = false;
            this.plus_10.Click += new System.EventHandler(this.plus_10_Click);
            // 
            // Plus
            // 
            this.Plus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Plus.Location = new System.Drawing.Point(0, 0);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(124, 29);
            this.Plus.TabIndex = 0;
            this.Plus.Text = "plus";
            this.Plus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.minus_1);
            this.panel1.Controls.Add(this.minus_5);
            this.panel1.Controls.Add(this.minus_10);
            this.panel1.Controls.Add(this.Minus);
            this.panel1.Location = new System.Drawing.Point(146, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(124, 192);
            this.panel1.TabIndex = 1;
            // 
            // minus_1
            // 
            this.minus_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minus_1.Location = new System.Drawing.Point(0, 93);
            this.minus_1.Name = "minus_1";
            this.minus_1.Size = new System.Drawing.Size(124, 29);
            this.minus_1.TabIndex = 3;
            this.minus_1.Text = "-1";
            this.minus_1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.minus_1.UseVisualStyleBackColor = true;
            this.minus_1.Visible = false;
            this.minus_1.Click += new System.EventHandler(this.minus_1_Click);
            // 
            // minus_5
            // 
            this.minus_5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minus_5.Location = new System.Drawing.Point(0, 128);
            this.minus_5.Name = "minus_5";
            this.minus_5.Size = new System.Drawing.Size(124, 29);
            this.minus_5.TabIndex = 2;
            this.minus_5.Text = "-5";
            this.minus_5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.minus_5.UseVisualStyleBackColor = true;
            this.minus_5.Visible = false;
            this.minus_5.Click += new System.EventHandler(this.minus_5_Click);
            // 
            // minus_10
            // 
            this.minus_10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minus_10.Location = new System.Drawing.Point(0, 163);
            this.minus_10.Name = "minus_10";
            this.minus_10.Size = new System.Drawing.Size(124, 29);
            this.minus_10.TabIndex = 1;
            this.minus_10.Text = "-10";
            this.minus_10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.minus_10.UseVisualStyleBackColor = true;
            this.minus_10.Visible = false;
            this.minus_10.Click += new System.EventHandler(this.minus_10_Click);
            // 
            // Minus
            // 
            this.Minus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minus.Location = new System.Drawing.Point(0, 0);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(124, 29);
            this.Minus.TabIndex = 0;
            this.Minus.Text = "minus";
            this.Minus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Out);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel Tree;
        private System.Windows.Forms.TextBox Out;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button plus_10;
        private System.Windows.Forms.Button plus_1;
        private System.Windows.Forms.Button plus_5;
        private System.Windows.Forms.Button minus_1;
        private System.Windows.Forms.Button minus_5;
        private System.Windows.Forms.Button miuns_10;
        private System.Windows.Forms.Button minus_10;
    }
}

