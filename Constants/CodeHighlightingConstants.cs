using System.Collections.Generic;

using Godot;

namespace PRPG.Constants
{
	public static class CodeHighlightingConstants
	{
		private static readonly Color NumberColor = new(0.639f, 0.933f, 0.278f, 1.0f);
		private static readonly Color SymbolColor = new(0.882f, 0.267f, 0.557f, 1.0f);
		private static readonly Color FunctionColor = new(0f, 0.48f, 0f, 1.0f);
		private static readonly Color MemberVariableColor = new(0.426f, 0.426f, 0.82f, 1.0f);

		public static readonly Godot.Collections.Dictionary FluidScriptKeywords = new()
		{
			["func"] = new Color(0.0f, 1.0f, 0.0f, 1.0f),
			["ret"] = new Color(0.0f, 1.0f, 0.0f, 1.0f),
			["var"] = new Color(0.0f, 0.25f, 0.5f, 1.0f)
		};

		public static readonly Godot.Collections.Dictionary TypeRKeywords = new()
		{
			["class"] = new Color(0.1f, 0.25f, 0.85f, 1.0f),
			["create"] = new Color(0.1f, 0.25f, 0.85f, 1.0f),
			["int"] = new Color(0.1f, 0.25f, 0.85f, 1.0f)
		};

		public static readonly Godot.Collections.Dictionary NKeywords = new()
		{
			["<-"] = new Color(0.6f, 0.75f, 0.1f, 1.0f),
		};

		public static readonly Godot.Collections.Dictionary LambdaFlowKeywords = new()
		{
			["def"] = new Color(0.1f, 0.75f, 0.45f, 1.0f),
			["obj"] = new Color(0.1f, 0.75f, 0.45f, 1.0f),
			["Int"] = new Color(0.1f, 0.75f, 0.45f, 1.0f)
		};

		public static readonly Dictionary<LanguageConstants.Language, CodeHighlighter> LanguageCodeHighlighters = new()
		{
			[LanguageConstants.Language.FluidScript] = new CodeHighlighter()
			{
				NumberColor = NumberColor,
				SymbolColor = SymbolColor,
				FunctionColor = FunctionColor,
				MemberVariableColor = MemberVariableColor,
				MemberKeywordColors = FluidScriptKeywords,
				KeywordColors = FluidScriptKeywords
			},
			[LanguageConstants.Language.TypeR] = new CodeHighlighter()
			{
				NumberColor = NumberColor,
				SymbolColor = SymbolColor,
				FunctionColor = FunctionColor,
				MemberVariableColor = MemberVariableColor,
				MemberKeywordColors = TypeRKeywords,
				KeywordColors = TypeRKeywords
			},
			[LanguageConstants.Language.N] = new CodeHighlighter()
			{
				NumberColor = NumberColor,
				SymbolColor = SymbolColor,
				FunctionColor = FunctionColor,
				MemberVariableColor = MemberVariableColor,
				MemberKeywordColors = NKeywords,
				KeywordColors = NKeywords
			},
			[LanguageConstants.Language.LambdaFlow] = new CodeHighlighter()
			{
				NumberColor = NumberColor,
				SymbolColor = SymbolColor,
				FunctionColor = FunctionColor,
				MemberVariableColor = MemberVariableColor,
				MemberKeywordColors = LambdaFlowKeywords,
				KeywordColors = LambdaFlowKeywords
			},
		};
	}
}
