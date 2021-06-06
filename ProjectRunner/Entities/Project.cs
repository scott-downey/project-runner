namespace ProjectRunner.Entities
{
    public class Project : BaseEntity
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public string Command { get; set; }
    }
}
