﻿using Altkom._20_22._11.CSharp.Module2.Models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Altkom._20_22._11.CSharp.Module2.Services
{
    public static class DataSource
    {
        // TODO 6.1a: Zmień kolekcję Teachers na listę generyczną
        public static ArrayList Teachers;
        public static List<Student> Students;
        // TODO 6.1b: Zmień kolekcję Grades na listę generyczną
        public static ArrayList Grades;

        //TODO 6.1e: Dodalij listę stringów o nazwie Subjects 

        public static void CreateData()
        {
            //TODO 6.1c: Popraw typ tworzonej kolekcji
            Teachers = new ArrayList()
            //TODO 6.1f: Zainicjuj kolekcję Subjects przesmiotami: Math, English, History, Geography, Science
            {
                new Teacher(1, "vallee", "password", "Esther", "Valle", "3C" ),
                new Teacher(2, "waited", "password", "David", "Waite", "4B" ),
                new Teacher(3, "newmanb", "password", "Belinda", "Newman", "2A" )
            };

            Students = new List<Student>()
            {
                new Student() { StudentID = 1, UserName = "liuk", Password = "password", TeacherID = 1, FirstName = "Kevin", LastName = "Liu" },
                new Student() { StudentID = 2, UserName = "weberm", Password = "password", TeacherID = 1, FirstName = "Martin", LastName = "Weber" },
                new Student() { StudentID = 3, UserName = "ligeorge", Password = "password", TeacherID = 1, FirstName = "George", LastName = "Li" },
                new Student() { StudentID = 4, UserName = "millerel", Password = "password", TeacherID = 1, FirstName = "Lisa", LastName = "Miller" },
                new Student() { StudentID = 5, UserName = "liur", Password = "password", TeacherID = 1, FirstName = "Run", LastName = "Liu" },
                new Student() { StudentID = 6, UserName = "stewarts", Password = "password", TeacherID = 2, FirstName = "Sean", LastName = "Stewart" },
                new Student() { StudentID = 7, UserName = "turnero", Password = "password", TeacherID = 2, FirstName = "Olinda", LastName = "Turner" },
                new Student() { StudentID = 8, UserName = "ortonj", Password = "password", TeacherID = 2, FirstName = "Jon", LastName = "Orton" },
                new Student() { StudentID = 9, UserName = "nixont", Password = "password", TeacherID = 2, FirstName = "Toby", LastName = "Nixon" },
                new Student() { StudentID = 10, UserName = "guinotd", Password = "password", TeacherID = 2, FirstName = "Daniela", LastName = "Guinot" },
                new Student() { StudentID = 11, UserName = "sundaramv", Password = "password", TeacherID = 3, FirstName = "Vijay", LastName = "Sundaram" },
                new Student() { StudentID = 12, UserName = "grubere", Password = "password", TeacherID = 3, FirstName = "Eric", LastName = "Gruber" },
                new Student() { StudentID = 13, UserName = "meyerc", Password = "password", TeacherID = 3, FirstName = "Chris", LastName = "Meyer" },
                new Student() { StudentID = 14, UserName = "liyuhong", Password = "password", TeacherID = 3, FirstName = "Yuhong", LastName = "Li" },
                new Student() { StudentID = 15, UserName = "liyan", Password = "password", TeacherID = 3, FirstName = "Yan", LastName = "Li" }

            };

            //TODO 6.1d: Popraw typ tworzonej kolekcji
            Grades = new ArrayList()
            {
                new Grade() { StudentID = 1, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "Math", Assessment = "A-", Comments = "Good" },
                new Grade() { StudentID = 1, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "English", Assessment = "B+", Comments = "OK" },
                new Grade() { StudentID = 1, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "Geography", Assessment = "C-", Comments = "Could do better" },
                new Grade() { StudentID = 1, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "History", Assessment = "D-", Comments = "Needs to work harder" },
                new Grade() { StudentID = 2, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "Math", Assessment = "A-", Comments = "Good" },
                new Grade() { StudentID = 2, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "English", Assessment = "B+", Comments = "OK" },
                new Grade() { StudentID = 2, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "Geography", Assessment = "C-", Comments = "Could do better" },
                new Grade() { StudentID = 2, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "History", Assessment = "D-", Comments = "Needs to work harder" },
                new Grade() { StudentID = 3, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "Math", Assessment = "A-", Comments = "Good" },
                new Grade() { StudentID = 3, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "English", Assessment = "B+", Comments = "OK" },
                new Grade() { StudentID = 3, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "Geography", Assessment = "C-", Comments = "Could do better" },
                new Grade() { StudentID = 3, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "History", Assessment = "D-", Comments = "Needs to work harder" },
                new Grade() { StudentID = 4, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "Math", Assessment = "A-", Comments = "Good" },
                new Grade() { StudentID = 4, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "English", Assessment = "B+", Comments = "OK" },
                new Grade() { StudentID = 4, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "Geography", Assessment = "C-", Comments = "Could do better" },
                new Grade() { StudentID = 4, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "History", Assessment = "D-", Comments = "Needs to work harder" },
                new Grade() { StudentID = 5, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "Math", Assessment = "A-", Comments = "Good" },
                new Grade() { StudentID = 5, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "English", Assessment = "B+", Comments = "OK" },
                new Grade() { StudentID = 5, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "Geography", Assessment = "C-", Comments = "Could do better" },
                new Grade() { StudentID = 5, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "History", Assessment = "D-", Comments = "Needs to work harder" },
                new Grade() { StudentID = 6, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "Math", Assessment = "A-", Comments = "Good" },
                new Grade() { StudentID = 6, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "English", Assessment = "B+", Comments = "OK" },
                new Grade() { StudentID = 6, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "Geography", Assessment = "C-", Comments = "Could do better" },
                new Grade() { StudentID = 6, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "History", Assessment = "D-", Comments = "Needs to work harder" },
                new Grade() { StudentID = 7, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "Math", Assessment = "A-", Comments = "Good" },
                new Grade() { StudentID = 7, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "English", Assessment = "B+", Comments = "OK" },
                new Grade() { StudentID = 7, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "Geography", Assessment = "C-", Comments = "Could do better" },
                new Grade() { StudentID = 7, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "History", Assessment = "D-", Comments = "Needs to work harder" },
                new Grade() { StudentID = 8, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "Math", Assessment = "A-", Comments = "Good" },
                new Grade() { StudentID = 8, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "English", Assessment = "B+", Comments = "OK" },
                new Grade() { StudentID = 8, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "Geography", Assessment = "C-", Comments = "Could do better" },
                new Grade() { StudentID = 8, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "History", Assessment = "D-", Comments = "Needs to work harder" },
                new Grade() { StudentID = 9, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "Math", Assessment = "A-", Comments = "Good" },
                new Grade() { StudentID = 9, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "English", Assessment = "B+", Comments = "OK" },
                new Grade() { StudentID = 9, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "Geography", Assessment = "C-", Comments = "Could do better" },
                new Grade() { StudentID = 9, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "History", Assessment = "D-", Comments = "Needs to work harder" },
                new Grade() { StudentID = 10, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "Math", Assessment = "A-", Comments = "Good" },
                new Grade() { StudentID = 10, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "English", Assessment = "B+", Comments = "OK" },
                new Grade() { StudentID = 10, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "Geography", Assessment = "C-", Comments = "Could do better" },
                new Grade() { StudentID = 10, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "History", Assessment = "D-", Comments = "Needs to work harder" },
                new Grade() { StudentID = 11, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "Math", Assessment = "A-", Comments = "Good" },
                new Grade() { StudentID = 11, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "English", Assessment = "B+", Comments = "OK" },
                new Grade() { StudentID = 11, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "Geography", Assessment = "C-", Comments = "Could do better" },
                new Grade() { StudentID = 11, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "History", Assessment = "D-", Comments = "Needs to work harder" },
                new Grade() { StudentID = 12, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "Math", Assessment = "A-", Comments = "Good" },
                new Grade() { StudentID = 12, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "English", Assessment = "B+", Comments = "OK" },
                new Grade() { StudentID = 12, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "Geography", Assessment = "C-", Comments = "Could do better" },
                new Grade() { StudentID = 12, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "History", Assessment = "D-", Comments = "Needs to work harder" },
                new Grade() { StudentID = 13, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "Math", Assessment = "A-", Comments = "Good" },
                new Grade() { StudentID = 13, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "English", Assessment = "B+", Comments = "OK" },
                new Grade() { StudentID = 13, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "Geography", Assessment = "C-", Comments = "Could do better" },
                new Grade() { StudentID = 13, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "History", Assessment = "D-", Comments = "Needs to work harder" },
                new Grade() { StudentID = 14, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "Math", Assessment = "A-", Comments = "Good" },
                new Grade() { StudentID = 14, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "English", Assessment = "B+", Comments = "OK" },
                new Grade() { StudentID = 14, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "Geography", Assessment = "C-", Comments = "Could do better" },
                new Grade() { StudentID = 14, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "History", Assessment = "D-", Comments = "Needs to work harder" },
                new Grade() { StudentID = 15, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "Math", Assessment = "A-", Comments = "Good" },
                new Grade() { StudentID = 15, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "English", Assessment = "B+", Comments = "OK" },
                new Grade() { StudentID = 15, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "Geography", Assessment = "C-", Comments = "Could do better" },
                new Grade() { StudentID = 15, AssessmentDate = DateTime.Now.ToString("d"), SubjectName = "History", Assessment = "D-", Comments = "Needs to work harder" },
            };
        }
    }
}
