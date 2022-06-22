using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using System.Timers;
using Microsoft.Win32;
using NinjaWareSecurity;
using NinjaWare;
// using AyXZmLoQ7w1;

namespace AyXZmLoQ7w1
{
	internal class Program
	{
		// ayarların başlangıcı 
		public static string Time;

		public static string Active;

		public static string StringHwid;

		public static string CurrentHwid = User.HWID();

		public static System.Timers.Timer UserMainTimer = new System.Timers.Timer(1000.0);

		public static System.Timers.Timer ExpirationTimer = new System.Timers.Timer(1000.0);

		public static int DyH6NvqVm = 0;

		public static int BRyMHDOu1W = 0;

		public static int x3IFbCrUGMIcDsk = 0;

		public static int igpSC3gOc6 = 0;

		public static int Yt76IFZziSy = 0;

		public static bool gkyUGIQMiI = false;

		private static bool X2jtodjgE5wgZcn = false;

		private static bool D0XdAbL7s = false;

		private static int[] sKwQycmrBH = new int[]
		{
			32,
			1,
			61,
			36,
			64,
			30,
			3,
			4,
			63,
			2
		};

		// Token: 0x04000034 RID: 52
		private static int[] EgW2jJznCXmnZE = new int[]
		{
			38,
			11,
			40,
			9
		};


		private static int JycJYFz87J5MT = 1;

		private static int hUW5NuwHco = 8;

		private static bool eFXiLvzf53kY6N1 = true;

		private static bool MnWqvN2O8CJyHy = true;

		private static bool ry4hdx05D9B2oSHL = true;

		private static float SFJDT62sTE7wSlz = 20f;

		private static float uZzJMI9zosKV = 10f;

		private static float zejZj64DtbwOf = 20f;

		private static float hHhXC0kb9A0ATO = 10f;

		private static int DcXwUJNLYNbnN = 1;

		private static int tVi0NgZBh6Mm2G = 8;

		private static bool a4UsXw0x7Yg = true;

		private static bool he7e68v2hmw = true;

		private static bool ASsoThmleKi8wj = true;

		private static bool Q4pTWfMIIbmKE = true;

		private static bool dsayYnaIz2O5eBem = true;

		private static bool FuWOXbApdDX0 = true;

		private static float A6Qeu0hU9qfl = 2.5f; // legit için 1f - 5f arası yapın 180f maximum aimbot fovu

		private static float ssdUE3pz6QbERkHo = 9f; //legit için 6f - 10f arası yapın 0.7f en hızlı kayma ayarı

		private static int HKU8tjKmUqRSHhT = 1;

		private static int XJHukK142r1O = 8;

		private static float EldOZhJFN = 10f;

		private static float eo7KAzy2ZllJz = 5f;

		private static bool aysUv5ufgHHD3Vv = true;

		private static bool WFEPkusSh = true;

		private static bool YqTftNC3N = true;

		private static bool T205W5rlBXGGE = true;

		private static bool cKUo2ANn4dnkyFT = true;

		private static bool fKn3GJjklex = true;

		private static int sreZP3iAasJG = 164;

		private static int Fz4GQdO6d = 0;

		private static int fsJ0noziJH = 0;

		private static int GrHgMRVCzit4 = 8;

		private static float LnK68OAp08 = 10f;

		private static float f9NrSzx2I = 5f;

		private static int Dnck3ljDP = 164;

		private static int Aw1wUBkLUmnIW = 0;

		private static int TnbRnBpkXbK3 = 0;

		private static int N3f9Vc2ghudp = 8;

		private static float Y3DwXy9Hk = 10f;

		private static float ZKhCeLAKJWi = 5f;

		private static bool RYA2q8jg6lxuacZZ = true;

		private static bool VrvjbuwVlC4Tw = true;

		private static bool PbjyTJdfBmu = true;

		private static int OmxOvPjmEz7r8 = 164;

		private static int tvmGWLq5SBs = 0;

		private static int ZfHfiyKDs = 0;

		private static int HHi0bydlnPmHI = 8;
		// ayarların sonu





		[DllImport("user32.dll")]
		public static extern short GetAsyncKeyState(int var_Key);




