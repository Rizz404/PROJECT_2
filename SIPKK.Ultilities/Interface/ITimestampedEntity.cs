namespace SIPKK.Ultilities.Interface
{
    public interface ITimestampedEntity : ICuidEntity
    {
        DateTime CreatedAt { get; set; }
        DateTime UpdatedAt { get; set; }
    }
}
