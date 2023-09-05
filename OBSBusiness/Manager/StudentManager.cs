using OBSBusiness.DTO;
using OBSDataAccess.Repository.Abstract;
using OBSDataAccess.UnitOfWorks;
using OBSEntity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBSBusiness.Manager
{
    public class StudentManager
    {
        readonly IStudentRepository _studentRepository;
        private UnitOfWork _context = UnitOfWork.Instance;
        public StudentManager()
        {
        }

        public List<StudentEntity> GetListStudent()
        {
            List<StudentEntity> studentEntities = (List<StudentEntity>)_context.studentRepository.GetAll().ToList();
            List<StudentEntity> studentForViewBag = new List<StudentEntity>();
            return studentEntities;
        }

        public bool AddStudent(StudentAddDto studentAddDto)
        {
            if(studentAddDto != null)
            {
                if (studentAddDto.Id != 0)
                {
                    StudentEntity studentsEn = _context.studentRepository.Get(studentAddDto.Id);
                    studentsEn.Name = studentAddDto.Name;
                    studentsEn.Surname = studentAddDto.Surname;
                    studentsEn.PhoneNumber = studentAddDto.PhoneNumber;
                    studentsEn.EMail = studentAddDto.EMail;
                    studentsEn.Adress = studentAddDto.Adress;
                    studentsEn.Class = studentAddDto.Class;

                    _context.studentRepository.Update(studentsEn);
                }
                else
                {
                    StudentEntity students = new StudentEntity();
                    students.Name = studentAddDto.Name;
                    students.Surname = studentAddDto.Surname;
                    students.PhoneNumber = studentAddDto.PhoneNumber;
                    students.EMail = studentAddDto.EMail;
                    students.Adress = studentAddDto.Adress;
                    students.Class = studentAddDto.Class;

                    _context.studentRepository.Add(students);
                }
                _context.Complement();
            }
            return true;
        }

        public StudentEntity GetStudent(int Id)
        {
            StudentEntity students = _context.studentRepository.Get(Id);

            return students;
        }

        public bool DeleteProducut(int id)
        {
            try
            {
                _context.studentRepository.Remove(id);
                _context.Complement();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }



    }
}
