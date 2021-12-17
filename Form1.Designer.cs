
namespace FindtheMin_andAverage
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
            this.btn_add = new System.Windows.Forms.Button();
            this.lb_numbers = new System.Windows.Forms.ListBox();
            this.tb_num1 = new System.Windows.Forms.TextBox();
            this.btn_rem = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_min = new System.Windows.Forms.Button();
            this.lb_min1 = new System.Windows.Forms.Label();
            this.btn_avg = new System.Windows.Forms.Button();
            this.lb_avg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.IndianRed;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_add.Location = new System.Drawing.Point(215, 68);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Add ->";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lb_numbers
            // 
            this.lb_numbers.BackColor = System.Drawing.Color.LightGray;
            this.lb_numbers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_numbers.FormattingEnabled = true;
            this.lb_numbers.Location = new System.Drawing.Point(320, 36);
            this.lb_numbers.Name = "lb_numbers";
            this.lb_numbers.ScrollAlwaysVisible = true;
            this.lb_numbers.Size = new System.Drawing.Size(120, 147);
            this.lb_numbers.Sorted = true;
            this.lb_numbers.TabIndex = 1;
            // 
            // tb_num1
            // 
            this.tb_num1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tb_num1.Location = new System.Drawing.Point(72, 68);
            this.tb_num1.Name = "tb_num1";
            this.tb_num1.Size = new System.Drawing.Size(100, 20);
            this.tb_num1.TabIndex = 2;
            // 
            // btn_rem
            // 
            this.btn_rem.BackColor = System.Drawing.Color.IndianRed;
            this.btn_rem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rem.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rem.Location = new System.Drawing.Point(215, 116);
            this.btn_rem.Name = "btn_rem";
            this.btn_rem.Size = new System.Drawing.Size(75, 23);
            this.btn_rem.TabIndex = 3;
            this.btn_rem.Text = "<- Remove";
            this.btn_rem.UseVisualStyleBackColor = false;
            this.btn_rem.Click += new System.EventHandler(this.btn_rem_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.IndianRed;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(215, 160);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.Text = "<- Clear ->";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_min
            // 
            this.btn_min.BackColor = System.Drawing.Color.IndianRed;
            this.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_min.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_min.Location = new System.Drawing.Point(515, 67);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(104, 23);
            this.btn_min.TabIndex = 5;
            this.btn_min.Text = "Calculate Min";
            this.btn_min.UseVisualStyleBackColor = false;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // lb_min1
            // 
            this.lb_min1.AutoSize = true;
            this.lb_min1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_min1.ForeColor = System.Drawing.Color.IndianRed;
            this.lb_min1.Location = new System.Drawing.Point(667, 77);
            this.lb_min1.Name = "lb_min1";
            this.lb_min1.Size = new System.Drawing.Size(2, 15);
            this.lb_min1.TabIndex = 6;
            // 
            // btn_avg
            // 
            this.btn_avg.BackColor = System.Drawing.Color.IndianRed;
            this.btn_avg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_avg.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_avg.Location = new System.Drawing.Point(515, 145);
            this.btn_avg.Name = "btn_avg";
            this.btn_avg.Size = new System.Drawing.Size(104, 23);
            this.btn_avg.TabIndex = 7;
            this.btn_avg.Text = "Find Average";
            this.btn_avg.UseVisualStyleBackColor = false;
            this.btn_avg.Click += new System.EventHandler(this.btn_avg_Click);
            // 
            // lb_avg
            // 
            this.lb_avg.AutoSize = true;
            this.lb_avg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_avg.ForeColor = System.Drawing.Color.IndianRed;
            this.lb_avg.Location = new System.Drawing.Point(667, 155);
            this.lb_avg.Name = "lb_avg";
            this.lb_avg.Size = new System.Drawing.Size(2, 15);
            this.lb_avg.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_avg);
            this.Controls.Add(this.btn_avg);
            this.Controls.Add(this.lb_min1);
            this.Controls.Add(this.btn_min);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_rem);
            this.Controls.Add(this.tb_num1);
            this.Controls.Add(this.lb_numbers);
            this.Controls.Add(this.btn_add);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ListBox lb_numbers;
        private System.Windows.Forms.TextBox tb_num1;
        private System.Windows.Forms.Button btn_rem;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.Label lb_min1;
        private System.Windows.Forms.Button btn_avg;
        private System.Windows.Forms.Label lb_avg;
    }
}

