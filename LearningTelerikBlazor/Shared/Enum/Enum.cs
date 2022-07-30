using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LearningTelerikBlazor.Shared.Enum
{
    public  class Enum
    {
        public enum Sizes
        {
            [Display(Name = "Select a size")]
            NoneSelected,
            Small, 
            Medium,
            Large,
            [Display(Name = "Very Special")]
            Special
        }
    }
}
