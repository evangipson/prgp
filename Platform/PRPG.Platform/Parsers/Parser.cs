using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

using PRPG.Platform.Constants;
using PRPG.Platform.Enums;

namespace PRPG.Platform.Parsers
{
	public abstract partial class Parser
	{
		protected abstract Language Language { get; }

		protected virtual string FileExtension => LanguageConstants.LanguageFileExtensions[Language];

		protected virtual IEnumerable<string> Keywords => LanguageConstants.LanguageKeywords[Language];

		public virtual Action LoadProgram(string programContents)
		{
			return () => { };
		}

		public virtual IEnumerable<string> ParseProgram(string programContents)
		{
			var findStringsRegex = FindStringsRegex();
			var splitProgram = findStringsRegex.Split(programContents);
			var trimmedSplitProgram = splitProgram.Select(programToken => programToken.Trim());
			return [];
		}

		[GeneratedRegex("\"[.\n]*\"")]
		private static partial Regex FindStringsRegex();
	}
}
