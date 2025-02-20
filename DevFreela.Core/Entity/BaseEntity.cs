namespace DevFreela.Core.Entity
{
    public class BaseEntity
    {

        protected BaseEntity()
        {
            CreatedAt = DateTime.Now;
            IsDeleted = false;
        }

        public int Id { get; private set; }
        public DateTime CreatedAt  { get; private set; }
        public bool IsDeleted { get; private set; }

        public void SetAsDeleted() => IsDeleted = true;
    }
}