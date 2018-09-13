package mono.com.flask.colorpicker;


public class OnColorChangedListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.flask.colorpicker.OnColorChangedListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onColorChanged:(I)V:GetOnColorChanged_IHandler:Com.Flask.Colorpicker.IOnColorChangedListenerInvoker, ClassLibrary1\n" +
			"";
		mono.android.Runtime.register ("Com.Flask.Colorpicker.IOnColorChangedListenerImplementor, ClassLibrary1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", OnColorChangedListenerImplementor.class, __md_methods);
	}


	public OnColorChangedListenerImplementor ()
	{
		super ();
		if (getClass () == OnColorChangedListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Flask.Colorpicker.IOnColorChangedListenerImplementor, ClassLibrary1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onColorChanged (int p0)
	{
		n_onColorChanged (p0);
	}

	private native void n_onColorChanged (int p0);

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
