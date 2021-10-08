﻿using DTO;
using System.Collections.Generic;


namespace DAL.Interfaces
{
    public interface ICategoryDAL
    {
        List<CategoryDTO> GetAllCategory();
        CategoryDTO GetCategoryById(int сategoryId);
        CategoryDTO UpdateCategory(CategoryDTO с);
        CategoryDTO CreateCategory(CategoryDTO с);
        void DeleteCategory(int сategoryId);
    }
}
