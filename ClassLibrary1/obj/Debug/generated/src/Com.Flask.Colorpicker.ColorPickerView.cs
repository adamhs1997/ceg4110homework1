using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Flask.Colorpicker {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerView']"
	[global::Android.Runtime.Register ("com/flask/colorpicker/ColorPickerView", DoNotGenerateAcw=true)]
	public partial class ColorPickerView : global::Android.Views.View {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerView.WHEEL_TYPE']"
		[global::Android.Runtime.Register ("com/flask/colorpicker/ColorPickerView$WHEEL_TYPE", DoNotGenerateAcw=true)]
		public sealed partial class WHEEL_TYPE : global::Java.Lang.Enum {


			static IntPtr CIRCLE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerView.WHEEL_TYPE']/field[@name='CIRCLE']"
			[Register ("CIRCLE")]
			public static global::Com.Flask.Colorpicker.ColorPickerView.WHEEL_TYPE Circle {
				get {
					if (CIRCLE_jfieldId == IntPtr.Zero)
						CIRCLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CIRCLE", "Lcom/flask/colorpicker/ColorPickerView$WHEEL_TYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CIRCLE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.ColorPickerView.WHEEL_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr FLOWER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerView.WHEEL_TYPE']/field[@name='FLOWER']"
			[Register ("FLOWER")]
			public static global::Com.Flask.Colorpicker.ColorPickerView.WHEEL_TYPE Flower {
				get {
					if (FLOWER_jfieldId == IntPtr.Zero)
						FLOWER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FLOWER", "Lcom/flask/colorpicker/ColorPickerView$WHEEL_TYPE;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FLOWER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.ColorPickerView.WHEEL_TYPE> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/flask/colorpicker/ColorPickerView$WHEEL_TYPE", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (WHEEL_TYPE); }
			}

			internal WHEEL_TYPE (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_indexOf_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerView.WHEEL_TYPE']/method[@name='indexOf' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("indexOf", "(I)Lcom/flask/colorpicker/ColorPickerView$WHEEL_TYPE;", "")]
			public static unsafe global::Com.Flask.Colorpicker.ColorPickerView.WHEEL_TYPE IndexOf (int p0)
			{
				if (id_indexOf_I == IntPtr.Zero)
					id_indexOf_I = JNIEnv.GetStaticMethodID (class_ref, "indexOf", "(I)Lcom/flask/colorpicker/ColorPickerView$WHEEL_TYPE;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					return global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.ColorPickerView.WHEEL_TYPE> (JNIEnv.CallStaticObjectMethod  (class_ref, id_indexOf_I, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerView.WHEEL_TYPE']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/flask/colorpicker/ColorPickerView$WHEEL_TYPE;", "")]
			public static unsafe global::Com.Flask.Colorpicker.ColorPickerView.WHEEL_TYPE ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/flask/colorpicker/ColorPickerView$WHEEL_TYPE;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Flask.Colorpicker.ColorPickerView.WHEEL_TYPE __ret = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.ColorPickerView.WHEEL_TYPE> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerView.WHEEL_TYPE']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/flask/colorpicker/ColorPickerView$WHEEL_TYPE;", "")]
			public static unsafe global::Com.Flask.Colorpicker.ColorPickerView.WHEEL_TYPE[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/flask/colorpicker/ColorPickerView$WHEEL_TYPE;");
				try {
					return (global::Com.Flask.Colorpicker.ColorPickerView.WHEEL_TYPE[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Flask.Colorpicker.ColorPickerView.WHEEL_TYPE));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/flask/colorpicker/ColorPickerView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ColorPickerView); }
		}

		protected ColorPickerView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerView']/constructor[@name='ColorPickerView' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;II)V", "")]
		public unsafe ColorPickerView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2, int p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				if (((object) this).GetType () != typeof (ColorPickerView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;II)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;II)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_II == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_II = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_II, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_II, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerView']/constructor[@name='ColorPickerView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe ColorPickerView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (ColorPickerView)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerView']/constructor[@name='ColorPickerView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe ColorPickerView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (ColorPickerView)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerView']/constructor[@name='ColorPickerView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe ColorPickerView (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (ColorPickerView)) {
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

		static Delegate cb_getSelectedColor;
#pragma warning disable 0169
		static Delegate GetGetSelectedColorHandler ()
		{
			if (cb_getSelectedColor == null)
				cb_getSelectedColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSelectedColor);
			return cb_getSelectedColor;
		}

		static int n_GetSelectedColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Flask.Colorpicker.ColorPickerView __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.ColorPickerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SelectedColor;
		}
#pragma warning restore 0169

		static Delegate cb_setSelectedColor_I;
#pragma warning disable 0169
		static Delegate GetSetSelectedColor_IHandler ()
		{
			if (cb_setSelectedColor_I == null)
				cb_setSelectedColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSelectedColor_I);
			return cb_setSelectedColor_I;
		}

		static void n_SetSelectedColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Flask.Colorpicker.ColorPickerView __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.ColorPickerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SelectedColor = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSelectedColor;
		static IntPtr id_setSelectedColor_I;
		public virtual unsafe int SelectedColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerView']/method[@name='getSelectedColor' and count(parameter)=0]"
			[Register ("getSelectedColor", "()I", "GetGetSelectedColorHandler")]
			get {
				if (id_getSelectedColor == IntPtr.Zero)
					id_getSelectedColor = JNIEnv.GetMethodID (class_ref, "getSelectedColor", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getSelectedColor);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSelectedColor", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerView']/method[@name='setSelectedColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSelectedColor", "(I)V", "GetSetSelectedColor_IHandler")]
			set {
				if (id_setSelectedColor_I == IntPtr.Zero)
					id_setSelectedColor_I = JNIEnv.GetMethodID (class_ref, "setSelectedColor", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSelectedColor_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSelectedColor", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_addOnColorChangedListener_Lcom_flask_colorpicker_OnColorChangedListener_;
#pragma warning disable 0169
		static Delegate GetAddOnColorChangedListener_Lcom_flask_colorpicker_OnColorChangedListener_Handler ()
		{
			if (cb_addOnColorChangedListener_Lcom_flask_colorpicker_OnColorChangedListener_ == null)
				cb_addOnColorChangedListener_Lcom_flask_colorpicker_OnColorChangedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddOnColorChangedListener_Lcom_flask_colorpicker_OnColorChangedListener_);
			return cb_addOnColorChangedListener_Lcom_flask_colorpicker_OnColorChangedListener_;
		}

		static void n_AddOnColorChangedListener_Lcom_flask_colorpicker_OnColorChangedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Flask.Colorpicker.ColorPickerView __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.ColorPickerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Flask.Colorpicker.IOnColorChangedListener p0 = (global::Com.Flask.Colorpicker.IOnColorChangedListener)global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.IOnColorChangedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddOnColorChangedListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addOnColorChangedListener_Lcom_flask_colorpicker_OnColorChangedListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerView']/method[@name='addOnColorChangedListener' and count(parameter)=1 and parameter[1][@type='com.flask.colorpicker.OnColorChangedListener']]"
		[Register ("addOnColorChangedListener", "(Lcom/flask/colorpicker/OnColorChangedListener;)V", "GetAddOnColorChangedListener_Lcom_flask_colorpicker_OnColorChangedListener_Handler")]
		public virtual unsafe void AddOnColorChangedListener (global::Com.Flask.Colorpicker.IOnColorChangedListener p0)
		{
			if (id_addOnColorChangedListener_Lcom_flask_colorpicker_OnColorChangedListener_ == IntPtr.Zero)
				id_addOnColorChangedListener_Lcom_flask_colorpicker_OnColorChangedListener_ = JNIEnv.GetMethodID (class_ref, "addOnColorChangedListener", "(Lcom/flask/colorpicker/OnColorChangedListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addOnColorChangedListener_Lcom_flask_colorpicker_OnColorChangedListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addOnColorChangedListener", "(Lcom/flask/colorpicker/OnColorChangedListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_addOnColorSelectedListener_Lcom_flask_colorpicker_OnColorSelectedListener_;
#pragma warning disable 0169
		static Delegate GetAddOnColorSelectedListener_Lcom_flask_colorpicker_OnColorSelectedListener_Handler ()
		{
			if (cb_addOnColorSelectedListener_Lcom_flask_colorpicker_OnColorSelectedListener_ == null)
				cb_addOnColorSelectedListener_Lcom_flask_colorpicker_OnColorSelectedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddOnColorSelectedListener_Lcom_flask_colorpicker_OnColorSelectedListener_);
			return cb_addOnColorSelectedListener_Lcom_flask_colorpicker_OnColorSelectedListener_;
		}

		static void n_AddOnColorSelectedListener_Lcom_flask_colorpicker_OnColorSelectedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Flask.Colorpicker.ColorPickerView __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.ColorPickerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Flask.Colorpicker.IOnColorSelectedListener p0 = (global::Com.Flask.Colorpicker.IOnColorSelectedListener)global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.IOnColorSelectedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddOnColorSelectedListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addOnColorSelectedListener_Lcom_flask_colorpicker_OnColorSelectedListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerView']/method[@name='addOnColorSelectedListener' and count(parameter)=1 and parameter[1][@type='com.flask.colorpicker.OnColorSelectedListener']]"
		[Register ("addOnColorSelectedListener", "(Lcom/flask/colorpicker/OnColorSelectedListener;)V", "GetAddOnColorSelectedListener_Lcom_flask_colorpicker_OnColorSelectedListener_Handler")]
		public virtual unsafe void AddOnColorSelectedListener (global::Com.Flask.Colorpicker.IOnColorSelectedListener p0)
		{
			if (id_addOnColorSelectedListener_Lcom_flask_colorpicker_OnColorSelectedListener_ == IntPtr.Zero)
				id_addOnColorSelectedListener_Lcom_flask_colorpicker_OnColorSelectedListener_ = JNIEnv.GetMethodID (class_ref, "addOnColorSelectedListener", "(Lcom/flask/colorpicker/OnColorSelectedListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addOnColorSelectedListener_Lcom_flask_colorpicker_OnColorSelectedListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addOnColorSelectedListener", "(Lcom/flask/colorpicker/OnColorSelectedListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_callOnColorChangedListeners_II;
#pragma warning disable 0169
		static Delegate GetCallOnColorChangedListeners_IIHandler ()
		{
			if (cb_callOnColorChangedListeners_II == null)
				cb_callOnColorChangedListeners_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_CallOnColorChangedListeners_II);
			return cb_callOnColorChangedListeners_II;
		}

		static void n_CallOnColorChangedListeners_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Flask.Colorpicker.ColorPickerView __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.ColorPickerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CallOnColorChangedListeners (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_callOnColorChangedListeners_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerView']/method[@name='callOnColorChangedListeners' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("callOnColorChangedListeners", "(II)V", "GetCallOnColorChangedListeners_IIHandler")]
		protected virtual unsafe void CallOnColorChangedListeners (int p0, int p1)
		{
			if (id_callOnColorChangedListeners_II == IntPtr.Zero)
				id_callOnColorChangedListeners_II = JNIEnv.GetMethodID (class_ref, "callOnColorChangedListeners", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_callOnColorChangedListeners_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "callOnColorChangedListeners", "(II)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getAllColors;
#pragma warning disable 0169
		static Delegate GetGetAllColorsHandler ()
		{
			if (cb_getAllColors == null)
				cb_getAllColors = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAllColors);
			return cb_getAllColors;
		}

		static IntPtr n_GetAllColors (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Flask.Colorpicker.ColorPickerView __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.ColorPickerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetAllColors ());
		}
#pragma warning restore 0169

		static IntPtr id_getAllColors;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerView']/method[@name='getAllColors' and count(parameter)=0]"
		[Register ("getAllColors", "()[Ljava/lang/Integer;", "GetGetAllColorsHandler")]
		public virtual unsafe global::Java.Lang.Integer[] GetAllColors ()
		{
			if (id_getAllColors == IntPtr.Zero)
				id_getAllColors = JNIEnv.GetMethodID (class_ref, "getAllColors", "()[Ljava/lang/Integer;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (global::Java.Lang.Integer[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAllColors), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Integer));
				else
					return (global::Java.Lang.Integer[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAllColors", "()[Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Integer));
			} finally {
			}
		}

		static Delegate cb_setAlphaSlider_Lcom_flask_colorpicker_slider_AlphaSlider_;
#pragma warning disable 0169
		static Delegate GetSetAlphaSlider_Lcom_flask_colorpicker_slider_AlphaSlider_Handler ()
		{
			if (cb_setAlphaSlider_Lcom_flask_colorpicker_slider_AlphaSlider_ == null)
				cb_setAlphaSlider_Lcom_flask_colorpicker_slider_AlphaSlider_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAlphaSlider_Lcom_flask_colorpicker_slider_AlphaSlider_);
			return cb_setAlphaSlider_Lcom_flask_colorpicker_slider_AlphaSlider_;
		}

		static void n_SetAlphaSlider_Lcom_flask_colorpicker_slider_AlphaSlider_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Flask.Colorpicker.ColorPickerView __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.ColorPickerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Flask.Colorpicker.Slider.AlphaSlider p0 = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Slider.AlphaSlider> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetAlphaSlider (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAlphaSlider_Lcom_flask_colorpicker_slider_AlphaSlider_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerView']/method[@name='setAlphaSlider' and count(parameter)=1 and parameter[1][@type='com.flask.colorpicker.slider.AlphaSlider']]"
		[Register ("setAlphaSlider", "(Lcom/flask/colorpicker/slider/AlphaSlider;)V", "GetSetAlphaSlider_Lcom_flask_colorpicker_slider_AlphaSlider_Handler")]
		public virtual unsafe void SetAlphaSlider (global::Com.Flask.Colorpicker.Slider.AlphaSlider p0)
		{
			if (id_setAlphaSlider_Lcom_flask_colorpicker_slider_AlphaSlider_ == IntPtr.Zero)
				id_setAlphaSlider_Lcom_flask_colorpicker_slider_AlphaSlider_ = JNIEnv.GetMethodID (class_ref, "setAlphaSlider", "(Lcom/flask/colorpicker/slider/AlphaSlider;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAlphaSlider_Lcom_flask_colorpicker_slider_AlphaSlider_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAlphaSlider", "(Lcom/flask/colorpicker/slider/AlphaSlider;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setAlphaValue_F;
#pragma warning disable 0169
		static Delegate GetSetAlphaValue_FHandler ()
		{
			if (cb_setAlphaValue_F == null)
				cb_setAlphaValue_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetAlphaValue_F);
			return cb_setAlphaValue_F;
		}

		static void n_SetAlphaValue_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Flask.Colorpicker.ColorPickerView __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.ColorPickerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAlphaValue (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAlphaValue_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerView']/method[@name='setAlphaValue' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setAlphaValue", "(F)V", "GetSetAlphaValue_FHandler")]
		public virtual unsafe void SetAlphaValue (float p0)
		{
			if (id_setAlphaValue_F == IntPtr.Zero)
				id_setAlphaValue_F = JNIEnv.GetMethodID (class_ref, "setAlphaValue", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAlphaValue_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAlphaValue", "(F)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setColor_IZ;
#pragma warning disable 0169
		static Delegate GetSetColor_IZHandler ()
		{
			if (cb_setColor_IZ == null)
				cb_setColor_IZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, bool>) n_SetColor_IZ);
			return cb_setColor_IZ;
		}

		static void n_SetColor_IZ (IntPtr jnienv, IntPtr native__this, int p0, bool p1)
		{
			global::Com.Flask.Colorpicker.ColorPickerView __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.ColorPickerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetColor (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setColor_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerView']/method[@name='setColor' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("setColor", "(IZ)V", "GetSetColor_IZHandler")]
		public virtual unsafe void SetColor (int p0, bool p1)
		{
			if (id_setColor_IZ == IntPtr.Zero)
				id_setColor_IZ = JNIEnv.GetMethodID (class_ref, "setColor", "(IZ)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setColor_IZ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setColor", "(IZ)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setColorEdit_Landroid_widget_EditText_;
#pragma warning disable 0169
		static Delegate GetSetColorEdit_Landroid_widget_EditText_Handler ()
		{
			if (cb_setColorEdit_Landroid_widget_EditText_ == null)
				cb_setColorEdit_Landroid_widget_EditText_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetColorEdit_Landroid_widget_EditText_);
			return cb_setColorEdit_Landroid_widget_EditText_;
		}

		static void n_SetColorEdit_Landroid_widget_EditText_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Flask.Colorpicker.ColorPickerView __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.ColorPickerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.EditText p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.EditText> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetColorEdit (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setColorEdit_Landroid_widget_EditText_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerView']/method[@name='setColorEdit' and count(parameter)=1 and parameter[1][@type='android.widget.EditText']]"
		[Register ("setColorEdit", "(Landroid/widget/EditText;)V", "GetSetColorEdit_Landroid_widget_EditText_Handler")]
		public virtual unsafe void SetColorEdit (global::Android.Widget.EditText p0)
		{
			if (id_setColorEdit_Landroid_widget_EditText_ == IntPtr.Zero)
				id_setColorEdit_Landroid_widget_EditText_ = JNIEnv.GetMethodID (class_ref, "setColorEdit", "(Landroid/widget/EditText;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setColorEdit_Landroid_widget_EditText_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setColorEdit", "(Landroid/widget/EditText;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setColorEditTextColor_I;
#pragma warning disable 0169
		static Delegate GetSetColorEditTextColor_IHandler ()
		{
			if (cb_setColorEditTextColor_I == null)
				cb_setColorEditTextColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetColorEditTextColor_I);
			return cb_setColorEditTextColor_I;
		}

		static void n_SetColorEditTextColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Flask.Colorpicker.ColorPickerView __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.ColorPickerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetColorEditTextColor (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setColorEditTextColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerView']/method[@name='setColorEditTextColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setColorEditTextColor", "(I)V", "GetSetColorEditTextColor_IHandler")]
		public virtual unsafe void SetColorEditTextColor (int p0)
		{
			if (id_setColorEditTextColor_I == IntPtr.Zero)
				id_setColorEditTextColor_I = JNIEnv.GetMethodID (class_ref, "setColorEditTextColor", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setColorEditTextColor_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setColorEditTextColor", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setColorPreview_Landroid_widget_LinearLayout_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetColorPreview_Landroid_widget_LinearLayout_Ljava_lang_Integer_Handler ()
		{
			if (cb_setColorPreview_Landroid_widget_LinearLayout_Ljava_lang_Integer_ == null)
				cb_setColorPreview_Landroid_widget_LinearLayout_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetColorPreview_Landroid_widget_LinearLayout_Ljava_lang_Integer_);
			return cb_setColorPreview_Landroid_widget_LinearLayout_Ljava_lang_Integer_;
		}

		static void n_SetColorPreview_Landroid_widget_LinearLayout_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Flask.Colorpicker.ColorPickerView __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.ColorPickerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.LinearLayout p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.LinearLayout> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetColorPreview (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setColorPreview_Landroid_widget_LinearLayout_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerView']/method[@name='setColorPreview' and count(parameter)=2 and parameter[1][@type='android.widget.LinearLayout'] and parameter[2][@type='java.lang.Integer']]"
		[Register ("setColorPreview", "(Landroid/widget/LinearLayout;Ljava/lang/Integer;)V", "GetSetColorPreview_Landroid_widget_LinearLayout_Ljava_lang_Integer_Handler")]
		public virtual unsafe void SetColorPreview (global::Android.Widget.LinearLayout p0, global::Java.Lang.Integer p1)
		{
			if (id_setColorPreview_Landroid_widget_LinearLayout_Ljava_lang_Integer_ == IntPtr.Zero)
				id_setColorPreview_Landroid_widget_LinearLayout_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setColorPreview", "(Landroid/widget/LinearLayout;Ljava/lang/Integer;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setColorPreview_Landroid_widget_LinearLayout_Ljava_lang_Integer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setColorPreview", "(Landroid/widget/LinearLayout;Ljava/lang/Integer;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setDensity_I;
#pragma warning disable 0169
		static Delegate GetSetDensity_IHandler ()
		{
			if (cb_setDensity_I == null)
				cb_setDensity_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDensity_I);
			return cb_setDensity_I;
		}

		static void n_SetDensity_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Flask.Colorpicker.ColorPickerView __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.ColorPickerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDensity (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDensity_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerView']/method[@name='setDensity' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setDensity", "(I)V", "GetSetDensity_IHandler")]
		public virtual unsafe void SetDensity (int p0)
		{
			if (id_setDensity_I == IntPtr.Zero)
				id_setDensity_I = JNIEnv.GetMethodID (class_ref, "setDensity", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDensity_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDensity", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setInitialColor_IZ;
#pragma warning disable 0169
		static Delegate GetSetInitialColor_IZHandler ()
		{
			if (cb_setInitialColor_IZ == null)
				cb_setInitialColor_IZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, bool>) n_SetInitialColor_IZ);
			return cb_setInitialColor_IZ;
		}

		static void n_SetInitialColor_IZ (IntPtr jnienv, IntPtr native__this, int p0, bool p1)
		{
			global::Com.Flask.Colorpicker.ColorPickerView __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.ColorPickerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetInitialColor (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setInitialColor_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerView']/method[@name='setInitialColor' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("setInitialColor", "(IZ)V", "GetSetInitialColor_IZHandler")]
		public virtual unsafe void SetInitialColor (int p0, bool p1)
		{
			if (id_setInitialColor_IZ == IntPtr.Zero)
				id_setInitialColor_IZ = JNIEnv.GetMethodID (class_ref, "setInitialColor", "(IZ)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setInitialColor_IZ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInitialColor", "(IZ)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setInitialColors_arrayLjava_lang_Integer_I;
#pragma warning disable 0169
		static Delegate GetSetInitialColors_arrayLjava_lang_Integer_IHandler ()
		{
			if (cb_setInitialColors_arrayLjava_lang_Integer_I == null)
				cb_setInitialColors_arrayLjava_lang_Integer_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_SetInitialColors_arrayLjava_lang_Integer_I);
			return cb_setInitialColors_arrayLjava_lang_Integer_I;
		}

		static void n_SetInitialColors_arrayLjava_lang_Integer_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Flask.Colorpicker.ColorPickerView __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.ColorPickerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer[] p0 = (global::Java.Lang.Integer[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Integer));
			__this.SetInitialColors (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setInitialColors_arrayLjava_lang_Integer_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerView']/method[@name='setInitialColors' and count(parameter)=2 and parameter[1][@type='java.lang.Integer[]'] and parameter[2][@type='int']]"
		[Register ("setInitialColors", "([Ljava/lang/Integer;I)V", "GetSetInitialColors_arrayLjava_lang_Integer_IHandler")]
		public virtual unsafe void SetInitialColors (global::Java.Lang.Integer[] p0, int p1)
		{
			if (id_setInitialColors_arrayLjava_lang_Integer_I == IntPtr.Zero)
				id_setInitialColors_arrayLjava_lang_Integer_I = JNIEnv.GetMethodID (class_ref, "setInitialColors", "([Ljava/lang/Integer;I)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setInitialColors_arrayLjava_lang_Integer_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInitialColors", "([Ljava/lang/Integer;I)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_setLightness_F;
#pragma warning disable 0169
		static Delegate GetSetLightness_FHandler ()
		{
			if (cb_setLightness_F == null)
				cb_setLightness_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetLightness_F);
			return cb_setLightness_F;
		}

		static void n_SetLightness_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Flask.Colorpicker.ColorPickerView __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.ColorPickerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetLightness (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setLightness_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerView']/method[@name='setLightness' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setLightness", "(F)V", "GetSetLightness_FHandler")]
		public virtual unsafe void SetLightness (float p0)
		{
			if (id_setLightness_F == IntPtr.Zero)
				id_setLightness_F = JNIEnv.GetMethodID (class_ref, "setLightness", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLightness_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLightness", "(F)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setLightnessSlider_Lcom_flask_colorpicker_slider_LightnessSlider_;
#pragma warning disable 0169
		static Delegate GetSetLightnessSlider_Lcom_flask_colorpicker_slider_LightnessSlider_Handler ()
		{
			if (cb_setLightnessSlider_Lcom_flask_colorpicker_slider_LightnessSlider_ == null)
				cb_setLightnessSlider_Lcom_flask_colorpicker_slider_LightnessSlider_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLightnessSlider_Lcom_flask_colorpicker_slider_LightnessSlider_);
			return cb_setLightnessSlider_Lcom_flask_colorpicker_slider_LightnessSlider_;
		}

		static void n_SetLightnessSlider_Lcom_flask_colorpicker_slider_LightnessSlider_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Flask.Colorpicker.ColorPickerView __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.ColorPickerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Flask.Colorpicker.Slider.LightnessSlider p0 = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Slider.LightnessSlider> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetLightnessSlider (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setLightnessSlider_Lcom_flask_colorpicker_slider_LightnessSlider_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerView']/method[@name='setLightnessSlider' and count(parameter)=1 and parameter[1][@type='com.flask.colorpicker.slider.LightnessSlider']]"
		[Register ("setLightnessSlider", "(Lcom/flask/colorpicker/slider/LightnessSlider;)V", "GetSetLightnessSlider_Lcom_flask_colorpicker_slider_LightnessSlider_Handler")]
		public virtual unsafe void SetLightnessSlider (global::Com.Flask.Colorpicker.Slider.LightnessSlider p0)
		{
			if (id_setLightnessSlider_Lcom_flask_colorpicker_slider_LightnessSlider_ == IntPtr.Zero)
				id_setLightnessSlider_Lcom_flask_colorpicker_slider_LightnessSlider_ = JNIEnv.GetMethodID (class_ref, "setLightnessSlider", "(Lcom/flask/colorpicker/slider/LightnessSlider;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLightnessSlider_Lcom_flask_colorpicker_slider_LightnessSlider_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLightnessSlider", "(Lcom/flask/colorpicker/slider/LightnessSlider;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setRenderer_Lcom_flask_colorpicker_renderer_ColorWheelRenderer_;
#pragma warning disable 0169
		static Delegate GetSetRenderer_Lcom_flask_colorpicker_renderer_ColorWheelRenderer_Handler ()
		{
			if (cb_setRenderer_Lcom_flask_colorpicker_renderer_ColorWheelRenderer_ == null)
				cb_setRenderer_Lcom_flask_colorpicker_renderer_ColorWheelRenderer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRenderer_Lcom_flask_colorpicker_renderer_ColorWheelRenderer_);
			return cb_setRenderer_Lcom_flask_colorpicker_renderer_ColorWheelRenderer_;
		}

		static void n_SetRenderer_Lcom_flask_colorpicker_renderer_ColorWheelRenderer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Flask.Colorpicker.ColorPickerView __this = global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.ColorPickerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Flask.Colorpicker.Renderer.IColorWheelRenderer p0 = (global::Com.Flask.Colorpicker.Renderer.IColorWheelRenderer)global::Java.Lang.Object.GetObject<global::Com.Flask.Colorpicker.Renderer.IColorWheelRenderer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetRenderer (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setRenderer_Lcom_flask_colorpicker_renderer_ColorWheelRenderer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.flask.colorpicker']/class[@name='ColorPickerView']/method[@name='setRenderer' and count(parameter)=1 and parameter[1][@type='com.flask.colorpicker.renderer.ColorWheelRenderer']]"
		[Register ("setRenderer", "(Lcom/flask/colorpicker/renderer/ColorWheelRenderer;)V", "GetSetRenderer_Lcom_flask_colorpicker_renderer_ColorWheelRenderer_Handler")]
		public virtual unsafe void SetRenderer (global::Com.Flask.Colorpicker.Renderer.IColorWheelRenderer p0)
		{
			if (id_setRenderer_Lcom_flask_colorpicker_renderer_ColorWheelRenderer_ == IntPtr.Zero)
				id_setRenderer_Lcom_flask_colorpicker_renderer_ColorWheelRenderer_ = JNIEnv.GetMethodID (class_ref, "setRenderer", "(Lcom/flask/colorpicker/renderer/ColorWheelRenderer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRenderer_Lcom_flask_colorpicker_renderer_ColorWheelRenderer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRenderer", "(Lcom/flask/colorpicker/renderer/ColorWheelRenderer;)V"), __args);
			} finally {
			}
		}

#region "Event implementation for Com.Flask.Colorpicker.IOnColorChangedListener"
		public event EventHandler<global::Com.Flask.Colorpicker.ColorChangedEventArgs> ColorChanged {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Flask.Colorpicker.IOnColorChangedListener, global::Com.Flask.Colorpicker.IOnColorChangedListenerImplementor>(
						ref weak_implementor_AddOnColorChangedListener,
						__CreateIOnColorChangedListenerImplementor,
						AddOnColorChangedListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Flask.Colorpicker.IOnColorChangedListener, global::Com.Flask.Colorpicker.IOnColorChangedListenerImplementor>(
						ref weak_implementor_AddOnColorChangedListener,
						global::Com.Flask.Colorpicker.IOnColorChangedListenerImplementor.__IsEmpty,
						__v => {throw new NotSupportedException ("Cannot unregister from Com.Flask.Colorpicker.IOnColorChangedListener.AddOnColorChangedListener");},
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_AddOnColorChangedListener;

		global::Com.Flask.Colorpicker.IOnColorChangedListenerImplementor __CreateIOnColorChangedListenerImplementor ()
		{
			return new global::Com.Flask.Colorpicker.IOnColorChangedListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Flask.Colorpicker.IOnColorSelectedListener"
		public event EventHandler<global::Com.Flask.Colorpicker.ColorSelectedEventArgs> ColorSelected {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Flask.Colorpicker.IOnColorSelectedListener, global::Com.Flask.Colorpicker.IOnColorSelectedListenerImplementor>(
						ref weak_implementor_AddOnColorSelectedListener,
						__CreateIOnColorSelectedListenerImplementor,
						AddOnColorSelectedListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Flask.Colorpicker.IOnColorSelectedListener, global::Com.Flask.Colorpicker.IOnColorSelectedListenerImplementor>(
						ref weak_implementor_AddOnColorSelectedListener,
						global::Com.Flask.Colorpicker.IOnColorSelectedListenerImplementor.__IsEmpty,
						__v => {throw new NotSupportedException ("Cannot unregister from Com.Flask.Colorpicker.IOnColorSelectedListener.AddOnColorSelectedListener");},
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_AddOnColorSelectedListener;

		global::Com.Flask.Colorpicker.IOnColorSelectedListenerImplementor __CreateIOnColorSelectedListenerImplementor ()
		{
			return new global::Com.Flask.Colorpicker.IOnColorSelectedListenerImplementor (this);
		}
#endregion
	}
}
