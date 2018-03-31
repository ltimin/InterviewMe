﻿using InterviewMe.Models.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewMe.Models.Requests
{
    public class QuizUpdateRequest : QuizRequest
    {
        [Required]
        public int Id { get; set; }
    }
}
