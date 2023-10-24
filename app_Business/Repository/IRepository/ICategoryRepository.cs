﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using app_Models;

namespace app_Business.Repository.IRepository
{
    public interface ICategoryRepository
    {
        public CategoryDTO Create(CategoryDTO objDTO);
        public CategoryDTO Update(CategoryDTO objDTO);
        public int Delete(int id);
        public CategoryDTO Get(int id);
        public IEnumerable<CategoryDTO> GetAll();
    }
}
