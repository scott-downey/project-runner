using System.Collections.Generic;

namespace ProjectRunner.Common.Entities
{
    public class Executable : BaseEntity
    {
        public string Name { get; set; }
        public string FileName { get; set; }
        public List<Project> Projects { get; set; }
    }
}
