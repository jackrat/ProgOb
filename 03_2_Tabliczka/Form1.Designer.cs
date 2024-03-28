namespace _03_2_Tabliczka
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
      this.tbCol1 = new System.Windows.Forms.TextBox();
      this.tbCol2 = new System.Windows.Forms.TextBox();
      this.tbRow1 = new System.Windows.Forms.TextBox();
      this.tbRow2 = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.label1.Location = new System.Drawing.Point(125, 68);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(70, 22);
      this.label1.TabIndex = 0;
      this.label1.Text = "label1";
      // 
      // tbCol1
      // 
      this.tbCol1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.tbCol1.Location = new System.Drawing.Point(129, 26);
      this.tbCol1.Name = "tbCol1";
      this.tbCol1.Size = new System.Drawing.Size(100, 29);
      this.tbCol1.TabIndex = 1;
      this.tbCol1.Text = "1";
      this.tbCol1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
      // 
      // tbCol2
      // 
      this.tbCol2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.tbCol2.Location = new System.Drawing.Point(604, 26);
      this.tbCol2.Name = "tbCol2";
      this.tbCol2.Size = new System.Drawing.Size(100, 29);
      this.tbCol2.TabIndex = 2;
      this.tbCol2.Text = "10";
      this.tbCol2.TextChanged += new System.EventHandler(this.tbCol2_TextChanged);
      // 
      // tbRow1
      // 
      this.tbRow1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.tbRow1.Location = new System.Drawing.Point(12, 61);
      this.tbRow1.Name = "tbRow1";
      this.tbRow1.Size = new System.Drawing.Size(100, 29);
      this.tbRow1.TabIndex = 3;
      this.tbRow1.Text = "1";
      this.tbRow1.TextChanged += new System.EventHandler(this.tbRow1_TextChanged);
      // 
      // tbRow2
      // 
      this.tbRow2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.tbRow2.Location = new System.Drawing.Point(12, 294);
      this.tbRow2.Name = "tbRow2";
      this.tbRow2.Size = new System.Drawing.Size(100, 29);
      this.tbRow2.TabIndex = 4;
      this.tbRow2.Text = "10";
      this.tbRow2.TextChanged += new System.EventHandler(this.tbRow2_TextChanged);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.tbRow2);
      this.Controls.Add(this.tbRow1);
      this.Controls.Add(this.tbCol2);
      this.Controls.Add(this.tbCol1);
      this.Controls.Add(this.label1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox tbCol1;
    private System.Windows.Forms.TextBox tbCol2;
    private System.Windows.Forms.TextBox tbRow1;
    private System.Windows.Forms.TextBox tbRow2;
  }
}

