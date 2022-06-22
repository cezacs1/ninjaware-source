using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using AyXZmLoQ7w1;

namespace NinjaWare
{
	internal class PrLxxKXSLyCLTWw
	{
		[DllImport("kernel32.dll")]
		private static extern bool ReadProcessMemory(int wMrBDuBzCUc1A8TT, int HGUyJSxbMyC, byte[] jFIeNA5APOhg, int vJjAbamhYV7E, ref int DICbR92tTy6eu);

		private static T VY8LiZeRaGR6x6Zg<T>(byte[] JrSuddRnZCmsQ) where T : struct
		{
			GCHandle gchandle = GCHandle.Alloc(JrSuddRnZCmsQ, GCHandleType.Pinned);
			T result;
			try
			{
				result = (T)((object)Marshal.PtrToStructure(gchandle.AddrOfPinnedObject(), typeof(T)));
			}
			finally
			{
				gchandle.Free();
			}
			return result;
		}

		[DllImport("kernel32.dll")]
		private static extern bool WriteProcessMemory(int wMrBDuBzCUc1A8TT, int HGUyJSxbMyC, byte[] jFIeNA5APOhg, int vJjAbamhYV7E, out int DICbR92tTy6eu);

		public static T B4qNq2LNdun<T>(int HGUyJSxbMyC) where T : struct
		{
			int num = Marshal.SizeOf(typeof(T));
			byte[] array = new byte[num];
			PrLxxKXSLyCLTWw.ReadProcessMemory(PrLxxKXSLyCLTWw.oxs0VO5K16jaPu, HGUyJSxbMyC, array, array.Length, ref PrLxxKXSLyCLTWw.WPWjzHXu0eex);
			return PrLxxKXSLyCLTWw.VY8LiZeRaGR6x6Zg<T>(array);
		}

		public static Process nWC4p6IEuJH()
		{
			float num = 1164.4f;
			num += 619.31f;
			Process result;
			if (Process.GetProcessesByName("csgo").Length > 0)
			{
				Process process = Process.GetProcessesByName("csgo")[0];

				foreach (object obj in process.Modules)
				{
					ProcessModule processModule = (ProcessModule)obj;
					string moduleName = processModule.ModuleName;
					string text = moduleName;
					if (text == null)
					{
						goto IL_D3;
					}
					if (!(text == "engine.dll"))
					{
						if (!(text == "client.dll"))
						{
							goto IL_D3;
						}
						PrLxxKXSLyCLTWw.QTdQul4r30C = (int)processModule.BaseAddress;
					}
					else
					{
						PrLxxKXSLyCLTWw.K2nNi7Tf0MbHp = (int)processModule.BaseAddress;
					}
					IL_F8:
					float num4 = 4523.28f;
					num4 -= 702.36f;
					continue;
					IL_D3:
					float num5 = 5153.85f;
					num5 += 589.57f;
					goto IL_F8;
				}
				PrLxxKXSLyCLTWw.oxs0VO5K16jaPu = (int)PrLxxKXSLyCLTWw.OpenProcess(56, false, process.Id);
				if (PrLxxKXSLyCLTWw.oxs0VO5K16jaPu > 0 && PrLxxKXSLyCLTWw.QTdQul4r30C > 0 && PrLxxKXSLyCLTWw.K2nNi7Tf0MbHp > 0)
				{
					result = process;
				}
				else
				{
					result = null;
				}
			}
			else
			{
				result = null;
			}
			return result;
		}

		private static byte[] TgvLiCFmT6(object znmQuCma6L)
		{
			int num = Marshal.SizeOf(znmQuCma6L);
			byte[] array = new byte[num];
			IntPtr intPtr = Marshal.AllocHGlobal(num);
			Marshal.StructureToPtr(znmQuCma6L, intPtr, true);
			Marshal.Copy(intPtr, array, 0, num);
			Marshal.FreeHGlobal(intPtr);
			return array;
		}

		[DllImport("kernel32.dll")]
		private static extern IntPtr OpenProcess(int GMvEPvLHhNq, bool s7fHClMMQZFmYOOR, int lZmHfMZjt);

		public static void zqKwGGtLEAI1AX<T>(int HGUyJSxbMyC, object RYxAodougQdWt5pb) where T : struct
		{
			byte[] array = PrLxxKXSLyCLTWw.TgvLiCFmT6(RYxAodougQdWt5pb);
			PrLxxKXSLyCLTWw.WriteProcessMemory(PrLxxKXSLyCLTWw.oxs0VO5K16jaPu, HGUyJSxbMyC, array, array.Length, out PrLxxKXSLyCLTWw.oSpv8pkBTAeSttx);
		}

		private static int oSpv8pkBTAeSttx = 0;

		public static int QTdQul4r30C = 0;

		private static int WPWjzHXu0eex = 0;

		public static int oxs0VO5K16jaPu = 0;

		public static int K2nNi7Tf0MbHp = 0;
	}
}
