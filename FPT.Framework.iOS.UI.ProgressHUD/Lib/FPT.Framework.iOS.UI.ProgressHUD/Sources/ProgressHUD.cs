using System;
using MBProgressHUDBinding;
using UIKit;

namespace FPT.Framework.iOS.UI
{
	public static class ProgressHUD
	{
		public static MBProgressHUD ShowHUDAddedTo(UIView view, bool animated)
		{
			return MBProgressHUD.ShowHUDAddedTo(view, animated);
		}

		public static bool HideHUDForView(UIView view, bool animated)
		{
			return MBProgressHUD.HideHUDForView(view, animated);
		}

		public static MBProgressHUD HUDForView(UIView view)
		{
			return MBProgressHUD.HUDForView(view);
		}

	}
}
