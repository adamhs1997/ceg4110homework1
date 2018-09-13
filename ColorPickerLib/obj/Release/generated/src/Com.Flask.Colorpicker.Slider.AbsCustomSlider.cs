using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Flask.Colorpicker.Slider {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.flask.colorpicker.slider']/class[@name='AbsCustomSlider']"
	[global::Android.Runtime.Register ("com/flask/colorpicker/slider/AbsCustomSlider", DoNotGenerateAcw=true)]
	public abstract partial class AbsCustomSlider : global::Android.Views.View {


		static IntPtr bar_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.flask.colorpicker.slider']/class[@name='AbsCustomSlider']/field[@name='bar']"
		[Register ("bar")]
		protected global::Android.Graphics.Bitmap Bar {
			get {
				if (bar_jfieldId == IntPtr.Zero)
					bar_jfieldId = JNIEnv.GetFieldID (class_ref, "bar", "Landroid/graphics/Bitmap;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, bar_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (bar_jfieldId == IntPtr.Zero)
					bar_jfieldId = JNIEnv.GetFieldID (class_ref, "bar", "Landroid/graphics/Bitmap;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, bar_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr barCanvas_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.flask.colorpicker.slider']/class[@name='AbsCustomSlider']/field[@name='barCanvas']"
		[Register ("barCanvas")]
		protected global::Android.Graphics.Canvas BarCanvas {
			get {
				if (barCanvas_jfieldId == IntPtr.Zero)
					barCanvas_jfieldId = JNIEnv.GetFieldID (class_ref, "barCanvas", "Landroid/graphics/Canvas;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, barCanvas_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (barCanvas_jfieldId == IntPtr.Zero)
					barCanvas_jfieldId = JNIEnv.GetFieldID (class_ref, "barCanvas", "Landroid/graphics/Canvas;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, barCanvas_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr barHeight_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.flask.colorpicker.slider']/class[@name='AbsCustomSlider']/field[@name='barHeight']"
		[Register ("barHeight")]
		protected int BarHeight {
			get {
				if (barHeight_jfieldId == IntPtr.Zero)
					barHeight_jfieldId = JNIEnv.GetFieldID (class_ref, "barHeight", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, barHeight_jfieldId);
			}
			set {
				if (barHeight_jfieldId == IntPtr.Zero)
					barHeight_jfieldId = JNIEnv.GetFieldID (class_ref, "barHeight", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, barHeight_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr barOffsetX_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.flask.colorpicker.slider']/class[@name='AbsCustomSlider']/field[@name='barOffsetX']"
		[Register ("barOffsetX")]
		protected int BarOffsetX {
			get {
				if (barOffsetX_jfieldId == IntPtr.Zero)
					barOffsetX_jfieldId = JNIEnv.GetFieldID (class_ref, "barOffsetX", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, barOffsetX_jfieldId);
			}
			set {
				if (barOffsetX_jfieldId == IntPtr.Zero)
					barOffsetX_jfieldId = JNIEnv.GetFieldID (class_ref, "barOffsetX", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, barOffsetX_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr bitmap_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.flask.colorpicker.slider']/class[@name='AbsCustomSlider']/field[@name='bitmap']"
		[Register ("bitmap")]
		protected global::Android.Graphics.Bitmap Bitmap {
			get {
				if (bitmap_jfieldId == IntPtr.Zero)
					bitmap_jfieldId = JNIEnv.GetFieldID (class_ref, "bitmap", "Landroid/graphics/Bitmap;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, bitmap_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (bitmap_jfieldId == IntPtr.Zero)
					bitmap_jfieldId = JNIEnv.GetFieldID (class_ref, "bitmap", "Landroid/graphics/Bitmap;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, bitmap_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr bitmapCanvas_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.flask.colorpicker.slider']/class[@name='AbsCustomSlider']/field[@name='bitmapCanvas']"
		[Register ("bitmapCanvas")]
		protected global::Android.Graphics.Canvas BitmapCanvas {
			get {
				if (bitmapCanvas_jfieldId == IntPtr.Zero)
					bitmapCanvas_jfieldId = JNIEnv.GetFieldID (class_ref, "bitmapCanvas", "Landroid/graphics/Canvas;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, bitmapCanvas_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (bitmapCanvas_jfieldId == IntPtr.Zero)
					bitmapCanvas_jfieldId = JNIEnv.GetFieldID (class_ref, "bitmapCanvas", "Landroid/graphics/Canvas;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, bitmapCanvas_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr handleRadius_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.flask.colorpicker.slider']/class[@name='AbsCustomSlider']/field[@name='handleRadius']"
		[Register ("handleRadius")]
		protected int HandleRadius {
			get {
				if (handleRadius_jfieldId == IntPtr.Zero)
					handleRadius_jfieldId = JNIEnv.GetFieldID (class_ref, "handleRadius", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, handleRadius_jfieldId);
			}
			set {
				if (handleRadius_jfieldId == IntPtr.Zero)
					handleRadius_jfieldId = JNIEnv.GetFieldID (class_ref, "handleRadius", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, handleRadius_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr onValueChangedListener_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.flask.colorpicker.slider']/class[@name='AbsCustomSlider']/field[@name='onValueChangedListener']"
		[Register ("onValueChangedListener")]
		protected global::Com.Flask.Colorpicker.Slider.IOnValueChangedListener OnValueChangedListener {
			get {
				if (onValueChangedListener_jfieldId == IntPtr.Zero)
					onValueChangedListener_jfieldId = JNIEnv.GetFieldID (class_ref, "onValueChangedListener", "Lcom/flask/colorpicker/slider/OnValueChangedListener;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, onValueChangedListener_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Slider.IOnValueChangedListener> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (onValueChangedListener_jfieldId == IntPtr.Zero)
					onValueChangedListener_jfieldId = JNIEnv.GetFieldID (class_ref, "onValueChangedListener", "Lcom/flask/colorpicker/slider/OnValueChangedListener;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, onValueChangedListener_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr value_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.flask.colorpicker.slider']/class[@name='AbsCustomSlider']/field[@name='value']"
		[Register ("value")]
		protected float Value {
			get {
				if (value_jfieldId == IntPtr.Zero)
					value_jfieldId = JNIEnv.GetFieldID (class_ref, "value", "F");
				return JNIEnv.GetFloatField (((global::Java.Lang.Object) this).Handle, value_jfieldId);
			}
			set {
				if (value_jfieldId == IntPtr.Zero)
					value_jfieldId = JNIEnv.GetFieldID (class_ref, "value", "F");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, value_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/flask/colorpicker/slider/AbsCustomSlider", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbsCustomSlider); }
		}

		protected AbsCustomSlider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.flask.colorpicker.slider']/class[@name='AbsCustomSlider']/constructor[@name='AbsCustomSlider' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe AbsCustomSlider (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (AbsCustomSlider)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.flask.colorpicker.slider']/class[@name='AbsCustomSlider']/constructor[@name='AbsCustomSlider' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe AbsCustomSlider (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (AbsCustomSlider)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.flask.colorpicker.slider']/class[@name='AbsCustomSlider']/constructor[@name='AbsCustomSlider' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe AbsCustomSlider (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (AbsCustomSlider)) {
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

		static Delegate cb_createBitmaps;
#pragma warning disable 0169
		static Delegate GetCreateBitmapsHandler ()
		{
			if (cb_createBitmaps == null)
				cb_createBitmaps = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CreateBitmaps);
			return cb_createBitmaps;
		}

		static void n_CreateBitmaps (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Flask.Colorpicker.Slider.AbsCustomSlider __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Slider.AbsCustomSlider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CreateBitmaps ();
		}
#pragma warning restore 0169

		static IntPtr id_createBitmaps;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.slider']/class[@name='AbsCustomSlider']/method[@name='createBitmaps' and count(parameter)=0]"
		[Register ("createBitmaps", "()V", "GetCreateBitmapsHandler")]
		protected virtual unsafe void CreateBitmaps ()
		{
			if (id_createBitmaps == IntPtr.Zero)
				id_createBitmaps = JNIEnv.GetMethodID (class_ref, "createBitmaps", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_createBitmaps);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createBitmaps", "()V"));
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
			global::Com.Flask.Colorpicker.Slider.AbsCustomSlider __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Slider.AbsCustomSlider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DrawBar (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.slider']/class[@name='AbsCustomSlider']/method[@name='drawBar' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("drawBar", "(Landroid/graphics/Canvas;)V", "GetDrawBar_Landroid_graphics_Canvas_Handler")]
		protected abstract void DrawBar (global::Android.Graphics.Canvas p0);

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
			global::Com.Flask.Colorpicker.Slider.AbsCustomSlider __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Slider.AbsCustomSlider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DrawHandle (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.slider']/class[@name='AbsCustomSlider']/method[@name='drawHandle' and count(parameter)=3 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("drawHandle", "(Landroid/graphics/Canvas;FF)V", "GetDrawHandle_Landroid_graphics_Canvas_FFHandler")]
		protected abstract void DrawHandle (global::Android.Graphics.Canvas p0, float p1, float p2);

		static Delegate cb_getDimension_I;
#pragma warning disable 0169
		static Delegate GetGetDimension_IHandler ()
		{
			if (cb_getDimension_I == null)
				cb_getDimension_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetDimension_I);
			return cb_getDimension_I;
		}

		static int n_GetDimension_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Flask.Colorpicker.Slider.AbsCustomSlider __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Slider.AbsCustomSlider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetDimension (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getDimension_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.slider']/class[@name='AbsCustomSlider']/method[@name='getDimension' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getDimension", "(I)I", "GetGetDimension_IHandler")]
		protected virtual unsafe int GetDimension (int p0)
		{
			if (id_getDimension_I == IntPtr.Zero)
				id_getDimension_I = JNIEnv.GetMethodID (class_ref, "getDimension", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getDimension_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDimension", "(I)I"), __args);
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
			global::Com.Flask.Colorpicker.Slider.AbsCustomSlider __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Slider.AbsCustomSlider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnValueChanged (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.slider']/class[@name='AbsCustomSlider']/method[@name='onValueChanged' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("onValueChanged", "(F)V", "GetOnValueChanged_FHandler")]
		protected abstract void OnValueChanged (float p0);

		static Delegate cb_setOnValueChangedListener_Lcom_flask_colorpicker_slider_OnValueChangedListener_;
#pragma warning disable 0169
		static Delegate GetSetOnValueChangedListener_Lcom_flask_colorpicker_slider_OnValueChangedListener_Handler ()
		{
			if (cb_setOnValueChangedListener_Lcom_flask_colorpicker_slider_OnValueChangedListener_ == null)
				cb_setOnValueChangedListener_Lcom_flask_colorpicker_slider_OnValueChangedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnValueChangedListener_Lcom_flask_colorpicker_slider_OnValueChangedListener_);
			return cb_setOnValueChangedListener_Lcom_flask_colorpicker_slider_OnValueChangedListener_;
		}

		static void n_SetOnValueChangedListener_Lcom_flask_colorpicker_slider_OnValueChangedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Flask.Colorpicker.Slider.AbsCustomSlider __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Slider.AbsCustomSlider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Flask.Colorpicker.Slider.IOnValueChangedListener p0 = (global::Com.Flask.Colorpicker.Slider.IOnValueChangedListener)global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Slider.IOnValueChangedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnValueChangedListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnValueChangedListener_Lcom_flask_colorpicker_slider_OnValueChangedListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.slider']/class[@name='AbsCustomSlider']/method[@name='setOnValueChangedListener' and count(parameter)=1 and parameter[1][@type='com.flask.colorpicker.slider.OnValueChangedListener']]"
		[Register ("setOnValueChangedListener", "(Lcom/flask/colorpicker/slider/OnValueChangedListener;)V", "GetSetOnValueChangedListener_Lcom_flask_colorpicker_slider_OnValueChangedListener_Handler")]
		public virtual unsafe void SetOnValueChangedListener (global::Com.Flask.Colorpicker.Slider.IOnValueChangedListener p0)
		{
			if (id_setOnValueChangedListener_Lcom_flask_colorpicker_slider_OnValueChangedListener_ == IntPtr.Zero)
				id_setOnValueChangedListener_Lcom_flask_colorpicker_slider_OnValueChangedListener_ = JNIEnv.GetMethodID (class_ref, "setOnValueChangedListener", "(Lcom/flask/colorpicker/slider/OnValueChangedListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnValueChangedListener_Lcom_flask_colorpicker_slider_OnValueChangedListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnValueChangedListener", "(Lcom/flask/colorpicker/slider/OnValueChangedListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_updateBar;
#pragma warning disable 0169
		static Delegate GetUpdateBarHandler ()
		{
			if (cb_updateBar == null)
				cb_updateBar = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_UpdateBar);
			return cb_updateBar;
		}

		static void n_UpdateBar (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Flask.Colorpicker.Slider.AbsCustomSlider __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Slider.AbsCustomSlider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateBar ();
		}
#pragma warning restore 0169

		static IntPtr id_updateBar;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.slider']/class[@name='AbsCustomSlider']/method[@name='updateBar' and count(parameter)=0]"
		[Register ("updateBar", "()V", "GetUpdateBarHandler")]
		protected virtual unsafe void UpdateBar ()
		{
			if (id_updateBar == IntPtr.Zero)
				id_updateBar = JNIEnv.GetMethodID (class_ref, "updateBar", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateBar);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateBar", "()V"));
			} finally {
			}
		}

#region "Event implementation for Com.Flask.Colorpicker.Slider.IOnValueChangedListener"
		public event EventHandler<global::Com.Flask.Colorpicker.Slider.ValueChangedEventArgs> ValueChanged {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Flask.Colorpicker.Slider.IOnValueChangedListener, global::Com.Flask.Colorpicker.Slider.IOnValueChangedListenerImplementor>(
						ref weak_implementor_SetOnValueChangedListener,
						__CreateIOnValueChangedListenerImplementor,
						SetOnValueChangedListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Flask.Colorpicker.Slider.IOnValueChangedListener, global::Com.Flask.Colorpicker.Slider.IOnValueChangedListenerImplementor>(
						ref weak_implementor_SetOnValueChangedListener,
						global::Com.Flask.Colorpicker.Slider.IOnValueChangedListenerImplementor.__IsEmpty,
						__v => SetOnValueChangedListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnValueChangedListener;

		global::Com.Flask.Colorpicker.Slider.IOnValueChangedListenerImplementor __CreateIOnValueChangedListenerImplementor ()
		{
			return new global::Com.Flask.Colorpicker.Slider.IOnValueChangedListenerImplementor (this);
		}
#endregion
	}

	[global::Android.Runtime.Register ("com/flask/colorpicker/slider/AbsCustomSlider", DoNotGenerateAcw=true)]
	internal partial class AbsCustomSliderInvoker : AbsCustomSlider {

		public AbsCustomSliderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbsCustomSliderInvoker); }
		}

		static IntPtr id_drawBar_Landroid_graphics_Canvas_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.slider']/class[@name='AbsCustomSlider']/method[@name='drawBar' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("drawBar", "(Landroid/graphics/Canvas;)V", "GetDrawBar_Landroid_graphics_Canvas_Handler")]
		protected override unsafe void DrawBar (global::Android.Graphics.Canvas p0)
		{
			if (id_drawBar_Landroid_graphics_Canvas_ == IntPtr.Zero)
				id_drawBar_Landroid_graphics_Canvas_ = JNIEnv.GetMethodID (class_ref, "drawBar", "(Landroid/graphics/Canvas;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_drawBar_Landroid_graphics_Canvas_, __args);
			} finally {
			}
		}

		static IntPtr id_drawHandle_Landroid_graphics_Canvas_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.slider']/class[@name='AbsCustomSlider']/method[@name='drawHandle' and count(parameter)=3 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
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
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_drawHandle_Landroid_graphics_Canvas_FF, __args);
			} finally {
			}
		}

		static IntPtr id_onValueChanged_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.slider']/class[@name='AbsCustomSlider']/method[@name='onValueChanged' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("onValueChanged", "(F)V", "GetOnValueChanged_FHandler")]
		protected override unsafe void OnValueChanged (float p0)
		{
			if (id_onValueChanged_F == IntPtr.Zero)
				id_onValueChanged_F = JNIEnv.GetMethodID (class_ref, "onValueChanged", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onValueChanged_F, __args);
			} finally {
			}
		}

	}

}
