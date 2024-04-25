﻿using AutoMapper;
using BE_CRUD_Operations.Core.Dto;
//using BE_CRUD_Operations.Core.Mapper;
using BE_CRUD_Operations.Core.Services;
using BE_CRUD_Operations.Data.AppDbContext;
using BE_CRUD_Operations.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Serilog.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace BE_CRUD_Operations.Core.Implementation
{
    public class StudentService : IStudentService
    {
        private readonly CRUD_DbContext _context;
        private readonly IMapper _mapper;

        public StudentService(CRUD_DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> CreateStudent(StudentDTO studentDTO)
        {
            try
            {

                //var student = _mapper.Map<Student>(studentDTO);

                // Create a new Student instance
                var student = new Student();

                // Map properties from StudentDTO to Student manually
                student.FirstName = studentDTO.FirstName;
                student.LastName = studentDTO.LastName;
                student.Department = studentDTO.Department;
                student.Gender = studentDTO.Gender;
                student.DateOfBirth = studentDTO.DateOfBirth;
                student.Age = studentDTO.Age;
                student.IsGraduated = studentDTO.IsGraduated;

                _context.students.Add(student);
                await _context.SaveChangesAsync();

                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine($"An error occurred while creating a student: {ex.Message}"); 

                return false;
            }
        }

        public async Task<bool> DeleteStudentById(string studentId)
        {
            try
            {
                var studentToDelete = await _context.students.FindAsync(studentId);

                if (studentToDelete == null)
                    return false;

                _context.students.Remove(studentToDelete);
                await _context.SaveChangesAsync();

                return true;
            }
            catch(Exception ex)
            {
                throw new Exception($"Error occurred while deleting student with ID {studentId}: {ex.Message}", ex);
            }
        }

        public async Task<IEnumerable<StudentDTO>> GetAllStudents()
        {
            var students = await _context.students.ToListAsync();
            //return _mapper.Map<IEnumerable<StudentDTO>>(students); "This line solves from line 87 to 110

            // Create a list to store mapped StudentDTO objects
            var studentDTOs = new List<StudentDTO>();

            // Iterate through each student and map it to StudentDTO manually
            foreach (var student in students)
            {
                // Create a new StudentDTO instance
                var studentDTO = new StudentDTO();

                // Map properties from Student to StudentDTO manually
                studentDTO.FirstName = student.FirstName;
                studentDTO.LastName = student.LastName;
                studentDTO.Department = student.Department;
                studentDTO.Gender = student.Gender;
                studentDTO.DateOfBirth = student.DateOfBirth;
                studentDTO.Age = student.Age;
                studentDTO.IsGraduated = student.IsGraduated;

                // Add the mapped StudentDTO to the list
                studentDTOs.Add(studentDTO);
            }

            // Return the list of mapped StudentDTOs
            return studentDTOs;
        }

        public async Task<StudentDTO> GetStudentById(string studentId)
        {
            try
            {
                var gottenStudent = await _context.students.FirstOrDefaultAsync(s => s.StudentId == studentId);

                if (gottenStudent == null)
                    return null;

                //return _mapper.Map<StudentDTO>(gottenStudent);

                // Create a new StudentDTO instance
                var studentDTO = new StudentDTO();

                // Map properties from gottenStudent to StudentDTO manually
                studentDTO.FirstName = gottenStudent.FirstName;
                studentDTO.LastName = gottenStudent.LastName;
                studentDTO.Department = gottenStudent.Department;
                studentDTO.Gender = gottenStudent.Gender;
                studentDTO.DateOfBirth = gottenStudent.DateOfBirth;
                studentDTO.Age = gottenStudent.Age;
                studentDTO.IsGraduated = gottenStudent.IsGraduated;

                // Return the mapped StudentDTO
                return studentDTO;
            }
            catch(Exception ex)
            {
                throw new Exception($"Error occurred while fetching student with ID {studentId}: {ex.Message}", ex);
            }
        }

        public async Task<bool> UpdateStudent(string studentId, StudentDTO updatedStudentDTO)
        {
            try
            {
                var existingStudent = await _context.students.FindAsync(studentId);

                if(existingStudent == null)
                {
                    Console.WriteLine($"Student with ID {studentId} not found.");
                    return false;
                }

                //_mapper.Map(updatedStudentDTO, existingStudent);

                // Update the properties of the existing student with the values from updatedStudentDTO manually
                existingStudent.FirstName = updatedStudentDTO.FirstName;
                existingStudent.LastName = updatedStudentDTO.LastName;
                existingStudent.Department = updatedStudentDTO.Department;
                existingStudent.Gender = updatedStudentDTO.Gender;
                existingStudent.DateOfBirth = updatedStudentDTO.DateOfBirth;
                existingStudent.Age = updatedStudentDTO.Age;
                existingStudent.IsGraduated = updatedStudentDTO.IsGraduated;

                await _context.SaveChangesAsync();

                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine($"An error occurred while updating student with ID {studentId}: {ex.Message}");
                return false;
            }
        }
    }
}
