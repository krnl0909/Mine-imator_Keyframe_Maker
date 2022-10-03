using Newtonsoft.Json;
using static MKM.Char.Bodypart;

namespace MKM
{
	public class MKMmain
	{
		static void Main(string[] args)
		{
			var mikf = new MIKeyframes();
			var settings = new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore };

			mikf.Add(0, right_arm);
			mikf.Add(24, right_arm, new Values(ROT_X: 30, BEND_ANGLE_X: 30));

			FileUtils.WriteMIKeyframes(JsonConvert.SerializeObject(mikf, settings));
		}
	}
}