using System;
using ObjCRuntime;
using Foundation;

namespace MBProgressHUDBinding
{
	
	[Native]
	public enum MBProgressHUDMode : long
	{
		Indeterminate,
		Determinate,
		DeterminateHorizontalBar,
		AnnularDeterminate,
		CustomView,
		Text
	}

	[Native]
	public enum MBProgressHUDAnimation : long
	{
		Fade,
		Zoom,
		ZoomOut,
		ZoomIn
	}

	[Native]
	public enum MBProgressHUDBackgroundStyle : long
	{
		SolidColor,
		Blur
	}

}
