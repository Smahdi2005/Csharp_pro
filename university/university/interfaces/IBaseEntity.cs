namespace BaseBackend.Interfaces;

public interface IFullEntity<T> : IDeletableEntity, ICreateableEntity
{
    public T Id { get; set; }
}

public interface IAuditableEntity
{
    public int Id { get; set; }
    public DateTime UpdatedAt { get; set; }
}

public interface IDeletableEntity
{
    public int DeletedByUserId { get; set; } // History of User
    public bool IsDeleted { get; set; }
    public DateTime DeletedAt { get; set; }
}

public interface ICreateableEntity
{
    public int CreatedByUserId { get; set; }
    public DateTime CreatedAt { get; set; }
}