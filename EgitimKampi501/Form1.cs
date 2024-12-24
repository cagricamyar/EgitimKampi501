using Dapper;
using EgitimKampi501.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EgitimKampi501
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		
		SqlConnection connection = new SqlConnection("Server=(localdb)\\mssqllocaldb; initial Catalog = EgitimKampi501Db; integrated security = true");
		private async void btnList_Click(object sender, EventArgs e)
		{
			string query = "Select * from TblProduct";
			var values = await connection.QueryAsync<ResultProductDto>(query);
			dataGridView1.DataSource = values;
		}

		private async void btnAdd_Click(object sender, EventArgs e)
		{
			string query = "insert into TblProduct (ProductName, ProductStock, ProductPrice,ProductCategory)" +
				"values (@productName, @productStock, @productPrice, @productCategory)";
			var parameters = new DynamicParameters();
			parameters.Add("@productName", txtProductName.Text);
			parameters.Add("@productStock", txtProductStock.Text);
			parameters.Add("@productPrice", txtProductPrice.Text);
			parameters.Add("@productCategory", txtProductCategory.Text);
			await connection.ExecuteAsync(query, parameters);
			MessageBox.Show("Yeni Kitap Ekleme Basarili");
		}

		private async void btnDelete_Click(object sender, EventArgs e)
		{
			string query = "delete from TblProduct where ProductId = @productId";
			var parameters = new DynamicParameters();
			parameters.Add("@productId", txtProductId.Text);
			await connection.ExecuteAsync(query, parameters);
			MessageBox.Show("Kitap Silme Basarili");
		}

		private async void btnUpdate_Click(object sender, EventArgs e)
		{
			string query = "update TblProduct set ProductName = @productName, ProductPrice = @productPrice, " +
				"ProductStock = @productStock, ProductCategory = @productCategory where ProductId = @productId";
			var parameters = new DynamicParameters();
			parameters.Add("@productId", txtProductId.Text);
			parameters.Add("@productName", txtProductName.Text);
			parameters.Add("@productStock", txtProductStock.Text);
			parameters.Add("@productPrice", txtProductPrice.Text);
			parameters.Add("@productCategory", txtProductCategory.Text);
			await connection.ExecuteAsync(query, parameters);
			MessageBox.Show("Kitap guncelleme islemi basarili",  "Guncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private async void Form1_Load(object sender, EventArgs e)
		{
			string query1 = "Select count(*) from TblProduct";
			var productTotalCount = await connection.QueryFirstOrDefaultAsync<int>(query1);
			lblTotalProductCount.Text = productTotalCount.ToString();

			string query2 = "Select productName from TblProduct where productPrice = (Select max(productPrice) from tblproduct)";
			var maxPriceProductName = await connection.QueryFirstOrDefaultAsync<string>(query2);
			lblMaxPriceProduct.Text = maxPriceProductName.ToString();

			string query3 = "Select count(distinct(productCategory)) from tblProduct";
			var distinctProductCount = await connection.QueryFirstOrDefaultAsync<int>(query3);
			lblDistinctCategoryCount.Text = distinctProductCount.ToString();
		}
	}
}
