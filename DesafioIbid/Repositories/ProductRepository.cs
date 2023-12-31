﻿using DesafioIbid.Datas;
using DesafioIbid.Models;
using DesafioIbid.Repositories.interfaces;
using Microsoft.EntityFrameworkCore;

namespace DesafioIbid.Repositories
{
    public class ProductRepository : IProduct
    {
        private readonly SystemProductDbContext _dbContext;

        public ProductRepository(SystemProductDbContext systemProductDbContext)
        {
            _dbContext = systemProductDbContext;
        }


        public async Task<List<ProductModel>> GetAll()
        {
            return await _dbContext.ProductsTable.ToListAsync();
        }

        public async Task<ProductModel> GetById(int id)
        {
            return await _dbContext.ProductsTable.FirstOrDefaultAsync(product => product.Id == id);
        }

        public async Task<ProductModel> GetByName(string name)
        {
            return await _dbContext.ProductsTable.FirstOrDefaultAsync(product => product.Name == name);
        }

        public async Task<ProductModel> CreateProduct(ProductModel product)
        {
            await _dbContext.ProductsTable.AddAsync(product);
            await _dbContext.SaveChangesAsync();
            return product;
        }

        public async Task<ProductModel> UpdateProduct(ProductModel product, int id)
        {
            ProductModel productById = await GetById(id) ?? throw new Exception($"User of ID:{id} was not found!");

            productById.Name = product.Name;
            productById.Description = product.Description;
            productById.Price = product.Price;
            productById.Category = product.Category;

            return productById;
        }

        public async Task<bool> DeleteProduct(int id)
        {
            ProductModel productById = await GetById(id) ?? throw new Exception($"User of ID:{id} was not found!");

            _dbContext.Remove(productById);
            _dbContext.SaveChanges();

            return true;
        }
    }
}
