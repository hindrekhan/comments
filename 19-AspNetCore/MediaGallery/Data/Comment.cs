﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaGallery.Data
{
    public class Comment
    {
        public int Id { get; set; }
        public int MediaItemId { get; set; }
        public string UserId { get; set; }
        public string Content { get; set; }
        public DateTime Time { get; set; }
    }
}
