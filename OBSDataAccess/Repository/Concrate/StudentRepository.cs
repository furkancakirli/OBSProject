using Microsoft.EntityFrameworkCore;
using OBSDataAccess.Context;
using OBSDataAccess.Repository.Abstract;
using OBSEntity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBSDataAccess.Repository.Concrate
{
    public class StudentRepository : Repository<StudentEntity>, IStudentRepository
    {
        public StudentRepository(DbContext dbContext) : base(dbContext)
        {
        }

        DataContext _dbContext = new DataContext();
        
    }
}
