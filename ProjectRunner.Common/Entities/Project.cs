namespace ProjectRunner.Common.Entities
{
    public class Project : BaseEntity
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public string Executable { get; set; }
#nullable enable
        public string? ExecutableArguments { get; set; }
#nullable disable
    }
}
