using System.ComponentModel.DataAnnotations;

namespace Models.Requests
{
    public class Paging
    {
        private const int MAX_LIMIT = 200;

        [Required]
        public int Page { get; set; } = 1;

        [Range(1, MAX_LIMIT)]
        public int Limit { get; set; } = 50;

    }
}
