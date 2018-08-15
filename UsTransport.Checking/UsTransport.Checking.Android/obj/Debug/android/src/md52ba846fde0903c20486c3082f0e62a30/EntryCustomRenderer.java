package md52ba846fde0903c20486c3082f0e62a30;


public class EntryCustomRenderer
	extends md51558244f76c53b6aeda52c8a337f2c37.EntryRenderer
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("UsTransport.Checking.Droid.Renderers.EntryCustomRenderer, UsTransport.Checking.Android", EntryCustomRenderer.class, __md_methods);
	}


	public EntryCustomRenderer (android.content.Context p0)
	{
		super (p0);
		if (getClass () == EntryCustomRenderer.class)
			mono.android.TypeManager.Activate ("UsTransport.Checking.Droid.Renderers.EntryCustomRenderer, UsTransport.Checking.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public EntryCustomRenderer (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == EntryCustomRenderer.class)
			mono.android.TypeManager.Activate ("UsTransport.Checking.Droid.Renderers.EntryCustomRenderer, UsTransport.Checking.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public EntryCustomRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == EntryCustomRenderer.class)
			mono.android.TypeManager.Activate ("UsTransport.Checking.Droid.Renderers.EntryCustomRenderer, UsTransport.Checking.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
