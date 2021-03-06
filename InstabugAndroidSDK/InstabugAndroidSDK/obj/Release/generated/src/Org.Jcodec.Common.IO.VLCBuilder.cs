using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Common.IO {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.common.io']/class[@name='VLCBuilder']"
	[global::Android.Runtime.Register ("org/jcodec/common/io/VLCBuilder", DoNotGenerateAcw=true)]
	public partial class VLCBuilder : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/common/io/VLCBuilder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VLCBuilder); }
		}

		protected VLCBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.common.io']/class[@name='VLCBuilder']/constructor[@name='VLCBuilder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VLCBuilder ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (VLCBuilder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
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

		static IntPtr id_ctor_arrayIarrayIarrayI;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.common.io']/class[@name='VLCBuilder']/constructor[@name='VLCBuilder' and count(parameter)=3 and parameter[1][@type='int[]'] and parameter[2][@type='int[]'] and parameter[3][@type='int[]']]"
		[Register (".ctor", "([I[I[I)V", "")]
		public unsafe VLCBuilder (int[] p0, int[] p1, int[] p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				if (GetType () != typeof (VLCBuilder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "([I[I[I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([I[I[I)V", __args);
					return;
				}

				if (id_ctor_arrayIarrayIarrayI == IntPtr.Zero)
					id_ctor_arrayIarrayIarrayI = JNIEnv.GetMethodID (class_ref, "<init>", "([I[I[I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayIarrayIarrayI, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayIarrayIarrayI, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static Delegate cb_getVLC;
#pragma warning disable 0169
		static Delegate GetGetVLCHandler ()
		{
			if (cb_getVLC == null)
				cb_getVLC = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVLC);
			return cb_getVLC;
		}

		static IntPtr n_GetVLC (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Common.IO.VLCBuilder __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.VLCBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.VLC);
		}
#pragma warning restore 0169

		static IntPtr id_getVLC;
		public virtual unsafe global::Org.Jcodec.Common.IO.VLC VLC {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.io']/class[@name='VLCBuilder']/method[@name='getVLC' and count(parameter)=0]"
			[Register ("getVLC", "()Lorg/jcodec/common/io/VLC;", "GetGetVLCHandler")]
			get {
				if (id_getVLC == IntPtr.Zero)
					id_getVLC = JNIEnv.GetMethodID (class_ref, "getVLC", "()Lorg/jcodec/common/io/VLC;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.VLC> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getVLC), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.VLC> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVLC", "()Lorg/jcodec/common/io/VLC;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_set_III;
#pragma warning disable 0169
		static Delegate GetSet_IIIHandler ()
		{
			if (cb_set_III == null)
				cb_set_III = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int, IntPtr>) n_Set_III);
			return cb_set_III;
		}

		static IntPtr n_Set_III (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2)
		{
			global::Org.Jcodec.Common.IO.VLCBuilder __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.VLCBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Set (p0, p1, p2));
		}
#pragma warning restore 0169

		static IntPtr id_set_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.io']/class[@name='VLCBuilder']/method[@name='set' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("set", "(III)Lorg/jcodec/common/io/VLCBuilder;", "GetSet_IIIHandler")]
		public virtual unsafe global::Org.Jcodec.Common.IO.VLCBuilder Set (int p0, int p1, int p2)
		{
			if (id_set_III == IntPtr.Zero)
				id_set_III = JNIEnv.GetMethodID (class_ref, "set", "(III)Lorg/jcodec/common/io/VLCBuilder;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.VLCBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_set_III, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.VLCBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set", "(III)Lorg/jcodec/common/io/VLCBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_set_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSet_ILjava_lang_String_Handler ()
		{
			if (cb_set_ILjava_lang_String_ == null)
				cb_set_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_Set_ILjava_lang_String_);
			return cb_set_ILjava_lang_String_;
		}

		static IntPtr n_Set_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Org.Jcodec.Common.IO.VLCBuilder __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.VLCBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Set (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_set_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.common.io']/class[@name='VLCBuilder']/method[@name='set' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("set", "(ILjava/lang/String;)Lorg/jcodec/common/io/VLCBuilder;", "GetSet_ILjava_lang_String_Handler")]
		public virtual unsafe global::Org.Jcodec.Common.IO.VLCBuilder Set (int p0, string p1)
		{
			if (id_set_ILjava_lang_String_ == IntPtr.Zero)
				id_set_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "set", "(ILjava/lang/String;)Lorg/jcodec/common/io/VLCBuilder;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				global::Org.Jcodec.Common.IO.VLCBuilder __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.VLCBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_set_ILjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Common.IO.VLCBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set", "(ILjava/lang/String;)Lorg/jcodec/common/io/VLCBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
