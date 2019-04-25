using UnityEditor;

namespace JfranMora.EditorExtensions
{
	public static class CompileBeforePlay
	{
		[InitializeOnLoadMethod]
		public static void Initialize()
		{
			if (EditorApplication.isPlaying) return;

			EditorApplication.update += Update;
		}

		private static void Update()
		{
			if (EditorApplication.isPlayingOrWillChangePlaymode && !EditorApplication.isPlaying)
			{
				AssetDatabase.Refresh();
			}
		}
	}
}