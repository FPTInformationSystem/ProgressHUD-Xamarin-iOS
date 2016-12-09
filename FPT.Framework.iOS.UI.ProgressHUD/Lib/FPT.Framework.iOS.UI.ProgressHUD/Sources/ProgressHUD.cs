using System;
using MBProgressHUDBinding;
using UIKit;

namespace FPT.Framework.iOS.UI
{
	public static class ProgressHUD
	{
		static MBProgressHUD ShowHUDAddedTo(UIView view, bool animated)
		{
			return MBProgressHUD.ShowHUDAddedTo(view, animated);
		}

		static bool HideHUDForView(UIView view, bool animated)
		{
			return MBProgressHUD.HideHUDForView(view, animated);
		}

		static MBProgressHUD HUDForView(UIView view)
		{
			return MBProgressHUD.HUDForView(view);
		}


	}
}
