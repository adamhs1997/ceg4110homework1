using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Flask.Colorpicker.Renderer {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.flask.colorpicker.renderer']/class[@name='ColorWheelRenderOption']"
	[global::Android.Runtime.Register ("com/flask/colorpicker/renderer/ColorWheelRenderOption", DoNotGenerateAcw=true)]
	public partial class ColorWheelRenderOption : global::Java.Lang.Object {


		static IntPtr alpha_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.flask.colorpicker.renderer']/class[@name='ColorWheelRenderOption']/field[@name='alpha']"
		[Register ("alpha")]
		public float Alpha {
			get {
				if (alpha_jfieldId == IntPtr.Zero)
					alpha_jfieldId = JNIEnv.GetFieldID (class_ref, "alpha", "F");
				return JNIEnv.GetFloatField (((global::Java.Lang.Object) this).Handle, alpha_jfieldId);
			}
			set {
				if (alpha_jfieldId == IntPtr.Zero)
					alpha_jfieldId = JNIEnv.GetFieldID (class_ref, "alpha", "F");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, alpha_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr cSize_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.flask.colorpicker.renderer']/class[@name='ColorWheelRenderOption']/field[@name='cSize']"
		[Register ("cSize")]
		public float CSize {
			get {
				if (cSize_jfieldId == IntPtr.Zero)
					cSize_jfieldId = JNIEnv.GetFieldID (class_ref, "cSize", "F");
				return JNIEnv.GetFloatField (((global::Java.Lang.Object) this).Handle, cSize_jfieldId);
			}
			set {
				if (cSize_jfieldId == IntPtr.Zero)
					cSize_jfieldId = JNIEnv.GetFieldID (class_ref, "cSize", "F");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, cSize_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr density_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.flask.colorpicker.renderer']/class[@name='ColorWheelRenderOption']/field[@name='density']"
		[Register ("density")]
		public int Density {
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

		static IntPtr lightness_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.flask.colorpicker.renderer']/class[@name='ColorWheelRenderOption']/field[@name='lightness']"
		[Register ("lightness")]
		public float Lightness {
			get {
				if (lightness_jfieldId == IntPtr.Zero)
					lightness_jfieldId = JNIEnv.GetFieldID (class_ref, "lightness", "F");
				return JNIEnv.GetFloatField (((global::Java.Lang.Object) this).Handle, lightness_jfieldId);
			}
			set {
				if (lightness_jfieldId == IntPtr.Zero)
					lightness_jfieldId = JNIEnv.GetFieldID (class_ref, "lightness", "F");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, lightness_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr maxRadius_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.flask.colorpicker.renderer']/class[@name='ColorWheelRenderOption']/field[@name='maxRadius']"
		[Register ("maxRadius")]
		public float MaxRadius {
			get {
				if (maxRadius_jfieldId == IntPtr.Zero)
					maxRadius_jfieldId = JNIEnv.GetFieldID (class_ref, "maxRadius", "F");
				return JNIEnv.GetFloatField (((global::Java.Lang.Object) this).Handle, maxRadius_jfieldId);
			}
			set {
				if (maxRadius_jfieldId == IntPtr.Zero)
					maxRadius_jfieldId = JNIEnv.GetFieldID (class_ref, "maxRadius", "F");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, maxRadius_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr strokeWidth_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.flask.colorpicker.renderer']/class[@name='ColorWheelRenderOption']/field[@name='strokeWidth']"
		[Register ("strokeWidth")]
		public float StrokeWidth {
			get {
				if (strokeWidth_jfieldId == IntPtr.Zero)
					strokeWidth_jfieldId = JNIEnv.GetFieldID (class_ref, "strokeWidth", "F");
				return JNIEnv.GetFloatField (((global::Java.Lang.Object) this).Handle, strokeWidth_jfieldId);
			}
			set {
				if (strokeWidth_jfieldId == IntPtr.Zero)
					strokeWidth_jfieldId = JNIEnv.GetFieldID (class_ref, "strokeWidth", "F");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, strokeWidth_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr targetCanvas_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.flask.colorpicker.renderer']/class[@name='ColorWheelRenderOption']/field[@name='targetCanvas']"
		[Register ("targetCanvas")]
		public global::Android.Graphics.Canvas TargetCanvas {
			get {
				if (targetCanvas_jfieldId == IntPtr.Zero)
					targetCanvas_jfieldId = JNIEnv.GetFieldID (class_ref, "targetCanvas", "Landroid/graphics/Canvas;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, targetCanvas_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (targetCanvas_jfieldId == IntPtr.Zero)
					targetCanvas_jfieldId = JNIEnv.GetFieldID (class_ref, "targetCanvas", "Landroid/graphics/Canvas;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, targetCanvas_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/flask/colorpicker/renderer/ColorWheelRenderOption", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ColorWheelRenderOption); }
		}

		protected ColorWheelRenderOption (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.flask.colorpicker.renderer']/class[@name='ColorWheelRenderOption']/constructor[@name='ColorWheelRenderOption' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ColorWheelRenderOption ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ColorWheelRenderOption)) {
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

	}
}
