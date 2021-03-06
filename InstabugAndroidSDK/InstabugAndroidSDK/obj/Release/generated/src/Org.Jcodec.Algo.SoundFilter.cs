using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Jcodec.Algo {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.jcodec.algo']/class[@name='SoundFilter']"
	[global::Android.Runtime.Register ("org/jcodec/algo/SoundFilter", DoNotGenerateAcw=true)]
	public partial class SoundFilter : global::Java.Lang.Object {


		static IntPtr linear_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.algo']/class[@name='SoundFilter']/field[@name='linear']"
		[Register ("linear")]
		public static IList<int> Linear {
			get {
				if (linear_jfieldId == IntPtr.Zero)
					linear_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "linear", "[I");
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, linear_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr sine_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.jcodec.algo']/class[@name='SoundFilter']/field[@name='sine']"
		[Register ("sine")]
		public static IList<int> Sine {
			get {
				if (sine_jfieldId == IntPtr.Zero)
					sine_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "sine", "[I");
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, sine_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/jcodec/algo/SoundFilter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SoundFilter); }
		}

		protected SoundFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.jcodec.algo']/class[@name='SoundFilter']/constructor[@name='SoundFilter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SoundFilter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (SoundFilter)) {
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

		static IntPtr id_in16BitSignedLE_arrayBIarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.algo']/class[@name='SoundFilter']/method[@name='in16BitSignedLE' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int[]']]"
		[Register ("in16BitSignedLE", "([BI[I)V", "")]
		public static unsafe void In16BitSignedLE (byte[] p0, int p1, int[] p2)
		{
			if (id_in16BitSignedLE_arrayBIarrayI == IntPtr.Zero)
				id_in16BitSignedLE_arrayBIarrayI = JNIEnv.GetStaticMethodID (class_ref, "in16BitSignedLE", "([BI[I)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_in16BitSignedLE_arrayBIarrayI, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static IntPtr id_out16BitSignedLE_arrayBIarrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.jcodec.algo']/class[@name='SoundFilter']/method[@name='out16BitSignedLE' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int[]']]"
		[Register ("out16BitSignedLE", "([BI[I)V", "")]
		public static unsafe void Out16BitSignedLE (byte[] p0, int p1, int[] p2)
		{
			if (id_out16BitSignedLE_arrayBIarrayI == IntPtr.Zero)
				id_out16BitSignedLE_arrayBIarrayI = JNIEnv.GetStaticMethodID (class_ref, "out16BitSignedLE", "([BI[I)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_out16BitSignedLE_arrayBIarrayI, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

	}
}
