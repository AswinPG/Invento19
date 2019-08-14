using System;
using System.Collections.Generic;
using System.Text;

namespace Invento19.Models
{
    public class ProgramModel
    {
        public string ImgUrl { get; set; }
        public string Name { get; set; }
        public string About { get; set; }
        public string Type { get; internal set; }
        public string Event { get; internal set; }
    }
}
