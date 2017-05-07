﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiscoveryApi.Models
{
    public class PlayersOnline
    {
        public string Error { get; set; }
        public List<PlayerOnlineSingle> Players { get; set; }
        public string Timestamp { get; set; }
    }

    public class PlayerOnlineSingle
    {
        public string Time { get; set;}
        public string Name { get; set; }
        public string Faction { get; set; }
        public string System { get; set; }
        public string Region { get; set; }
        public int Ping { get; set; }
    }
}
