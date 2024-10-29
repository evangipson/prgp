using PRPG.Platform.Constants;
using PRPG.Platform.Enums;
using PRPG.Platform.Parsers;

namespace PRPG.Tests.Parsers
{
	public class FluidScriptParserTests
	{
		private readonly FluidScriptParser _fluidScriptParser = new();

		[Fact]
		public void ParseProgram_ShouldSplitProgramCodeIntoTokens_WhenProvidedValidProgramCode()
		{
			var fluidScriptCode = LanguageConstants.LanguageExamples[Language.FluidScript];
			var programCodeTokens = _fluidScriptParser.ParseProgram(fluidScriptCode);

			Assert.NotNull(programCodeTokens);
			Assert.NotEmpty(programCodeTokens);
		}

		[Fact]
		public void RunProgram_ShouldCreateExpressions_WhenProvidedValidProgramCode()
		{
			var fluidScriptCode = LanguageConstants.LanguageExamples[Language.FluidScript];
			var programContext = _fluidScriptParser.RunProgram(fluidScriptCode);

			Assert.NotNull(programContext);
			Assert.NotEmpty(programContext);
		}
	}
}
