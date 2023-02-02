namespace Task_03
{
    public abstract class Asset
    {
        public string Title { get; set; }

        public Asset(string title) 
        { 
            Title = title;
        }
    }
}
