﻿using System;
using System.Collections.Generic;

namespace DiscoveryApi.DAL
{
    public partial class ServerFactionsActivity
    {
        public int Id { get; set; }
        public ulong Duration { get; set; }
        public ulong? Duration2 { get; set; }
        public int FactionId { get; set; }
        public DateTime Stamp { get; set; }

        public virtual ServerFactions Faction { get; set; }
    }
}
