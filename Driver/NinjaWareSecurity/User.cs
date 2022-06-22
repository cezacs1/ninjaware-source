using System;
using System.Collections.Generic;
using System.Management;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using Microsoft.Win32;

namespace NinjaWareSecurity
{
	// Token: 0x02000002 RID: 2
	public class User
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002144 File Offset: 0x00000344
		public static string HWID()
		{
			string text = string.Empty;
			if (string.IsNullOrEmpty(text))
			{
				text = User.GetHash(string.Concat(new string[]
				{
					"\nCPU >> ",
					User.CPUID(),
					"\nBIOS>> ",
					User.BIOSID(),
					"\nBASE >> ",
					User.BASEID()
				}));
			}
			return text;
		}

		// Token: 0x06000002 RID: 2 RVA: 0x000021B0 File Offset: 0x000003B0
		public static string GetMachineGuid()
		{
			string text = "SOFTWARE\\Microsoft\\Cryptography";
			string text2 = "MachineGuid";
			string result;
			using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
			{
				using (RegistryKey registryKey2 = registryKey.OpenSubKey(text))
				{
					if (registryKey2 == null)
					{
						throw new KeyNotFoundException(string.Format("Key Not Found: {0}", text));
					}
					object value = registryKey2.GetValue(text2);
					if (value == null)
					{
						throw new IndexOutOfRangeException(string.Format("Index Not Found: {0}", text2));
					}
					result = value.ToString();
				}
			}
			return result;
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002278 File Offset: 0x00000478
		public static string Identifier(string wmiClass, string wmiProperty, string wmiMustBeTrue)
		{
			string text = "";
			ManagementClass managementClass = new ManagementClass(wmiClass);
			ManagementObjectCollection instances = managementClass.GetInstances();
			foreach (ManagementBaseObject managementBaseObject in instances)
			{
				ManagementObject managementObject = (ManagementObject)managementBaseObject;
				if (managementObject[wmiMustBeTrue].ToString() == "True")
				{
					if (text == "")
					{
						try
						{
							text = managementObject[wmiProperty].ToString();
							break;
						}
						catch
						{
						}
					}
				}
			}
			return text;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x0000234C File Offset: 0x0000054C
		public static string GetHash(string s)
		{
			MD5 md = new MD5CryptoServiceProvider();
			ASCIIEncoding asciiencoding = new ASCIIEncoding();
			byte[] bytes = asciiencoding.GetBytes(s);
			return User.GetHexString(md.ComputeHash(bytes));
		}

		public static string GetHexString(byte[] bt)
		{
			string text = string.Empty;
			for (int i = 0; i < bt.Length; i++)
			{
				byte b = bt[i];
				int num = (int)b;
				int num2 = num & 15;
				int num3 = num >> 4 & 15;
				if (num3 > 9)
				{
					text += ((char)(num3 - 10 + 65)).ToString();
				}
				else
				{
					text += num3.ToString();
				}
				if (num2 > 9)
				{
					text += ((char)(num2 - 10 + 65)).ToString();
				}
				else
				{
					text += num2.ToString();
				}
				if (i + 1 != bt.Length && (i + 1) % 2 == 0)
				{
					text += "-";
				}
			}
			return text;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002464 File Offset: 0x00000664
		public static string GetHashDLL(string s)
		{
			MD5 md = new MD5CryptoServiceProvider();
			ASCIIEncoding asciiencoding = new ASCIIEncoding();
			byte[] bytes = asciiencoding.GetBytes(s);
			return User.GetHexStringDLL(md.ComputeHash(bytes));
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002498 File Offset: 0x00000698
		public static string GetHexStringDLL(byte[] bt)
		{
			string str = string.Empty;
			for (int i = 0; i < bt.Length; i++)
			{
				byte b = bt[i];
				int num = (int)b;
				int num2 = num & 15;
				int num3 = num >> 4 & 15;
				if (num3 > 9)
				{
					str += ((char)(num3 - 10 + 97)).ToString();
				}
				else
				{
					str += num3.ToString();
				}
				if (num2 > 9)
				{
					str += ((char)(num2 - 10 + 97)).ToString();
				}
				else
				{
					str += num2.ToString();
				}
				if (i + 2 != bt.Length && (i + 1) % 3 == 0)
				{
					str += "-";
				}
			}
			return str + ".tmp";
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002588 File Offset: 0x00000788
		public static string Identifier(string wmiClass, string wmiProperty)
		{
			string text = "";
			ManagementClass managementClass = new ManagementClass(wmiClass);
			ManagementObjectCollection instances = managementClass.GetInstances();
			foreach (ManagementBaseObject managementBaseObject in instances)
			{
				ManagementObject managementObject = (ManagementObject)managementBaseObject;
				if (text == "")
				{
					try
					{
						text = managementObject[wmiProperty].ToString();
						break;
					}
					catch
					{
					}
				}
			}
			return text;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002638 File Offset: 0x00000838
		public static string CPUID()
		{
			string text = User.Identifier("Win32_Processor", "UniqueId");
			if (text == "")
			{
				text = User.Identifier("Win32_Processor", "ProcessorId");
				if (text == "")
				{
					text = User.Identifier("Win32_Processor", "Name");
					if (text == "")
					{
						text = User.Identifier("Win32_Processor", "Manufacturer");
					}
				}
			}
			return text;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000026C8 File Offset: 0x000008C8
		public static string BIOSID()
		{
			return string.Concat(new string[]
			{
				User.Identifier("Win32_BIOS", "Manufacturer"),
				User.Identifier("Win32_BIOS", "SMBIOSBIOSVersion"),
				User.Identifier("Win32_BIOS", "IdentificationCode"),
				User.Identifier("Win32_BIOS", "SerialNumber"),
				User.Identifier("Win32_BIOS", "ReleaseDate"),
				User.Identifier("Win32_BIOS", "Version")
			});
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002754 File Offset: 0x00000954
		public static string DISKID()
		{
			return User.Identifier("Win32_DiskDrive", "Model") + User.Identifier("Win32_DiskDrive", "Manufacturer") + User.Identifier("Win32_DiskDrive", "Signature") + User.Identifier("Win32_DiskDrive", "TotalHeads");
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000027A8 File Offset: 0x000009A8
		public static string BASEID()
		{
			return User.Identifier("Win32_BaseBoard", "Model") + User.Identifier("Win32_BaseBoard", "Manufacturer") + User.Identifier("Win32_BaseBoard", "Name") + User.Identifier("Win32_BaseBoard", "SerialNumber");
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000027FC File Offset: 0x000009FC
		public static string VIDEOID()
		{
			return User.Identifier("Win32_VideoController", "DriverVersion") + User.Identifier("Win32_VideoController", "Name");
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002834 File Offset: 0x00000A34
		public static string MACID()
		{
			return User.Identifier("Win32_NetworkAdapterConfiguration", "MACAddress", "IPEnabled");
		}

		// Token: 0x0600000F RID: 15 RVA: 0x0000285C File Offset: 0x00000A5C
		public static string IP()
		{
			WebClient webClient = new WebClient();
			return webClient.DownloadString("https://ipv4.wtfismyip.com/text");
		}
	}
}
