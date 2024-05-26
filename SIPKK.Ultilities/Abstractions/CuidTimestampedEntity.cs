using SIPKK.Ultilities.Abstractions;
using SIPKK.Ultilities.Interface;

namespace SIPKK.Ultilities.Abstractions
{
    public abstract class CuidTimestampedEntity : CuidEntity, ITimestampedEntity
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
