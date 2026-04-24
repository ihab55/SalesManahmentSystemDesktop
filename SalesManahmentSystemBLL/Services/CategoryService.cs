using SalesManahmentSystemBLL.DTOs;
using SalesManahmentSystemBLL.ServicesInterface;
using SalesManahmentSystemDAL;
using SalesManahmentSystemDAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesManahmentSystemBLL.Services
{
    public class CategoryService : ICategoryService
    {
        public async Task<IEnumerable<Category>> GetAllCategories()
        {
            IEnumerable<Category> categories =
               await DataBaseHelper.Instance.ExecuteSelect<Category>("SELECT * FROM CATEGORYS");
            return categories;
        }
        public async Task<IEnumerable<CategoryReadBasicDTO>> GetAllBasicCategories()
        {
            IEnumerable<CategoryReadBasicDTO> categories =
              await  DataBaseHelper.Instance.ExecuteSelect<CategoryReadBasicDTO>
                ("SELECT ID, NAME FROM CATEGORYS");
            return categories;
        }
        public async Task<IEnumerable<Category>> GetAllCategoriesByPattern( string pattern)
        {
            string wrappedPattern = $"%{pattern}%";

            IEnumerable<Category> categories =
               await DataBaseHelper.Instance.ExecuteSelect<Category>(
                    "SELECT * FROM CATEGORYS WHERE Name LIKE @Pattern", 
                    new { Pattern = wrappedPattern }
                );

            return categories;
        }
        public async Task<bool> AddCategory(Category category)
        {
            string command = $"INSERT INTO CATEGORYS (Name) VALUES (N'{category.Name}')";
            int affectedRows = await DataBaseHelper.Instance.ExecuteDML(command);
            return affectedRows > 0;
        }
        public async Task<bool> UpdateCategory(Category category)
        {
            string command = $"UPDATE CATEGORYS SET Name = '{category.Name}' WHERE ID = {category.ID}";
            int affectedRows = await DataBaseHelper.Instance.ExecuteDML(command);
            return affectedRows > 0;
        }
        public async Task<bool> DeleteCategory(int categoryId)
        {
            string command = $"DELETE FROM CATEGORYS WHERE ID = {categoryId}";
            int affectedRows = await DataBaseHelper.Instance.ExecuteDML(command);
            return affectedRows > 0;
        }
        public async Task<bool> DeleteAllCategory()
        {
            string command = "DELETE FROM CATEGORYS";
            int affectedRows = await DataBaseHelper.Instance.ExecuteDML(command);
            return affectedRows > 0;
        }

    }
}
