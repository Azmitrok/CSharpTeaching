﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsApp.Models
{
    public class Repository
    {
        public List<Student> Students { get; set; } = new List<Student>();

        public List<Teacher> Teachers { get; set; } = new List<Teacher>();

        public List<Room> Rooms { get; set; } = new List<Room>();

        public List<Subject> Subjects { get; set; } = new List<Subject>();

        public List<Lesson> Lessons { get; set; } = new List<Lesson>();

        public List<StudentVisit> Visits { get; set; } = new List<StudentVisit>();
    }
}
