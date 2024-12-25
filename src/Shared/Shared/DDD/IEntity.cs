namespace Shared.DDD
{
    public interface IEntity<T> : IEntity
    {
        public T Id { get; set; }
    }
    public interface IEntity
    {
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
