namespace TestWebService.Models
{
    public class PaginationParams
    {
        private const int _maxItemsPerPage = 34;
        private int itemsPerPage = 34;

        public int Page { get; set; } = 1;
        public int ItemsPerPage
        {
            get=> itemsPerPage;
            set => itemsPerPage = value > _maxItemsPerPage ? _maxItemsPerPage : value;
        }
    }
}
