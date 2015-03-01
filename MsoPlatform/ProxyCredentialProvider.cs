using MonoDevelop.Core;
using MonoDevelop.Core.Web;
using System.Net;
using System;

namespace MsoPlatform
{
	public class ProxyCredentialProvider : ICredentialProvider
	{
		public ICredentials GetCredentials (Uri uri, IWebProxy proxy, CredentialType credentialType, bool retrying)
		{
			throw new NotImplementedException ();
		}
	}
}

