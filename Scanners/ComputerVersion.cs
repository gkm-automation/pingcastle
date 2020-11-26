﻿//
// Copyright (c) Ping Castle. All rights reserved.
// https://www.pingcastle.com
//
// Licensed under the Non-Profit OSL. See LICENSE file in the project root for full license information.
//
using PingCastle.ADWS;
using PingCastle.misc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Security.Principal;
using System.Text;
using System.Threading;

namespace PingCastle.Scanners
{
	public class ComputerVersion : ScannerBase
    {
		public override string Name { get { return "computerversion"; } }

		public override string Description { get { return "Get the version of a computer. Can be used to determine if obsolete operating systems are still present."; } }

		override protected string GetCsvHeader()
		{
			return "Computer\tVersion";
		}

		override protected string GetCsvData(string computer)
		{
		    string version = NativeMethods.GetComputerVersion(computer);
			if (version != "not found")
			{
				return computer + "\t" + version;
			}
			return null;
		}
	}
}
