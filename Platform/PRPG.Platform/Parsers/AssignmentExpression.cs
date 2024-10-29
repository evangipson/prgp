namespace PRPG.Platform.Parsers
{
	public sealed class AssignmentExpression : IExpression
	{
		public string Name { get; set; }

		public object Value { get; set; }

		public object DoExpression() => this;
	}
}
