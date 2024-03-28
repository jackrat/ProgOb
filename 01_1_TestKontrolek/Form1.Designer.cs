namespace _01_1_TestKontrolek
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
      this.tbA = new System.Windows.Forms.TextBox();
      this.tbB = new System.Windows.Forms.TextBox();
      this.tbC = new System.Windows.Forms.TextBox();
      this.btnOblicz = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // tbA
      // 
      this.tbA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.tbA.ForeColor = System.Drawing.Color.Blue;
      this.tbA.Location = new System.Drawing.Point(113, 95);
      this.tbA.Name = "tbA";
      this.tbA.Size = new System.Drawing.Size(164, 31);
      this.tbA.TabIndex = 0;
      this.tbA.Text = "1";
      // 
      // tbB
      // 
      this.tbB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.tbB.ForeColor = System.Drawing.Color.Blue;
      this.tbB.Location = new System.Drawing.Point(115, 152);
      this.tbB.Name = "tbB";
      this.tbB.Size = new System.Drawing.Size(162, 31);
      this.tbB.TabIndex = 1;
      this.tbB.Text = "2";
      // 
      // tbC
      // 
      this.tbC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.tbC.ForeColor = System.Drawing.Color.Blue;
      this.tbC.Location = new System.Drawing.Point(115, 204);
      this.tbC.Name = "tbC";
      this.tbC.Size = new System.Drawing.Size(162, 31);
      this.tbC.TabIndex = 2;
      this.tbC.Text = "3";
      // 
      // btnOblicz
      // 
      this.btnOblicz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.btnOblicz.ForeColor = System.Drawing.Color.Blue;
      this.btnOblicz.Location = new System.Drawing.Point(403, 112);
      this.btnOblicz.Name = "btnOblicz";
      this.btnOblicz.Size = new System.Drawing.Size(358, 155);
      this.btnOblicz.TabIndex = 3;
      this.btnOblicz.Text = "Oblicz\r\npierwiastki równania...\r\n";
      this.btnOblicz.UseVisualStyleBackColor = true;
      this.btnOblicz.Click += new System.EventHandler(this.btnOblicz_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.label1.ForeColor = System.Drawing.Color.Blue;
      this.label1.Location = new System.Drawing.Point(126, 334);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(76, 25);
      this.label1.TabIndex = 4;
      this.label1.Text = "label1";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(942, 574);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnOblicz);
      this.Controls.Add(this.tbC);
      this.Controls.Add(this.tbB);
      this.Controls.Add(this.tbA);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox tbA;
    private System.Windows.Forms.TextBox tbB;
    private System.Windows.Forms.TextBox tbC;
    private System.Windows.Forms.Button btnOblicz;
    private System.Windows.Forms.Label label1;
  }
}

