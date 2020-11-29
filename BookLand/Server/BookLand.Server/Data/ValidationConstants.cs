namespace BookLand.Server.Data
{
    public class ValidationConstants
    {
        public class Book
        {
            public const int MaxTitleLength = 50;
            public const int MaxLanguageLength = 20;
            public const int MaxDescriptionLength = 3000;
            public const int MaxISBNLength = 30;
            public const string MinPrice = "0";
            public const string MaxPrice = "1000000";
        }
    }
}
