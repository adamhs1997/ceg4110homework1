using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Flask.Colorpicker.Builder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.flask.colorpicker.builder']/class[@name='PaintBuilder']"
	[global::Android.Runtime.Register ("com/flask/colorpicker/builder/PaintBuilder", DoNotGenerateAcw=true)]
	public partial class PaintBuilder : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.flask.colorpicker.builder']/class[@name='PaintBuilder.PaintHolder']"
		[global::Android.Runtime.Register ("com/flask/colorpicker/builder/PaintBuilder$PaintHolder", DoNotGenerateAcw=true)]
		public partial class PaintHolder : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/flask/colorpicker/builder/PaintBuilder$PaintHolder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (PaintHolder); }
			}

			protected PaintHolder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_antiAlias_Z;
#pragma warning disable 0169
			static Delegate GetAntiAlias_ZHandler ()
			{
				if (cb_antiAlias_Z == null)
					cb_antiAlias_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_AntiAlias_Z);
				return cb_antiAlias_Z;
			}

			static IntPtr n_AntiAlias_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AntiAlias (p0));
			}
#pragma warning restore 0169

			static IntPtr id_antiAlias_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.builder']/class[@name='PaintBuilder.PaintHolder']/method[@name='antiAlias' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("antiAlias", "(Z)Lcom/flask/colorpicker/builder/PaintBuilder$PaintHolder;", "GetAntiAlias_ZHandler")]
			public virtual unsafe global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder AntiAlias (bool p0)
			{
				if (id_antiAlias_Z == IntPtr.Zero)
					id_antiAlias_Z = JNIEnv.GetMethodID (class_ref, "antiAlias", "(Z)Lcom/flask/colorpicker/builder/PaintBuilder$PaintHolder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_antiAlias_Z, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "antiAlias", "(Z)Lcom/flask/colorpicker/builder/PaintBuilder$PaintHolder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_build;
#pragma warning disable 0169
			static Delegate GetBuildHandler ()
			{
				if (cb_build == null)
					cb_build = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Build);
				return cb_build;
			}

			static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			static IntPtr id_build;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.builder']/class[@name='PaintBuilder.PaintHolder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Landroid/graphics/Paint;", "GetBuildHandler")]
			public virtual unsafe global::Android.Graphics.Paint Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Landroid/graphics/Paint;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "()Landroid/graphics/Paint;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_color_I;
#pragma warning disable 0169
			static Delegate GetColor_IHandler ()
			{
				if (cb_color_I == null)
					cb_color_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Color_I);
				return cb_color_I;
			}

			static IntPtr n_Color_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Color (p0));
			}
