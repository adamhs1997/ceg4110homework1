using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Flask.Colorpicker.Slider {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.flask.colorpicker.slider']/class[@name='LightnessSlider']"
	[global::Android.Runtime.Register ("com/flask/colorpicker/slider/LightnessSlider", DoNotGenerateAcw=true)]
	public partial class LightnessSlider : global::Com.Flask.Colorpicker.Slider.AbsCustomSlider {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/flask/colorpicker/slider/LightnessSlider", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LightnessSlider); }
		}

		protected LightnessSlider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.flask.colorpicker.slider']/class[@name='LightnessSlider']/constructor[@name='LightnessSlider' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe LightnessSlider (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (LightnessSlider)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.flask.colorpicker.slider']/class[@name='LightnessSlider']/constructor[@name='LightnessSlider' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe LightnessSlider (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (LightnessSlider)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.flask.colorpicker.slider']/class[@name='LightnessSlider']/constructor[@name='LightnessSlider' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe LightnessSlider (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (LightnessSlider)) {
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

		static Delegate cb_drawBar_Landroid_graphics_Canvas_;
#pragma warning disable 0169
		static Delegate GetDrawBar_Landroid_graphics_Canvas_Handler ()
		{
			if (cb_drawBar_Landroid_graphics_Canvas_ == null)
				cb_drawBar_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DrawBar_Landroid_graphics_Canvas_);
			return cb_drawBar_Landroid_graphics_Canvas_;
		}

		static void n_DrawBar_Landroid_graphics_Canvas_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Flask.Colorpicker.Slider.LightnessSlider __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Slider.LightnessSlider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DrawBar (p0);
		}
#pragma warning restore 0169

		static IntPtr id_drawBar_Landroid_graphics_Canvas_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.slider']/class[@name='LightnessSlider']/method[@name='drawBar' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("drawBar", "(Landroid/graphics/Canvas;)V", "GetDrawBar_Landroid_graphics_Canvas_Handler")]
		protected override unsafe void DrawBar (global::Android.Graphics.Canvas p0)
		{
			if (id_drawBar_Landroid_graphics_Canvas_ == IntPtr.Zero)
				id_drawBar_Landroid_graphics_Canvas_ = JNIEnv.GetMethodID (class_ref, "drawBar", "(Landroid/graphics/Canvas;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_drawBar_Landroid_graphics_Canvas_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "drawBar", "(Landroid/graphics/Canvas;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_drawHandle_Landroid_graphics_Canvas_FF;
#pragma warning disable 0169
		static Delegate GetDrawHandle_Landroid_graphics_Canvas_FFHandler ()
		{
			if (cb_drawHandle_Landroid_graphics_Canvas_FF == null)
				cb_drawHandle_Landroid_graphics_Canvas_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, float, float>) n_DrawHandle_Landroid_graphics_Canvas_FF);
			return cb_drawHandle_Landroid_graphics_Canvas_FF;
		}

		static void n_DrawHandle_Landroid_graphics_Canvas_FF (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, float p1, float p2)
		{
			global::Com.Flask.Colorpicker.Slider.LightnessSlider __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Slider.LightnessSlider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DrawHandle (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_drawHandle_Landroid_graphics_Canvas_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.slider']/class[@name='LightnessSlider']/method[@name='drawHandle' and count(parameter)=3 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("drawHandle", "(Landroid/graphics/Canvas;FF)V", "GetDrawHandle_Landroid_graphics_Canvas_FFHandler")]
		protected override unsafe void DrawHandle (global::Android.Graphics.Canvas p0, float p1, float p2)
		{
			if (id_drawHandle_Landroid_graphics_Canvas_FF == IntPtr.Zero)
				id_drawHandle_Landroid_graphics_Canvas_FF = JNIEnv.GetMethodID (class_ref, "drawHandle", "(Landroid/graphics/Canvas;FF)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_drawHandle_Landroid_graphics_Canvas_FF, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "drawHandle", "(Landroid/graphics/Canvas;FF)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onValueChanged_F;
#pragma warning disable 0169
		static Delegate GetOnValueChanged_FHandler ()
		{
			if (cb_onValueChanged_F == null)
				cb_onValueChanged_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_OnValueChanged_F);
			return cb_onValueChanged_F;
		}

		static void n_OnValueChanged_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Flask.Colorpicker.Slider.LightnessSlider __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Slider.LightnessSlider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnValueChanged (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onValueChanged_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.slider']/class[@name='LightnessSlider']/method[@name='onValueChanged' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("onValueChanged", "(F)V", "GetOnValueChanged_FHandler")]
		protected override unsafe void OnValueChanged (float p0)
		{
			if (id_onValueChanged_F == IntPtr.Zero)
				id_onValueChanged_F = JNIEnv.GetMethodID (class_ref, "onValueChanged", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onValueChanged_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onValueChanged", "(F)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setColor_I;
#pragma warning disable 0169
		static Delegate GetSetColor_IHandler ()
		{
			if (cb_setColor_I == null)
				cb_setColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetColor_I);
			return cb_setColor_I;
		}

		static void n_SetColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Flask.Colorpicker.Slider.LightnessSlider __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Slider.LightnessSlider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetColor (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.slider']/class[@name='LightnessSlider']/method[@name='setColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setColor", "(I)V", "GetSetColor_IHandler")]
		public virtual unsafe void SetColor (int p0)
		{
			if (id_setColor_I == IntPtr.Zero)
				id_setColor_I = JNIEnv.GetMethodID (class_ref, "setColor", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setColor_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setColor", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setColorPicker_Lcom_flask_colorpicker_ColorPickerView_;
#pragma warning disable 0169
		static Delegate GetSetColorPicker_Lcom_flask_colorpicker_ColorPickerView_Handler ()
		{
			if (cb_setColorPicker_Lcom_flask_colorpicker_ColorPickerView_ == null)
				cb_setColorPicker_Lcom_flask_colorpicker_ColorPickerView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetColorPicker_Lcom_flask_colorpicker_ColorPickerView_);
			return cb_setColorPicker_Lcom_flask_colorpicker_ColorPickerView_;
		}

		static void n_SetColorPicker_Lcom_flask_colorpicker_ColorPickerView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Flask.Colorpicker.Slider.LightnessSlider __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Slider.LightnessSlider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Flask.Colorpicker.ColorPickerView p0 = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.ColorPickerView> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetColorPicker (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setColorPicker_Lcom_flask_colorpicker_ColorPickerView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.slider']/class[@name='LightnessSlider']/method[@name='setColorPicker' and count(parameter)=1 and parameter[1][@type='com.flask.colorpicker.ColorPickerView']]"
		[Register ("setColorPicker", "(Lcom/flask/colorpicker/ColorPickerView;)V", "GetSetColorPicker_Lcom_flask_colorpicker_ColorPickerView_Handler")]
		public virtual unsafe void SetColorPicker (global::Com.Flask.Colorpicker.ColorPickerView p0)
		{
			if (id_setColorPicker_Lcom_flask_colorpicker_ColorPickerView_ == IntPtr.Zero)
				id_setColorPicker_Lcom_flask_colorpicker_ColorPickerView_ = JNIEnv.GetMethodID (class_ref, "setColorPicker", "(Lcom/flask/colorpicker/ColorPickerView;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setColorPicker_Lcom_flask_colorpicker_ColorPickerView_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setColorPicker", "(Lcom/flask/colorpicker/ColorPickerView;)V"), __args);
			} finally {
			}
		}

	}
}
