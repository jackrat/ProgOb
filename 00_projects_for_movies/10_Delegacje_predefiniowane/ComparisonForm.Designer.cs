namespace C_Delegacje_predefiniowane
{
  partial class ComparisonForm
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
      this.button5 = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.btnComp1 = new System.Windows.Forms.Button();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // button5
      // 
      this.button5.Location = new System.Drawing.Point(456, 8);
      this.button5.Name = "button5";
      this.button5.Size = new System.Drawing.Size(105, 23);
      this.button5.TabIndex = 16;
      this.button5.Text = "by Name & Price";
      this.button5.UseVisualStyleBackColor = true;
      this.button5.Click += new System.EventHandler(this.button5_Click);
      // 
      // button4
      // 
      this.button4.Location = new System.Drawing.Point(345, 8);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(105, 23);
      this.button4.TabIndex = 15;
      this.button4.Text = "by Price";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new System.EventHandler(this.button4_Click);
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(234, 8);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(105, 23);
      this.button3.TabIndex = 14;
      this.button3.Text = "by ProductionDate";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(123, 8);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(105, 23);
      this.button2.TabIndex = 13;
      this.button2.Text = "by Description";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // btnComp1
      // 
      this.btnComp1.Location = new System.Drawing.Point(12, 8);
      this.btnComp1.Name = "btnComp1";
      this.btnComp1.Size = new System.Drawing.Size(105, 23);
      this.btnComp1.TabIndex = 12;
      this.btnComp1.Text = "by Name";
      this.btnComp1.UseVisualStyleBackColor = true;
      this.btnComp1.Click += new System.EventHandler(this.btnComp1_Click);
      // 
      // dataGridView1
      // 
      this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(12, 48);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(945, 419);
      this.dataGridView1.TabIndex = 11;
      // 
      // ComparisonForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(969, 479);
      this.Controls.Add(this.button5);
      this.Controls.Add(this.button4);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.btnComp1);
      this.Controls.Add(this.dataGridView1);
      this.Name = "ComparisonForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "ComparisonForm";
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button button5;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button btnComp1;
    private System.Windows.Forms.DataGridView dataGridView1;
  }
}