﻿namespace CESDEUniversity.Models
{

    public enum Grade
    {

        A, B, C, D, E

    }

    public class Enrollment
    {

        public int EnrollmentID { get; set; }

        public int CourseID { get; set; }

        public int StudentID { get; set; }

        //? porque es una elección entre las opciones disponibles (A, B, ...)
        public Grade? Grade { get; set; }

        public virtual Course Course { get; set; }

        public virtual Student Student { get; set; }

    }
}