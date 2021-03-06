﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Zorbo.Core.Data.Packets
{
    public class UnknownJson : Unknown
    {
        public UnknownJson() { }

        public UnknownJson(byte id, string payload)
        {
            Id = id;
            Payload = Encoding.UTF8.GetBytes(payload);
        }
    }
}
