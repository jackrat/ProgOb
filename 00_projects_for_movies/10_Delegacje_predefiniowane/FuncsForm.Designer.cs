namespace C_Delegacje_predefiniowane
{
  partial class FuncsForm
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
      this.button4 = new System.Windows.Forms.Button();
      this.btnAvgCheapPrices = new System.Windows.Forms.Button();
      this.btbAvgPrice = new System.Windows.Forms.Button();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // button4
      // 
      this.button4.Location = new System.Drawing.Point(28, 44);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(191, 23);
      this.button4.TabIndex = 5;
      this.button4.Text = "some Prices";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new System.EventHandler(this.button4_Click);
      // 
      // btnAvgCheapPrices
      // 
      this.btnAvgCheapPrices.Location = new System.Drawing.Point(106, 12);
      this.btnAvgCheapPrices.Name = "btnAvgCheapPrices";
      this.btnAvgCheapPrices.Size = new System.Drawing.Size(113, 23);
      this.btnAvgCheapPrices.TabIndex = 4;
      this.btnAvgCheapPrices.Text = "avgCheapPrices";
      this.btnAvgCheapPrices.UseVisualStyleBackColor = true;
      this.btnAvgCheapPrices.Click += new System.EventHandler(this.btnAvgCheapPrices_Click);
      // 
      // btbAvgPrice
      // 
      this.btbAvgPrice.Location = new System.Drawing.Point(25, 12);
      this.btbAvgPrice.Name = "btbAvgPrice";
      this.btbAvgPrice.Size = new System.Drawing.Size(75, 23);
      this.btbAvgPrice.TabIndex = 3;
      this.btbAvgPrice.Text = "avgPrices";
      this.btbAvgPrice.UseVisualStyleBackColor = true;
      this.btbAvgPrice.Click += new System.EventHandler(this.btbAvgPrice_Click);
      // 
      // dataGridView1
      // 
      this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(12, 86);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(1008, 390);
      this.dataGridView1.TabIndex = 6;
      // 
      // FuncsForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1032, 488);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.button4);
      this.Controls.Add(this.btnAvgCheapPrices);
      this.Controls.Add(this.btbAvgPrice);
      this.Name = "FuncsForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "FuncsForm";
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button btnAvgCheapPrices;
    private System.Windows.Forms.Button btbAvgPrice;
    private System.Windows.Forms.DataGridView dataGridView1;
  }
}