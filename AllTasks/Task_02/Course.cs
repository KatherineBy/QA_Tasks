namespace Task_02
{
    internal class Course
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public Course(string title, string description) 
        { 
            Title = title;
            Description = description;  
        }
    }
}
