namespace DiscountTA
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
         if(disposing && (components != null))
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
         this.components = new System.ComponentModel.Container();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
         this.label1 = new System.Windows.Forms.Label();
         this.tbTotalAmount = new System.Windows.Forms.TextBox();
         this.dataGridView1 = new System.Windows.Forms.DataGridView();
         this.CHK = new System.Windows.Forms.DataGridViewCheckBoxColumn();
         this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Type = new System.Windows.Forms.DataGridViewComboBoxColumn();
         this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
         this.priorityUp = new System.Windows.Forms.DataGridViewButtonColumn();
         this.priorityDown = new System.Windows.Forms.DataGridViewButtonColumn();
         this.label3 = new System.Windows.Forms.Label();
         this.button1 = new System.Windows.Forms.Button();
         this.imageList1 = new System.Windows.Forms.ImageList(this.components);
         this.tbResults = new System.Windows.Forms.TextBox();
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.textBox2 = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(19, 22);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(90, 13);
         this.label1.TabIndex = 0;
         this.label1.Text = "Total Order Gross";
         // 
         // tbTotalAmount
         // 
         this.tbTotalAmount.Location = new System.Drawing.Point(115, 22);
         this.tbTotalAmount.Name = "tbTotalAmount";
         this.tbTotalAmount.Size = new System.Drawing.Size(100, 20);
         this.tbTotalAmount.TabIndex = 0;
         this.tbTotalAmount.Text = "340,00";
         this.tbTotalAmount.WordWrap = false;
         // 
         // dataGridView1
         // 
         this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CHK,
            this.Discount,
            this.Type,
            this.Amount,
            this.Delete,
            this.priorityUp,
            this.priorityDown});
         this.dataGridView1.Location = new System.Drawing.Point(115, 64);
         this.dataGridView1.Name = "dataGridView1";
         this.dataGridView1.Size = new System.Drawing.Size(586, 150);
         this.dataGridView1.TabIndex = 1;
         this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
         this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
         // 
         // CHK
         // 
         this.CHK.FalseValue = "0";
         this.CHK.HeaderText = "Apply";
         this.CHK.Name = "CHK";
         this.CHK.Resizable = System.Windows.Forms.DataGridViewTriState.True;
         this.CHK.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
         this.CHK.TrueValue = "1";
         this.CHK.Width = 40;
         // 
         // Discount
         // 
         this.Discount.HeaderText = "Discount";
         this.Discount.Name = "Discount";
         this.Discount.Width = 200;
         // 
         // Type
         // 
         this.Type.HeaderText = "Type";
         this.Type.Items.AddRange(new object[] {
            "Fixed amount",
            "Percentage"});
         this.Type.Name = "Type";
         this.Type.Resizable = System.Windows.Forms.DataGridViewTriState.True;
         this.Type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
         // 
         // Amount
         // 
         dataGridViewCellStyle1.Format = "N2";
         dataGridViewCellStyle1.NullValue = null;
         this.Amount.DefaultCellStyle = dataGridViewCellStyle1;
         this.Amount.HeaderText = "Amount";
         this.Amount.Name = "Amount";
         this.Amount.Width = 50;
         // 
         // Delete
         // 
         dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
         dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
         dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
         dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
         dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
         this.Delete.DefaultCellStyle = dataGridViewCellStyle2;
         this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
         this.Delete.HeaderText = "Delete";
         this.Delete.Name = "Delete";
         this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
         this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
         this.Delete.Width = 40;
         // 
         // priorityUp
         // 
         dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
         dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
         dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
         dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
         dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
         this.priorityUp.DefaultCellStyle = dataGridViewCellStyle3;
         this.priorityUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
         this.priorityUp.HeaderText = "Up";
         this.priorityUp.Name = "priorityUp";
         this.priorityUp.Resizable = System.Windows.Forms.DataGridViewTriState.True;
         this.priorityUp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
         this.priorityUp.Width = 40;
         // 
         // priorityDown
         // 
         dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
         dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
         dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
         dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
         dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
         this.priorityDown.DefaultCellStyle = dataGridViewCellStyle4;
         this.priorityDown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
         this.priorityDown.HeaderText = "Down";
         this.priorityDown.Name = "priorityDown";
         this.priorityDown.Resizable = System.Windows.Forms.DataGridViewTriState.True;
         this.priorityDown.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
         this.priorityDown.Width = 40;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(12, 64);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(100, 13);
         this.label3.TabIndex = 5;
         this.label3.Text = "Available Discounts";
         // 
         // button1
         // 
         this.button1.BackColor = System.Drawing.SystemColors.Window;
         this.button1.Image = global::DiscountTA.Properties.Resources.Money_6;
         this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.button1.Location = new System.Drawing.Point(115, 222);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(586, 23);
         this.button1.TabIndex = 2;
         this.button1.Text = "Apply Selected Discounts";
         this.button1.UseVisualStyleBackColor = false;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // imageList1
         // 
         this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
         this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
         this.imageList1.Images.SetKeyName(0, "db delete.bmp");
         this.imageList1.Images.SetKeyName(1, "Fill Up.bmp");
         this.imageList1.Images.SetKeyName(2, "Fill Down.bmp");
         // 
         // tbResults
         // 
         this.tbResults.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
         this.tbResults.Location = new System.Drawing.Point(115, 418);
         this.tbResults.Multiline = true;
         this.tbResults.Name = "tbResults";
         this.tbResults.Size = new System.Drawing.Size(586, 138);
         this.tbResults.TabIndex = 8;
         // 
         // textBox1
         // 
         this.textBox1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
         this.textBox1.Location = new System.Drawing.Point(114, 265);
         this.textBox1.Multiline = true;
         this.textBox1.Name = "textBox1";
         this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
         this.textBox1.Size = new System.Drawing.Size(284, 135);
         this.textBox1.TabIndex = 6;
         // 
         // textBox2
         // 
         this.textBox2.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
         this.textBox2.Location = new System.Drawing.Point(417, 265);
         this.textBox2.Multiline = true;
         this.textBox2.Name = "textBox2";
         this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
         this.textBox2.Size = new System.Drawing.Size(284, 135);
         this.textBox2.TabIndex = 7;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(112, 249);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(62, 13);
         this.label2.TabIndex = 9;
         this.label2.Text = "Input JSON";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(414, 249);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(70, 13);
         this.label4.TabIndex = 10;
         this.label4.Text = "Output JSON";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(112, 402);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(72, 13);
         this.label5.TabIndex = 11;
         this.label5.Text = "Verbal Output";
         // 
         // MainForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(713, 568);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.textBox2);
         this.Controls.Add(this.textBox1);
         this.Controls.Add(this.tbResults);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.dataGridView1);
         this.Controls.Add(this.tbTotalAmount);
         this.Controls.Add(this.label1);
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.Name = "MainForm";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Final order process";
         this.Shown += new System.EventHandler(this.MainForm_Shown);
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox tbTotalAmount;
      private System.Windows.Forms.DataGridView dataGridView1;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.ImageList imageList1;
      private System.Windows.Forms.TextBox tbResults;
      private System.Windows.Forms.DataGridViewCheckBoxColumn CHK;
      private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
      private System.Windows.Forms.DataGridViewComboBoxColumn Type;
      private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
      private System.Windows.Forms.DataGridViewButtonColumn Delete;
      private System.Windows.Forms.DataGridViewButtonColumn priorityUp;
      private System.Windows.Forms.DataGridViewButtonColumn priorityDown;
      private System.Windows.Forms.TextBox textBox1;
      private System.Windows.Forms.TextBox textBox2;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label5;
   }
}

