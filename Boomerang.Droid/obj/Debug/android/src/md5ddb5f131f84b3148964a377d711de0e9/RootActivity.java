package md5ddb5f131f84b3148964a377d711de0e9;


public class RootActivity
	extends android.support.v7.app.AppCompatActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("Boomerang.Droid.Activities.RootActivity, Boomerang.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", RootActivity.class, __md_methods);
	}


	public RootActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == RootActivity.class)
			mono.android.TypeManager.Activate ("Boomerang.Droid.Activities.RootActivity, Boomerang.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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
