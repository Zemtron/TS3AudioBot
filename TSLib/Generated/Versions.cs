// TSLib - A free TeamSpeak 3 and 5 client library
// Copyright (C) 2017  TSLib contributors
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the Open Software License v. 3.0
//
// You should have received a copy of the Open Software License along with this
// program. If not, see <https://opensource.org/licenses/OSL-3.0>.
// <auto-generated />










using System.Collections.Generic;

namespace TSLib.Full
{
	/// <summary>
	/// Describes a triple of version, platform and a cryptographical signature (usually distributed by "TeamSpeak Systems").
	/// Each triple has to match and is not interchangeable with other triple parts.
	/// </summary>
	public sealed class VersionSign
	{
		private static readonly Dictionary<string, ClientPlatform> Platforms = new Dictionary<string, ClientPlatform> {
			{ "Windows", ClientPlatform.Windows },
			{ "Linux", ClientPlatform.Linux },
			{ "OS X", ClientPlatform.MacOs },
			{ "macOS", ClientPlatform.MacOs },
			{ "Android", ClientPlatform.Android },
			{ "iOS", ClientPlatform.Ios },
		};

		public string Sign { get; }
		public string Name { get; }
		public ClientPlatform Platform { get; }
		public string PlatformName { get; }

		private static ClientPlatform GetPlatform(string platform)
			=> Platforms.TryGetValue(platform, out var enu) ? enu : ClientPlatform.Other;

		public VersionSign(string name, string platform, string sign)
			: this(name, platform, GetPlatform(platform), sign) { }

		public VersionSign(string name, string platform, ClientPlatform platformType, string sign)
		{
			Name = name;
			Sign = sign;
			Platform = platformType;
			PlatformName = platform;
		}

		public bool CheckValid() => TsCrypt.EdCheck(this);

