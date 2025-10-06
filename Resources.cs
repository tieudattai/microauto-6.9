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
	
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		
		internal Resources()
		{
		}

		
		
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

		
		
		internal static Icon dragon
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("dragon", Resources.cultureInfo_0);
				return (Icon)@object;
			}
		}

		
		
		internal static Icon dragonPause
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("dragonPause", Resources.cultureInfo_0);
				return (Icon)@object;
			}
		}

		
		private static ResourceManager resourceManager_0;

		
		private static CultureInfo cultureInfo_0;
	}
}
