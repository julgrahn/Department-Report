namespace Avdelningsrapport_2
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Type { get; set; }

        public override string ToString()
        {
            return Title + " : " + Type + " av " + Author;
        }
    }
}
