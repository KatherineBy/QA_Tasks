namespace Task_03
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
        public override bool Equals(object item)
        {
            if (item == null || item.GetType() == this.GetType()) return false;

            Course check = (Course)item;

            return check.Title == this.Title;
        }
    }
}
