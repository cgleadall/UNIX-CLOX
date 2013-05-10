using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace UNIXCLOX.iOS
{
    public partial class FirstViewController : UIViewController
    {
        public FirstViewController() : base ("FirstViewController", null)
        {
            Title = NSBundle.MainBundle.LocalizedString("First", "First");
            TabBarItem.Image = UIImage.FromBundle("first");
        }

        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();
			
            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
			
            // Perform any additional setup after loading the view, typically from a nib.

            SetCurrentTimeLabels(DateTime.Now);

        var timeUpdate = new System.Threading.Tasks.Task(()=>{
                while(true){
                    var timeNow = DateTime.Now;
                    var sleeptime = 995 - timeNow.Millisecond;
                    InvokeOnMainThread(()=>{
                        ConversionHumanTimeEdit.Text = String.Format("{0}", sleeptime);
                    });
                    System.Threading.Thread.Sleep(sleeptime > 0 ?sleeptime : 5);
                    SetCurrentTimeLabels(DateTime.Now);
                }
            });

            timeUpdate.Start();

        }

        private  void SetCurrentTimeLabels(DateTime value)
        {
            InvokeOnMainThread(()=>{
                CurrentLocalHumanTimeLabel.Text = String.Format("{0}", value.ToString("yyyy-MM-dd HH:mm:ss"));
                CurrentUTCHumanTimeLabel.Text = String.Format("{0}", value.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss"));
                CurrentUnixTimeLabel.Text = String.Format("{0}", (long)(value.ToUniversalTime() - new DateTime(1970, 1, 1)).TotalSeconds);
            });
        }

        public override bool ShouldAutorotateToInterfaceOrientation(UIInterfaceOrientation toInterfaceOrientation)
        {
            // Return true for supported orientations
            return (toInterfaceOrientation != UIInterfaceOrientation.PortraitUpsideDown);
        }
    }
}

