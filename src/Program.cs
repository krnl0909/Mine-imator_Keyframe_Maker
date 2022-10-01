using Newtonsoft.Json;

namespace MKM
{
	public class MKMmain
	{
		static void Main(string[] args)
		{
			MIKeyframes miKeyframes = new MIKeyframes();
			JsonSerializerSettings settings = new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore };

			miKeyframes.AddKeyframe(miKeyframes.MakeKeyframe(0, values: new Values(POS_X: 0, POS_Y: 0, POS_Z: 0)));
			miKeyframes.AddKeyframe(miKeyframes.MakeKeyframe(24, values: new Values(POS_X: 50, POS_Y: 0, POS_Z: 0, ROT_Z: 50)));

			string str = JsonConvert.SerializeObject(miKeyframes, settings);

			Console.WriteLine(str);

			FileUtils.WriteMIKeyframes(str);
		}
	}
}