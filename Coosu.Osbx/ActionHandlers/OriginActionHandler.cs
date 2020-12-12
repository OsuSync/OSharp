﻿using Coosu.Osbx.Actions;
using Coosu.Storyboard.Parsing;

namespace Coosu.Osbx.ActionHandlers
{
    public class OriginActionHandler : BasicTimelineHandler<Origin>
    {
        public override int ParameterDimension => 2;
        public override string Flag => "O";
    }
}