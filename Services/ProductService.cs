﻿using ProvaPub.Models;
using ProvaPub.Repository;

namespace ProvaPub.Services
{
	public class ProductService 
	{
		TestDbContext _ctx;

		public ProductService(TestDbContext dbContext)  
		{
            _ctx = dbContext;
		}

		public ProductList  ListProducts(int page)
		{
			return new ProductList() {  HasNext=false, TotalCount =10, Products = _ctx.Products.ToList() };
		}

	}
}
