using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWebApp.Core.SharedKernel
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
