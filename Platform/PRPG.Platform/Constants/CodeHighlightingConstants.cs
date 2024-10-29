using System.Collections.Generic;
using Godot;

using PRPG.Platform.Enums;

namespace PRPG.Platform.Constants
{
	public static class CodeHighlightingConstants
	{
		private static readonly Color NumberColor = new(0.639f, 0.933f, 0.278f, 1.0f);
		private static readonly Color SymbolColor = new(0.882f, 0.267f, 0.557f, 1.0f);
		private static readonly Color FunctionColor = new(0f, 0.48f, 0f, 1.0f);
		private static readonly Color MemberVariableColor = new(0.426f, 0.426f, 0.82f, 1.0f);

		private static readonly Color BrightGreen = new(0.0f, 1.0f, 0.0f, 1.0f);
		private static readonly Color Teal = new(0.0f, 1.0f, 0.0f, 1.0f);

		public static readonly Godot.Collections.Dictionary FluidScriptKeywordColors = new()
		{
			["func"] = BrightGreen,
			["ret"] = BrightGreen,
			["var"] = Teal
		};

		public static readonly Godot.Collections.Dictionary TypeRKeywordColors = new()
		{
			["class"] = new Color(0.1f, 0.25f, 0.85f, 1.0f),
			["create"] = new Color(0.1f, 0.25f, 0.85f, 1.0f),
			["int"] = new Color(0.1f, 0.25f, 0.85f, 1.0f)
		};

		public static readonly Godot.Collections.Dictionary NKeywordColors = new()
		{
			["<-"] = new Color(0.6f, 0.75f, 0.1f, 1.0f),
		};

		public static readonly Godot.Collections.Dictionary LambdaFlowKeywordColors = new()
		{
			["def"] = new Color(0.1f, 0.75f, 0.45f, 1.0f),
			["obj"] = new Color(0.1f, 0.75f, 0.45f, 1.0f),
			["Int"] = new Color(0.1f, 0.75f, 0.45f, 1.0f)
		};

		public static readonly Dictionary<Language, CodeHighlighter> LanguageCodeHighlighters = new()
		{
			[Language.FluidScript] = new CodeHighlighter()
			{
				NumberColor = NumberColor,
				SymbolColor = SymbolColor,
				FunctionColor = FunctionColor,
				MemberVariableColor = MemberVariableColor,
				MemberKeywordColors = FluidScriptKeywordColors,
				KeywordColors = FluidScriptKeywordColors
			},
			[Language.TypeR] = new CodeHighlighter()
			{
				NumberColor = NumberColor,
				SymbolColor = SymbolColor,
				FunctionColor = FunctionColor,
				MemberVariableColor = MemberVariableColor,
				MemberKeywordColors = TypeRKeywordColors,
				KeywordColors = TypeRKeywordColors
			},
			[Language.N] = new CodeHighlighter()
			{
				NumberColor = NumberColor,
				SymbolColor = SymbolColor,
				FunctionColor = FunctionColor,
				MemberVariableColor = MemberVariableColor,
				MemberKeywordColors = NKeywordColors,
				KeywordColors = NKeywordColors
			},
			[Language.LambdaFlow] = new CodeHighlighter()
			{
				NumberColor = NumberColor,
				SymbolColor = SymbolColor,
				FunctionColor = FunctionColor,
				MemberVariableColor = MemberVariableColor,
				MemberKeywordColors = LambdaFlowKeywordColors,
				KeywordColors = LambdaFlowKeywordColors
			},
		};
	}
}
