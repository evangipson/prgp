using Godot;

using PRPG.Enums;

namespace PRPG.Singletons
{
	public partial class PlayerService : Node
	{
		private Language _playerLanguage;

		public void SetPlayerLanguage(int languageIndex)
		{
			try
			{
				_playerLanguage = (Language)languageIndex;
			}
			catch
			{
				_playerLanguage = Language.FluidScript;
			}
		}

		public Language GetPlayerLanguage() => _playerLanguage;
	}
}
