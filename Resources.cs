using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace MicroAuto_6._0.Properties
{
	// Token: 0x02000021 RID: 33
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x06000198 RID: 408 RVA: 0x00014EBC File Offset: 0x000130BC
		internal Resources()
		{
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000199 RID: 409 RVA: 0x00014ED0 File Offset: 0x000130D0
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				int num = 2;
				for (;;)
				{
					switch (num)
					{
					case 0:
						goto IL_6F;
					case 1:
					{
						ResourceManager resourceManager = new ResourceManager("MicroAuto_6._0.Properties.Resources", typeof(Resources).Assembly);
						Resources.a = resourceManager;
						num = 0;
						continue;
					}
					}
					if (true)
					{
					}
					if (!object.ReferenceEquals(Resources.a, null))
					{
						break;
					}
					num = 1;
				}
				IL_6F:
				return Resources.a;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600019A RID: 410 RVA: 0x00014F54 File Offset: 0x00013154
		// (set) Token: 0x0600019B RID: 411 RVA: 0x00014F68 File Offset: 0x00013168
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.b;
			}
			set
			{
				Resources.b = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600019C RID: 412 RVA: 0x00014F7C File Offset: 0x0001317C
		internal static Icon dragon
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("dragon", Resources.b);
				return (Icon)@object;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600019D RID: 413 RVA: 0x00014FA4 File Offset: 0x000131A4
		internal static Icon dragonPause
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("dragonPause", Resources.b);
				return (Icon)@object;
			}
		}

		// Token: 0x04000113 RID: 275
		private static ResourceManager a;

		// Token: 0x04000114 RID: 276
		private static CultureInfo b;
	}
}
