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

            // Perform any additional setup after loading the view, typically from a nib.
            CalculateButton.TouchUpInside += delegate {

                var people = int.Parse(PeopleEntry.Text);
                var pizzas = people / 3;
                PizzaCountLabel.Text = pizzas.ToString();
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
