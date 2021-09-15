using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCore.Models
{
    public partial class TestApi : BaseEntity
    {
        private string name;
        private int age;
        [MaxLength(30)]
        public string Name
        {
            get => this.name;
            set { this.name = value; NotifyOfPropertyChange(() => Name); }
        }

        public int Age
        {
            get => this.age;
            set { this.age = value; NotifyOfPropertyChange(() => Age); }
        }
    }
}
