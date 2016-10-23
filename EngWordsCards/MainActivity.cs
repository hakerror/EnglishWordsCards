using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace EngWordsCards
{
	[Activity(Label = "EngWordsCards", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			//Button button = FindViewById<Button>(Resource.Id.myButton);
			Button newCardButton = FindViewById<Button>(Resource.Id.newCardButton);
			Button learnButton = FindViewById<Button>(Resource.Id.learnButton);
			Button aboutButton = FindViewById<Button>(Resource.Id.aboutButton);

			aboutButton.Click += (sender, e) => {
				var aboutIntent = new Intent(this, typeof(AboutActivity));
				StartActivity(aboutIntent);
			};

			learnButton.Click += (sender, e) => {
				StartActivity(typeof(LearnActivity));
			};
		}
	}
}

