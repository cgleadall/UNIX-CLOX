// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace UNIXCLOX.iOS
{
	[Register ("FirstViewController")]
	partial class FirstViewController
	{
		[Outlet]
		MonoTouch.UIKit.UILabel CurrentUnixTimeLabel { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel CurrentUTCHumanTimeLabel { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel CurrentLocalHumanTimeLabel { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton GetCurrentTimeButton { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField ConversionUnixTimeEdit { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField ConversionHumanTimeEdit { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (CurrentUnixTimeLabel != null) {
				CurrentUnixTimeLabel.Dispose ();
				CurrentUnixTimeLabel = null;
			}

			if (CurrentUTCHumanTimeLabel != null) {
				CurrentUTCHumanTimeLabel.Dispose ();
				CurrentUTCHumanTimeLabel = null;
			}

			if (CurrentLocalHumanTimeLabel != null) {
				CurrentLocalHumanTimeLabel.Dispose ();
				CurrentLocalHumanTimeLabel = null;
			}

			if (GetCurrentTimeButton != null) {
				GetCurrentTimeButton.Dispose ();
				GetCurrentTimeButton = null;
			}

			if (ConversionUnixTimeEdit != null) {
				ConversionUnixTimeEdit.Dispose ();
				ConversionUnixTimeEdit = null;
			}

			if (ConversionHumanTimeEdit != null) {
				ConversionHumanTimeEdit.Dispose ();
				ConversionHumanTimeEdit = null;
			}
		}
	}
}
