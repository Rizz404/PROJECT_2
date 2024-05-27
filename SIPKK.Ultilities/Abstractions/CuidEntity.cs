using SIPKK.Ultilities.Interface;
using System.ComponentModel.DataAnnotations;
using Visus.Cuid;

namespace SIPKK.Ultilities.Abstractions
{
    public abstract class CuidEntity : ICuidEntity
    {
        public void GenerateId()
        {
            if(string.IsNullOrEmpty(Id))
            {
                Id = new Cuid2().ToString();
            }
        }

        [Key]
        [MaxLength(36)]
        public string Id { get; set; }
    }
}
