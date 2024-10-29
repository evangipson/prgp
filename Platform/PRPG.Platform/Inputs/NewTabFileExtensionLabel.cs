using Godot;

using PRPG.Platform.Constants;
using PRPG.Platform.Singletons;

namespace PRPG.Platform.Inputs
{
	public partial class NewTabFileExtensionLabel : Label
	{
		public override void _Ready()
		{
			Text = $".{LanguageConstants.LanguageFileExtensions[PlayerService.GetPlayerLanguage()]}";
		}
	}
}
