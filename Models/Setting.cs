﻿using System.Collections.Generic;

namespace MatriX.API.Models
{
    public class Setting
    {
        public int port { get; set; } = 8090;

        public bool IPAddressAny { get; set; } = true;

        public bool onlyRemoteApi { get; set; }

        public List<Server> servers { get; set; }

        public string interface_network { get; set; } = "eth0";

        public int worknodetominutes { get; set; } = 5;

        public int maxiptoIsLockHostOrUser { get; set; } = 8;

        public string domainid_pattern { get; set; } = "^([^\\.]{8})\\.";

        public bool AuthorizationRequired { get; set; } = true;

        public bool allowedToChangeSettings { get; set; } = true;

        public string AuthorizationServerAPI { get; set; }

        public HashSet<Known> KnownProxies { get; set; } = new HashSet<Known>();
    }
}
