using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Flask.Colorpicker.Renderer {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.flask.colorpicker.renderer']/class[@name='AbsColorWheelRenderer']"
	[global::Android.Runtime.Register ("com/flask/colorpicker/renderer/AbsColorWheelRenderer", DoNotGenerateAcw=true)]
	public abstract partial class AbsColorWheelRenderer : global::Java.Lang.Object, global::Com.Flask.Colorpicker.Renderer.IColorWheelRenderer {


		static IntPtr colorWheelRenderOption_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.flask.colorpicker.renderer']/class[@name='AbsColorWheelRenderer']/field[@name='colorWheelRenderOption']"
		[Register ("colorWheelRenderOption")]
		protected global::Com.Flask.Colorpicker.Renderer.ColorWheelRenderOption ColorWheelRenderOption {
			get {
				if (colorWheelRenderOption_jfieldId == IntPtr.Zero)
					colorWheelRenderOption_jfieldId = JNIEnv.GetFieldID (class_ref, "colorWheelRenderOption", "Lcom/flask/colorpicker/renderer/ColorWheelRenderOption;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, colorWheelRenderOption_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Renderer.ColorWheelRenderOption> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (colorWheelRenderOption_jfieldId == IntPtr.Zero)
					colorWheelRenderOption_jfieldId = JNIEnv.GetFieldID (class_ref, "colorWheelRenderOption", "Lcom/flask/colorpicker/renderer/ColorWheelRenderOption;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, colorWheelRenderOption_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		public static class InterfaceConsts {

			// The following are fields from: com.flask.colorpicker.renderer.ColorWheelRenderer

			// Metadata.xml XPath field reference: path="/api/package[@name='com.flask.colorpicker.renderer']/interface[@name='ColorWheelRenderer']/field[@name='GAP_PERCENTAGE']"
			[Register ("GAP_PERCENTAGE")]
			public const float GapPercentage = (float) 0.025000;
		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/flask/colorpicker/renderer/AbsColorWheelRenderer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbsColorWheelRenderer); }
		}

		protected AbsColorWheelRenderer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.flask.colorpicker.renderer']/class[@name='AbsColorWheelRenderer']/constructor[@name='AbsColorWheelRenderer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AbsColorWheelRenderer ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (AbsColorWheelRenderer)) {
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

		static Delegate cb_getAlphaValueAsInt;
#pragma warning disable 0169
		static Delegate GetGetAlphaValueAsIntHandler ()
		{
			if (cb_getAlphaValueAsInt == null)
				cb_getAlphaValueAsInt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetAlphaValueAsInt);
			return cb_getAlphaValueAsInt;
		}

		static int n_GetAlphaValueAsInt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Flask.Colorpicker.Renderer.AbsColorWheelRenderer __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Renderer.AbsColorWheelRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AlphaValueAsInt;
		}
#pragma warning restore 0169

		static IntPtr id_getAlphaValueAsInt;
		protected virtual unsafe int AlphaValueAsInt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.renderer']/class[@name='AbsColorWheelRenderer']/method[@name='getAlphaValueAsInt' and count(parameter)=0]"
			[Register ("getAlphaValueAsInt", "()I", "GetGetAlphaValueAsIntHandler")]
			get {
				if (id_getAlphaValueAsInt == IntPtr.Zero)
					id_getAlphaValueAsInt = JNIEnv.GetMethodID (class_ref, "getAlphaValueAsInt", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getAlphaValueAsInt);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAlphaValueAsInt", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getColorCircleList;
#pragma warning disable 0169
		static Delegate GetGetColorCircleListHandler ()
		{
			if (cb_getColorCircleList == null)
				cb_getColorCircleList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetColorCircleList);
			return cb_getColorCircleList;
		}

		static IntPtr n_GetColorCircleList (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Flask.Colorpicker.Renderer.AbsColorWheelRenderer __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Renderer.AbsColorWheelRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Flask.Colorpicker.ColorCircle>.ToLocalJniHandle (__this.ColorCircleList);
		}
#pragma warning restore 0169

		static IntPtr id_getColorCircleList;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Flask.Colorpicker.ColorCircle> ColorCircleList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.renderer']/class[@name='AbsColorWheelRenderer']/method[@name='getColorCircleList' and count(parameter)=0]"
			[Register ("getColorCircleList", "()Ljava/util/List;", "GetGetColorCircleListHandler")]
			get {
				if (id_getColorCircleList == IntPtr.Zero)
					id_getColorCircleList = JNIEnv.GetMethodID (class_ref, "getColorCircleList", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Flask.Colorpicker.ColorCircle>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getColorCircleList), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Flask.Colorpicker.ColorCircle>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getColorCircleList", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRenderOption;
#pragma warning disable 0169
		static Delegate GetGetRenderOptionHandler ()
		{
			if (cb_getRenderOption == null)
				cb_getRenderOption = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRenderOption);
			return cb_getRenderOption;
		}

		static IntPtr n_GetRenderOption (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Flask.Colorpicker.Renderer.AbsColorWheelRenderer __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Renderer.AbsColorWheelRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RenderOption);
		}
