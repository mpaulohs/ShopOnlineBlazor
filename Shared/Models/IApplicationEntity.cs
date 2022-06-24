namespace Shared.Models
{
    public interface IApplicationEntity<TKey>
    {
        public TKey Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public string ConcurrencyStamp { get; set; }

        public string ToString();
    }
}
