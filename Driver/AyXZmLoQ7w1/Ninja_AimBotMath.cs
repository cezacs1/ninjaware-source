using System;
using AyXZmLoQ7w1;

namespace NinjaWare
{
	internal static class gUAgaRMSEPsqJg
	{
		private static double G44nXHJsy(double FUgZWNJt0STC)
		{
			double num = 0.017453292519943295;
			return FUgZWNJt0STC * num;
		}

		public static float met_VectorDistance(gUAgaRMSEPsqJg.fuH1JM0VkmpN zaZQmKAsPUs2yPb3, gUAgaRMSEPsqJg.fuH1JM0VkmpN IzlwhcUZA0SPWS)
		{
			gUAgaRMSEPsqJg.fuH1JM0VkmpN fuH1JM0VkmpN = default(gUAgaRMSEPsqJg.fuH1JM0VkmpN);
			fuH1JM0VkmpN.iWeQooh8m = zaZQmKAsPUs2yPb3.iWeQooh8m - IzlwhcUZA0SPWS.iWeQooh8m;
			fuH1JM0VkmpN.aIJTJisnViEQC1pN = zaZQmKAsPUs2yPb3.aIJTJisnViEQC1pN - IzlwhcUZA0SPWS.aIJTJisnViEQC1pN;
			fuH1JM0VkmpN.F7uN4RgKL = zaZQmKAsPUs2yPb3.F7uN4RgKL - IzlwhcUZA0SPWS.F7uN4RgKL;
			return (float)Math.Sqrt((double)(fuH1JM0VkmpN.F7uN4RgKL * fuH1JM0VkmpN.F7uN4RgKL + fuH1JM0VkmpN.aIJTJisnViEQC1pN * fuH1JM0VkmpN.aIJTJisnViEQC1pN + fuH1JM0VkmpN.iWeQooh8m * fuH1JM0VkmpN.iWeQooh8m));
		}

		public static gUAgaRMSEPsqJg.fuH1JM0VkmpN R2V1HPSdvy9wSF(gUAgaRMSEPsqJg.fuH1JM0VkmpN FxF8CYoITL1TanWQ, gUAgaRMSEPsqJg.fuH1JM0VkmpN tkZbdYxhEdF, bool TVKjXKvdw = false)
		{
			gUAgaRMSEPsqJg.fuH1JM0VkmpN result = default(gUAgaRMSEPsqJg.fuH1JM0VkmpN);
			gUAgaRMSEPsqJg.fuH1JM0VkmpN fuH1JM0VkmpN = default(gUAgaRMSEPsqJg.fuH1JM0VkmpN);
			fuH1JM0VkmpN.iWeQooh8m = FxF8CYoITL1TanWQ.iWeQooh8m - tkZbdYxhEdF.iWeQooh8m;
			fuH1JM0VkmpN.F7uN4RgKL = FxF8CYoITL1TanWQ.F7uN4RgKL - tkZbdYxhEdF.F7uN4RgKL;
			fuH1JM0VkmpN.aIJTJisnViEQC1pN = FxF8CYoITL1TanWQ.aIJTJisnViEQC1pN - tkZbdYxhEdF.aIJTJisnViEQC1pN;
			float num = (float)Math.Sqrt(Math.Pow((double)fuH1JM0VkmpN.F7uN4RgKL, 2.0) + Math.Pow((double)fuH1JM0VkmpN.aIJTJisnViEQC1pN, 2.0));
			result.aIJTJisnViEQC1pN = gUAgaRMSEPsqJg.yQCOiQ8RspBP((float)Math.Atan((double)(fuH1JM0VkmpN.aIJTJisnViEQC1pN / fuH1JM0VkmpN.F7uN4RgKL)));
			result.F7uN4RgKL = gUAgaRMSEPsqJg.yQCOiQ8RspBP((float)Math.Atan((double)(fuH1JM0VkmpN.iWeQooh8m / num)));
			if (fuH1JM0VkmpN.F7uN4RgKL >= 0f)
			{
				result.aIJTJisnViEQC1pN += 180f;
			}
			if (TVKjXKvdw)
			{
				int num2 = PrLxxKXSLyCLTWw.B4qNq2LNdun<int>(Program.DyH6NvqVm + Ninja_Offsets.m_iShotsFired);
				if (num2 > 1)
				{
					gUAgaRMSEPsqJg.pizdkjwrIYc5QOQ5 pizdkjwrIYc5QOQ = default(gUAgaRMSEPsqJg.pizdkjwrIYc5QOQ5);
					pizdkjwrIYc5QOQ.F7uN4RgKL = PrLxxKXSLyCLTWw.B4qNq2LNdun<float>(Program.DyH6NvqVm + Ninja_Offsets.m_aimPunchAngle);
					pizdkjwrIYc5QOQ.aIJTJisnViEQC1pN = PrLxxKXSLyCLTWw.B4qNq2LNdun<float>(Program.DyH6NvqVm + Ninja_Offsets.m_aimPunchAngle + 4);
					float num3 = pizdkjwrIYc5QOQ.F7uN4RgKL * 2f;
					float num4 = pizdkjwrIYc5QOQ.aIJTJisnViEQC1pN * 2f;
					result.F7uN4RgKL -= num3;
					result.aIJTJisnViEQC1pN -= num4;
				}
			}
			return result;
		}

