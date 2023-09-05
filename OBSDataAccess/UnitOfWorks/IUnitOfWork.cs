using OBSDataAccess.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBSDataAccess.UnitOfWorks
{
    public interface IUnitOfWork
    {
        IStudentRepository studentRepository { get; set; }
        int Complement();
    }
}
