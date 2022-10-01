using Newtonsoft.Json;

namespace MKM
{
	public class MKMmain
	{
		static void Main(string[] args)
		{
			MIKeyframes mikf = new MIKeyframes();
			var settings = new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore };

			mikf.MakeAndAddKeyframe(0, Char.Bodypart.right_arm.ToString());
			mikf.MakeAndAddKeyframe(24, Char.Bodypart.right_arm.ToString(), new Values(ROT_X: 30, BEND_ANGLE_X: 30));

			FileUtils.WriteMIKeyframes(JsonConvert.SerializeObject(mikf, settings));
		}
	}
}