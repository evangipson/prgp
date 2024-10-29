using Godot;

namespace PRPG.Platform.Singletons
{
	public partial class ColorService : Node
	{
		private static readonly float _minimumColorThreshold = 0.2f;
		
		private static readonly float _maximumColorThreshold = 0.8f;

		public static Color Lerp(Color startColor, Color endColor, float strength) => new()
		{
			R = Mathf.Lerp(startColor.R, endColor.R, strength),
			B = Mathf.Lerp(startColor.B, endColor.B, strength),
			G = Mathf.Lerp(startColor.G, endColor.G, strength),
			A = 1
		};

		public static float GetColorVariant(float newColorValue, float modificationAmount)
		{
			modificationAmount = GD.Randf() > 0.5
				? modificationAmount
				: modificationAmount * -1;

			return Mathf.Clamp(newColorValue + modificationAmount, _minimumColorThreshold, _maximumColorThreshold);
		}
	}
}
