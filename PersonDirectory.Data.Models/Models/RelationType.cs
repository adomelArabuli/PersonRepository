using PersonDirectory.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonDirectory.Data.Models
{
    public class RelationType : Base<RelationTypeEnum>
    {
        public string Name { get; set; }
    }
}
