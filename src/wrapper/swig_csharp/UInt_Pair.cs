//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace GraphMolWrap {

public class UInt_Pair : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal UInt_Pair(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UInt_Pair obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~UInt_Pair() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RDKFuncsPINVOKE.delete_UInt_Pair(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public UInt_Pair() : this(RDKFuncsPINVOKE.new_UInt_Pair__SWIG_0(), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public UInt_Pair(uint t, int u) : this(RDKFuncsPINVOKE.new_UInt_Pair__SWIG_1(t, u), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public UInt_Pair(UInt_Pair p) : this(RDKFuncsPINVOKE.new_UInt_Pair__SWIG_2(UInt_Pair.getCPtr(p)), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public uint first {
    set {
      RDKFuncsPINVOKE.UInt_Pair_first_set(swigCPtr, value);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      uint ret = RDKFuncsPINVOKE.UInt_Pair_first_get(swigCPtr);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int second {
    set {
      RDKFuncsPINVOKE.UInt_Pair_second_set(swigCPtr, value);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      int ret = RDKFuncsPINVOKE.UInt_Pair_second_get(swigCPtr);
      if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

}

}
