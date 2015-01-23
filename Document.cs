using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP5.Provided
{
	public sealed class Document
	{
		public Document(string id, string contents)
		{
			Id = id;
			Contents = contents;
		}

		public string Id { get; private set; }

		public string Contents { get; private set; }

		public override int GetHashCode()
		{
			return Id.GetHashCode() ^ Contents.GetHashCode();
		}

		public override bool Equals(object obj)
		{
			return obj is Document && Id == ((Document)obj).Id && Contents == ((Document)obj).Contents;
		}
	}
}
