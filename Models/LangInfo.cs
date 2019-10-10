using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class LangInfo
    {
        public int LangInfoId { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public virtual ICollection<Form> Forms { get; set; }
    }
}