#pragma warning restore 0169

			static IntPtr id_color_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.builder']/class[@name='PaintBuilder.PaintHolder']/method[@name='color' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("color", "(I)Lcom/flask/colorpicker/builder/PaintBuilder$PaintHolder;", "GetColor_IHandler")]
			public virtual unsafe global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder Color (int p0)
			{
				if (id_color_I == IntPtr.Zero)
					id_color_I = JNIEnv.GetMethodID (class_ref, "color", "(I)Lcom/flask/colorpicker/builder/PaintBuilder$PaintHolder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_color_I, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "color", "(I)Lcom/flask/colorpicker/builder/PaintBuilder$PaintHolder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_mode_Landroid_graphics_PorterDuff_Mode_;
#pragma warning disable 0169
			static Delegate GetMode_Landroid_graphics_PorterDuff_Mode_Handler ()
			{
				if (cb_mode_Landroid_graphics_PorterDuff_Mode_ == null)
					cb_mode_Landroid_graphics_PorterDuff_Mode_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Mode_Landroid_graphics_PorterDuff_Mode_);
				return cb_mode_Landroid_graphics_PorterDuff_Mode_;
			}

			static IntPtr n_Mode_Landroid_graphics_PorterDuff_Mode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.PorterDuff.Mode p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.PorterDuff.Mode> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Mode (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_mode_Landroid_graphics_PorterDuff_Mode_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.builder']/class[@name='PaintBuilder.PaintHolder']/method[@name='mode' and count(parameter)=1 and parameter[1][@type='android.graphics.PorterDuff.Mode']]"
			[Register ("mode", "(Landroid/graphics/PorterDuff$Mode;)Lcom/flask/colorpicker/builder/PaintBuilder$PaintHolder;", "GetMode_Landroid_graphics_PorterDuff_Mode_Handler")]
			public virtual unsafe global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder Mode (global::Android.Graphics.PorterDuff.Mode p0)
			{
				if (id_mode_Landroid_graphics_PorterDuff_Mode_ == IntPtr.Zero)
					id_mode_Landroid_graphics_PorterDuff_Mode_ = JNIEnv.GetMethodID (class_ref, "mode", "(Landroid/graphics/PorterDuff$Mode;)Lcom/flask/colorpicker/builder/PaintBuilder$PaintHolder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_mode_Landroid_graphics_PorterDuff_Mode_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "mode", "(Landroid/graphics/PorterDuff$Mode;)Lcom/flask/colorpicker/builder/PaintBuilder$PaintHolder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_shader_Landroid_graphics_Shader_;
#pragma warning disable 0169
			static Delegate GetShader_Landroid_graphics_Shader_Handler ()
			{
				if (cb_shader_Landroid_graphics_Shader_ == null)
					cb_shader_Landroid_graphics_Shader_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Shader_Landroid_graphics_Shader_);
				return cb_shader_Landroid_graphics_Shader_;
			}

			static IntPtr n_Shader_Landroid_graphics_Shader_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Shader p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Shader> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Shader (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_shader_Landroid_graphics_Shader_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.builder']/class[@name='PaintBuilder.PaintHolder']/method[@name='shader' and count(parameter)=1 and parameter[1][@type='android.graphics.Shader']]"
			[Register ("shader", "(Landroid/graphics/Shader;)Lcom/flask/colorpicker/builder/PaintBuilder$PaintHolder;", "GetShader_Landroid_graphics_Shader_Handler")]
			public virtual unsafe global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder Shader (global::Android.Graphics.Shader p0)
			{
				if (id_shader_Landroid_graphics_Shader_ == IntPtr.Zero)
					id_shader_Landroid_graphics_Shader_ = JNIEnv.GetMethodID (class_ref, "shader", "(Landroid/graphics/Shader;)Lcom/flask/colorpicker/builder/PaintBuilder$PaintHolder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_shader_Landroid_graphics_Shader_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shader", "(Landroid/graphics/Shader;)Lcom/flask/colorpicker/builder/PaintBuilder$PaintHolder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_stroke_F;
#pragma warning disable 0169
			static Delegate GetStroke_FHandler ()
			{
				if (cb_stroke_F == null)
					cb_stroke_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_Stroke_F);
				return cb_stroke_F;
			}

			static IntPtr n_Stroke_F (IntPtr jnienv, IntPtr native__this, float p0)
			{
				global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Stroke (p0));
			}
#pragma warning restore 0169

			static IntPtr id_stroke_F;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.builder']/class[@name='PaintBuilder.PaintHolder']/method[@name='stroke' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("stroke", "(F)Lcom/flask/colorpicker/builder/PaintBuilder$PaintHolder;", "GetStroke_FHandler")]
			public virtual unsafe global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder Stroke (float p0)
			{
				if (id_stroke_F == IntPtr.Zero)
					id_stroke_F = JNIEnv.GetMethodID (class_ref, "stroke", "(F)Lcom/flask/colorpicker/builder/PaintBuilder$PaintHolder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_stroke_F, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stroke", "(F)Lcom/flask/colorpicker/builder/PaintBuilder$PaintHolder;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_style_Landroid_graphics_Paint_Style_;
#pragma warning disable 0169
			static Delegate GetStyle_Landroid_graphics_Paint_Style_Handler ()
			{
				if (cb_style_Landroid_graphics_Paint_Style_ == null)
					cb_style_Landroid_graphics_Paint_Style_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Style_Landroid_graphics_Paint_Style_);
				return cb_style_Landroid_graphics_Paint_Style_;
			}

			static IntPtr n_Style_Landroid_graphics_Paint_Style_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Paint.Style p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint.Style> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Style (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_style_Landroid_graphics_Paint_Style_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.builder']/class[@name='PaintBuilder.PaintHolder']/method[@name='style' and count(parameter)=1 and parameter[1][@type='android.graphics.Paint.Style']]"
			[Register ("style", "(Landroid/graphics/Paint$Style;)Lcom/flask/colorpicker/builder/PaintBuilder$PaintHolder;", "GetStyle_Landroid_graphics_Paint_Style_Handler")]
			public virtual unsafe global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder Style (global::Android.Graphics.Paint.Style p0)
			{
				if (id_style_Landroid_graphics_Paint_Style_ == IntPtr.Zero)
					id_style_Landroid_graphics_Paint_Style_ = JNIEnv.GetMethodID (class_ref, "style", "(Landroid/graphics/Paint$Style;)Lcom/flask/colorpicker/builder/PaintBuilder$PaintHolder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_style_Landroid_graphics_Paint_Style_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "style", "(Landroid/graphics/Paint$Style;)Lcom/flask/colorpicker/builder/PaintBuilder$PaintHolder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_xPerMode_Landroid_graphics_PorterDuff_Mode_;
#pragma warning disable 0169
			static Delegate GetXPerMode_Landroid_graphics_PorterDuff_Mode_Handler ()
			{
				if (cb_xPerMode_Landroid_graphics_PorterDuff_Mode_ == null)
					cb_xPerMode_Landroid_graphics_PorterDuff_Mode_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_XPerMode_Landroid_graphics_PorterDuff_Mode_);
				return cb_xPerMode_Landroid_graphics_PorterDuff_Mode_;
			}

			static IntPtr n_XPerMode_Landroid_graphics_PorterDuff_Mode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.PorterDuff.Mode p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.PorterDuff.Mode> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.XPerMode (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_xPerMode_Landroid_graphics_PorterDuff_Mode_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.builder']/class[@name='PaintBuilder.PaintHolder']/method[@name='xPerMode' and count(parameter)=1 and parameter[1][@type='android.graphics.PorterDuff.Mode']]"
			[Register ("xPerMode", "(Landroid/graphics/PorterDuff$Mode;)Lcom/flask/colorpicker/builder/PaintBuilder$PaintHolder;", "GetXPerMode_Landroid_graphics_PorterDuff_Mode_Handler")]
			public virtual unsafe global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder XPerMode (global::Android.Graphics.PorterDuff.Mode p0)
			{
				if (id_xPerMode_Landroid_graphics_PorterDuff_Mode_ == IntPtr.Zero)
					id_xPerMode_Landroid_graphics_PorterDuff_Mode_ = JNIEnv.GetMethodID (class_ref, "xPerMode", "(Landroid/graphics/PorterDuff$Mode;)Lcom/flask/colorpicker/builder/PaintBuilder$PaintHolder;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_xPerMode_Landroid_graphics_PorterDuff_Mode_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "xPerMode", "(Landroid/graphics/PorterDuff$Mode;)Lcom/flask/colorpicker/builder/PaintBuilder$PaintHolder;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/flask/colorpicker/builder/PaintBuilder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PaintBuilder); }
		}

		protected PaintBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.flask.colorpicker.builder']/class[@name='PaintBuilder']/constructor[@name='PaintBuilder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PaintBuilder ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (PaintBuilder)) {
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

		static IntPtr id_createAlphaPatternShader_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.builder']/class[@name='PaintBuilder']/method[@name='createAlphaPatternShader' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("createAlphaPatternShader", "(I)Landroid/graphics/Shader;", "")]
		public static unsafe global::Android.Graphics.Shader CreateAlphaPatternShader (int p0)
		{
			if (id_createAlphaPatternShader_I == IntPtr.Zero)
				id_createAlphaPatternShader_I = JNIEnv.GetStaticMethodID (class_ref, "createAlphaPatternShader", "(I)Landroid/graphics/Shader;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Shader> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createAlphaPatternShader_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_newPaint;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker.builder']/class[@name='PaintBuilder']/method[@name='newPaint' and count(parameter)=0]"
		[Register ("newPaint", "()Lcom/flask/colorpicker/builder/PaintBuilder$PaintHolder;", "")]
		public static unsafe global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder NewPaint ()
		{
			if (id_newPaint == IntPtr.Zero)
				id_newPaint = JNIEnv.GetStaticMethodID (class_ref, "newPaint", "()Lcom/flask/colorpicker/builder/PaintBuilder$PaintHolder;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Builder.PaintBuilder.PaintHolder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newPaint), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
