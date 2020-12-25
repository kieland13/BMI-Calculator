namespace BMICalc
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
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.txtResults = new System.Windows.Forms.TextBox();
         this.txtHeight = new System.Windows.Forms.TextBox();
         this.txtWeight = new System.Windows.Forms.TextBox();
         this.label5 = new System.Windows.Forms.Label();
         this.label6 = new System.Windows.Forms.Label();
         this.label7 = new System.Windows.Forms.Label();
         this.label8 = new System.Windows.Forms.Label();
         this.label9 = new System.Windows.Forms.Label();
         this.btncalc = new System.Windows.Forms.Button();
         this.btnclear = new System.Windows.Forms.Button();
         this.btnexit = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(42, 9);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(283, 26);
         this.label1.TabIndex = 0;
         this.label1.Text = "Body Mass Index Calculator";
         // 
         // label2
         // 
         this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
         this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.label2.Location = new System.Drawing.Point(34, 62);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(100, 23);
         this.label2.TabIndex = 1;
         this.label2.Text = "Height(Inches)";
         this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // label3
         // 
         this.label3.BackColor = System.Drawing.SystemColors.AppWorkspace;
         this.label3.Location = new System.Drawing.Point(34, 109);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(100, 23);
         this.label3.TabIndex = 2;
         this.label3.Text = "Weight(Pounds)";
         this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // label4
         // 
         this.label4.BackColor = System.Drawing.SystemColors.AppWorkspace;
         this.label4.Location = new System.Drawing.Point(34, 158);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(100, 23);
         this.label4.TabIndex = 3;
         this.label4.Text = "Your BMI is:";
         this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // txtResults
         // 
         this.txtResults.Location = new System.Drawing.Point(189, 158);
         this.txtResults.Name = "txtResults";
         this.txtResults.Size = new System.Drawing.Size(100, 20);
         this.txtResults.TabIndex = 4;
         // 
         // txtHeight
         // 
         this.txtHeight.Location = new System.Drawing.Point(189, 62);
         this.txtHeight.Name = "txtHeight";
         this.txtHeight.Size = new System.Drawing.Size(100, 20);
         this.txtHeight.TabIndex = 5;
         // 
         // txtWeight
         // 
         this.txtWeight.Location = new System.Drawing.Point(189, 111);
         this.txtWeight.Name = "txtWeight";
         this.txtWeight.Size = new System.Drawing.Size(100, 20);
         this.txtWeight.TabIndex = 6;
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label5.Location = new System.Drawing.Point(331, 46);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(142, 24);
         this.label5.TabIndex = 7;
         this.label5.Text = "BMI Categories:";
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label6.Location = new System.Drawing.Point(331, 88);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(160, 20);
         this.label6.TabIndex = 8;
         this.label6.Text = "Underweight = < 18.5";
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label7.Location = new System.Drawing.Point(331, 125);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(197, 20);
         this.label7.TabIndex = 9;
         this.label7.Text = "Normal Weight = 18.5-24.9";
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label8.Location = new System.Drawing.Point(331, 161);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(159, 20);
         this.label8.TabIndex = 10;
         this.label8.Text = "Overweight = 25-29.9";
         // 
         // label9
         // 
         this.label9.AutoSize = true;
         this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label9.Location = new System.Drawing.Point(331, 201);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(221, 20);
         this.label9.TabIndex = 11;
         this.label9.Text = "Obesity = BMI of 30 or greater";
         // 
         // btncalc
         // 
         this.btncalc.Location = new System.Drawing.Point(12, 201);
         this.btncalc.Name = "btncalc";
         this.btncalc.Size = new System.Drawing.Size(75, 23);
         this.btncalc.TabIndex = 13;
         this.btncalc.Text = "Calculate";
         this.btncalc.UseVisualStyleBackColor = true;
         this.btncalc.Click += new System.EventHandler(this.btncalc_Click);
         // 
         // btnclear
         // 
         this.btnclear.Location = new System.Drawing.Point(117, 201);
         this.btnclear.Name = "btnclear";
         this.btnclear.Size = new System.Drawing.Size(75, 23);
         this.btnclear.TabIndex = 14;
         this.btnclear.Text = "Clear";
         this.btnclear.UseVisualStyleBackColor = true;
         this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
         // 
         // btnexit
         // 
         this.btnexit.Location = new System.Drawing.Point(218, 201);
         this.btnexit.Name = "btnexit";
         this.btnexit.Size = new System.Drawing.Size(75, 23);
         this.btnexit.TabIndex = 15;
         this.btnexit.Text = "Exit";
         this.btnexit.UseVisualStyleBackColor = true;
         this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(584, 261);
         this.Controls.Add(this.btnexit);
         this.Controls.Add(this.btnclear);
         this.Controls.Add(this.btncalc);
         this.Controls.Add(this.label9);
         this.Controls.Add(this.label8);
         this.Controls.Add(this.label7);
         this.Controls.Add(this.label6);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.txtWeight);
         this.Controls.Add(this.txtHeight);
         this.Controls.Add(this.txtResults);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Name = "Form1";
         this.Text = "Form1";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.TextBox txtResults;
      private System.Windows.Forms.TextBox txtHeight;
      private System.Windows.Forms.TextBox txtWeight;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.Label label8;
      private System.Windows.Forms.Label label9;
      private System.Windows.Forms.Button btncalc;
      private System.Windows.Forms.Button btnclear;
      private System.Windows.Forms.Button btnexit;
   }
}

