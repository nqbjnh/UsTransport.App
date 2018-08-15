using Android.Content;
using UsTransport.Checking.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Entry),typeof(EntryCustomRenderer))]
namespace UsTransport.Checking.Droid.Renderers
{
    public class EntryCustomRenderer:EntryRenderer
    {
        public EntryCustomRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.SetHintTextColor(global::Android.Graphics.Color.LightGray);
            }
        }
    }
}