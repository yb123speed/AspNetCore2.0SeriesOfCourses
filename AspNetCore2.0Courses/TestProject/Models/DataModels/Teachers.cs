﻿using System;
using System.Collections.Generic;

namespace TestProject.Models.DataModels
{
    public partial class Teachers
    {
        public Teachers()
        {
            Tests = new HashSet<Tests>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string TeaacherNo { get; set; }
        public string Password { get; set; }

        public ICollection<Tests> Tests { get; set; }
    }
}
