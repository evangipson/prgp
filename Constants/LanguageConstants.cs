using System;
using System.Collections.Generic;

namespace PRPG.Constants
{
	public static class LanguageConstants
	{
		public enum Language
		{
			FluidScript = 1,
			TypeR,
			N,
			LambdaFlow
		};

		public static readonly Dictionary<Language, string> LanguagesWithDescriptions = new()
		{
			[Language.FluidScript] = $"{Enum.GetName(Language.FluidScript)} is a popular interpreted scripting language that is typically easy for beginners to pick up.",
			[Language.TypeR] = $"{Enum.GetName(Language.TypeR)} is a popular object-oriented language suited for beginners and mid-level programmers alike; powerful things like inheritance are possible in {Enum.GetName(Language.TypeR)}.",
			[Language.N] = $"{Enum.GetName(Language.N)} is a scientific language, suited for numerical and statistical programming. Performing large, complex calculations is much easier in {Enum.GetName(Language.N)}.",
			[Language.LambdaFlow] = $"{Enum.GetName(Language.LambdaFlow)} is a more obscure functional-style language that is hard to master, but powerful. You'll be writing many functions that are composable and succinct."
		};

		public static readonly Dictionary<Language, string> LanguageExamples = new()
		{
			[Language.FluidScript] = @"var x = 13;
var y = 15;
var z = x + y;

func add(x, y) {
	ret x + y;
};

var result = add(13, 15);",
			[Language.TypeR] = @"int X = 13;
int Y = 15;
int Z = X + Y;

class Adder
{
	Add(int a, int b)
	{
		a + b;
	};
};

Adder MyAdder = create Adder;
int Result = MyAdder.Add(13, 15);",
			[Language.N] = @"""X"" <- 15
""Y"" <- 13
""Z"" <- X + Y

""Result"" <- a + b <- (a, b)",
			[Language.LambdaFlow] = @"def Main(Int, Int) : Int{
	args[0]+args[1]
}
def Result: Int{
	Main(13, 15)
}
Result"
		};
	}
}
