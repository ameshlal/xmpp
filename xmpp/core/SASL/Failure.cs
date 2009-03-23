// Failure.cs
//
//XMPP .NET Library Copyright (C) 2008 Dieter Lunn
//
//This library is free software; you can redistribute it and/or modify it under
//the terms of the GNU Lesser General Public License as published by the Free
//Software Foundation; either version 3 of the License, or (at your option)
//any later version.
//
//This library is distributed in the hope that it will be useful, but WITHOUT
//ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS
//FOR A PARTICULAR PURPOSE. See the GNU Lesser General Public License for more
//
//You should have received a copy of the GNU Lesser General Public License along
//with this library; if not, write to the Free Software Foundation, Inc., 59
//Temple Place, Suite 330, Boston, MA 02111-1307 USA

using System.Xml;
using ubiety.attributes;
using ubiety.common;

namespace ubiety.core.SASL
{
	[XmppTag("failure", Namespaces.SASL, typeof(Failure))]
	public class Failure : ubiety.common.Tag
	{
		public Failure(string prefix, XmlQualifiedName qname, XmlDocument doc) : base(prefix, qname, doc)
		{
		}
	}
	
	[XmppTag("not-authorized", Namespaces.SASL, typeof(NotAuthorized))]
	public class NotAuthorized : ubiety.common.Tag
	{
		public NotAuthorized(string prefix, XmlQualifiedName qname, XmlDocument doc) : base(prefix, qname, doc)
		{
		}
	}
	
	[XmppTag("bad-protocol", Namespaces.SASL, typeof(BadProtocol))]
	public class BadProtocol : Tag
	{
		public BadProtocol(string prefix, XmlQualifiedName qname, XmlDocument doc) : base(prefix, qname, doc)
		{}
	}
}