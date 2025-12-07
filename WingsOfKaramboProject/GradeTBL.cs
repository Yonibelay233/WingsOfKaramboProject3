using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WingsOfKaramboProject
{
    public class GradeTBL:BaseEntity
    {
        private string whatGrade;

        public string WhatGrade { get => whatGrade; set => whatGrade = value; }
    }
}
