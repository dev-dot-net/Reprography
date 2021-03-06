﻿using Reprography.Domain.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reprography.Domain.Features
{
    public class PermissionFeature:BaseEntity
    {
        public Guid PermissionId { get; set; }
        public Guid FeatureId { get; set; }
        public PermissionTypes ActionType { get; set; }
        public virtual Permission Permission { get; set; }
        public virtual Feature Feature { get; set; }
    }

}
