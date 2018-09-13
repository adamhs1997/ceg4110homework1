using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Flask.Colorpicker {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='Utils']"
	[global::Android.Runtime.Register ("com/flask/colorpicker/Utils", DoNotGenerateAcw=true)]
	public partial class Utils : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/flask/colorpicker/Utils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Utils); }
		}

		protected Utils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='Utils']/constructor[@name='Utils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Utils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Utils)) {
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

		static IntPtr id_adjustAlpha_FI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='Utils']/method[@name='adjustAlpha' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='int']]"
		[Register ("adjustAlpha", "(FI)I", "")]
		public static unsafe int AdjustAlpha (float p0, int p1)
		{
			if (id_adjustAlpha_FI == IntPtr.Zero)
				id_adjustAlpha_FI = JNIEnv.GetStaticMethodID (class_ref, "adjustAlpha", "(FI)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_adjustAlpha_FI, __args);
			} finally {
			}
		}

		static IntPtr id_alphaValueAsInt_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='Utils']/method[@name='alphaValueAsInt' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("alphaValueAsInt", "(F)I", "")]
		public static unsafe int AlphaValueAsInt (float p0)
		{
			if (id_alphaValueAsInt_F == IntPtr.Zero)
				id_alphaValueAsInt_F = JNIEnv.GetStaticMethodID (class_ref, "alphaValueAsInt", "(F)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_alphaValueAsInt_F, __args);
			} finally {
			}
		}

		static IntPtr id_colorAtLightness_IF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='Utils']/method[@name='colorAtLightness' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='float']]"
		[Register ("colorAtLightness", "(IF)I", "")]
		public static unsafe int ColorAtLightness (int p0, float p1)
		{
			if (id_colorAtLightness_IF == IntPtr.Zero)
				id_colorAtLightness_IF = JNIEnv.GetStaticMethodID (class_ref, "colorAtLightness", "(IF)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_colorAtLightness_IF, __args);
			} finally {
			}
		}

		static IntPtr id_getAlphaPercent_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='Utils']/method[@name='getAlphaPercent' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getAlphaPercent", "(I)F", "")]
		public static unsafe float GetAlphaPercent (int p0)
		{
			if (id_getAlphaPercent_I == IntPtr.Zero)
				id_getAlphaPercent_I = JNIEnv.GetStaticMethodID (class_ref, "getAlphaPercent", "(I)F");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticFloatMethod  (class_ref, id_getAlphaPercent_I, __args);
			} finally {
			}
		}

		static IntPtr id_getHexString_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='Utils']/method[@name='getHexString' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("getHexString", "(IZ)Ljava/lang/String;", "")]
		public static unsafe string GetHexString (int p0, bool p1)
		{
			if (id_getHexString_IZ == IntPtr.Zero)
				id_getHexString_IZ = JNIEnv.GetStaticMethodID (class_ref, "getHexString", "(IZ)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getHexString_IZ, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_lightnessOfColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='Utils']/method[@name='lightnessOfColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("lightnessOfColor", "(I)F", "")]
		public static unsafe float LightnessOfColor (int p0)
		{
			if (id_lightnessOfColor_I == IntPtr.Zero)
				id_lightnessOfColor_I = JNIEnv.GetStaticMethodID (class_ref, "lightnessOfColor", "(I)F");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticFloatMethod  (class_ref, id_lightnessOfColor_I, __args);
			} finally {
			}
		}

	}
}
