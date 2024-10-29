using System.Collections.Generic;

namespace PRPG.Parsers
{
	public class FluidScriptParser : Parser
	{
		protected override string FileExtension => "fs";

		protected override IEnumerable<string> Keywords => ["thing"];
	}
}
