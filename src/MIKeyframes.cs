namespace MKM
{
	internal class Values
	{
		public decimal? POS_X { get; set; }
		public decimal? POS_Y { get; set; }
		public decimal? POS_Z { get; set; }

		public decimal? ROT_X { get; set; }
		public decimal? ROT_Y { get; set; }
		public decimal? ROT_Z { get; set; }

		public decimal? BEND_ANGLE_X { get; set; }
		public decimal? BEND_ANGLE_Y { get; set; }
		public decimal? BEND_ANGLE_Z { get; set; }

		public Values
			(
			decimal? POS_X = null,
			decimal? POS_Y = null,
			decimal? POS_Z = null,
			decimal? ROT_X = null,
			decimal? ROT_Y = null,
			decimal? ROT_Z = null,
			decimal? BEND_ANGLE_X = null,
			decimal? BEND_ANGLE_Y = null,
			decimal? BEND_ANGLE_Z = null
			)
		{
			this.POS_X = POS_X;
			this.POS_Y = POS_Y;
			this.POS_Z = POS_Z;

			this.ROT_X = ROT_X;
			this.ROT_Y = ROT_Y;
			this.ROT_Z = ROT_Z;

			this.BEND_ANGLE_X = BEND_ANGLE_X;
			this.BEND_ANGLE_Y = BEND_ANGLE_Y;
			this.BEND_ANGLE_Z = BEND_ANGLE_Z;
		}
	}
	internal class Keyframe
	{
		public int position { get; set; }
		public string? part_name { get; set; }
		public Values? values { get; set; }
	}
	internal class MIKeyframes
	{
		#region 생성자와 변수
		public int format { get; set; }
		public string created_in { get; set; }
		public bool is_model {get; set;}
		public int tempo { get; set; }
		public int length { get; set; }

		public Keyframe[] keyframes { get; set; }

		public MIKeyframes(int tempo = 24, int length = 24)
		{
			format = 33;
			created_in = "2.0 Pre-release 2";
			is_model = true;

			this.tempo = 24;
			this.length = 24;

			keyframes = new Keyframe[0];
		}
		#endregion

		#region 메서드
		/// <summary>정보를 받아 Keyframe 객체를 만든다.</summary>
		/// <param name="pos">타임라인 상의 위치</param>
		/// <param name="part_name">부위 이름(비었을 시 본인)</param>
		/// <param name="values">Values 객체</param>
		/// <returns>Keyframe 객체</returns>
		public Keyframe MakeKeyframe(int pos, string? part_name = null, Values? values = null)
		{
			Keyframe kf = new Keyframe();

			kf.position = pos;
			kf.part_name = part_name ?? null;
			kf.values = values ?? null;

			return kf;
		}

		/// <summary>
		/// 키프레임을 배열에 추가한다.
		/// </summary>
		/// <param name="kf">Keyframe 객체</param>
		public void AddKeyframe(Keyframe kf)
		{
			keyframes = keyframes.Append(kf).ToArray();
		}
		#endregion
	}
}
