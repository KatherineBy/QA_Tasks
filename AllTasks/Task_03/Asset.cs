namespace Task_03
{
    internal abstract class Asset
    {
        public string Title { get; set; }

        public Asset(string title) 
        { 
            Title = title;
        }
    }
}
