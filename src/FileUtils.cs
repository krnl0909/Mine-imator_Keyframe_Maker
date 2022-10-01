namespace MKM
{
	static internal class FileUtils
	{
		/// <summary>위치와 json 배열을 받아 .miframes 파일로 출력한다.</summary>
		/// <param name="jMI">Serialized한 키프레임들</param>
		/// <returns>작업 성공 여부</returns>
		static public void WriteMIKeyframes(string jMI)
		{
			WriteMIKeyframes(jMI, Directory.GetCurrentDirectory());
		}

		/// <summary>위치와 json 배열을 받아 .miframes 파일로 출력한다.</summary>
		/// <param name="jMI">Serialized한 키프레임들</param>
		/// <param name="path">저장 위치</param>
		/// <returns>작업 성공 여부</returns>
		static public void WriteMIKeyframes(string jMI, string path, string filename="output")
		{
			File.WriteAllText($"{path}\\{filename}.miframes", jMI);
		}
	}
}
