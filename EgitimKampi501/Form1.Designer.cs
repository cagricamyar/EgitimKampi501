namespace EgitimKampi501
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnList = new System.Windows.Forms.Button();
			this.txtProductId = new System.Windows.Forms.TextBox();
			this.txtProductName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtProductStock = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtProductPrice = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtProductCategory = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.lblTotal = new System.Windows.Forms.Label();
			this.lblTotalProductCount = new System.Windows.Forms.Label();
			this.lblMaxPriceProductName = new System.Windows.Forms.Label();
			this.lblMaxPriceProduct = new System.Windows.Forms.Label();
			this.lblDistinctCategoryCount = new System.Windows.Forms.Label();
			this.lblDistinctCategory = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(58, 67);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Urun Id:";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(273, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(687, 395);
			this.dataGridView1.TabIndex = 1;
			// 
			// btnList
			// 
			this.btnList.Location = new System.Drawing.Point(109, 214);
			this.btnList.Name = "btnList";
			this.btnList.Size = new System.Drawing.Size(158, 23);
			this.btnList.TabIndex = 2;
			this.btnList.Text = "Listele";
			this.btnList.UseVisualStyleBackColor = true;
			this.btnList.Click += new System.EventHandler(this.btnList_Click);
			// 
			// txtProductId
			// 
			this.txtProductId.Location = new System.Drawing.Point(109, 60);
			this.txtProductId.Name = "txtProductId";
			this.txtProductId.Size = new System.Drawing.Size(158, 20);
			this.txtProductId.TabIndex = 3;
			// 
			// txtProductName
			// 
			this.txtProductName.Location = new System.Drawing.Point(109, 86);
			this.txtProductName.Name = "txtProductName";
			this.txtProductName.Size = new System.Drawing.Size(158, 20);
			this.txtProductName.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(52, 93);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Urun Adi:";
			// 
			// txtProductStock
			// 
			this.txtProductStock.Location = new System.Drawing.Point(109, 138);
			this.txtProductStock.Name = "txtProductStock";
			this.txtProductStock.Size = new System.Drawing.Size(158, 20);
			this.txtProductStock.TabIndex = 9;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(71, 145);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Stok:";
			// 
			// txtProductPrice
			// 
			this.txtProductPrice.Location = new System.Drawing.Point(109, 112);
			this.txtProductPrice.Name = "txtProductPrice";
			this.txtProductPrice.Size = new System.Drawing.Size(158, 20);
			this.txtProductPrice.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(71, 119);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(32, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Fiyat:";
			// 
			// txtProductCategory
			// 
			this.txtProductCategory.Location = new System.Drawing.Point(109, 164);
			this.txtProductCategory.Name = "txtProductCategory";
			this.txtProductCategory.Size = new System.Drawing.Size(158, 20);
			this.txtProductCategory.TabIndex = 11;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(54, 171);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(49, 13);
			this.label5.TabIndex = 10;
			this.label5.Text = "Kategori:";
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(109, 243);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(158, 23);
			this.btnAdd.TabIndex = 12;
			this.btnAdd.Text = "Ekle";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(109, 301);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(158, 23);
			this.btnUpdate.TabIndex = 14;
			this.btnUpdate.Text = "Guncelle";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(109, 272);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(158, 23);
			this.btnDelete.TabIndex = 13;
			this.btnDelete.Text = "Sil";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// lblTotal
			// 
			this.lblTotal.AutoSize = true;
			this.lblTotal.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblTotal.Location = new System.Drawing.Point(75, 502);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(192, 26);
			this.lblTotal.TabIndex = 15;
			this.lblTotal.Text = "Toplam Kitap Sayısı : ";
			// 
			// lblTotalProductCount
			// 
			this.lblTotalProductCount.AutoSize = true;
			this.lblTotalProductCount.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblTotalProductCount.ForeColor = System.Drawing.Color.Gold;
			this.lblTotalProductCount.Location = new System.Drawing.Point(268, 502);
			this.lblTotalProductCount.Name = "lblTotalProductCount";
			this.lblTotalProductCount.Size = new System.Drawing.Size(23, 26);
			this.lblTotalProductCount.TabIndex = 16;
			this.lblTotalProductCount.Text = "0";
			// 
			// lblMaxPriceProductName
			// 
			this.lblMaxPriceProductName.AutoSize = true;
			this.lblMaxPriceProductName.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblMaxPriceProductName.Location = new System.Drawing.Point(75, 528);
			this.lblMaxPriceProductName.Name = "lblMaxPriceProductName";
			this.lblMaxPriceProductName.Size = new System.Drawing.Size(155, 26);
			this.lblMaxPriceProductName.TabIndex = 17;
			this.lblMaxPriceProductName.Text = "En Pahali Kitap : ";
			// 
			// lblMaxPriceProduct
			// 
			this.lblMaxPriceProduct.AutoSize = true;
			this.lblMaxPriceProduct.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblMaxPriceProduct.ForeColor = System.Drawing.Color.Gold;
			this.lblMaxPriceProduct.Location = new System.Drawing.Point(268, 528);
			this.lblMaxPriceProduct.Name = "lblMaxPriceProduct";
			this.lblMaxPriceProduct.Size = new System.Drawing.Size(23, 26);
			this.lblMaxPriceProduct.TabIndex = 18;
			this.lblMaxPriceProduct.Text = "0";
			// 
			// lblDistinctCategoryCount
			// 
			this.lblDistinctCategoryCount.AutoSize = true;
			this.lblDistinctCategoryCount.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblDistinctCategoryCount.ForeColor = System.Drawing.Color.Gold;
			this.lblDistinctCategoryCount.Location = new System.Drawing.Point(268, 554);
			this.lblDistinctCategoryCount.Name = "lblDistinctCategoryCount";
			this.lblDistinctCategoryCount.Size = new System.Drawing.Size(23, 26);
			this.lblDistinctCategoryCount.TabIndex = 20;
			this.lblDistinctCategoryCount.Text = "0";
			// 
			// lblDistinctCategory
			// 
			this.lblDistinctCategory.AutoSize = true;
			this.lblDistinctCategory.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblDistinctCategory.Location = new System.Drawing.Point(75, 554);
			this.lblDistinctCategory.Name = "lblDistinctCategory";
			this.lblDistinctCategory.Size = new System.Drawing.Size(148, 26);
			this.lblDistinctCategory.TabIndex = 19;
			this.lblDistinctCategory.Text = "Kategori Sayisi :";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.MediumSeaGreen;
			this.ClientSize = new System.Drawing.Size(1150, 770);
			this.Controls.Add(this.lblDistinctCategoryCount);
			this.Controls.Add(this.lblDistinctCategory);
			this.Controls.Add(this.lblMaxPriceProduct);
			this.Controls.Add(this.lblMaxPriceProductName);
			this.Controls.Add(this.lblTotalProductCount);
			this.Controls.Add(this.lblTotal);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.txtProductCategory);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtProductStock);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtProductPrice);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtProductName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtProductId);
			this.Controls.Add(this.btnList);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnList;
		private System.Windows.Forms.TextBox txtProductId;
		private System.Windows.Forms.TextBox txtProductName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtProductStock;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtProductPrice;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtProductCategory;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.Label lblTotalProductCount;
		private System.Windows.Forms.Label lblMaxPriceProductName;
		private System.Windows.Forms.Label lblMaxPriceProduct;
		private System.Windows.Forms.Label lblDistinctCategoryCount;
		private System.Windows.Forms.Label lblDistinctCategory;
	}
}

