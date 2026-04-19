using System;
using SalesManahmentSystemDAL.Models;
using System.Collections.Generic;
using System.Text;
using System.Data;
using SalesManahmentSystemDAL;

namespace SalesManahmentSystemBLL.Services
{
    public static class CategoryService
    {
        public static IEnumerable<Category> GetAllCategories()
        {
            IEnumerable<Category> categories = 
                DataBaseHelper.ExecuteSelect<Category>("SELECT * FROM CATEGORYS");
            return categories;
        }
        public static IEnumerable<Category> GetAllCategoriesByPattern( string pattern)
        {
            string wrappedPattern = $"%{pattern}%";

            IEnumerable<Category> categories =
                DataBaseHelper.ExecuteSelect<Category>(
                    "SELECT * FROM CATEGORYS WHERE Name LIKE @Pattern", 
                    new { Pattern = wrappedPattern }
                );

            return categories;
        }

        public static bool AddCategory(Category category)
        {
            string command = $"INSERT INTO CATEGORYS (Name) VALUES (N'{category.Name}')";
            int affectedRows = DataBaseHelper.ExecuteDML(command);
            return affectedRows > 0;
        }

        public static bool UpdateCategory(Category category)
        {
            string command = $"UPDATE CATEGORYS SET Name = '{category.Name}' WHERE ID = {category.ID}";
            int affectedRows = DataBaseHelper.ExecuteDML(command);
            return affectedRows > 0;
        }

        public static bool DeleteCategory(int categoryId)
        {
            string command = $"DELETE FROM CATEGORYS WHERE ID = {categoryId}";
            int affectedRows = DataBaseHelper.ExecuteDML(command);
            return affectedRows > 0;
        }
        public static bool DeleteAllCategory()
        {
            string command = "DELETE FROM CATEGORYS";
            int affectedRows = DataBaseHelper.ExecuteDML(command);
            return affectedRows > 0;
        }
    }
}
