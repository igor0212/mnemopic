using System;

namespace Mnemopic.Borders.Entities
{
    public class Word
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid ImageId { get; set; }
        public DateTime CreatedAd { get; set; }
    }
}

