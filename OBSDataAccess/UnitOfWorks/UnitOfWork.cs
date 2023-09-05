using OBSDataAccess.Context;
using OBSDataAccess.Repository.Abstract;
using OBSDataAccess.Repository.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBSDataAccess.UnitOfWorks
{
    public class UnitOfWork
    {
        private static readonly UnitOfWork lazy = new UnitOfWork();
        private readonly DataContext _context;

        public UnitOfWork()
        {
            _context = new DataContext();
            studentRepository = new StudentRepository(_context);
        }
        public static UnitOfWork Instance { get { return lazy; } }
        public IStudentRepository studentRepository { get; set; }

        public int Complement()
        {
            return _context.SaveChanges();
        }
    }
}
