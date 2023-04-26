﻿using CallMePhonyEntities.Enums;

namespace CallMePhonyEntities.Models
{
    public class Site : ModelBase, ISearchableObject
    {
        public string? Name { get; set; }
        public SiteType? SiteType { get; set; }

        public virtual IEnumerable<User>? Users { get; set; }
    }
}
