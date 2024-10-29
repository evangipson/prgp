using System.Collections.Generic;
using System.Linq;

using PRPG.Platform.Enums;

namespace PRPG.Platform.Parsers
{
	public class FluidScriptParser : Parser
	{
		protected override Language Language => Language.FluidScript;

		public override IEnumerable<IExpression> RunProgram(string programContents)
		{
			var parsedProgram = ParseProgram(programContents);

			List<AssignmentExpression> assignmentExpressions = [];
			foreach (var programLine in parsedProgram)
			{
				var spaceSplitTokens = programLine.Split(' ');

				IEnumerable<MathematicExpression> mathExpressions = assignmentExpressions.Count != 0
					? GetMathematicExpressionsFromLine(programLine, assignmentExpressions)
					: [];

				if (spaceSplitTokens.FirstOrDefault() == "var")
				{
					assignmentExpressions.Add(new()
					{
						Name = programLine.Split(' ').FirstOrDefault(tokenPart => tokenPart != "var"),
						Value = mathExpressions.Any() ? mathExpressions.Select(mathExpression => mathExpression.DoExpression()) : programLine.Split('=').LastOrDefault()?.Trim()
					});
				}
			}

			return [.. assignmentExpressions];
		}
	}
}
