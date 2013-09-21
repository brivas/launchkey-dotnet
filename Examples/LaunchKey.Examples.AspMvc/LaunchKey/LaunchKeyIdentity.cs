﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace LaunchKey.Examples.AspMvc.LaunchKey
{
	public class LaunchKeyIdentity : IIdentity
	{
		private string userHash;
		private string friendlyName;
		private string authRequest;

		public LaunchKeyIdentity(string userHash, string authRequest, string friendlyName)
		{
			this.userHash = userHash;
			this.friendlyName = friendlyName;
			this.authRequest = authRequest;

		}

		public string AuthenticationType
		{
			get { return "LaunchKey"; }
		}

		public bool IsAuthenticated
		{
			get { return true; }
		}

		public string Name
		{
			get { return this.userHash; }
		}

		public string FriendlyName
		{
			get { return this.friendlyName; }
		}

		public string AuthRequest
		{
			get { return this.authRequest; }
		}
	}
}