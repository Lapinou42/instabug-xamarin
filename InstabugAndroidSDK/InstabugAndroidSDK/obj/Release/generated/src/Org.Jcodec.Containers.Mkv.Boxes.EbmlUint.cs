using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Containers.Mkv.Boxes {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='EbmlUint']"
	[global::Android.Runtime.Register ("org/jcodec/containers/mkv/boxes/EbmlUint", DoNotGenerateAcw=true)]
	public partial class EbmlUint : global::Org.Jcodec.Containers.Mkv.Boxes.EbmlBin {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/containers/mkv/boxes/EbmlUint", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EbmlUint); }
		}

		protected EbmlUint (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='EbmlUint']/constructor[@name='EbmlUint' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register (".ctor", "([B)V", "")]
		public unsafe EbmlUint (byte[] p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (EbmlUint)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "([B)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([B)V", __args);
					return;
				}

				if (id_ctor_arrayB == IntPtr.Zero)
					id_ctor_arrayB = JNIEnv.GetMethodID (class_ref, "<init>", "([B)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayB, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayB, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_ctor_arrayBJ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='EbmlUint']/constructor[@name='EbmlUint' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='long']]"
		[Register (".ctor", "([BJ)V", "")]
		public unsafe EbmlUint (byte[] p0, long p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (EbmlUint)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "([BJ)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([BJ)V", __args);
					return;
				}

				if (id_ctor_arrayBJ == IntPtr.Zero)
					id_ctor_arrayBJ = JNIEnv.GetMethodID (class_ref, "<init>", "([BJ)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayBJ, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayBJ, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_calculatePayloadSize_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='EbmlUint']/method[@name='calculatePayloadSize' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("calculatePayloadSize", "(J)I", "")]
		public static unsafe int CalculatePayloadSize (long p0)
		{
			if (id_calculatePayloadSize_J == IntPtr.Zero)
				id_calculatePayloadSize_J = JNIEnv.GetStaticMethodID (class_ref, "calculatePayloadSize", "(J)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_calculatePayloadSize_J, __args);
			} finally {
			}
		}

		static Delegate cb_get;
#pragma warning disable 0169
		static Delegate GetGetHandler ()
		{
			if (cb_get == null)
				cb_get = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_Get);
			return cb_get;
		}

		static long n_Get (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Jcodec.Containers.Mkv.Boxes.EbmlUint __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.Boxes.EbmlUint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get ();
		}
#pragma warning restore 0169

		static IntPtr id_get;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='EbmlUint']/method[@name='get' and count(parameter)=0]"
		[Register ("get", "()J", "GetGetHandler")]
		public virtual unsafe long Get ()
		{
			if (id_get == IntPtr.Zero)
				id_get = JNIEnv.GetMethodID (class_ref, "get", "()J");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_get);
				else
					return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "get", "()J"));
			} finally {
			}
		}

		static IntPtr id_longToBytes_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='EbmlUint']/method[@name='longToBytes' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("longToBytes", "(J)[B", "")]
		public static unsafe byte[] LongToBytes (long p0)
		{
			if (id_longToBytes_J == IntPtr.Zero)
				id_longToBytes_J = JNIEnv.GetStaticMethodID (class_ref, "longToBytes", "(J)[B");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_longToBytes_J, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_set_J;
#pragma warning disable 0169
		static Delegate GetSet_JHandler ()
		{
			if (cb_set_J == null)
				cb_set_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_Set_J);
			return cb_set_J;
		}

		static void n_Set_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Org.Jcodec.Containers.Mkv.Boxes.EbmlUint __this = global::Java.Lang.Object.GetObject<global::Org.Jcodec.Containers.Mkv.Boxes.EbmlUint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Set (p0);
		}
#pragma warning restore 0169

		static IntPtr id_set_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.containers.mkv.boxes']/class[@name='EbmlUint']/method[@name='set' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("set", "(J)V", "GetSet_JHandler")]
		public virtual unsafe void Set (long p0)
		{
			if (id_set_J == IntPtr.Zero)
				id_set_J = JNIEnv.GetMethodID (class_ref, "set", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_set_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set", "(J)V"), __args);
			} finally {
			}
		}

	}
}
