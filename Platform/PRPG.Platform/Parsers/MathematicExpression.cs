using System;
using System.Collections.Generic;
using System.Linq;

namespace PRPG.Platform.Parsers
{
	public sealed class MathematicExpression : IExpression
	{
		public string Name { get; set; }

		public MathematicalSymbol Symbol { get; set; }

		public IEnumerable<string> Strings { get; set; }

		public IEnumerable<double> Numbers => Strings.Select(value => double.TryParse(value, out double doubleValue) ? doubleValue : double.MinValue);

		private bool IsNumberExpression => Strings.Count() == Numbers.Where(number => number != double.MinValue).Count();

		public object DoExpression() => Symbol switch
		{
			MathematicalSymbol.Add => IsNumberExpression
				? Numbers.Aggregate((oldValue, newValue) => oldValue += newValue)
				: Strings.Aggregate((oldValue, newValue) => oldValue += newValue),
			MathematicalSymbol.Subtract => IsNumberExpression
				? Numbers.Aggregate((oldValue, newValue) => oldValue -= newValue)
				: Strings,
			MathematicalSymbol.Multiply => IsNumberExpression
				? Numbers.Aggregate((oldValue, newValue) => oldValue *= newValue)
				: Strings,
			MathematicalSymbol.Divide => IsNumberExpression
				? Numbers.Aggregate((oldValue, newValue) => oldValue /= newValue)
				: Strings,
			MathematicalSymbol.Modulus => IsNumberExpression
				? Numbers.Aggregate((oldValue, newValue) => oldValue %= newValue)
				: Strings,
			MathematicalSymbol.Power => IsNumberExpression
				? Numbers.Aggregate(Math.Pow)
				: Strings,
			_ => null
		};
	}
}
