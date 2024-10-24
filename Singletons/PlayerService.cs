using Godot;

using PRPG.Enums;

namespace PRPG.Singletons
{
	public static class PlayerService
	{
		private static Language _playerLanguage;

		public static void SetPlayerLanguage(int languageIndex)
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

		public static Language GetPlayerLanguage() => _playerLanguage;
	}
}
