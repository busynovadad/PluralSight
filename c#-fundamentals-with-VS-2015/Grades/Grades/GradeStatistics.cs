﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeStatistics
    {
        public GradeStatistics()
        {
            LowestGrade = float.MaxValue;
            HighestGrade = 0;
        }
            public float AverageGrade;
            public float HighestGrade;
            public float LowestGrade;
    }
}