		// ReSharper disable InconsistentNaming, UnusedMember.Global
		public static VersionSign VER_WIN_3_X_X { get; } = new VersionSign("3.?.? [Build: 5680278000] DEBUG", "Windows", ClientPlatform.Windows, "FaA10gndI44f19ZThYJX2OSM8ESrx9/vJ2uY+rON4enzzPsPR9kiPhsUXtMcC5szzTu6F/vLCiNNEhCr70CKCQ==");
		public static VersionSign VER_MAC_3_X_X { get; } = new VersionSign("3.?.? [Build: 5680278000]", "OS X", ClientPlatform.MacOs, "SttEnjoWE8jqIM6BOHSfiZP9DGjW0EP/ajU4bdKqgGMV4aYq/kzwVA9gxbmdIzV4lbaokvXBqrRjfBHrTVh8Cg==");
		public static VersionSign VER_LIN_3_X_X { get; } = new VersionSign("3.?.? [Build: 5680278000]", "Linux", ClientPlatform.Linux, "Hjd+N58Gv3ENhoKmGYy2bNRBsNNgm5kpiaQWxOj5HN2DXttG6REjymSwJtpJ8muC2gSwRuZi0R+8Laan5ts5CQ==");
		public static VersionSign VER_IOS_3_X_X { get; } = new VersionSign("3.?.? [Build: 5680278000]", "iOS", ClientPlatform.Ios, "XrAf+Buq6Eb0ehEW/niFp06YX+nGGOS0Ke4MoUBzn+cX9q6G5C0A/d5XtgcNMe8r9jJgV/adIYVpsGS3pVlSAA==");
		public static VersionSign VER_AND_3_X_X { get; } = new VersionSign("3.?.? [Build: 5680278000]", "Android", ClientPlatform.Android, "AWb948BY32Z7bpIyoAlQguSmxOGcmjESPceQe1DpW5IZ4+AW1KfTk2VUIYNfUPsxReDJMCtlhVKslzhR2lf0AA==");
		public static VersionSign VER_MAC_5_0_0 { get; } = new VersionSign("5.0.0-test.3 [Build: 1573037288]", "macOS", ClientPlatform.MacOs, "+AqLKfemvASC0sYMz7/G1J5Yhf2/M3Te4/kYrsCgsq39zUxcViLJoJ/B0Poz3R5Q6vpugSpYvzGM4g2x3eBWCg==");
		public static VersionSign VER_WIN_5_0_0 { get; } = new VersionSign("5.0.0-beta.12 [Build: 1572868115]", "Windows", ClientPlatform.Windows, "w8i8mSIJ3y6wnFxSp8Gh6CRl3i8Q5owzchsHefG3kKYqzm2oyYsMDOsX61FVELbyiQoQea+QJZgGHY+MZCTCAQ==");
		public static VersionSign VER_WIN_3_5_0 { get; } = new VersionSign("3.5.0 [Build: 1572447082]", "Windows", ClientPlatform.Windows, "igVHTt+UUyZDHQpj8sEm3fGw+r+MDVkspQKPS/+fsxiVJr1vy2LpDQlpeZ7Yr6C6eECtCx7He58DXALTQD7JAg==");
		public static VersionSign VER_MAC_3_5_0 { get; } = new VersionSign("3.5.0 [Build: 1572447082]", "OS X", ClientPlatform.MacOs, "H20O0S/45t4TerVsFDNAOXr5yD5VrI7Ps3Nx0RFyPwubYUWXDiIj+LO4wu8wbuxag9V2VJKxtAax1OVWYZssAw==");
		public static VersionSign VER_LIN_3_5_0 { get; } = new VersionSign("3.5.0 [Build: 1572447082]", "Linux", ClientPlatform.Linux, "/5nJG7aByRNQKpUapx+cd7EQS80iEA9B+8z1bQgkrkopYfpYJD3PioUaI4oNCvdyq5I2ROheOcaHMTI9M7duAw==");
		public static VersionSign VER_LIN_5_0_0 { get; } = new VersionSign("5.0.0-beta.9 [Build: 1571949734]", "Linux", ClientPlatform.Linux, "b6ksNapJZndbf5qa1dcvqRgCdcgay0KQrnw8IYkPAXY/OvccuoJ/LUfg/a01nXbxbh45kp7h5gTk9l0L9NVPDQ==");
		public static VersionSign VER_IOS_3_5_0 { get; } = new VersionSign("3.5.0 [Build: 1570810399]", "iOS", ClientPlatform.Ios, "RdN1+nQ2YRxJi66Yd8ta7CXUMsisWTU64qGNDTyuV2vdO/+vYQz6qOUaWjwDxzw3JAXr8FfCPcPaPo3suJj7AA==");
		public static VersionSign VER_WIN_3_3_2 { get; } = new VersionSign("3.3.2 [Build: 1566767614]", "Windows", ClientPlatform.Windows, "fAjM3pPl95eGXrhFcsvCXgdI6Epr8XpafOJZlYbFws2VMllYy/4DUleSVzPuVqu/TCgrTaqb0wP+KANse3/vAw==");
		public static VersionSign VER_MAC_3_3_2 { get; } = new VersionSign("3.3.2 [Build: 1566767614]", "OS X", ClientPlatform.MacOs, "JiKoykMS5BExaAEMpIYB3JRH+YturPua/Q+VTQxJGRi002zni9b8ReitLaJJQt2EMcNAbDpl57um4mekqFvGBA==");
		public static VersionSign VER_LIN_3_3_2 { get; } = new VersionSign("3.3.2 [Build: 1566767614]", "Linux", ClientPlatform.Linux, "UhiFNnz8npgT22qkLXlZJnX3T2n+a8usv/0cTh+tgybrgsFd2WIuI3eabWCibPeU+AYeHLaeYR+x+pF4GX/NDw==");
		public static VersionSign VER_WIN_3_3_1 { get; } = new VersionSign("3.3.1 [Build: 1566673023]", "Windows", ClientPlatform.Windows, "utZjz6KhPiaR9zdhS3NvbLpi4oTGH/vseHd9/mUrLxYYD5JvfeeHH6nzLf8H3manoNrQnONsCcqUOvYglCotCQ==");
		public static VersionSign VER_MAC_3_3_1 { get; } = new VersionSign("3.3.1 [Build: 1566673023]", "OS X", ClientPlatform.MacOs, "dNpW3zyuLCNdhCJpCbaCHWob9xnHSbrRNyJgNShwAPQfyclrtarPLOiTYN9IgQbIGxTu1Yo4fra59VHzpHhaDQ==");
		public static VersionSign VER_LIN_3_3_1 { get; } = new VersionSign("3.3.1 [Build: 1566673023]", "Linux", ClientPlatform.Linux, "IdO00q19oqEwf9CB1R2c+2ZALMrUC6YPwTohdmD9abnDzpfDH/P/p70oDolrL+pRLoh1LjDiLtUdKRETLbeqAw==");
		public static VersionSign VER_AND_3_3_1 { get; } = new VersionSign("3.3.1 [Build: 1564678999]", "Android", ClientPlatform.Android, "kPqHuXEgLxpThXc5XYdvTLk+iaY0AL99jf2WJIXKBJuCJmD0pfW1Ep/zYCxU2NGsu4HIHMMXnB0d2lkr7AHiDw==");
		public static VersionSign VER_WIN_3_3_0 { get; } = new VersionSign("3.3.0 [Build: 1560850141]", "Windows", ClientPlatform.Windows, "v9gCHwBYJKBxLWwptMvqhj+tvWuSAz/AjcThvv/J3ZNsPeivRk4P9Y9YtalQbIRkrALQSC+qNc5wIAw4HG2cCA==");
		public static VersionSign VER_MAC_3_3_0 { get; } = new VersionSign("3.3.0 [Build: 1560850141]", "OS X", ClientPlatform.MacOs, "Z/UJgrYae1BsdKJfvMorW4/zIQ8E0sKBMTBI5Cm58oYE3TtCE9+1FpUE9VkqWSm3J8SMmu2+J/FpaK6pa8KaBQ==");
		public static VersionSign VER_LIN_3_3_0 { get; } = new VersionSign("3.3.0 [Build: 1560850141]", "Linux", ClientPlatform.Linux, "8giDUlJFDtdmzpfyngDzL3UP47C1+U1iwrzROU70MoiSeswf1oJujYeQ1bx4dD2OPxF4Avi/XgbZUQ/Y4NcDAA==");
		public static VersionSign VER_AND_3_3_0 { get; } = new VersionSign("3.3.0 [Build: 1559834030]", "Android", ClientPlatform.Android, "Ux59iejFFnEANHPjL4dmwUgXKhvnV7dPqjzAIqYMNs0RoF9RyhsgxEaJO72IgNt7D3yaD+4lGtYfcEFG8WDKCg==");
		public static VersionSign VER_IOS_3_3_0 { get; } = new VersionSign("3.3.0 [Build: 1559144369]", "iOS", ClientPlatform.Ios, "xXYmjT4t0D0Oll99yVPTsRXxJuqFr4ShKEtetow7ii6Qwkm3mkMIrg67NR8foo24bBQgcY+s1CQC88CD8WT6Bg==");
		public static VersionSign VER_WIN_3_2_5 { get; } = new VersionSign("3.2.5 [Build: 1555517253]", "Windows", ClientPlatform.Windows, "iyy+8G7ksPHvXb45ijQ9Kfr8TMsCc3sGRKJLiPArx7YMPu8YV4GgYzM4+MpuMQUTlNkU7w5B0od9IJ/7E4nDDQ==");
		public static VersionSign VER_MAC_3_2_5 { get; } = new VersionSign("3.2.5 [Build: 1555517253]", "OS X", ClientPlatform.MacOs, "xrP7+C0BjffIZf7FD21P/xYoCSTmq8nCa3w2q3McX2DlUIEjfMLAX7uepdeiNYZfspAWJmi9QIkpQCltNBwqAg==");
		public static VersionSign VER_LIN_3_2_5 { get; } = new VersionSign("3.2.5 [Build: 1555517253]", "Linux", ClientPlatform.Linux, "+nqAMBv2NxHYfPwHyRmleALMU/2gpiv1LAV6dmrLjNXaTS3BwLBVuysSuqHsuiK3/Xff0IRRFANz8qT1ztJqDQ==");
		public static VersionSign VER_MAC_0_0_1 { get; } = new VersionSign("0.0.1 [Build: 1555082010]", "OS X", ClientPlatform.MacOs, "o/GYOMVcxtE+JWFjozRjS9FJ/h35gGcPfvZkc23AlglNXI5aj6oGg3Gin3M1fLOnSOxn3TSU5WhaQtvCYZgZDg==");
		public static VersionSign VER_WIN_0_0_1 { get; } = new VersionSign("0.0.1 [Build: 1555015683]", "Windows", ClientPlatform.Windows, "AMnbAjVfFPOWlwcEFQjz0pokTLpjGEN7TdH6HliidbMBQXLlj9T/LmwRr+IT/ZjpY9+znSXLbVmF2+d0jLRLAA==");
		public static VersionSign VER_AND_3_2_5 { get; } = new VersionSign("3.2.5 [Build: 1554991343]", "Android", ClientPlatform.Android, "HkOn2tmPaY8qTNhnpZl34QkmhHJzOBVuUdeANQQoCMqDyDovii5zFJnGALyuab5/bHPl9rqy1jllmhWlm34JCA==");
		public static VersionSign VER_LIN_0_0_1 { get; } = new VersionSign("0.0.1 [Build: 1550226976]", "Linux", ClientPlatform.Linux, "22vWrtMv2ObaBwrQGw2CLs2LzUQJ94KoXiVuMObXf5pfoIw2MY4ZqMt8oL9CCyQBtKl6vV3CZntLrAR25ljeDw==");
		public static VersionSign VER_IOS_3_2_3 { get; } = new VersionSign("3.2.3 [Build: 1538494750]", "iOS", ClientPlatform.Ios, "YgRxbZGpaxVAPuC3bln8HiCdgyx8EgM37H+VCSjZnn+05+lo1w74P9LFHSVqr1NBuB5YtKNWp0xjHRbBZVJtDQ==");
		public static VersionSign VER_WIN_3_2_3 { get; } = new VersionSign("3.2.3 [Build: 1538467030]", "Windows", ClientPlatform.Windows, "dZ1i/CsCaAh4F7Pi2F/FfaBpdTmUuNVsAIRnqm86FUR3HhwBRn+xlmbwRF8gObgFMuwFMCLmawncFWplSILKAQ==");
		public static VersionSign VER_MAC_3_2_3 { get; } = new VersionSign("3.2.3 [Build: 1538467030]", "OS X", ClientPlatform.MacOs, "yr8F54NuExnwarhvcJ27f3LvDop1wqwrhyqEVvpliRKi0hLD3e+cW2mJWRkq0eDjPRQ2kzPvBst9yNH1MsuYAQ==");
		public static VersionSign VER_LIN_3_2_3 { get; } = new VersionSign("3.2.3 [Build: 1538467030]", "Linux", ClientPlatform.Linux, "pEBdtUvRUmczMmHZM5xmeZuiRP/Kb/H2YShNKGpaat8aPTmG5EF+zsbjUFNWW4tnt43Yard0bWDUsrJ9/mmjBQ==");
		public static VersionSign VER_AND_3_2_4 { get; } = new VersionSign("3.2.4 [Build: 1537790492]", "Android", ClientPlatform.Android, "cJVVnQRoUWsYSaYKWZ/sIGAAMTpnBDFu8T6shyH5o9AXWLVyu2qRmVVuyvKmMSlEVlYNtVrHIlC2AHtq3l2nDg==");
		public static VersionSign VER_AND_3_2_3 { get; } = new VersionSign("3.2.3 [Build: 1537790492]", "Android", ClientPlatform.Android, "qLdDfrZyNIdl1pDYtyrGbOLZK/Yi/i8PE/a7QOInsEa5/RBz+HW8EBGPvazz+lLZbHrBXyp875NyrKtLnc4dDg==");
		public static VersionSign VER_WIN_3_2_2 { get; } = new VersionSign("3.2.2 [Build: 1537178465]", "Windows", ClientPlatform.Windows, "LHJV3O+hoZZlKWDPKH4ZMCoPUarYWwnaUgfMP+Xdm/4sY5NYUYjkVQaU4FS4pqxii5jx6O4cFToG7ekFB53NBA==");
		public static VersionSign VER_MAC_3_2_2 { get; } = new VersionSign("3.2.2 [Build: 1537178465]", "OS X", ClientPlatform.MacOs, "QbSOeAPhPHgZKykNbEAlzGLZe8w+ulxcZXbk07wOBGLK/vWCfQlyIDPUK5DipGBUfRY9yJvxfUx7g9b5dU8aBw==");
		public static VersionSign VER_LIN_3_2_2 { get; } = new VersionSign("3.2.2 [Build: 1537178465]", "Linux", ClientPlatform.Linux, "P2NaVyWrk5AkG1KE8hTPCT6J0ql0NzLeeII4BF3WarfVjDbekqKu2sQfO7W3OSJKN3cH8w5470csP4LZ+hrkAA==");
		public static VersionSign VER_IOS_3_2_2 { get; } = new VersionSign("3.2.2 [Build: 1536587534]", "iOS", ClientPlatform.Ios, "4rsRo3H9Uw0kui/cQkaBiqYy8ox6/gC6jDUVktcB6I71m1TeqUYy/IYMYbNSBtv0bmKntvcA0ZU79+zoXUkSAg==");
		public static VersionSign VER_AND_3_2_2 { get; } = new VersionSign("3.2.2 [Build: 1536327256]", "Android", ClientPlatform.Android, "dwHJuheBuCMZlUGz2N+DeyoWokK9/ui0CCV6HE4yJ6fqjoyFIyuX9TqXho63tNKXDa0XscL1U4TOaJlgU6pWDQ==");
		public static VersionSign VER_AND_3_2_1 { get; } = new VersionSign("3.2.1 [Build: 1535010120]", "Android", ClientPlatform.Android, "HHlJgd/XKWFdPOR5N4n2hpsjZ3y5b+4f4x1tLk397GI+gcALWlehtQDSaxe2R975/dFcEWmHiFd9zSC3tsecDA==");
		public static VersionSign VER_IOS_3_2_0 { get; } = new VersionSign("3.2.0 [Build: 1534410132]", "iOS", ClientPlatform.Ios, "BIWgZdgGSu6yPwCiEDQuORaLRqV1Z17ZLcxYdLqM2hfWXiKwBOO/j5eH4IH7LGubFfDwdGcVW2RUYKATpaJAAA==");
		public static VersionSign VER_AND_3_2_0 { get; } = new VersionSign("3.2.0 [Build: 1534407950]", "Android", ClientPlatform.Android, "rY2Hhki/5tJZW5YyJI6S9o9zuU4IGFpONwR6JBJ3Q7Pukfj08z2brFwCmGR61RzH8IaoPxoAWXIHQoHp6fUABQ==");
		public static VersionSign VER_WIN_3_2_1 { get; } = new VersionSign("3.2.1 [Build: 1534255236]", "Windows", ClientPlatform.Windows, "RtNOb2UrlXwwy3lplxRilvknygxamwb3eKlRRAsG5YjrMEikStl/Sf+oJgFUFBBMSJ+q+xPx3+xfOmMxAkB8Bg==");
		public static VersionSign VER_MAC_3_2_1 { get; } = new VersionSign("3.2.1 [Build: 1534255236]", "OS X", ClientPlatform.MacOs, "AWbZhd8XH+s7uu5Qkb2QkdDcc9/WXfNu2iKWD+e6m2oTrOmI1Jt55SsyDTvkpBpumnWsrtR/GI2nK9HbmFhGAw==");
		public static VersionSign VER_LIN_3_2_1 { get; } = new VersionSign("3.2.1 [Build: 1534255236]", "Linux", ClientPlatform.Linux, "betw82OYRNjyhXDHmmUKwR6xfvyPHBMdkn+jukQKNG8PPLKOfLFb0OAMXPZxp9n8gio840gFowwA/jnbg/OMBw==");
		public static VersionSign VER_WIN_3_2_0 { get; } = new VersionSign("3.2.0 [Build: 1533739581]", "Windows", ClientPlatform.Windows, "TJ1XoCjQz+VxW15qiGInWf5llTBtVu+2m2ShbY0/HWTM7adLyfThq7wzSgr09Fvowibvu91nOFxTlIpPXCAVAQ==");
		public static VersionSign VER_MAC_3_2_0 { get; } = new VersionSign("3.2.0 [Build: 1533739581]", "OS X", ClientPlatform.MacOs, "WkySbYMiHN22ra3Y1cktHyeNikQ4fZ0K++8brc+8ImYhuzrmuzeGwL+QNaPJNty7stTNCfRUSpDzVAWz5TYQCA==");
		public static VersionSign VER_LIN_3_2_0 { get; } = new VersionSign("3.2.0 [Build: 1533739581]", "Linux", ClientPlatform.Linux, "Vt+iPp952TU4uKwGXY0L61mXgBNfXg+1+16fnS0snPU9fhkfOKzdPN4rBELOwJ5XzZc33KdVC8rzZGYzlQceBg==");
		public static VersionSign VER_WIN_3_1_10 { get; } = new VersionSign("3.1.10 [Build: 1528537615]", "Windows", ClientPlatform.Windows, "+/BWvueikGg4YkO1v2uuZB5vtJJgUZ5bL8cRfxAstfnCVdro2ja+4a+8rGUzDx8/vvTZOUVD6U95hnWb638MCQ==");
		public static VersionSign VER_MAC_3_1_10 { get; } = new VersionSign("3.1.10 [Build: 1528537615]", "OS X", ClientPlatform.MacOs, "AJMF6gyw5DBtzAuW7aA7YcZaLIgOHFappwzWtE+0UUMYgMjMkSZ1LewDaW3YyRDHuLG5Nb7X26VNhFNZu+ohBw==");
		public static VersionSign VER_LIN_3_1_10 { get; } = new VersionSign("3.1.10 [Build: 1528537615]", "Linux", ClientPlatform.Linux, "jEfjYy09JfbJPZ+W3fwqygOu8uuc5raYTGpbJ5F8dHLHpqUfvmCyJVKoXRieMNkmPzeiylsUc9/HiV+8bt8tDw==");
		public static VersionSign VER_WIN_3_1_9 { get; } = new VersionSign("3.1.9 [Build: 1525442084]", "Windows", ClientPlatform.Windows, "2SLjPTFXM9hQyNkeEGYIzs0fkBffyhsh5z+ZuaCcZdDfM8vgRM5lrAU6KNspFjLddcvw8cXw6gxRY73ZHsRVBg==");
		public static VersionSign VER_MAC_3_1_9 { get; } = new VersionSign("3.1.9 [Build: 1525442084]", "OS X", ClientPlatform.MacOs, "WVaMmYPig4eG2JUM8cMMW2MA7+IoRoPUSr74CPe7oS8TLHGjYxPr1FP88op6YsFFQrPJysWmIsnGR7BiFXjHCQ==");
		public static VersionSign VER_LIN_3_1_9 { get; } = new VersionSign("3.1.9 [Build: 1525442084]", "Linux", ClientPlatform.Linux, "wBcnfNU7FA0CvFeisKhywZWzmUqD6IBFbYQTveMvxWowXUjWwNHTg9tbRLQ1YgBFDdlOwV36VMX7aAMXMX2rAA==");
		public static VersionSign VER_IOS_3_1_8 { get; } = new VersionSign("3.1.8 [Build: 1516887927]", "iOS", ClientPlatform.Ios, "pdWyIOpTWECIdA2NExrjqY1a7Q0alFyU7MgiDJYdiUXAspusOHwMIcfKm7oAh+Ty2gcgVgOh8wAPyZcKFKYXBA==");
		public static VersionSign VER_AND_3_1_8 { get; } = new VersionSign("3.1.8 [Build: 1516865456]", "Android", ClientPlatform.Android, "sG/qsKb9iZpBRXFSYY2Tuq7ZLUKHcmgA/6Qe/cx35L3risqoH4aGkPkDicuKtaQi8Ikh4IrQz6xe7V49M+8VBg==");
		public static VersionSign VER_WIN_3_1_8 { get; } = new VersionSign("3.1.8 [Build: 1516614607]", "Windows", ClientPlatform.Windows, "gDEgQf/BiOQZdAheKccM1XWcMUj2OUQqt75oFuvF2c0MQMXyv88cZQdUuckKbcBRp7RpmLInto4PIgd7mPO7BQ==");
		public static VersionSign VER_MAC_3_1_8 { get; } = new VersionSign("3.1.8 [Build: 1516614607]", "OS X", ClientPlatform.MacOs, "93J+FDUbtRjonzFnQpGdgN6+o4jwI2M65zEKftQILCdZlGHGfc7z5Z9+TM6nU0/pnPgTqvKmaw9WYPsh88iCCA==");
		public static VersionSign VER_LIN_3_1_8 { get; } = new VersionSign("3.1.8 [Build: 1516614607]", "Linux", ClientPlatform.Linux, "LJ5q+KWT4KwBX7oR/9j9A12hBrq5ds5ony99f9kepNmqFskhT7gfB51bAJNgAMOzXVCeaItNmc10F2wUNktqCw==");
		public static VersionSign VER_WIN_3_1_7 { get; } = new VersionSign("3.1.7 [Build: 1513163251]", "Windows", ClientPlatform.Windows, "tdNngCAZ1ImAf7BxJzO4RXv5nBRsUERsrSOnMKVUFNQg6BS4Bzag0RFgLVzs2DRj19AC8+q5cXgH+5Ms50mTCA==");
		public static VersionSign VER_MAC_3_1_7 { get; } = new VersionSign("3.1.7 [Build: 1513163251]", "OS X", ClientPlatform.MacOs, "41eIdGPhullYi9ofXewHPXf232ZbepovkYsmR3Kc4CPlA5d/K599m5BZYBYwSz1/YfKvbTzzg0VE0FRbhcZmBQ==");
		public static VersionSign VER_LIN_3_1_7 { get; } = new VersionSign("3.1.7 [Build: 1513163251]", "Linux", ClientPlatform.Linux, "/j5TZqPuOU8yMYPdGehvijYvU74KefRrKO5sgTUrkpeslNFiy4XfU7quKW0diLHQoPQn1t3KArdfzOAMk8dlAg==");
		public static VersionSign VER_AND_3_1_7 { get; } = new VersionSign("3.1.7 [Build: 1512665843]", "Android", ClientPlatform.Android, "J04O7RCgM3ZlecpZz5H8IgWggyCJQB5KG4/MEEB5/mrW6XJEK4J5IpU3jKztkvy54B8Nrj9tbwMaRujZfILSAg==");
		public static VersionSign VER_IOS_3_1_6 { get; } = new VersionSign("3.1.6 [Build: 1502881949]", "iOS", ClientPlatform.Ios, "DXVaZKOza0ivNdKG66VPD/g+TYwio6XmJlCfralcUIpJuh3PI4ZgAnjxzXONzTmgFm0O/rb2iN/vvxIYwhcqAQ==");
		public static VersionSign VER_WIN_3_1_6 { get; } = new VersionSign("3.1.6 [Build: 1502873983]", "Windows", ClientPlatform.Windows, "73fB82Jt1lmIRHKBFaE8h1JKPGFbnt6/yrXOHwTS93Oo7Adx1usY5TzNg+8BKy9nmmA2FEBnRmz5cRfXDghnBA==");
		public static VersionSign VER_MAC_3_1_6 { get; } = new VersionSign("3.1.6 [Build: 1502873983]", "OS X", ClientPlatform.MacOs, "ELteM70OI6OkQ6hjOr1m1ZXxDtOeCI7pqO2ce7+Sw7CoUgKlqxreTKVSlHpD7XfCEuqo3AdNfxWUNAaBci3DDA==");
		public static VersionSign VER_LIN_3_1_6 { get; } = new VersionSign("3.1.6 [Build: 1502873983]", "Linux", ClientPlatform.Linux, "o+l92HKfiUF+THx2rBsuNjj/S1QpxG1fd5o3Q7qtWxkviR3LI3JeWyc26eTmoQoMTgI3jjHV7dCwHsK1BVu6Aw==");
		public static VersionSign VER_AND_3_1_6 { get; } = new VersionSign("3.1.6 [Build: 1502275280]", "Android", ClientPlatform.Android, "sEg1lt9N9lck/Kub6/N6kffI28dEsTrybGLsLc/MeWWfZ/t3EoVwwqCcBxEbUZyszx1htnbnWbd/dYBcrjSCCw==");
		public static VersionSign VER_WIN_3_1_5 { get; } = new VersionSign("3.1.5 [Build: 1500537355]", "Windows", ClientPlatform.Windows, "O9WqHB9oX0qe9AXIYmJm0+mzl6VLxNvrGF0lGlovLaig5MXUIwd6T00NkCj62OkBbzM3eECs9FUuJk7N8V0dCg==");
		public static VersionSign VER_MAC_3_1_5 { get; } = new VersionSign("3.1.5 [Build: 1500537355]", "OS X", ClientPlatform.MacOs, "oiS3ROFEy4r7zhkmCuj4cro2kIwntHNpuTFpFB+zV+AkfwX3Y2F51/JJPWG0J63tPR82n3ot/JiDkJqPKBJpDg==");
		public static VersionSign VER_LIN_3_1_5 { get; } = new VersionSign("3.1.5 [Build: 1500537355]", "Linux", ClientPlatform.Linux, "Ea/9gUeh5HuXyiOZ+gRDPOn0rDHzXDVSYB70qy/BtczJPZn/0dDwQgRAF7/W6vHcaH67j+IF9AtUpuDCA6yzBw==");
		public static VersionSign VER_WIN_3_1_4_2 { get; } = new VersionSign("3.1.4.2 [Build: 1498644101]", "Windows", ClientPlatform.Windows, "WtscrpvJG13kbF6aoVzsGwQuE/WwR1b8++ydDc8IpmiXLw+zFC6zFUvLinOeE0zZgh2Hs5Amp3DZoPJSynOWBg==");
		public static VersionSign VER_MAC_3_1_4_2 { get; } = new VersionSign("3.1.4.2 [Build: 1498644101]", "OS X", ClientPlatform.MacOs, "MMVozpqhiRqPHFu+skm8ftODA2waeWJx2trAx205schgiJMz+H4KOLfoa92Fjrn8kAQZxpA3krUro/iBpJYkBw==");
		public static VersionSign VER_LIN_3_1_4_2 { get; } = new VersionSign("3.1.4.2 [Build: 1498644101]", "Linux", ClientPlatform.Linux, "Rv3SzHDwLIkuUqySQhn279jf2b7PPzCQH2q53zHWH5qyFL/Qw4m/n7ZrXEF46/sUSpOPFPYjfKMKcN/9IRCoCQ==");
		public static VersionSign VER_AND_3_1_3_1 { get; } = new VersionSign("3.1.3.1 [Build: 1493128735]", "Android", ClientPlatform.Android, "Me2oMSfwCsCCGsBtgDTy+TCidslmK66JxQVR2qFsKv0v6izk6o7jzuPIFdL8Fo4rVegdCyuXPbzmOPe9j71YCQ==");
		public static VersionSign VER_WIN_3_1_4 { get; } = new VersionSign("3.1.4 [Build: 1491993378]", "Windows", ClientPlatform.Windows, "rwdyEwnJCzbVfNCqbxMrRyhL5BSYqYSzKQkeZ6m5KImc1F8VB8wEkwwwyxoG7SimC/sxIyy4h27CjBFP6rcgBQ==");
		public static VersionSign VER_MAC_3_1_4 { get; } = new VersionSign("3.1.4 [Build: 1491993378]", "OS X", ClientPlatform.MacOs, "JSg4RcthTCvJUSXTLhrmdPt1592Nk1lG9AuXg+yIyOBL6tlb030+hXniu/QrI2NeNHAMYxTJgZyi+rTnu6sFCQ==");
		public static VersionSign VER_LIN_3_1_4 { get; } = new VersionSign("3.1.4 [Build: 1491993378]", "Linux", ClientPlatform.Linux, "wJPx0S2Q2S8EgSEpZhu+Yp80d6xVQDX5u9DYgm7XxI7sh7gJIoBbdaE5cfjwR2UN6XFyV+V/2AV4stB3CxtgCQ==");
		public static VersionSign VER_IOS_3_1_2 { get; } = new VersionSign("3.1.2 [Build: 1490291439]", "iOS", ClientPlatform.Ios, "mTC8yRgh04oHF3jKleXVy5324ysJKp2LQIUhWh85MXqPTjh9CD0pgiUIoTuCzDQTNutAzRefcLVwniaIhNCnAw==");
		public static VersionSign VER_WIN_3_1_3 { get; } = new VersionSign("3.1.3 [Build: 1490279472]", "Windows", ClientPlatform.Windows, "7RPY2bzJmMdgVX24VuKD3lTnYYb6yHWqfn2x21tFOjXL9q+2t7tU9Vy8Bh5/IpeiqklUHTWc23mWpYOCoW9eCA==");
		public static VersionSign VER_LIN_3_1_3 { get; } = new VersionSign("3.1.3 [Build: 1490279472]", "Linux", ClientPlatform.Linux, "Y1M2TQvKLGmUSP4YPuTBQOeUxmF+jaqazFXuN4v2gOKP8QmxyYOsg9PsG9z7SFYQkgneQxs8QdzC+IGo0bOWBQ==");
		public static VersionSign VER_WIN_3_1_2 { get; } = new VersionSign("3.1.2 [Build: 1489662774]", "Windows", ClientPlatform.Windows, "5Aaj21gGFtrjW9424ezfLa1SMQBpZvgQgcJLZmrLoNMe4XebBPV2s8rxEDAIodfFpruLxLFbFpH63A/BGnJyDw==");
		public static VersionSign VER_MAC_3_1_2 { get; } = new VersionSign("3.1.2 [Build: 1489662774]", "OS X", ClientPlatform.MacOs, "571chpoaq6bxLisThXfiU3zB7pU0NOmH/Qso8ABTR0TXmcK9Y16pYwmPFs/d7fmcHVeI3xSM4dbgzKjRSB61Dg==");
		public static VersionSign VER_LIN_3_1_2 { get; } = new VersionSign("3.1.2 [Build: 1489662774]", "Linux", ClientPlatform.Linux, "W9TgKEviDgWvrQErw8vaoQcPboaUx8xRL5MPoQzlur9eO2yseHgvzkpWGYqSQyCI+ptcCpTHaXRFym0imKnfBA==");
		public static VersionSign VER_WIN_3_1_1_1 { get; } = new VersionSign("3.1.1.1 [Build: 1487668590]", "Windows", ClientPlatform.Windows, "CchjMitGiVGfRlGph0D1mDjOCJCnkVxR/WuYvNHdPyeQUCncRWML8jYxYfnhRF6CzViwYRnsmZkN+W5oenB2CQ==");
		public static VersionSign VER_MAC_3_1_1_1 { get; } = new VersionSign("3.1.1.1 [Build: 1487668590]", "OS X", ClientPlatform.MacOs, "WrETtyinA18FGhiDC458SwfGDozCnM+euEDmCeyC1YgQnfaEC49FtoVAbw2fry/daonzgxmyNBymVHhoUX5iDA==");
		public static VersionSign VER_LIN_3_1_1_1 { get; } = new VersionSign("3.1.1.1 [Build: 1487668590]", "Linux", ClientPlatform.Linux, "0B4RK2WOu5w39+CLznQtaexYeNqqBwU9YHBvSLw3bu+OAne8XtFc2NJzepjynrxwc1/xsmrm8uEZJzqzF+TcAg==");
		public static VersionSign VER_WIN_3_1_1 { get; } = new VersionSign("3.1.1 [Build: 1486712038]", "Windows", ClientPlatform.Windows, "sryyx++NhRWKDAo+Tnwv9N+IrOaQBP0XjjDszY0BBv0YIMr4jmdHtgrwzWkUqhU7kfql7qBWIhlb/r0l1ZHeBw==");
		public static VersionSign VER_LIN_3_1_1 { get; } = new VersionSign("3.1.1 [Build: 1486712038]", "Linux", ClientPlatform.Linux, "umeERdZkG9pS3oeJTirnYK9Q947j8lVlszz2VXBPcjhQrsiKFM6lIkbj3K2HSqA/hJ+sUOcuZgo880PmU6ZdCw==");
		public static VersionSign VER_WIN_3_1_0_1 { get; } = new VersionSign("3.1.0.1 [Build: 1484223040]", "Windows", ClientPlatform.Windows, "oaaorJ4co/sS2m5JT5oRiu9AieW6kfFY+RENqPfp26iP4pbWbf9GcZj+JhDA+/JyLpfueCcSulZSRRbash2JCw==");
		public static VersionSign VER_LIN_3_1_0_1 { get; } = new VersionSign("3.1.0.1 [Build: 1484223040]", "Linux", ClientPlatform.Linux, "xWfxm14Vw53mTMHuzeaIM428KkoI/2wuoR4O2TIuy2Q7ZpwaN48vG0rMJbUQNVycP8rRHg+bIGuFiJai8f5dDg==");
		public static VersionSign VER_AND_3_1_0 { get; } = new VersionSign("3.1.0 [Build: 1481889010]", "Android", ClientPlatform.Android, "eH8svg9XpltTbw+UYkQ4ixfqpbEAhwO9nmDDUWuI11swEU3Ye5HKGlFv70LxHZSgYlEqEH/N1J9U4ygptbPIDg==");
		public static VersionSign VER_WIN_3_1 { get; } = new VersionSign("3.1 [Build: 1481795005]", "Windows", ClientPlatform.Windows, "3TpZZM0V+PKHELFnsfRPoKjEFfvfHUL/6mUP5LHbI3nvmdOjRqEEKi4ndXZG6OpWOKQ3VeadHDH0KBfD8EI2Cg==");
		public static VersionSign VER_LIN_3_1 { get; } = new VersionSign("3.1 [Build: 1481795005]", "Linux", ClientPlatform.Linux, "xpJQcdaIImbctnJw0PnLQOIZBcmN+HDGcjxoIW8So7SSdSYLyUI5lAECWaCewbYmNKqaO85YqXPiNXfOBM5fBA==");
		public static VersionSign VER_IOS_3_1 { get; } = new VersionSign("3.1 [Build: 1481641346]", "iOS", ClientPlatform.Ios, "SDH0QNTA1wDQdfIU0HbcRugD3qkkPHnvlSq/IeW/I4A2myFQnDbzm8ilEGR0vOU4NoTae8CH5XsBmRqwyPIeBA==");
		public static VersionSign VER_WIN_3_0_19_4 { get; } = new VersionSign("3.0.19.4 [Build: 1468491418]", "Windows", ClientPlatform.Windows, "ldWL49uDKC3N9uxdgWRMTOzUuiG1nBqUiOa+Nal5HvdxJiN4fsTnmmPo5tvglN7WqoVoFfuuKuYq1LzodtEtCg==");
		public static VersionSign VER_MAC_3_0_19_4 { get; } = new VersionSign("3.0.19.4 [Build: 1468491418]", "OS X", ClientPlatform.MacOs, "Pvcizdk3HRQMzTLt7goUYBmmS5nbAS1g2E6HIypLU+9eXTqGTBLim0UUtKc0s867TFHbK91GroDrTtv0aMUGAw==");
		public static VersionSign VER_LIN_3_0_19_4 { get; } = new VersionSign("3.0.19.4 [Build: 1468491418]", "Linux", ClientPlatform.Linux, "jvhhk75EV3nCGeewx4Y5zZmiZSN07q5ByKZ9Wlmg85aAbnw7c1jKq5/Iq0zY6dfGwCEwuKod0I5lQcVLf2NTCg==");
		public static VersionSign VER_WIN_3_0_19_3 { get; } = new VersionSign("3.0.19.3 [Build: 1466672534]", "Windows", ClientPlatform.Windows, "a1OYzvM18mrmfUQBUgxYBxYz2DUU6y5k3/mEL6FurzU0y97Bd1FL7+PRpcHyPkg4R+kKAFZ1nhyzbgkGphDWDg==");
		public static VersionSign VER_WIN_3_0_19_2 { get; } = new VersionSign("3.0.19.2 [Build: 1466597785]", "Windows", ClientPlatform.Windows, "sDOzu7rCGb7kBID2WbBk35DjPijKkXzujnsAtLhXxhkQ+am0JlDOpuU1ISHhq9gCl/Qo0dzc723o0AIPI+yoCQ==");
		public static VersionSign VER_WIN_3_0_20 { get; } = new VersionSign("3.0.20 [Build: 1465542546]", "Windows", ClientPlatform.Windows, "vDK31sOwOvDpTXgqAJzmR1NzeUeSDG9dLMgIz5LCX+KpDSVD/qU60mzScz9tuc9AsLyrL8DxHpDDO3eQD+hYCA==");
		public static VersionSign VER_AND_3_0_23 { get; } = new VersionSign("3.0.23 [Build: 1463662487]", "Android", ClientPlatform.Android, "RN+cwFI+jSHJEhggucIuUyEteWNVFy4iw0QDp3qn2UzfopypFVE9BPZqJjBUGeoCN7Q/SfYL4RNIRzJEQaZUCA==");
		public static VersionSign VER_WIN_3_0_19_1 { get; } = new VersionSign("3.0.19.1 [Build: 1461588969]", "Windows", ClientPlatform.Windows, "KYo52MA89dowkYpFU1KixgHngjbJ6F2Yi++5tbaqBlBpz9YikX2gI3sqmU1kP1ghsKCLKM7o0patDH1hv9bmAg==");
		public static VersionSign VER_MAC_3_0_19_1 { get; } = new VersionSign("3.0.19.1 [Build: 1461588969]", "OS X", ClientPlatform.MacOs, "J4cWj2v28tC/8uRqXB1nnAQPfFngOFE/E4Yx7uKMY+Cb8csFrhsJW4J8i+t3dpvZeMJ0BJnB0a/dZ1iL4zh1Dw==");
		public static VersionSign VER_WIN_3_0_19 { get; } = new VersionSign("3.0.19 [Build: 1459504131]", "Windows", ClientPlatform.Windows, "JoHyZHF4k/a3+QH1zPNSEzc40487fzbpssyRZtoWB5kbQorAJgwlpcScA08J4vjGoUbdaTZsT0vCw56wo/Q9Ag==");
		public static VersionSign VER_LIN_3_0_19 { get; } = new VersionSign("3.0.19 [Build: 1459504131]", "Linux", ClientPlatform.Linux, "48s6oiT+4yKVJPsEzbPUZ2L2LqrKJ0bixxVmTFjS5f5EsfDFbD8bl7t3V+OQd84bgN7t8W80B/fjEW45IszpAg==");
		public static VersionSign VER_AND_3_0_21 { get; } = new VersionSign("3.0.21 [Build: 1449476724]", "Android", ClientPlatform.Android, "X/xPOfXLC8ycGeWMlBc5zbyjQdBj7gYFVaSfG95gcZLoNijUaWDkB8DiqBfDvmef2JgmF8YdKTdmwjUm2n5MCw==");
		public static VersionSign VER_AND_3_0_20_2 { get; } = new VersionSign("3.0.20.2 [Build: 1445517273]", "Android", ClientPlatform.Android, "fp6DjpIL/GlTmI3o2QEhwnXUj/pY7OFvZVPbtFBizI2Rloqm+8i0jG8Iwk05ZBn1bDOF6acPzHjBwZgl8CeWAg==");
		public static VersionSign VER_IOS_3_0_18_2 { get; } = new VersionSign("3.0.18.2 [Build: 1445516611]", "iOS", ClientPlatform.Ios, "TEC965pHLJhoiNA2N95xBjQfh2n6uasS3BRFraucFv/+WgAKCKeoUYb3tu6feO5zvTEEiH6YCsedQdhbU1FFCw==");
		public static VersionSign VER_WIN_3_0_18_2 { get; } = new VersionSign("3.0.18.2 [Build: 1445512488]", "Windows", ClientPlatform.Windows, "F0hY25Dtja0wcU6dzC39rNuYbhnDAbIwPHC3VO9Oicf13kUY2I2g6scPZ3p195Cw9gUYdBIRYm8ucHEhtSeWCw==");
		public static VersionSign VER_MAC_3_0_18_2 { get; } = new VersionSign("3.0.18.2 [Build: 1445512488]", "OS X", ClientPlatform.MacOs, "hRZrg1T+25VXJffJoM9hV1qPe90HHrjbuHJM4SOj2QIasS+5bFSgzZ50/zus7Yzj8ZUovPWwn7B7WwdyiU29BQ==");
		public static VersionSign VER_LIN_3_0_18_2 { get; } = new VersionSign("3.0.18.2 [Build: 1445512488]", "Linux", ClientPlatform.Linux, "W9sU8xDfWZ+eQryTdNxXVXM5Ak81wJpYKDLOiJoJUuEXoxcPnKBWpTr5JPrUzheQvkUYUIJf6WzgGAG2B7GYCg==");
		public static VersionSign VER_WIN_3_0_18_1 { get; } = new VersionSign("3.0.18.1 [Build: 1444491275]", "Windows", ClientPlatform.Windows, "xqfa3CUd2GFiTqjJWYzcu9ZbxVVLng8qIMKlVxMqWdiM8JrTRiXBAaTBDd8Xc+flVe+rGSIOZTkXRsz1rqjiAA==");
		public static VersionSign VER_WIN_3_0_18 { get; } = new VersionSign("3.0.18 [Build: 1442998335]", "Windows", ClientPlatform.Windows, "vUgm8mJoeVLBG6qB2HcYF7YNG4D+H/4edILaZbHze2Unua6mrBvNmbtRkRtmRyDZSd7sVQHMApinRDgGT1mUBw==");
		public static VersionSign VER_WIN_3_0_17 { get; } = new VersionSign("3.0.17 [Build: 1438673913]", "Windows", ClientPlatform.Windows, "znDjHvCgmQF/jQKTK49X8tnXqF7AGXfS2XYcogww4XxNTBxp2tf1aFc/jgboKco9EuVa0ku2cf/xg9wW3Cm7AQ==");
		public static VersionSign VER_WIN_3_0_16 { get; } = new VersionSign("3.0.16 [Build: 1407159763]", "Windows", ClientPlatform.Windows, "Y1DuQGXo/8/rYznEGyeQHgpvZMuiCH4FYm4QVyAgLYyMpNpc/LM7XetVWhDQxGsNejkN/2olI7GVJkt4X+ooDg==");
		public static VersionSign VER_MAC_3_0_16 { get; } = new VersionSign("3.0.16 [Build: 1407159763]", "OS X", ClientPlatform.MacOs, "vLAH2cYjkF/3sQCgr/zSmtffXcH2flI2vOnUP3uNIDSm8gKO61Q2hOdQaUzXE1yekLSMx2E9RYz+OQjQ868KAw==");
		public static VersionSign VER_LIN_3_0_16 { get; } = new VersionSign("3.0.16 [Build: 1407159763]", "Linux", ClientPlatform.Linux, "8776GitHAgkFPfOLxEh5x+Luuh4NrYPEJUdsUzNKndcAuWMYjwQTZkmeZOeG/swdn/p2Cg2pRfZfsIFSOAUWCQ==");
		public static VersionSign VER_WIN_3_0_15_1 { get; } = new VersionSign("3.0.15.1 [Build: 1405341092]", "Windows", ClientPlatform.Windows, "b+hr0KQWOVW2WEn49BmNb08R9zimsJcThm2gEeF7EAgRUeUDYzeplh5HrHmda0ftbbnrzWV33U/GOo2LAs/rAg==");
		public static VersionSign VER_WIN_3_0_15 { get; } = new VersionSign("3.0.15 [Build: 1403250090]", "Windows", ClientPlatform.Windows, "FKKAHPwV1swKwH6mqHqdcGuYm8o5mZw4WreBxJrQjOprC3NXXcJviPe0p7EZPI810HOWMfmQRUgFpggoRL8kAQ==");
		public static VersionSign VER_WIN_3_0_14 { get; } = new VersionSign("3.0.14 [Build: 1394624943]", "Windows", ClientPlatform.Windows, "F0WIO9sBVzG893AtX2Jfd98cH6yZPAnfMBNvBlQbAIfvfyiq+cbjZ31AUngEjq7UPIYdnYSsdRX9hczwdBrKAQ==");
		public static VersionSign VER_WIN_3_0_13_1 { get; } = new VersionSign("3.0.13.1 [Build: 1382530211]", "Windows", ClientPlatform.Windows, "bCIfLPUgTM6C0kNkesvhcxaDPvV9h6qLbYVy9cQVSP5lzaYebZaeDzAOOHsdjKcRTa6LU1oHEdz9D/d+2gxJCw==");
		public static VersionSign VER_MAC_3_0_13_1 { get; } = new VersionSign("3.0.13.1 [Build: 1382530211]", "OS X", ClientPlatform.MacOs, "0KNdNcf2zmYUV7JzfKlXdM0Y6/dv9LOlETE8h2mTxq0YitdbZSObUdAJvrdiKX0LH2QP4h3QF2JeXyzjRSQTCw==");
		public static VersionSign VER_AND_3_0_13 { get; } = new VersionSign("3.0.13 [Build: 1380616389]", "Android", ClientPlatform.Android, "04JRo/B0zh54n18a61qWr3qFUrEVQeEiy7dyIEVhCLMwY8QJwk7kwG7GQKSxnr0rmRfTzD7iDXMUWlcwgkc/Cg==");
		public static VersionSign VER_WIN_3_0_13 { get; } = new VersionSign("3.0.13 [Build: 1380283653]", "Windows", ClientPlatform.Windows, "7dA+6EbVyMevol4gE3/Cu1WonRjqu1C6pTWF+txApbaiTgKtZ/ky+NVxluPkSDnCxXN1pOR4uGdF6B7LUqQgDQ==");
		public static VersionSign VER_WIN_3_0_12 { get; } = new VersionSign("3.0.12 [Build: 1378715177]", "Windows", ClientPlatform.Windows, "x6wFA5xqjenf6kbAh36IC4CkrbT8/uSBpgjM9juSt9oxGCXLqHOC2oaYlB1zZSJZjT4sOrnp0M+uOdVjYCzLCg==");
		public static VersionSign VER_WIN_3_0_11_1 { get; } = new VersionSign("3.0.11.1 [Build: 1375773286]", "Windows", ClientPlatform.Windows, "Qfvcn4uQmKETDsD4LbtdbZR8rDetJ26Z/bVbu5SZJjMjGlYEMSbJnR4PtOBshdMSEwEsAJf1G+5tjx+onm2fDA==");
		public static VersionSign VER_MAC_3_0_11_1 { get; } = new VersionSign("3.0.11.1 [Build: 1375773286]", "OS X", ClientPlatform.MacOs, "BngQ1112epNzhND5v7uDdbClbP9dSWczXKxvi1iRQo+xWt7WLYKJu/05MrW/CtPVtKwlT4PnbfI0Trvw+HvUCA==");
		public static VersionSign VER_LIN_3_0_11_1 { get; } = new VersionSign("3.0.11.1 [Build: 1375773286]", "Linux", ClientPlatform.Linux, "JMTTCSHw+ibyhqCDCWRgby/oJ5uAYHk0/QOwqqI5rNHCKTkb+ce6N+4J38WXAnRmtcEaMb0s30s3ipQBokrqDw==");
		public static VersionSign VER_WIN_3_0_11 { get; } = new VersionSign("3.0.11 [Build: 1375083581]", "Windows", ClientPlatform.Windows, "54wPDkfv0kT56UE0lv/LFkFJObH+Q4Irmo4Brfz1EcvjVhj8hJ+RCHcVTZsdKU2XvVvh+VLJpURulEHsAOsyBw==");
		// ReSharper restore InconsistentNaming, UnusedMember.Global
	}

	public enum ClientPlatform
	{
		Other = 0,
		Windows,
		Linux,
		MacOs,
		Android,
		Ios,
	}
}
