using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCore.DTOs
{
    public partial class TestApiDTO : BaseDto
    {
        public string Name { get; set; }

        public int Age { get; set; }
    }
}
