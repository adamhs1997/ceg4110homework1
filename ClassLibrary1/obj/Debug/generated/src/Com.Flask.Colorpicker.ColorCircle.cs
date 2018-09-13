using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Flask.Colorpicker {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorCircle']"
	[global::Android.Runtime.Register ("com/flask/colorpicker/ColorCircle", DoNotGenerateAcw=true)]
	public partial class ColorCircle : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/flask/colorpicker/ColorCircle", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ColorCircle); }
		}

		protected ColorCircle (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_FFarrayF;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorCircle']/constructor[@name='ColorCircle' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float[]']]"
		[Register (".ctor", "(FF[F)V", "")]
		public unsafe ColorCircle (float p0, float p1, float[] p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				if (((object) this).GetType () != typeof (ColorCircle)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(FF[F)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(FF[F)V", __args);
					return;
				}

				if (id_ctor_FFarrayF == IntPtr.Zero)
					id_ctor_FFarrayF = JNIEnv.GetMethodID (class_ref, "<init>", "(FF[F)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_FFarrayF, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_FFarrayF, __args);
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static Delegate cb_getColor;
#pragma warning disable 0169
		static Delegate GetGetColorHandler ()
		{
			if (cb_getColor == null)
				cb_getColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetColor);
			return cb_getColor;
		}

		static int n_GetColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Flask.Colorpicker.ColorCircle __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.ColorCircle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Color;
		}
#pragma warning restore 0169

		static IntPtr id_getColor;
		public virtual unsafe int Color {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorCircle']/method[@name='getColor' and count(parameter)=0]"
			[Register ("getColor", "()I", "GetGetColorHandler")]
			get {
				if (id_getColor == IntPtr.Zero)
					id_getColor = JNIEnv.GetMethodID (class_ref, "getColor", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getColor);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getColor", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getHsv;
#pragma warning disable 0169
		static Delegate GetGetHsvHandler ()
		{
			if (cb_getHsv == null)
				cb_getHsv = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHsv);
			return cb_getHsv;
		}

		static IntPtr n_GetHsv (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Flask.Colorpicker.ColorCircle __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.ColorCircle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetHsv ());
		}
#pragma warning restore 0169

		static IntPtr id_getHsv;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorCircle']/method[@name='getHsv' and count(parameter)=0]"
		[Register ("getHsv", "()[F", "GetGetHsvHandler")]
		public virtual unsafe float[] GetHsv ()
		{
			if (id_getHsv == IntPtr.Zero)
				id_getHsv = JNIEnv.GetMethodID (class_ref, "getHsv", "()[F");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (float[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHsv), JniHandleOwnership.TransferLocalRef, typeof (float));
				else
					return (float[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHsv", "()[F")), JniHandleOwnership.TransferLocalRef, typeof (float));
			} finally {
			}
		}

		static Delegate cb_getHsvWithLightness_F;
#pragma warning disable 0169
		static Delegate GetGetHsvWithLightness_FHandler ()
		{
			if (cb_getHsvWithLightness_F == null)
				cb_getHsvWithLightness_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_GetHsvWithLightness_F);
			return cb_getHsvWithLightness_F;
		}

		static IntPtr n_GetHsvWithLightness_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Flask.Colorpicker.ColorCircle __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.ColorCircle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetHsvWithLightness (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getHsvWithLightness_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorCircle']/method[@name='getHsvWithLightness' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("getHsvWithLightness", "(F)[F", "GetGetHsvWithLightness_FHandler")]
		public virtual unsafe float[] GetHsvWithLightness (float p0)
		{
			if (id_getHsvWithLightness_F == IntPtr.Zero)
				id_getHsvWithLightness_F = JNIEnv.GetMethodID (class_ref, "getHsvWithLightness", "(F)[F");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return (float[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHsvWithLightness_F, __args), JniHandleOwnership.TransferLocalRef, typeof (float));
				else
					return (float[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHsvWithLightness", "(F)[F"), __args), JniHandleOwnership.TransferLocalRef, typeof (float));
			} finally {
			}
		}

		static Delegate cb_getX;
#pragma warning disable 0169
		static Delegate GetGetXHandler ()
		{
			if (cb_getX == null)
				cb_getX = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetX);
			return cb_getX;
		}

		static float n_GetX (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Flask.Colorpicker.ColorCircle __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.ColorCircle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetX ();
		}
#pragma warning restore 0169

		static IntPtr id_getX;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorCircle']/method[@name='getX' and count(parameter)=0]"
		[Register ("getX", "()F", "GetGetXHandler")]
		public virtual unsafe float GetX ()
		{
			if (id_getX == IntPtr.Zero)
				id_getX = JNIEnv.GetMethodID (class_ref, "getX", "()F");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getX);
				else
					return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getX", "()F"));
			} finally {
			}
		}

		static Delegate cb_getY;
#pragma warning disable 0169
		static Delegate GetGetYHandler ()
		{
			if (cb_getY == null)
				cb_getY = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetY);
			return cb_getY;
		}

		static float n_GetY (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Flask.Colorpicker.ColorCircle __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.ColorCircle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetY ();
		}
#pragma warning restore 0169

		static IntPtr id_getY;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorCircle']/method[@name='getY' and count(parameter)=0]"
		[Register ("getY", "()F", "GetGetYHandler")]
		public virtual unsafe float GetY ()
		{
			if (id_getY == IntPtr.Zero)
				id_getY = JNIEnv.GetMethodID (class_ref, "getY", "()F");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getY);
				else
					return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getY", "()F"));
			} finally {
			}
		}

		static Delegate cb_set_FFarrayF;
#pragma warning disable 0169
		static Delegate GetSet_FFarrayFHandler ()
		{
			if (cb_set_FFarrayF == null)
				cb_set_FFarrayF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float, IntPtr>) n_Set_FFarrayF);
			return cb_set_FFarrayF;
		}

		static void n_Set_FFarrayF (IntPtr jnienv, IntPtr native__this, float p0, float p1, IntPtr native_p2)
		{
			global::Com.Flask.Colorpicker.ColorCircle __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.ColorCircle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] p2 = (float[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (float));
			__this.Set (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		static IntPtr id_set_FFarrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorCircle']/method[@name='set' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float[]']]"
		[Register ("set", "(FF[F)V", "GetSet_FFarrayFHandler")]
		public virtual unsafe void Set (float p0, float p1, float[] p2)
		{
			if (id_set_FFarrayF == IntPtr.Zero)
				id_set_FFarrayF = JNIEnv.GetMethodID (class_ref, "set", "(FF[F)V");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_set_FFarrayF, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set", "(FF[F)V"), __args);
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static Delegate cb_sqDist_FF;
#pragma warning disable 0169
		static Delegate GetSqDist_FFHandler ()
		{
			if (cb_sqDist_FF == null)
				cb_sqDist_FF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float, double>) n_SqDist_FF);
			return cb_sqDist_FF;
		}

		static double n_SqDist_FF (IntPtr jnienv, IntPtr native__this, float p0, float p1)
		{
			global::Com.Flask.Colorpicker.ColorCircle __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.ColorCircle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SqDist (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_sqDist_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorCircle']/method[@name='sqDist' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("sqDist", "(FF)D", "GetSqDist_FFHandler")]
		public virtual unsafe double SqDist (float p0, float p1)
		{
			if (id_sqDist_FF == IntPtr.Zero)
				id_sqDist_FF = JNIEnv.GetMethodID (class_ref, "sqDist", "(FF)D");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_sqDist_FF, __args);
				else
					return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sqDist", "(FF)D"), __args);
			} finally {
			}
		}

	}
}
