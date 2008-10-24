using MObjc;
using System;

namespace MCocoa
{
	[Register]
	public partial class CIImage : NSObject
	{
		public CIImage(IntPtr instance) : base(instance)
		{
		}

		public CIImage(Untyped instance) : base(instance)
		{
		}
		
		// TODO: missing a lot of methods
	}
}
