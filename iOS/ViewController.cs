using System;

using UIKit;

namespace PizzaCalculator.iOS
{
    public partial class ViewController : UIViewController
    {
        int count = 1;

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            var PizzaCalculatorService = new PizzaCalculatorService();

            // Perform any additional setup after loading the view, typically from a nib.
            CalculateButton.TouchUpInside += delegate {
                PizzaCountLabel.Text = PizzaCalculatorService.Calculate(PeopleEntry.Text);
                PeopleEntry.ResignFirstResponder();
	        };
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.		
        }
    }
}
