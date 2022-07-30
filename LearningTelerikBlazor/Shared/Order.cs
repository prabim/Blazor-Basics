using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using static LearningTelerikBlazor.Shared.Enum.Enum;

namespace LearningTelerikBlazor.Shared
{
    public class Order
    {
        [Required]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        public string Alias { get; }
        [Range(1,4)]
        public Sizes Size { get; set; } = Sizes.Small;
        public bool Decaf { get; set; }
        public bool Iced { get; set; }
        [MaxLength(length:1000)]
        public string Comment { get; set; }
        public double Tip { get; set; }

    }
}
