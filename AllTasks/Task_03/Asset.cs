namespace Task_03
{
    internal abstract class Asset
    {
        public string Title { get; }

        public Asset(string title) 
        { 
            Title = title;
        }
    }
}
