using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mxf.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='IndexEntries']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mxf/model/IndexEntries", DoNotGenerateAcw=true)]
	public partial class IndexEntries : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mxf/model/IndexEntries", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IndexEntries); }
		}

		protected IndexEntries (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayBarrayBarrayBarrayJ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='IndexEntries']/constructor[@name='IndexEntries' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='long[]']]"
		[Register (".ctor", "([B[B[B[J)V", "")]
		public unsafe IndexEntries (byte[] p0, byte[] p1, byte[] p2, long[] p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				if (GetType () != typeof (IndexEntries)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "([B[B[B[J)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([B[B[B[J)V", __args);
					return;
				}

				if (id_ctor_arrayBarrayBarrayBarrayJ == IntPtr.Zero)
					id_ctor_arrayBarrayBarrayBarrayJ = JNIEnv.GetMethodID (class_ref, "<init>", "([B[B[B[J)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayBarrayBarrayBarrayJ, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayBarrayBarrayBarrayJ, __args);
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
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

		static Delegate cb_getDisplayOff;
#pragma warning disable 0169
		static Delegate GetGetDisplayOffHandler ()
		{
			if (cb_getDisplayOff == null)
				cb_getDisplayOff = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDisplayOff);
			return cb_getDisplayOff;
		}

		static IntPtr n_GetDisplayOff (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.IndexEntries __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.IndexEntries> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetDisplayOff ());
		}
#pragma warning restore 0169

		static IntPtr id_getDisplayOff;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='IndexEntries']/method[@name='getDisplayOff' and count(parameter)=0]"
		[Register ("getDisplayOff", "()[B", "GetGetDisplayOffHandler")]
		public virtual unsafe byte[] GetDisplayOff ()
		{
			if (id_getDisplayOff == IntPtr.Zero)
				id_getDisplayOff = JNIEnv.GetMethodID (class_ref, "getDisplayOff", "()[B");
			try {

				if (GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDisplayOff), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDisplayOff", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_getFileOff;
#pragma warning disable 0169
		static Delegate GetGetFileOffHandler ()
		{
			if (cb_getFileOff == null)
				cb_getFileOff = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFileOff);
			return cb_getFileOff;
		}

		static IntPtr n_GetFileOff (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.IndexEntries __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.IndexEntries> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetFileOff ());
		}
#pragma warning restore 0169

		static IntPtr id_getFileOff;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='IndexEntries']/method[@name='getFileOff' and count(parameter)=0]"
		[Register ("getFileOff", "()[J", "GetGetFileOffHandler")]
		public virtual unsafe long[] GetFileOff ()
		{
			if (id_getFileOff == IntPtr.Zero)
				id_getFileOff = JNIEnv.GetMethodID (class_ref, "getFileOff", "()[J");
			try {

				if (GetType () == ThresholdType)
					return (long[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFileOff), JniHandleOwnership.TransferLocalRef, typeof (long));
				else
					return (long[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFileOff", "()[J")), JniHandleOwnership.TransferLocalRef, typeof (long));
			} finally {
			}
		}

		static Delegate cb_getFlags;
#pragma warning disable 0169
		static Delegate GetGetFlagsHandler ()
		{
			if (cb_getFlags == null)
				cb_getFlags = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFlags);
			return cb_getFlags;
		}

		static IntPtr n_GetFlags (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.IndexEntries __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.IndexEntries> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetFlags ());
		}
#pragma warning restore 0169

		static IntPtr id_getFlags;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='IndexEntries']/method[@name='getFlags' and count(parameter)=0]"
		[Register ("getFlags", "()[B", "GetGetFlagsHandler")]
		public virtual unsafe byte[] GetFlags ()
		{
			if (id_getFlags == IntPtr.Zero)
				id_getFlags = JNIEnv.GetMethodID (class_ref, "getFlags", "()[B");
			try {

				if (GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFlags), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFlags", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_getKeyFrameOff;
#pragma warning disable 0169
		static Delegate GetGetKeyFrameOffHandler ()
		{
			if (cb_getKeyFrameOff == null)
				cb_getKeyFrameOff = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetKeyFrameOff);
			return cb_getKeyFrameOff;
		}

		static IntPtr n_GetKeyFrameOff (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mxf.Model.IndexEntries __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.IndexEntries> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetKeyFrameOff ());
		}
#pragma warning restore 0169

		static IntPtr id_getKeyFrameOff;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='IndexEntries']/method[@name='getKeyFrameOff' and count(parameter)=0]"
		[Register ("getKeyFrameOff", "()[B", "GetGetKeyFrameOffHandler")]
		public virtual unsafe byte[] GetKeyFrameOff ()
		{
			if (id_getKeyFrameOff == IntPtr.Zero)
				id_getKeyFrameOff = JNIEnv.GetMethodID (class_ref, "getKeyFrameOff", "()[B");
			try {

				if (GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getKeyFrameOff), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getKeyFrameOff", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static IntPtr id_read_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mxf.model']/class[@name='IndexEntries']/method[@name='read' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("read", "(Ljava/nio/ByteBuffer;)Lorg/jcodec/containers/mxf/model/IndexEntries;", "")]
		public static unsafe global::Org.Jcodec.Containers.Mxf.Model.IndexEntries Read (global::Java.Nio.ByteBuffer p0)
		{
			if (id_read_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_read_Ljava_nio_ByteBuffer_ = JNIEnv.GetStaticMethodID (class_ref, "read", "(Ljava/nio/ByteBuffer;)Lorg/jcodec/containers/mxf/model/IndexEntries;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Org.Jcodec.Containers.Mxf.Model.IndexEntries __ret = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mxf.Model.IndexEntries> (JNIEnv.CallStaticObjectMethod  (class_ref, id_read_Ljava_nio_ByteBuffer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
