using System;
using System.Collections.Generic;

namespace PRPG.Parsers
{
	public abstract class Parser
	{
		protected abstract string FileExtension { get; }

		protected abstract IEnumerable<string> Keywords { get; }

		protected virtual Action LoadProgram(string programContents)
		{
			return () => { };
		}

		protected virtual IEnumerable<string> ParseProgram(string programContents)
		{
			return [];
		}
	}
}
