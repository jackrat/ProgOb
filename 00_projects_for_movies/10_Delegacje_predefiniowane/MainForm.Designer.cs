namespace C_Delegacje_predefiniowane
{
  partial class MainForm
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
      this.button1 = new System.Windows.Forms.Button();
      this.btnAction = new System.Windows.Forms.Button();
      this.btnComparison = new System.Windows.Forms.Button();
      this.btnFuncs = new System.Windows.Forms.Button();
      this.btnPredicates = new System.Windows.Forms.Button();
      this.btnConverters = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // dataGridView1
      // 
      this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(141, 12);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(880, 586);
      this.dataGridView1.TabIndex = 7;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(15, 12);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(110, 23);
      this.button1.TabIndex = 6;
      this.button1.Text = "ReInit";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // btnAction
      // 
      this.btnAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.btnAction.Location = new System.Drawing.Point(15, 169);
      this.btnAction.Name = "btnAction";
      this.btnAction.Size = new System.Drawing.Size(110, 23);
      this.btnAction.TabIndex = 5;
      this.btnAction.Text = "Actions";
      this.btnAction.UseVisualStyleBackColor = true;
      this.btnAction.Click += new System.EventHandler(this.btnActions_Click);
      // 
      // btnComparison
      // 
      this.btnComparison.Location = new System.Drawing.Point(15, 128);
      this.btnComparison.Name = "btnComparison";
      this.btnComparison.Size = new System.Drawing.Size(110, 23);
      this.btnComparison.TabIndex = 4;
      this.btnComparison.Text = "Comparison";
      this.btnComparison.UseVisualStyleBackColor = true;
      this.btnComparison.Click += new System.EventHandler(this.btnComparison_Click);
      // 
      // btnFuncs
      // 
      this.btnFuncs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.btnFuncs.Location = new System.Drawing.Point(15, 198);
      this.btnFuncs.Name = "btnFuncs";
      this.btnFuncs.Size = new System.Drawing.Size(110, 23);
      this.btnFuncs.TabIndex = 8;
      this.btnFuncs.Text = "Funcs";
      this.btnFuncs.UseVisualStyleBackColor = true;
      this.btnFuncs.Click += new System.EventHandler(this.btnFuncs_Click);
      // 
      // btnPredicates
      // 
      this.btnPredicates.Location = new System.Drawing.Point(15, 70);
      this.btnPredicates.Name = "btnPredicates";
      this.btnPredicates.Size = new System.Drawing.Size(110, 23);
      this.btnPredicates.TabIndex = 9;
      this.btnPredicates.Text = "Predicates";
      this.btnPredicates.UseVisualStyleBackColor = true;
      this.btnPredicates.Click += new System.EventHandler(this.btnPredicates_Click);
      // 
      // btnConverters
      // 
      this.btnConverters.Location = new System.Drawing.Point(15, 99);
      this.btnConverters.Name = "btnConverters";
      this.btnConverters.Size = new System.Drawing.Size(110, 23);
      this.btnConverters.TabIndex = 10;
      this.btnConverters.Text = "Converters";
      this.btnConverters.UseVisualStyleBackColor = true;
      this.btnConverters.Click += new System.EventHandler(this.btnConverters_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1033, 610);
      this.Controls.Add(this.btnConverters);
      this.Controls.Add(this.btnPredicates);
      this.Controls.Add(this.btnFuncs);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.btnAction);
      this.Controls.Add(this.btnComparison);
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button btnAction;
    private System.Windows.Forms.Button btnComparison;
    private System.Windows.Forms.Button btnFuncs;
    private System.Windows.Forms.Button btnPredicates;
    private System.Windows.Forms.Button btnConverters;
  }
}

