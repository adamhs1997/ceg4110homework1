using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Flask.Colorpicker.Renderer {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.flask.colorpicker.renderer']/class[@name='SimpleColorWheelRenderer']"
	[global::Android.Runtime.Register ("com/flask/colorpicker/renderer/SimpleColorWheelRenderer", DoNotGenerateAcw=true)]
	public partial class SimpleColorWheelRenderer : global::Com.Flask.Colorpicker.Renderer.AbsColorWheelRenderer {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/flask/colorpicker/renderer/SimpleColorWheelRenderer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SimpleColorWheelRenderer); }
		}

		protected SimpleColorWheelRenderer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.flask.colorpicker.renderer']/class[@name='SimpleColorWheelRenderer']/constructor[@name='SimpleColorWheelRenderer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SimpleColorWheelRenderer ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (SimpleColorWheelRenderer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_draw;
#pragma warning disable 0169
		static Delegate GetDrawHandler ()
		{
			if (cb_draw == null)
				cb_draw = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Draw);
			return cb_draw;
		}

		static void n_Draw (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Flask.Colorpicker.Renderer.SimpleColorWheelRenderer __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Renderer.SimpleColorWheelRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Draw ();
		}
#pragma warning restore 0169

		static IntPtr id_draw;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.renderer']/class[@name='SimpleColorWheelRenderer']/method[@name='draw' and count(parameter)=0]"
		[Register ("draw", "()V", "GetDrawHandler")]
		public override unsafe void Draw ()
		{
			if (id_draw == IntPtr.Zero)
				id_draw = JNIEnv.GetMethodID (class_ref, "draw", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_draw);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "draw", "()V"));
			} finally {
			}
		}

	}
}
