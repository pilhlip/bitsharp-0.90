﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MonoTorrent.Common
{
    public interface ITorrentFileSource
    {
        IEnumerable<FileMapping> Files { get; }
        bool IgnoreHidden { get; }
        string TorrentName { get; }
    }
}
