using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Flask.Colorpicker.Builder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.flask.colorpicker.builder']/class[@name='ColorWheelRendererBuilder']"
	[global::Android.Runtime.Register ("com/flask/colorpicker/builder/ColorWheelRendererBuilder", DoNotGenerateAcw=true)]
	public partial class ColorWheelRendererBuilder : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/flask/colorpicker/builder/ColorWheelRendererBuilder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ColorWheelRendererBuilder); }
		}

		protected ColorWheelRendererBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.flask.colorpicker.builder']/class[@name='ColorWheelRendererBuilder']/constructor[@name='ColorWheelRendererBuilder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ColorWheelRendererBuilder ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ColorWheelRendererBuilder)) {
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

		static IntPtr id_getRenderer_Lcom_flask_colorpicker_ColorPickerView_WHEEL_TYPE_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.builder']/class[@name='ColorWheelRendererBuilder']/method[@name='getRenderer' and count(parameter)=1 and parameter[1][@type='com.flask.colorpicker.ColorPickerView.WHEEL_TYPE']]"
		[Register ("getRenderer", "(Lcom/flask/colorpicker/ColorPickerView$WHEEL_TYPE;)Lcom/flask/colorpicker/renderer/ColorWheelRenderer;", "")]
		public static unsafe global::Com.Flask.Colorpicker.Renderer.IColorWheelRenderer GetRenderer (global::Com.Flask.Colorpicker.ColorPickerView.WHEEL_TYPE p0)
		{
			if (id_getRenderer_Lcom_flask_colorpicker_ColorPickerView_WHEEL_TYPE_ == IntPtr.Zero)
				id_getRenderer_Lcom_flask_colorpicker_ColorPickerView_WHEEL_TYPE_ = JNIEnv.GetStaticMethodID (class_ref, "getRenderer", "(Lcom/flask/colorpicker/ColorPickerView$WHEEL_TYPE;)Lcom/flask/colorpicker/renderer/ColorWheelRenderer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Flask.Colorpicker.Renderer.IColorWheelRenderer __ret = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Renderer.IColorWheelRenderer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getRenderer_Lcom_flask_colorpicker_ColorPickerView_WHEEL_TYPE_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
