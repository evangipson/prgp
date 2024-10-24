using Godot;

using PRPG.Constants;
using PRPG.Singletons;

public partial class NewTabFileExtensionLabel : Label
{
	public override void _Ready()
	{
		Text = $".{LanguageConstants.LanguageFileExtensions[PlayerService.GetPlayerLanguage()]}";
	}
}
