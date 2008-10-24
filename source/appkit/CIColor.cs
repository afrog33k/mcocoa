using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class CIColor : NSObject
	{
		public CIColor(IntPtr instance) : base(instance)
		{
		}

		public CIColor(Untyped instance) : base(instance)
		{
		}
		
		// TODO: missing a lot of methods
	}
}
