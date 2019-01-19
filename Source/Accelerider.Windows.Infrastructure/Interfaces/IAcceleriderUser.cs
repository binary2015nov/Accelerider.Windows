﻿using System;
using System.Collections.Generic;

namespace Accelerider.Windows.Infrastructure
{
    public interface IAcceleriderUser : IRefreshable
    {
        string Token { get; }

        string Email { get; }

        string Username { get; }

        Uri AvatarUrl { get; }

        IList<string> Apps { get; set; }
    }
}
