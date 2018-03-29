﻿using System;

namespace BeatPulse.UI.Core.Data
{

    class LivenessExecutionHistory
    {
        public int Id { get; set; }

        public DateTime ExecutedOn { get; set; }

        public string LivenessUri { get; set; }

        public bool IsHealthy { get; set; }

        public string Result { get; set; }
    }
}
