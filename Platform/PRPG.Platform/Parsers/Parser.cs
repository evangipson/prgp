using System;
using System.Collections.Generic;
using System.Linq;

using PRPG.Platform.Constants;
using PRPG.Platform.Enums;

namespace PRPG.Platform.Parsers
{
	public abstract partial class Parser
	{
		private static readonly IEnumerable<char> _mathTokens = Enum.GetValues<MathematicalSymbol>().Cast<MathematicalSymbol>().Select(symbol => (char)symbol);

		protected abstract Language Language { get; }

		protected virtual string FileExtension => LanguageConstants.LanguageFileExtensions[Language];

		protected virtual IEnumerable<string> Keywords => LanguageConstants.LanguageKeywords[Language];

		public abstract IEnumerable<IExpression> RunProgram(string programContents);

		public virtual IEnumerable<string> ParseProgram(string programContents)
		{
			var newlineSplitProgram = programContents.Split(["\r\n", "\n", "\r"], StringSplitOptions.RemoveEmptyEntries);
			return newlineSplitProgram.Select(programToken => programToken.Trim('\t').TrimEnd(';').Trim());
		}

		protected virtual List<MathematicExpression> GetMathematicExpressionsFromLine(string programLine, IEnumerable<AssignmentExpression> assignmentExpressions)
		{
			List<MathematicExpression> mathExpressions = [];
			if (programLine.Where(tokenChar => _mathTokens.Contains(tokenChar)).Any())
			{
				var rightSideOfExpression = programLine.Split('=').LastOrDefault();
				var rightSideTokens = rightSideOfExpression.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(expressionToken => expressionToken.Trim()).Chunk(3);
				var assignmentSubstitutedTokens = GetSubstitutedTokensForLine(rightSideTokens, assignmentExpressions);

				var exponentExpressions = rightSideTokens.Where(tokens => tokens.Any(token => token == ((char)MathematicalSymbol.Power).ToString()));
				if (exponentExpressions.Any())
				{
					mathExpressions.Add(new()
					{
						Symbol = MathematicalSymbol.Power,
						Strings = assignmentSubstitutedTokens.Where(token => token != ((char)MathematicalSymbol.Power).ToString())
					});
				}

				var multiplyExpressions = rightSideTokens.Where(tokens => tokens.Any(token => token == ((char)MathematicalSymbol.Multiply).ToString()));
				if (multiplyExpressions.Any())
				{
					mathExpressions.Add(new()
					{
						Symbol = MathematicalSymbol.Multiply,
						Strings = assignmentSubstitutedTokens.Where(token => token != ((char)MathematicalSymbol.Multiply).ToString())
					});
				}

				var divisionExpressions = rightSideTokens.Where(tokens => tokens.Any(token => token == ((char)MathematicalSymbol.Divide).ToString()));
				if (divisionExpressions.Any())
				{
					mathExpressions.Add(new()
					{
						Symbol = MathematicalSymbol.Divide,
						Strings = assignmentSubstitutedTokens.Where(token => token != ((char)MathematicalSymbol.Divide).ToString())
					});
				}

				var addExpressions = rightSideTokens.Where(tokens => tokens.Any(token => token == ((char)MathematicalSymbol.Add).ToString()));
				if (addExpressions.Any())
				{
					mathExpressions.Add(new()
					{
						Symbol = MathematicalSymbol.Add,
						Strings = assignmentSubstitutedTokens.Where(token => token != ((char)MathematicalSymbol.Add).ToString())
					});
				}

				var subtractExpressions = rightSideTokens.Where(tokens => tokens.Any(token => token == ((char)MathematicalSymbol.Subtract).ToString()));
				if (subtractExpressions.Any())
				{
					mathExpressions.Add(new()
					{
						Symbol = MathematicalSymbol.Subtract,
						Strings = assignmentSubstitutedTokens.Where(token => token != ((char)MathematicalSymbol.Subtract).ToString())
					});
				}
			}

			return mathExpressions;
		}

		private static IEnumerable<string> GetSubstitutedTokensForLine(IEnumerable<string[]> tokensInLine, IEnumerable<AssignmentExpression> assignmentExpressions)
		{
			return tokensInLine.SelectMany(tokens => tokens.Select(token => assignmentExpressions.FirstOrDefault(ae => ae.Name == token)?.Value.ToString() ?? token));
		}
	}
}
