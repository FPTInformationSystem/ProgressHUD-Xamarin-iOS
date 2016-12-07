using System;
using ObjCRuntime;

[Native]
public enum MBProgressHUDMode : nint
{
	Indeterminate,
	Determinate,
	DeterminateHorizontalBar,
	AnnularDeterminate,
	CustomView,
	Text
}

[Native]
public enum MBProgressHUDAnimation : nint
{
	Fade,
	Zoom,
	ZoomOut,
	ZoomIn
}

[Native]
public enum MBProgressHUDBackgroundStyle : nint
{
	SolidColor,
	Blur
}
