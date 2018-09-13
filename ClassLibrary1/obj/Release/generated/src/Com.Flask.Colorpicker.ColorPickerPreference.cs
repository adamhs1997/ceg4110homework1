using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Flask.Colorpicker {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerPreference']"
	[global::Android.Runtime.Register ("com/flask/colorpicker/ColorPickerPreference", DoNotGenerateAcw=true)]
	public partial class ColorPickerPreference : global::Android.Preferences.Preference {


		static IntPtr alphaSlider_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerPreference']/field[@name='alphaSlider']"
		[Register ("alphaSlider")]
		protected bool AlphaSlider {
			get {
				if (alphaSlider_jfieldId == IntPtr.Zero)
					alphaSlider_jfieldId = JNIEnv.GetFieldID (class_ref, "alphaSlider", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, alphaSlider_jfieldId);
			}
			set {
				if (alphaSlider_jfieldId == IntPtr.Zero)
					alphaSlider_jfieldId = JNIEnv.GetFieldID (class_ref, "alphaSlider", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, alphaSlider_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr colorIndicator_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerPreference']/field[@name='colorIndicator']"
		[Register ("colorIndicator")]
		protected global::Android.Widget.ImageView ColorIndicator {
			get {
				if (colorIndicator_jfieldId == IntPtr.Zero)
					colorIndicator_jfieldId = JNIEnv.GetFieldID (class_ref, "colorIndicator", "Landroid/widget/ImageView;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, colorIndicator_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.ImageView> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (colorIndicator_jfieldId == IntPtr.Zero)
					colorIndicator_jfieldId = JNIEnv.GetFieldID (class_ref, "colorIndicator", "Landroid/widget/ImageView;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, colorIndicator_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr density_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerPreference']/field[@name='density']"
		[Register ("density")]
		protected int Density {
			get {
				if (density_jfieldId == IntPtr.Zero)
					density_jfieldId = JNIEnv.GetFieldID (class_ref, "density", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, density_jfieldId);
			}
			set {
				if (density_jfieldId == IntPtr.Zero)
					density_jfieldId = JNIEnv.GetFieldID (class_ref, "density", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, density_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr lightSlider_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerPreference']/field[@name='lightSlider']"
		[Register ("lightSlider")]
		protected bool LightSlider {
			get {
				if (lightSlider_jfieldId == IntPtr.Zero)
					lightSlider_jfieldId = JNIEnv.GetFieldID (class_ref, "lightSlider", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, lightSlider_jfieldId);
			}
			set {
				if (lightSlider_jfieldId == IntPtr.Zero)
					lightSlider_jfieldId = JNIEnv.GetFieldID (class_ref, "lightSlider", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, lightSlider_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr selectedColor_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerPreference']/field[@name='selectedColor']"
		[Register ("selectedColor")]
		protected int SelectedColor {
			get {
				if (selectedColor_jfieldId == IntPtr.Zero)
					selectedColor_jfieldId = JNIEnv.GetFieldID (class_ref, "selectedColor", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, selectedColor_jfieldId);
			}
			set {
				if (selectedColor_jfieldId == IntPtr.Zero)
					selectedColor_jfieldId = JNIEnv.GetFieldID (class_ref, "selectedColor", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, selectedColor_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr wheelType_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerPreference']/field[@name='wheelType']"
		[Register ("wheelType")]
		protected global::Com.Flask.Colorpicker.ColorPickerView.WHEEL_TYPE WheelType {
			get {
				if (wheelType_jfieldId == IntPtr.Zero)
					wheelType_jfieldId = JNIEnv.GetFieldID (class_ref, "wheelType", "Lcom/flask/colorpicker/ColorPickerView$WHEEL_TYPE;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, wheelType_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.ColorPickerView.WHEEL_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (wheelType_jfieldId == IntPtr.Zero)
					wheelType_jfieldId = JNIEnv.GetFieldID (class_ref, "wheelType", "Lcom/flask/colorpicker/ColorPickerView$WHEEL_TYPE;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, wheelType_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/flask/colorpicker/ColorPickerPreference", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ColorPickerPreference); }
		}

		protected ColorPickerPreference (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerPreference']/constructor[@name='ColorPickerPreference' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe ColorPickerPreference (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (ColorPickerPreference)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerPreference']/constructor[@name='ColorPickerPreference' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe ColorPickerPreference (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (ColorPickerPreference)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerPreference']/constructor[@name='ColorPickerPreference' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe ColorPickerPreference (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (ColorPickerPreference)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_darken_IF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerPreference']/method[@name='darken' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='float']]"
		[Register ("darken", "(IF)I", "")]
		public static unsafe int Darken (int p0, float p1)
		{
			if (id_darken_IF == IntPtr.Zero)
				id_darken_IF = JNIEnv.GetStaticMethodID (class_ref, "darken", "(IF)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_darken_IF, __args);
			} finally {
			}
		}

		static Delegate cb_setValue_I;
#pragma warning disable 0169
		static Delegate GetSetValue_IHandler ()
		{
			if (cb_setValue_I == null)
				cb_setValue_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetValue_I);
			return cb_setValue_I;
		}

		static void n_SetValue_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Flask.Colorpicker.ColorPickerPreference __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.ColorPickerPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetValue (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setValue_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerPreference']/method[@name='setValue' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setValue", "(I)V", "GetSetValue_IHandler")]
		public virtual unsafe void SetValue (int p0)
		{
			if (id_setValue_I == IntPtr.Zero)
				id_setValue_I = JNIEnv.GetMethodID (class_ref, "setValue", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setValue_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setValue", "(I)V"), __args);
			} finally {
			}
		}

	}
}
