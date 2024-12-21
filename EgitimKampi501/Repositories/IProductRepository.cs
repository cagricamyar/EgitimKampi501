﻿using EgitimKampi501.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimKampi501.Repositories
{
	public interface IProductRepository
	{
		Task<List<ResultProductDto>> GetAllProductAsync();
		Task CreateProductAsync(CreateProductDto createProductDto);
		Task UpdateProductAsync(UpdateProductDto updateProductDto);
		Task DeleteProductAsync(int id);
		Task GetByIdAsync(int id);
	}
}