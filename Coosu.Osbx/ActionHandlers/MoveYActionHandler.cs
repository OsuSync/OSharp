﻿using Coosu.Storyboard.Events;
using Coosu.Storyboard.Parsing;

namespace Coosu.Osbx.ActionHandlers
{
    public class MoveYActionHandler : BasicTimelineHandler<MoveY>
    {
        public override int ParameterDimension => 1;
        public override string Flag => "MY";
    }
}