#pragma warning restore 0169

		static IntPtr id_getRenderOption;
		public virtual unsafe global::Com.Flask.Colorpicker.Renderer.ColorWheelRenderOption RenderOption {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.renderer']/class[@name='AbsColorWheelRenderer']/method[@name='getRenderOption' and count(parameter)=0]"
			[Register ("getRenderOption", "()Lcom/flask/colorpicker/renderer/ColorWheelRenderOption;", "GetGetRenderOptionHandler")]
			get {
				if (id_getRenderOption == IntPtr.Zero)
					id_getRenderOption = JNIEnv.GetMethodID (class_ref, "getRenderOption", "()Lcom/flask/colorpicker/renderer/ColorWheelRenderOption;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Renderer.ColorWheelRenderOption> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRenderOption), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Renderer.ColorWheelRenderOption> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRenderOption", "()Lcom/flask/colorpicker/renderer/ColorWheelRenderOption;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_calcTotalCount_FF;
#pragma warning disable 0169
		static Delegate GetCalcTotalCount_FFHandler ()
		{
			if (cb_calcTotalCount_FF == null)
				cb_calcTotalCount_FF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float, int>) n_CalcTotalCount_FF);
			return cb_calcTotalCount_FF;
		}

		static int n_CalcTotalCount_FF (IntPtr jnienv, IntPtr native__this, float p0, float p1)
		{
			global::Com.Flask.Colorpicker.Renderer.AbsColorWheelRenderer __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Renderer.AbsColorWheelRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CalcTotalCount (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_calcTotalCount_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.renderer']/class[@name='AbsColorWheelRenderer']/method[@name='calcTotalCount' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("calcTotalCount", "(FF)I", "GetCalcTotalCount_FFHandler")]
		protected virtual unsafe int CalcTotalCount (float p0, float p1)
		{
			if (id_calcTotalCount_FF == IntPtr.Zero)
				id_calcTotalCount_FF = JNIEnv.GetMethodID (class_ref, "calcTotalCount", "(FF)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_calcTotalCount_FF, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "calcTotalCount", "(FF)I"), __args);
			} finally {
			}
		}

		static Delegate cb_initWith_Lcom_flask_colorpicker_renderer_ColorWheelRenderOption_;
#pragma warning disable 0169
		static Delegate GetInitWith_Lcom_flask_colorpicker_renderer_ColorWheelRenderOption_Handler ()
		{
			if (cb_initWith_Lcom_flask_colorpicker_renderer_ColorWheelRenderOption_ == null)
				cb_initWith_Lcom_flask_colorpicker_renderer_ColorWheelRenderOption_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_InitWith_Lcom_flask_colorpicker_renderer_ColorWheelRenderOption_);
			return cb_initWith_Lcom_flask_colorpicker_renderer_ColorWheelRenderOption_;
		}

		static void n_InitWith_Lcom_flask_colorpicker_renderer_ColorWheelRenderOption_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Flask.Colorpicker.Renderer.AbsColorWheelRenderer __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Renderer.AbsColorWheelRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Flask.Colorpicker.Renderer.ColorWheelRenderOption p0 = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Renderer.ColorWheelRenderOption> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.InitWith (p0);
		}
#pragma warning restore 0169

		static IntPtr id_initWith_Lcom_flask_colorpicker_renderer_ColorWheelRenderOption_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.renderer']/class[@name='AbsColorWheelRenderer']/method[@name='initWith' and count(parameter)=1 and parameter[1][@type='com.flask.colorpicker.renderer.ColorWheelRenderOption']]"
		[Register ("initWith", "(Lcom/flask/colorpicker/renderer/ColorWheelRenderOption;)V", "GetInitWith_Lcom_flask_colorpicker_renderer_ColorWheelRenderOption_Handler")]
		public virtual unsafe void InitWith (global::Com.Flask.Colorpicker.Renderer.ColorWheelRenderOption p0)
		{
			if (id_initWith_Lcom_flask_colorpicker_renderer_ColorWheelRenderOption_ == IntPtr.Zero)
				id_initWith_Lcom_flask_colorpicker_renderer_ColorWheelRenderOption_ = JNIEnv.GetMethodID (class_ref, "initWith", "(Lcom/flask/colorpicker/renderer/ColorWheelRenderOption;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_initWith_Lcom_flask_colorpicker_renderer_ColorWheelRenderOption_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initWith", "(Lcom/flask/colorpicker/renderer/ColorWheelRenderOption;)V"), __args);
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
			global::Com.Flask.Colorpicker.Renderer.AbsColorWheelRenderer __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Renderer.AbsColorWheelRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Draw ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.renderer']/interface[@name='ColorWheelRenderer']/method[@name='draw' and count(parameter)=0]"
		[Register ("draw", "()V", "GetDrawHandler")]
		public abstract void Draw ();

	}

	[global::Android.Runtime.Register ("com/flask/colorpicker/renderer/AbsColorWheelRenderer", DoNotGenerateAcw=true)]
	internal partial class AbsColorWheelRendererInvoker : AbsColorWheelRenderer {

		public AbsColorWheelRendererInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbsColorWheelRendererInvoker); }
		}

		static IntPtr id_draw;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.renderer']/interface[@name='ColorWheelRenderer']/method[@name='draw' and count(parameter)=0]"
		[Register ("draw", "()V", "GetDrawHandler")]
		public override unsafe void Draw ()
		{
			if (id_draw == IntPtr.Zero)
				id_draw = JNIEnv.GetMethodID (class_ref, "draw", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_draw);
			} finally {
			}
		}

	}

}
