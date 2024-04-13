using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoCompareShop.Models
{
    public class Setting
    {
        public int Id { get; set; }

        
        public string? FileName { get; set; }
        public string? Path { get; set; }
        public string? Key { get; set; }

        public string? Value { get; set; }
        public string? Name { get; set; }

        public string? Description { get; set; }

        

        public bool? IsEnabled { get; set; } = true;

        public bool? IsActive { get; set; } = true;
        public bool? IsDeleted { get; set; } = false;

    }
}
