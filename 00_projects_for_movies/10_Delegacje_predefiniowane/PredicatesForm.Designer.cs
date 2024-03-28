namespace C_Delegacje_predefiniowane
{
  partial class PredicatesForm
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
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.btnPriceMoreThan50 = new System.Windows.Forms.Button();
      this.btnPriceEquel50 = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // dataGridView1
      // 
      this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(12, 88);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(811, 468);
      this.dataGridView1.TabIndex = 12;
      // 
      // btnPriceMoreThan50
      // 
      this.btnPriceMoreThan50.Location = new System.Drawing.Point(19, 14);
      this.btnPriceMoreThan50.Name = "btnPriceMoreThan50";
      this.btnPriceMoreThan50.Size = new System.Drawing.Size(127, 23);
      this.btnPriceMoreThan50.TabIndex = 13;
      this.btnPriceMoreThan50.Text = "PriceMoreThan50";
      this.btnPriceMoreThan50.UseVisualStyleBackColor = true;
      this.btnPriceMoreThan50.Click += new System.EventHandler(this.btnPriceMoreThan50_Click);
      // 
      // btnPriceEquel50
      // 
      this.btnPriceEquel50.Location = new System.Drawing.Point(152, 14);
      this.btnPriceEquel50.Name = "btnPriceEquel50";
      this.btnPriceEquel50.Size = new System.Drawing.Size(138, 24);
      this.btnPriceEquel50.TabIndex = 14;
      this.btnPriceEquel50.Text = "PriceBeetween40and60";
      this.btnPriceEquel50.UseVisualStyleBackColor = true;
      this.btnPriceEquel50.Click += new System.EventHandler(this.button2_Click);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(19, 44);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(271, 23);
      this.button1.TabIndex = 16;
      this.button1.Text = "Unfilter";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // PredicatesForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(835, 568);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.btnPriceEquel50);
      this.Controls.Add(this.btnPriceMoreThan50);
      this.Controls.Add(this.dataGridView1);
      this.Name = "PredicatesForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "PredicatesForm";
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Button btnPriceMoreThan50;
    private System.Windows.Forms.Button btnPriceEquel50;
    private System.Windows.Forms.Button button1;
  }
}