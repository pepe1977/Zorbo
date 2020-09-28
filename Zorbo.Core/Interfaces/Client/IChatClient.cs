﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Zorbo.Core.Interfaces.Client
{
    public interface IChatClient
    {
        IDirectories Directories { get; }
        IChatClientConfig Config { get; }
    }
}
