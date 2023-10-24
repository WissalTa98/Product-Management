using app_Business.Repository.IRepository;
using app_DataAccess;
using app_DataAccess.Data;
using app_Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_Business.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public CategoryRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public CategoryDTO Create(CategoryDTO objDTO)
        {
            Category category = new Category()
            {
                Name = objDTO.Name,
                Id = objDTO.Id,
                CreatedDate = DateTime.Now
            };

            _db.Categories.Add(category);
            _db.SaveChanges();

            return new CategoryDTO()
            {
                Id = category.Id,
                Name = category.Name
            };
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public CategoryDTO Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CategoryDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public CategoryDTO Update(CategoryDTO objDTO)
        {
            throw new NotImplementedException();
        }
    }
}
