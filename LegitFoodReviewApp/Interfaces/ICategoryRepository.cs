﻿using LegitFoodReviewApp.Models;

namespace LegitFoodReviewApp.Interfaces
{
    public interface ICategoryRepository
    {
        ICollection<Category> GetCategories();
        Category GetCategory(int id);
        ICollection<Food> GetFoodByCategory(int categoryId);
        bool CategoryExists(int id);
        bool CreateCategory(Category category);
        bool UpdateCategory(Category category);

        bool DeleteCategory(Category category);
        bool Save();


        
    }
}