		public static float MceHum3BxWGeTiel(gUAgaRMSEPsqJg.fuH1JM0VkmpN GWDYsr6HhLeVDiTv, gUAgaRMSEPsqJg.fuH1JM0VkmpN tkZbdYxhEdF, float EWJhOZss2jm8)
		{
			float num = (float)(Math.Sin(gUAgaRMSEPsqJg.G44nXHJsy((double)(GWDYsr6HhLeVDiTv.aIJTJisnViEQC1pN - tkZbdYxhEdF.aIJTJisnViEQC1pN))) * (double)EWJhOZss2jm8);
			float num2 = (float)(Math.Sin(gUAgaRMSEPsqJg.G44nXHJsy((double)(GWDYsr6HhLeVDiTv.F7uN4RgKL - tkZbdYxhEdF.F7uN4RgKL))) * (double)EWJhOZss2jm8);
			return (float)Math.Sqrt(Math.Pow((double)num2, 2.0) + Math.Pow((double)num, 2.0));
		}

		public static gUAgaRMSEPsqJg.fuH1JM0VkmpN AMd40AeDJJ(int mPmjE3hdztRBh, int Ml5NNmvf2LRL)
		{
			int num = PrLxxKXSLyCLTWw.B4qNq2LNdun<int>(mPmjE3hdztRBh + Ninja_Offsets.m_dwBoneMatrix);
			return new gUAgaRMSEPsqJg.fuH1JM0VkmpN
			{
				iWeQooh8m = PrLxxKXSLyCLTWw.B4qNq2LNdun<float>(num + 48 * Ml5NNmvf2LRL + 44),
				aIJTJisnViEQC1pN = PrLxxKXSLyCLTWw.B4qNq2LNdun<float>(num + 48 * Ml5NNmvf2LRL + 28),
				F7uN4RgKL = PrLxxKXSLyCLTWw.B4qNq2LNdun<float>(num + 48 * Ml5NNmvf2LRL + 12)
			};
		}

		public static gUAgaRMSEPsqJg.fuH1JM0VkmpN bbGGLdplG(gUAgaRMSEPsqJg.fuH1JM0VkmpN JrmHWKEmrT8eP)
		{
			if (JrmHWKEmrT8eP.F7uN4RgKL > 89f && JrmHWKEmrT8eP.F7uN4RgKL <= 180f)
			{
				JrmHWKEmrT8eP.F7uN4RgKL = 89f;
			}
			while (JrmHWKEmrT8eP.F7uN4RgKL > 180f)
			{
				JrmHWKEmrT8eP.F7uN4RgKL -= 360f;
			}
			while (JrmHWKEmrT8eP.F7uN4RgKL < -89f)
			{
				JrmHWKEmrT8eP.F7uN4RgKL = -89f;
			}
			JrmHWKEmrT8eP.iWeQooh8m = 0f;
			while (JrmHWKEmrT8eP.aIJTJisnViEQC1pN > 180f)
			{
				JrmHWKEmrT8eP.aIJTJisnViEQC1pN -= 360f;
			}
			while (JrmHWKEmrT8eP.aIJTJisnViEQC1pN < -180f)
			{
				JrmHWKEmrT8eP.aIJTJisnViEQC1pN += 360f;
			}
			return JrmHWKEmrT8eP;
		}

		private static float yQCOiQ8RspBP(float DIDtN8qgTvD)
		{
			float num = 57.29578f;
			return DIDtN8qgTvD * num;
		}

		public struct fuH1JM0VkmpN
		{
			public float iWeQooh8m;

			public float aIJTJisnViEQC1pN;

			public float F7uN4RgKL;
		}

		public struct pizdkjwrIYc5QOQ5
		{
			public float F7uN4RgKL;

			public float aIJTJisnViEQC1pN;
		}
	}
}
