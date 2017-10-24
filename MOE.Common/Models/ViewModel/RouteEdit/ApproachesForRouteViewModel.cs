﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOE.Common.Models.ViewModel.RouteEdit
{
    public class ApproachesForRouteViewModel
    {
        public List<RoutePhaseDirection> PrimaryApproaches { get; set; } = new List<RoutePhaseDirection>();
        public List<RoutePhaseDirection> OpposingApproaches { get; set; } = new List<RoutePhaseDirection>();
    }
}