        // #kullanıcı kontrol 1 (bu kısım artık gereksiz ninjaware'a üye değilseniz kapatıyodu programı :D)
		public static void UserMain(object sender, ElapsedEventArgs e)
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("NinjaWare");
			try
			{
				WebRequest.DefaultWebProxy = new WebProxy();
				ServicePointManager.SecurityProtocol = (SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12);
				WebRequest webRequest = WebRequest.Create("https://www.ninjaware.net/api/external_api/active.php?username=" + registryKey.GetValue("Username").ToString());
				webRequest.Credentials = CredentialCache.DefaultCredentials;
				WebResponse response = webRequest.GetResponse();
				using (Stream responseStream = response.GetResponseStream())
				{
					StreamReader streamReader = new StreamReader(responseStream);
					Program.Active = streamReader.ReadToEnd();
				}
				response.Close();
				if (Program.Active == "1")
				{
					WebRequest.DefaultWebProxy = new WebProxy();
					ServicePointManager.SecurityProtocol = (SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12);
					WebRequest webRequest2 = WebRequest.Create("https://www.ninjaware.net/api/external_api/hwid.php?username=" + registryKey.GetValue("Username").ToString() + "&hwid=" + Program.CurrentHwid);
					webRequest2.Credentials = CredentialCache.DefaultCredentials;
					WebResponse response2 = webRequest2.GetResponse();
					using (Stream responseStream2 = response2.GetResponseStream())
					{
						StreamReader streamReader2 = new StreamReader(responseStream2);
						Program.StringHwid = streamReader2.ReadToEnd();
					}
					response2.Close();
					if (Program.StringHwid == "1" || Program.StringHwid == "3")
					{
						Process process = null;
						string str9 = "wFgAiWME1rS5Q70Q";
						str9 += "FQJip3";
						while (process == null)
						{
							process = PrLxxKXSLyCLTWw.nWC4p6IEuJH();
							Thread.Sleep(500);
						}
						Program.ExpirationTimer.Elapsed += Program.Expiration;
						Program.ExpirationTimer.Start();

					}
					else
					{
						Program.UserMainTimer.Stop();
						Thread.Sleep(5000);
						Environment.Exit(0);
					}
				}
				else
				{
					Program.UserMainTimer.Stop();
					Thread.Sleep(5000);
					Environment.Exit(0);
				}
			}
			catch (Exception)
			{
				Program.UserMainTimer.Stop();
				Thread.Sleep(5000);
				try
				{
					Thread.Sleep(5000);
					using (WebClient webClient = new WebClient())
					{
						using (webClient.OpenRead("http://www.google.com"))
						{
							Thread.Sleep(5000);
							Program.UserMainTimer.Start();
						}
					}
				}
				catch
				{
					Thread.Sleep(5000);
					Environment.Exit(0);
				}
			}
		}
		// #kullanıcı kontrol 2 (artık işlevsiz devre dışı bıraktım üstteki gibi)
		public static void Expiration(object sender, ElapsedEventArgs e)
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("NinjaWare");
			try
			{
				WebRequest.DefaultWebProxy = new WebProxy();
				ServicePointManager.SecurityProtocol = (SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12);
				WebRequest webRequest = WebRequest.Create("https://www.ninjaware.net/api/external_api/expired.php?username=" + registryKey.GetValue("Username").ToString());
				webRequest.Credentials = CredentialCache.DefaultCredentials;
				WebResponse response = webRequest.GetResponse();
				using (Stream responseStream = response.GetResponseStream())
				{
					StreamReader streamReader = new StreamReader(responseStream);
					Program.Time = streamReader.ReadToEnd();
				}
				response.Close();
				if (Program.Time == "0")
				{
					Program.ExpirationTimer.Stop();
					Thread.Sleep(5000);
					Environment.Exit(0);
				}
			}
			catch (Exception)
			{
				Program.ExpirationTimer.Stop();
				Thread.Sleep(5000);
				try
				{
					Thread.Sleep(5000);
					using (WebClient webClient = new WebClient())
					{
						using (webClient.OpenRead("http://www.google.com"))
						{
							Thread.Sleep(5000);
							Program.ExpirationTimer.Start();
						}
					}
				}
				catch
				{
					Thread.Sleep(5000);
					Environment.Exit(0);
				}
			}
		}



		// Program başlangıcı
		private static void Main(string[] args)
		{

			Process process = null;
			while (process == null)
			{
				process = PrLxxKXSLyCLTWw.nWC4p6IEuJH();
				// burası csgo'yu içeri aktarmaya yarar devamında iste alttaki özellikler tek tek aktif edilir.
				Thread.Sleep(500); //0.5 saniye gecikme sabit (değiştirmeyin)
			}

			Console.ForegroundColor = ConsoleColor.DarkGreen;
			Console.WriteLine("actived fake driver lol");

			Program.ExpirationTimer.Start();
			new Thread(delegate()
			{
				for (;;)
				{
					Program.DyH6NvqVm = PrLxxKXSLyCLTWw.B4qNq2LNdun<int>(PrLxxKXSLyCLTWw.QTdQul4r30C + Ninja_Offsets.dwLocalPlayer);
					Program.BRyMHDOu1W = PrLxxKXSLyCLTWw.B4qNq2LNdun<int>(Program.DyH6NvqVm + Ninja_Offsets.m_iTeamNum);
					Program.x3IFbCrUGMIcDsk = PrLxxKXSLyCLTWw.B4qNq2LNdun<int>(Program.DyH6NvqVm + Ninja_Offsets.m_iHealth);
					Program.gkyUGIQMiI = ((Program.BRyMHDOu1W == 2 || Program.BRyMHDOu1W == 3) && Program.x3IFbCrUGMIcDsk > 1 && Program.x3IFbCrUGMIcDsk <= 1337);
					int num = PrLxxKXSLyCLTWw.B4qNq2LNdun<int>(Program.DyH6NvqVm + Ninja_Offsets.m_hActiveWeapon);
					Program.igpSC3gOc6 = PrLxxKXSLyCLTWw.B4qNq2LNdun<int>(PrLxxKXSLyCLTWw.QTdQul4r30C + Ninja_Offsets.dwEntityList + ((num & 4095) - 1) * 16);
					Program.Yt76IFZziSy = PrLxxKXSLyCLTWw.B4qNq2LNdun<int>(Program.igpSC3gOc6 + Ninja_Offsets.m_iItemDefinitionIndex);
					Program.X2jtodjgE5wgZcn = Program.sKwQycmrBH.Contains(Program.Yt76IFZziSy);
					Program.D0XdAbL7s = Program.EgW2jJznCXmnZE.Contains(Program.Yt76IFZziSy);
					Thread.Sleep(100);
				}
			}).Start();

			// tüm özellikler aşağıda (çoğunu belirtmeye üşendim :D)


			// fov changer
			new Thread(delegate()
			{
				for (;;)
				{
					int num = PrLxxKXSLyCLTWw.B4qNq2LNdun<int>(Program.DyH6NvqVm + Ninja_Offsets.m_bIsScoped);
					int num2 = PrLxxKXSLyCLTWw.B4qNq2LNdun<int>(Program.igpSC3gOc6 + Ninja_Offsets.m_zoomLevel);
					int num3 = 115;
					PrLxxKXSLyCLTWw.zqKwGGtLEAI1AX<int>(Program.DyH6NvqVm + Ninja_Offsets.m_iFOV, num3);
				}
			}).Start();

			// aimbot smoot & helper
			new Thread(delegate()
			{
				float num = 0f;
				float num2 = 0f;
				for (;;)
				{
					if (Program.GetAsyncKeyState(1) != 0 && PrLxxKXSLyCLTWw.B4qNq2LNdun<int>(Program.DyH6NvqVm + Ninja_Offsets.m_iShotsFired) > 1)
					{
						int num3 = PrLxxKXSLyCLTWw.B4qNq2LNdun<int>(PrLxxKXSLyCLTWw.K2nNi7Tf0MbHp + Ninja_Offsets.dwClientState);
						float num4 = PrLxxKXSLyCLTWw.B4qNq2LNdun<float>(Program.DyH6NvqVm + Ninja_Offsets.m_aimPunchAngle + 4);
						float num5 = PrLxxKXSLyCLTWw.B4qNq2LNdun<float>(num3 + Ninja_Offsets.dwClientState_ViewAngles);
						float num6 = PrLxxKXSLyCLTWw.B4qNq2LNdun<float>(Program.DyH6NvqVm + Ninja_Offsets.m_aimPunchAngle);
						float num7 = PrLxxKXSLyCLTWw.B4qNq2LNdun<float>(num3 + Ninja_Offsets.dwClientState_ViewAngles + 4) - (num4 - num2) * 2f;
						float num8 = num5 - (num6 - num) * 2f;
						if (num7 > 180f)
						{
							num7 = 180f;
						}
						else if (num7 < -180f)
						{
							num7 = -180f;
						}
						if (num8 > 89f)
						{
							num8 = 89f;
						}
						else if (num8 < -89f)
						{
							num8 = -89f;
						}
						PrLxxKXSLyCLTWw.zqKwGGtLEAI1AX<float>(num3 + Ninja_Offsets.dwClientState_ViewAngles, num8);
						PrLxxKXSLyCLTWw.zqKwGGtLEAI1AX<float>(num3 + Ninja_Offsets.dwClientState_ViewAngles + 4, num7);
						num = num6;
						num2 = num4;
					}
					else
					{
						num = 0f;
						num2 = 0f;
					}
					Thread.Sleep(1);
				}
			}).Start();



			new Thread(delegate()
			{
				for (;;)
				{
					if (!Program.X2jtodjgE5wgZcn || Program.HKU8tjKmUqRSHhT == -1 || Program.GetAsyncKeyState(Program.HKU8tjKmUqRSHhT) != 0)
					{
						if ((!Program.D0XdAbL7s || Program.JycJYFz87J5MT == -1 || Program.GetAsyncKeyState(Program.JycJYFz87J5MT) != 0) && (Program.X2jtodjgE5wgZcn || Program.D0XdAbL7s || Program.DcXwUJNLYNbnN == -1 || Program.GetAsyncKeyState(Program.DcXwUJNLYNbnN) != 0))
						{
							bool flag;
							if (Program.X2jtodjgE5wgZcn)
							{
								flag = Program.PHWMR3QY6xUkCe(Program.XJHukK142r1O, Program.zejZj64DtbwOf, Program.hHhXC0kb9A0ATO, Program.eFXiLvzf53kY6N1, Program.MnWqvN2O8CJyHy, Program.ry4hdx05D9B2oSHL);
							}
							else if (Program.D0XdAbL7s)
							{
								flag = Program.PHWMR3QY6xUkCe(Program.hUW5NuwHco, Program.SFJDT62sTE7wSlz, Program.uZzJMI9zosKV, Program.Q4pTWfMIIbmKE, Program.dsayYnaIz2O5eBem, Program.FuWOXbApdDX0);
							}
							else
							{
								flag = Program.PHWMR3QY6xUkCe(Program.tVi0NgZBh6Mm2G, Program.A6Qeu0hU9qfl, Program.ssdUE3pz6QbERkHo, Program.a4UsXw0x7Yg, Program.he7e68v2hmw, Program.ASsoThmleKi8wj);
							}
							if (flag)
							{
								continue;
							}
						}
						Thread.Sleep(0);
					}
				}
			}).Start();


			// kör olmama (amk salakları yanlış kodlamış burayı düzelttim)
			new Thread(delegate()
			{
				float num = 0 * 2.55f;
				for (;;)
				{
					if (PrLxxKXSLyCLTWw.B4qNq2LNdun<float>(Program.DyH6NvqVm + Ninja_Offsets.m_flFlashMaxAlpha) != num)
					{
						PrLxxKXSLyCLTWw.zqKwGGtLEAI1AX<float>(Program.DyH6NvqVm + Ninja_Offsets.m_flFlashMaxAlpha, num);
					}
					Thread.Sleep(100);
				}
			}).Start();


			// wallhack
			new Thread(delegate()
			{
				for (;;)
				{
					int num = PrLxxKXSLyCLTWw.B4qNq2LNdun<int>(PrLxxKXSLyCLTWw.QTdQul4r30C + Ninja_Offsets.dwGlowObjectManager);
					for (int i = 0; i < 64; i++)
					{
						int num2 = PrLxxKXSLyCLTWw.B4qNq2LNdun<int>(PrLxxKXSLyCLTWw.QTdQul4r30C + Ninja_Offsets.dwEntityList + i * 16);
						if (num2 != 0 && !PrLxxKXSLyCLTWw.B4qNq2LNdun<bool>(num2 + Ninja_Offsets.m_bDormant))
						{
							int num3 = PrLxxKXSLyCLTWw.B4qNq2LNdun<int>(num2 + Ninja_Offsets.m_iTeamNum);
							int num4 = PrLxxKXSLyCLTWw.B4qNq2LNdun<int>(num2 + Ninja_Offsets.m_iGlowIndex) * 56 + num;

							// takıma
							if (num3 == Program.BRyMHDOu1W)
							{
								byte[] array = new byte[]
								{
									byte.MaxValue,
									byte.MaxValue,
									byte.MaxValue,
									148
								};
								int[] array2 = Program.F9Yzm7h0ns(PrLxxKXSLyCLTWw.B4qNq2LNdun<int>(num2 + Ninja_Offsets.m_iHealth));
								array2[3] = 148;
								PrLxxKXSLyCLTWw.zqKwGGtLEAI1AX<float>(num4 + 16, (float)array2[2] / 255f);
								PrLxxKXSLyCLTWw.zqKwGGtLEAI1AX<float>(num4 + 8, (float)array2[0] / 255f);
								PrLxxKXSLyCLTWw.zqKwGGtLEAI1AX<float>(num4 + 12, (float)array2[1] / 255f);
								PrLxxKXSLyCLTWw.zqKwGGtLEAI1AX<bool>(num4 + 40, true);
								PrLxxKXSLyCLTWw.zqKwGGtLEAI1AX<float>(num4 + 20, (float)array2[3] / 255f);
								PrLxxKXSLyCLTWw.zqKwGGtLEAI1AX<int>(num2 + 131 - 17, array[2]);
								PrLxxKXSLyCLTWw.zqKwGGtLEAI1AX<int>(num2 + 154 - 41, array[1]);
								PrLxxKXSLyCLTWw.zqKwGGtLEAI1AX<int>(num2 + 150 - 35, 255);
								PrLxxKXSLyCLTWw.zqKwGGtLEAI1AX<int>(num2 + 35 + 77, array[0]);
								PrLxxKXSLyCLTWw.zqKwGGtLEAI1AX<bool>(num4 + 44, true);
								PrLxxKXSLyCLTWw.zqKwGGtLEAI1AX<float>(num4 + 16, (float)array2[2] / 255f);
								PrLxxKXSLyCLTWw.zqKwGGtLEAI1AX<bool>(num4 + 48, true);
								PrLxxKXSLyCLTWw.zqKwGGtLEAI1AX<bool>(num4 + 40, true);
								PrLxxKXSLyCLTWw.zqKwGGtLEAI1AX<float>(num4 + 20, (float)array2[3] / 255f);
								PrLxxKXSLyCLTWw.zqKwGGtLEAI1AX<float>(num4 + 12, (float)array2[1] / 255f);
								PrLxxKXSLyCLTWw.zqKwGGtLEAI1AX<float>(num4 + 8, (float)array2[0] / 255f);
							}

							// düşmanlara
							if (num3 != Program.BRyMHDOu1W)
							{
								byte[] array3 = new byte[]
								{
									byte.MaxValue,
									byte.MaxValue,
									byte.MaxValue,
									150
								};
								int[] array4 = Program.F9Yzm7h0ns(PrLxxKXSLyCLTWw.B4qNq2LNdun<int>(num2 + Ninja_Offsets.m_iHealth));
								array4[3] = 150;
								PrLxxKXSLyCLTWw.zqKwGGtLEAI1AX<float>(num4 + 12, (float)array4[1] / 255f);
								PrLxxKXSLyCLTWw.zqKwGGtLEAI1AX<bool>(num4 + 40, true);
								PrLxxKXSLyCLTWw.zqKwGGtLEAI1AX<float>(num4 + 20, (float)array4[3] / 255f);
								PrLxxKXSLyCLTWw.zqKwGGtLEAI1AX<float>(num4 + 16, (float)array4[2] / 255f);
								PrLxxKXSLyCLTWw.zqKwGGtLEAI1AX<float>(num4 + 8, (float)array4[0] / 255f);
								PrLxxKXSLyCLTWw.zqKwGGtLEAI1AX<int>(num2 + 8 + 105, array3[1]);
								PrLxxKXSLyCLTWw.zqKwGGtLEAI1AX<int>(num2 + 77 + 37, array3[2]);
								PrLxxKXSLyCLTWw.zqKwGGtLEAI1AX<bool>(num4 + 44, true);
								PrLxxKXSLyCLTWw.zqKwGGtLEAI1AX<int>(num2 + 225 - 110, 255);
								PrLxxKXSLyCLTWw.zqKwGGtLEAI1AX<int>(num2 + 112, array3[0]);
								PrLxxKXSLyCLTWw.zqKwGGtLEAI1AX<bool>(num4 + 40, true);
								PrLxxKXSLyCLTWw.zqKwGGtLEAI1AX<bool>(num4 + 48, true);
								PrLxxKXSLyCLTWw.zqKwGGtLEAI1AX<float>(num4 + 20, (float)array4[3] / 255f);
								PrLxxKXSLyCLTWw.zqKwGGtLEAI1AX<float>(num4 + 16, (float)array4[2] / 255f);
								PrLxxKXSLyCLTWw.zqKwGGtLEAI1AX<float>(num4 + 12, (float)array4[1] / 255f);
								PrLxxKXSLyCLTWw.zqKwGGtLEAI1AX<float>(num4 + 8, (float)array4[0] / 255f);
							}
						}
					}
				}
			}).Start();

            

			new Thread(delegate()
			{
				for (;;)
				{
					if (Program.GetAsyncKeyState(1) != 0)
					{
						PrLxxKXSLyCLTWw.zqKwGGtLEAI1AX<int>(PrLxxKXSLyCLTWw.QTdQul4r30C + Ninja_Offsets.dwForceAttack, 6);
					}
					Thread.Sleep(1);
				}
			}).Start();



			new Thread(delegate()
			{
				for (;;)
				{
					float value = 0f;
					int num = PrLxxKXSLyCLTWw.B4qNq2LNdun<int>(PrLxxKXSLyCLTWw.K2nNi7Tf0MbHp + Ninja_Offsets.model_ambient_min - 44);
					int num2 = BitConverter.ToInt32(BitConverter.GetBytes(value), 0) ^ num;
					PrLxxKXSLyCLTWw.zqKwGGtLEAI1AX<int>(PrLxxKXSLyCLTWw.K2nNi7Tf0MbHp + Ninja_Offsets.model_ambient_min, num2);
					Thread.Sleep(1000);
				}
			}).Start();


			new Thread(delegate()
			{
				for (;;)
				{
					for (int i = 0; i < 1024; i++)
					{
						int num = PrLxxKXSLyCLTWw.B4qNq2LNdun<int>(PrLxxKXSLyCLTWw.QTdQul4r30C + Ninja_Offsets.dwEntityList + i * 16);
						if (PrLxxKXSLyCLTWw.B4qNq2LNdun<int>(PrLxxKXSLyCLTWw.B4qNq2LNdun<int>(PrLxxKXSLyCLTWw.B4qNq2LNdun<int>(PrLxxKXSLyCLTWw.B4qNq2LNdun<int>(num + 8) + 8) + 1) + 20) == 69)
						{
							PrLxxKXSLyCLTWw.zqKwGGtLEAI1AX<int>(num + Ninja_Offsets.m_flCustomAutoExposureMin, 1);
							PrLxxKXSLyCLTWw.zqKwGGtLEAI1AX<int>(num + Ninja_Offsets.m_flCustomAutoExposureMax, 1);
							PrLxxKXSLyCLTWw.zqKwGGtLEAI1AX<float>(num + Ninja_Offsets.m_flCustomAutoExposureMin, 0f);
							PrLxxKXSLyCLTWw.zqKwGGtLEAI1AX<float>(num + Ninja_Offsets.m_flCustomAutoExposureMax, 0f);
						}
					}
					Thread.Sleep(1000);
				}
			}).Start();


			new Thread(delegate()
			{
				for (;;)
				{
					PrLxxKXSLyCLTWw.zqKwGGtLEAI1AX<int>(Program.DyH6NvqVm + 600, 0);
					Thread.Sleep(1000);
				}
			}).Start();


			new Thread(delegate()
			{
				int num = PrLxxKXSLyCLTWw.B4qNq2LNdun<int>(Program.DyH6NvqVm + 66552);
				for (;;)
				{
					int num2 = PrLxxKXSLyCLTWw.B4qNq2LNdun<int>(Program.DyH6NvqVm + 66552);
					if ((Program.GetAsyncKeyState(1) != 0 || Program.GetAsyncKeyState(Program.OmxOvPjmEz7r8) != 0 || Program.GetAsyncKeyState(Program.Dnck3ljDP) != 0 || Program.GetAsyncKeyState(Program.sreZP3iAasJG) != 0) && num != num2 && num2 > num)
					{
						Console.Beep(7500, 50);
						num = num2;
					}
					Thread.Sleep(1);
				}
			}).Start();
			new Thread(delegate()
			{
				for (;;)
				{
					float value = 0f;
					int num = PrLxxKXSLyCLTWw.B4qNq2LNdun<int>(PrLxxKXSLyCLTWw.K2nNi7Tf0MbHp + 5822896);
					int num2 = BitConverter.ToInt32(BitConverter.GetBytes(value), 0) ^ num;
					PrLxxKXSLyCLTWw.zqKwGGtLEAI1AX<int>(PrLxxKXSLyCLTWw.K2nNi7Tf0MbHp + 5822896 + 44, num2);
					Thread.Sleep(1000);
				}
			}).Start();
			new Thread(delegate()
			{
				for (;;)
				{
					int value = 1;
					int num = PrLxxKXSLyCLTWw.B4qNq2LNdun<int>(PrLxxKXSLyCLTWw.QTdQul4r30C + 14545008);
					int num2 = BitConverter.ToInt32(BitConverter.GetBytes(value), 0) ^ num;
					PrLxxKXSLyCLTWw.zqKwGGtLEAI1AX<int>(PrLxxKXSLyCLTWw.QTdQul4r30C + 14545008 + 48, num2);
					Thread.Sleep(1000);
				}
			}).Start();
			new Thread(delegate()
			{
				for (;;)
				{
					int value = 3;
					int num = PrLxxKXSLyCLTWw.B4qNq2LNdun<int>(PrLxxKXSLyCLTWw.QTdQul4r30C + 14553352);
					int num2 = BitConverter.ToInt32(BitConverter.GetBytes(value), 0) ^ num;
					PrLxxKXSLyCLTWw.zqKwGGtLEAI1AX<int>(PrLxxKXSLyCLTWw.QTdQul4r30C + 14553352 + 48, num2);
					Thread.Sleep(1000);
				}
			}).Start();
			new Thread(delegate()
			{
				for (;;)
				{
					float value = 1f;
					int num = PrLxxKXSLyCLTWw.B4qNq2LNdun<int>(PrLxxKXSLyCLTWw.QTdQul4r30C + 14547256);
					int num2 = BitConverter.ToInt32(BitConverter.GetBytes(value), 0) ^ num;
					PrLxxKXSLyCLTWw.zqKwGGtLEAI1AX<int>(PrLxxKXSLyCLTWw.QTdQul4r30C + 14547256 + 44, num2);
					Thread.Sleep(1000);
				}
			}).Start();
			new Thread(delegate()
			{
				for (;;)
				{
					int value = 1;
					int num = PrLxxKXSLyCLTWw.B4qNq2LNdun<int>(PrLxxKXSLyCLTWw.QTdQul4r30C + 14498416);
					int num2 = BitConverter.ToInt32(BitConverter.GetBytes(value), 0) ^ num;
					PrLxxKXSLyCLTWw.zqKwGGtLEAI1AX<int>(PrLxxKXSLyCLTWw.QTdQul4r30C + 14498416 + 48, num2);
					Thread.Sleep(1000);
				}
			}).Start();
			new Thread(delegate()
			{
				for (;;)
				{
					if ((!Program.X2jtodjgE5wgZcn || Program.OmxOvPjmEz7r8 == -1 || Program.GetAsyncKeyState(Program.OmxOvPjmEz7r8) != 0) && (!Program.D0XdAbL7s || Program.Dnck3ljDP == -1 || Program.GetAsyncKeyState(Program.Dnck3ljDP) != 0) && (Program.X2jtodjgE5wgZcn || Program.D0XdAbL7s || Program.sreZP3iAasJG == -1 || Program.GetAsyncKeyState(Program.sreZP3iAasJG) != 0) && Program.gkyUGIQMiI)
					{
						if (Program.X2jtodjgE5wgZcn)
						{
							Program.YcW0e27BHdO6(Program.ZfHfiyKDs, Program.tvmGWLq5SBs, Program.RYA2q8jg6lxuacZZ, Program.VrvjbuwVlC4Tw, Program.PbjyTJdfBmu, Program.HHi0bydlnPmHI, Program.f9NrSzx2I, Program.LnK68OAp08);
						}
						else if (Program.D0XdAbL7s)
						{
							Program.YcW0e27BHdO6(Program.TnbRnBpkXbK3, Program.Aw1wUBkLUmnIW, Program.T205W5rlBXGGE, Program.cKUo2ANn4dnkyFT, Program.fKn3GJjklex, Program.N3f9Vc2ghudp, Program.ZKhCeLAKJWi, Program.Y3DwXy9Hk);
						}
						else
						{
							Program.YcW0e27BHdO6(Program.fsJ0noziJH, Program.Fz4GQdO6d, Program.aysUv5ufgHHD3Vv, Program.WFEPkusSh, Program.YqTftNC3N, Program.GrHgMRVCzit4, Program.eo7KAzy2ZllJz, Program.EldOZhJFN);
						}
					}
					Thread.Sleep(0);
				}
			}).Start();
			new Thread(delegate()
			{
				for (;;)
				{
					if (PrLxxKXSLyCLTWw.B4qNq2LNdun<int>(PrLxxKXSLyCLTWw.QTdQul4r30C + Ninja_Offsets.dwForceJump) == 5)
					{
						while (Program.GetAsyncKeyState(32) != 0)
						{
							if (PrLxxKXSLyCLTWw.B4qNq2LNdun<int>(Program.DyH6NvqVm + Ninja_Offsets.m_fFlags) == 256)
							{
								PrLxxKXSLyCLTWw.zqKwGGtLEAI1AX<int>(PrLxxKXSLyCLTWw.QTdQul4r30C + Ninja_Offsets.dwForceJump, 4);
							}
							else
							{
								PrLxxKXSLyCLTWw.zqKwGGtLEAI1AX<int>(PrLxxKXSLyCLTWw.QTdQul4r30C + Ninja_Offsets.dwForceJump, 5);
							}
							Thread.Sleep(10);
						}
					}
					Thread.Sleep(1);
				}
			}).Start();
			new Thread(delegate()
			{
				for (;;)
				{
					for (int i = 0; i < 64; i++)
					{
						int num = PrLxxKXSLyCLTWw.B4qNq2LNdun<int>(PrLxxKXSLyCLTWw.QTdQul4r30C + Ninja_Offsets.dwEntityList + i * 16);
						if (PrLxxKXSLyCLTWw.B4qNq2LNdun<int>(num + Ninja_Offsets.m_bSpotted) == 0 && !PrLxxKXSLyCLTWw.B4qNq2LNdun<bool>(num + Ninja_Offsets.m_bDormant) && PrLxxKXSLyCLTWw.B4qNq2LNdun<int>(num + Ninja_Offsets.m_iHealth) > 0)
						{
							PrLxxKXSLyCLTWw.zqKwGGtLEAI1AX<int>(num + Ninja_Offsets.m_bSpotted, 1);
						}
					}
					Thread.Sleep(100);
				}
			}).Start();
		}

		private static bool PHWMR3QY6xUkCe(int FGjzEBRTRMXEA5W, float YgNgwu7GvVtKP, float ppQiukb5FQBz1k, bool TVKjXKvdw, bool NQnFzVjlKLN, bool B9glFtE1T8Y)
		{
			int num = PrLxxKXSLyCLTWw.B4qNq2LNdun<int>(PrLxxKXSLyCLTWw.K2nNi7Tf0MbHp + Ninja_Offsets.dwClientState);
			gUAgaRMSEPsqJg.fuH1JM0VkmpN gwdysr6HhLeVDiTv = default(gUAgaRMSEPsqJg.fuH1JM0VkmpN);
			gUAgaRMSEPsqJg.fuH1JM0VkmpN zaZQmKAsPUs2yPb = default(gUAgaRMSEPsqJg.fuH1JM0VkmpN);
			gUAgaRMSEPsqJg.fuH1JM0VkmpN fxF8CYoITL1TanWQ = default(gUAgaRMSEPsqJg.fuH1JM0VkmpN);
			gwdysr6HhLeVDiTv.aIJTJisnViEQC1pN = PrLxxKXSLyCLTWw.B4qNq2LNdun<float>(num + Ninja_Offsets.dwClientState_ViewAngles + 4);
			fxF8CYoITL1TanWQ.F7uN4RgKL = PrLxxKXSLyCLTWw.B4qNq2LNdun<float>(Program.DyH6NvqVm + Ninja_Offsets.dwClientState_State) + PrLxxKXSLyCLTWw.B4qNq2LNdun<float>(Program.DyH6NvqVm + Ninja_Offsets.m_vecOrigin);
			gwdysr6HhLeVDiTv.iWeQooh8m = PrLxxKXSLyCLTWw.B4qNq2LNdun<float>(num + Ninja_Offsets.dwClientState_ViewAngles + 8);
			zaZQmKAsPUs2yPb.aIJTJisnViEQC1pN = PrLxxKXSLyCLTWw.B4qNq2LNdun<float>(Program.DyH6NvqVm + Ninja_Offsets.m_vecOrigin + 4);
			fxF8CYoITL1TanWQ.aIJTJisnViEQC1pN = PrLxxKXSLyCLTWw.B4qNq2LNdun<float>(Program.DyH6NvqVm + Ninja_Offsets.dwClientState_State + 4) + PrLxxKXSLyCLTWw.B4qNq2LNdun<float>(Program.DyH6NvqVm + Ninja_Offsets.m_vecOrigin + 4);
			fxF8CYoITL1TanWQ.iWeQooh8m = PrLxxKXSLyCLTWw.B4qNq2LNdun<float>(Program.DyH6NvqVm + Ninja_Offsets.dwClientState_State + 8) + PrLxxKXSLyCLTWw.B4qNq2LNdun<float>(Program.DyH6NvqVm + Ninja_Offsets.m_vecOrigin + 8);
			zaZQmKAsPUs2yPb.iWeQooh8m = PrLxxKXSLyCLTWw.B4qNq2LNdun<float>(Program.DyH6NvqVm + Ninja_Offsets.m_vecOrigin + 8);
			zaZQmKAsPUs2yPb.F7uN4RgKL = PrLxxKXSLyCLTWw.B4qNq2LNdun<float>(Program.DyH6NvqVm + Ninja_Offsets.m_vecOrigin);
			gwdysr6HhLeVDiTv.F7uN4RgKL = PrLxxKXSLyCLTWw.B4qNq2LNdun<float>(num + Ninja_Offsets.dwClientState_ViewAngles);
			for (int i = 0; i < 64; i++)
			{
				int num2 = PrLxxKXSLyCLTWw.B4qNq2LNdun<int>(PrLxxKXSLyCLTWw.QTdQul4r30C + Ninja_Offsets.dwEntityList + i * 16);
				if (num2 != Program.DyH6NvqVm)
				{
					if (num2 != 0)
					{
						if (!PrLxxKXSLyCLTWw.B4qNq2LNdun<bool>(num2 + Ninja_Offsets.m_bDormant))
						{
							int num3 = PrLxxKXSLyCLTWw.B4qNq2LNdun<int>(num2 + Ninja_Offsets.m_iTeamNum);
							int num4 = PrLxxKXSLyCLTWw.B4qNq2LNdun<int>(num2 + Ninja_Offsets.m_iHealth);
							bool flag = num4 > 0;
							bool flag2 = false;
							if (num3 != Program.BRyMHDOu1W && NQnFzVjlKLN)
							{
								flag2 = true;
							}
							if (num3 == Program.BRyMHDOu1W && B9glFtE1T8Y)
							{
								flag2 = true;
							}
							if (num3 > 1)
							{
								PrLxxKXSLyCLTWw.zqKwGGtLEAI1AX<int>(num2 + Ninja_Offsets.m_bSpotted, 0);
								bool flag3 = PrLxxKXSLyCLTWw.B4qNq2LNdun<bool>(num2 + Ninja_Offsets.m_bSpottedByMask);
								if (flag2 && flag3 && flag)
								{
									gUAgaRMSEPsqJg.fuH1JM0VkmpN tkZbdYxhEdF = gUAgaRMSEPsqJg.AMd40AeDJJ(num2, FGjzEBRTRMXEA5W);
									gUAgaRMSEPsqJg.fuH1JM0VkmpN tkZbdYxhEdF2 = gUAgaRMSEPsqJg.R2V1HPSdvy9wSF(fxF8CYoITL1TanWQ, tkZbdYxhEdF, TVKjXKvdw);
									gUAgaRMSEPsqJg.fuH1JM0VkmpN izlwhcUZA0SPWS = new gUAgaRMSEPsqJg.fuH1JM0VkmpN
									{
										F7uN4RgKL = PrLxxKXSLyCLTWw.B4qNq2LNdun<float>(num2 + Ninja_Offsets.m_vecOrigin),
										iWeQooh8m = PrLxxKXSLyCLTWw.B4qNq2LNdun<float>(num2 + Ninja_Offsets.m_vecOrigin + 8),
										aIJTJisnViEQC1pN = PrLxxKXSLyCLTWw.B4qNq2LNdun<float>(num2 + Ninja_Offsets.m_vecOrigin + 4)
									};
									float num5 = gUAgaRMSEPsqJg.MceHum3BxWGeTiel(gwdysr6HhLeVDiTv, tkZbdYxhEdF2, gUAgaRMSEPsqJg.met_VectorDistance(zaZQmKAsPUs2yPb, izlwhcUZA0SPWS) / 10f);
									if (num5 <= YgNgwu7GvVtKP)
									{
										gUAgaRMSEPsqJg.fuH1JM0VkmpN fuH1JM0VkmpN = gUAgaRMSEPsqJg.bbGGLdplG(new gUAgaRMSEPsqJg.fuH1JM0VkmpN
										{
											aIJTJisnViEQC1pN = gwdysr6HhLeVDiTv.aIJTJisnViEQC1pN - tkZbdYxhEdF2.aIJTJisnViEQC1pN,
											F7uN4RgKL = gwdysr6HhLeVDiTv.F7uN4RgKL - tkZbdYxhEdF2.F7uN4RgKL
										});
										float num6 = gwdysr6HhLeVDiTv.aIJTJisnViEQC1pN - fuH1JM0VkmpN.aIJTJisnViEQC1pN / ppQiukb5FQBz1k;
										float num7 = gwdysr6HhLeVDiTv.F7uN4RgKL - fuH1JM0VkmpN.F7uN4RgKL / ppQiukb5FQBz1k;
										if (num6 > 180f)
										{
											num6 = 180f;
										}
										else if (num6 < -180f)
										{
											num6 = -180f;
										}
										if (num7 > 89f)
										{
											num7 = 89f;
										}
										else if (num7 < -89f)
										{
											num7 = -89f;
										}
										bool result;
										if (Math.Abs(gwdysr6HhLeVDiTv.F7uN4RgKL - num7) > YgNgwu7GvVtKP)
										{
											result = false;
										}
										else if (Math.Abs(gwdysr6HhLeVDiTv.aIJTJisnViEQC1pN - num6) > YgNgwu7GvVtKP)
										{
											result = false;
										}
										else
										{
											PrLxxKXSLyCLTWw.zqKwGGtLEAI1AX<float>(num + Ninja_Offsets.dwClientState_ViewAngles, num7);
											PrLxxKXSLyCLTWw.zqKwGGtLEAI1AX<float>(num + Ninja_Offsets.dwClientState_ViewAngles + 8, 0f);
											PrLxxKXSLyCLTWw.zqKwGGtLEAI1AX<float>(num + Ninja_Offsets.dwClientState_ViewAngles + 4, num6);
											Thread.Sleep(0);
											result = true;
										}
										return result;
									}
								}
							}
						}
					}
				}
			}
			return false;
		}

		private static void YcW0e27BHdO6(int VrUpmJDC2wulnoh, int gHJxcrhbPI, bool NQnFzVjlKLN, bool B9glFtE1T8Y, bool pLvkF61h9o03, int dcdq2N6VTuDp, float x3l8sydhKNbO, float NEZzKIoMAyd7B7)
		{
			if (pLvkF61h9o03)
			{
				Program.PHWMR3QY6xUkCe(dcdq2N6VTuDp, NEZzKIoMAyd7B7, x3l8sydhKNbO, false, NQnFzVjlKLN, B9glFtE1T8Y);
			}
			int num = PrLxxKXSLyCLTWw.B4qNq2LNdun<int>(Program.DyH6NvqVm + Ninja_Offsets.m_iCrosshairId);
			if (num > 0 && num <= 64)
			{
				int num2 = PrLxxKXSLyCLTWw.B4qNq2LNdun<int>(PrLxxKXSLyCLTWw.QTdQul4r30C + Ninja_Offsets.dwEntityList + (num - 1) * 16);
				int num3 = PrLxxKXSLyCLTWw.B4qNq2LNdun<int>(num2 + Ninja_Offsets.m_iTeamNum);
				if (num3 != Program.BRyMHDOu1W || B9glFtE1T8Y)
				{
					if (num3 == Program.BRyMHDOu1W || NQnFzVjlKLN)
					{
						Thread.Sleep(gHJxcrhbPI);
						PrLxxKXSLyCLTWw.zqKwGGtLEAI1AX<int>(PrLxxKXSLyCLTWw.QTdQul4r30C + Ninja_Offsets.dwForceAttack, 1);
						Thread.Sleep(10 + VrUpmJDC2wulnoh);
						PrLxxKXSLyCLTWw.zqKwGGtLEAI1AX<int>(PrLxxKXSLyCLTWw.QTdQul4r30C + Ninja_Offsets.dwForceAttack, 4);
					}
				}
			}
		}

		private static int[] F9Yzm7h0ns(int SKnBUCjG11n)
		{
			int[] result;
			if (SKnBUCjG11n > 100)
			{
				int[] array = new int[4];
				array[0] = 255;
				array[2] = 255;
				result = array;
			}
			else
			{
				float num = (float)SKnBUCjG11n * 2.55f;
				int num2 = Convert.ToInt32(num);
				int num3 = Convert.ToInt32(255f - num);
				result = new int[]
				{
					num3,
					num2,
					0,
					255
				};
			}
			return result;
		}


	}
}
