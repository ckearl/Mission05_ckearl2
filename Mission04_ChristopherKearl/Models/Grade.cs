﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission04_ChristopherKearl.Models
{

    public class Grade
    {
        [Key]
        public int GradeID { get; set; }

        [Range(0, 100, ErrorMessage = "Assignments grade must be between 0 and 100")]
        public int Assignments { get; set; }

        [Range(0, 100, ErrorMessage = "Group Projects grade must be between 0 and 100")]
        public int GroupProject { get; set; }

        [Range(0, 100, ErrorMessage = "Quizzes grade must be between 0 and 100")]
        public int Quizzes { get; set; }

        [Range(0, 100, ErrorMessage = "Midterm Exam grade must be between 0 and 100")]
        public int MidtermExam { get; set; }

        [Range(0, 100, ErrorMessage = "Final Exam grade must be between 0 and 100")]
        public int FinalExam { get; set; }

        [Range(0, 100, ErrorMessage = "Intex grade must be between 0 and 100")]
        public int Intex { get; set; }
    }
}