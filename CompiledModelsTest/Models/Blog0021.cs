﻿using System;
using System.Collections.Generic;

namespace Models
{
    public partial class Blog0021
    {
        public Blog0021()
        {
            Post0021Blog00s = new HashSet<Post0021>();
            Post0021Blog01s = new HashSet<Post0021>();
            Post0021Blog02s = new HashSet<Post0021>();
            Post0021Blog03s = new HashSet<Post0021>();
        }

        public long Id { get; set; }
        public string? Property00 { get; set; }
        public string? Property01 { get; set; }
        public string? Property02 { get; set; }
        public string? Property03 { get; set; }
        public string? Property04 { get; set; }
        public string? Property05 { get; set; }
        public string? Property06 { get; set; }
        public string? Property07 { get; set; }
        public string? Property08 { get; set; }
        public string? Property09 { get; set; }
        public string? Property10 { get; set; }
        public string? Property11 { get; set; }
        public string? Property12 { get; set; }
        public string? Property13 { get; set; }
        public string? Property14 { get; set; }
        public string? Property15 { get; set; }
        public string? Property16 { get; set; }
        public string? Property17 { get; set; }
        public string? Property18 { get; set; }
        public string? Property19 { get; set; }

        public virtual ICollection<Post0021> Post0021Blog00s { get; set; }
        public virtual ICollection<Post0021> Post0021Blog01s { get; set; }
        public virtual ICollection<Post0021> Post0021Blog02s { get; set; }
        public virtual ICollection<Post0021> Post0021Blog03s { get; set; }
    }
}
