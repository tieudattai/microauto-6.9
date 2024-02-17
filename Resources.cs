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
	// Token: 0x02000020 RID: 32
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x06000194 RID: 404 RVA: 0x00002CD0 File Offset: 0x00000ED0
		internal Resources()
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000195 RID: 405 RVA: 0x0000ED54 File Offset: 0x0000CF54
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (object.ReferenceEquals(Resources.resourceManager_0, null))
				{
					ResourceManager resourceManager = new ResourceManager("MicroAuto_6._0.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceManager_0 = resourceManager;
				}
				return Resources.resourceManager_0;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000196 RID: 406 RVA: 0x00003D4D File Offset: 0x00001F4D
		// (set) Token: 0x06000197 RID: 407 RVA: 0x00003D54 File Offset: 0x00001F54
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.cultureInfo_0;
			}
			set
			{
				Resources.cultureInfo_0 = value;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000198 RID: 408 RVA: 0x0000ED94 File Offset: 0x0000CF94
		internal static Icon dragon
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("dragon", Resources.cultureInfo_0);
				return (Icon)@object;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000199 RID: 409 RVA: 0x0000EDBC File Offset: 0x0000CFBC
		internal static Icon dragonPause
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("dragonPause", Resources.cultureInfo_0);
				return (Icon)@object;
			}
		}

		// Token: 0x04000110 RID: 272
		private static ResourceManager resourceManager_0;

		// Token: 0x04000111 RID: 273
		private static CultureInfo cultureInfo_0;
	}
}
