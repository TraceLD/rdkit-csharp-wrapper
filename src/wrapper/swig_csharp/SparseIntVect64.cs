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

public class SparseIntVect64 : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal SparseIntVect64(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SparseIntVect64 obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~SparseIntVect64() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RDKFuncsPINVOKE.delete_SparseIntVect64(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public SparseIntVect64() : this(RDKFuncsPINVOKE.new_SparseIntVect64__SWIG_0(), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public SparseIntVect64(long length) : this(RDKFuncsPINVOKE.new_SparseIntVect64__SWIG_1(length), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public SparseIntVect64(SparseIntVect64 other) : this(RDKFuncsPINVOKE.new_SparseIntVect64__SWIG_2(SparseIntVect64.getCPtr(other)), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public SparseIntVect64(string pkl) : this(RDKFuncsPINVOKE.new_SparseIntVect64__SWIG_3(pkl), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public SparseIntVect64(string pkl, uint len) : this(RDKFuncsPINVOKE.new_SparseIntVect64__SWIG_4(pkl, len), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public int getVal(long idx) {
    int ret = RDKFuncsPINVOKE.SparseIntVect64_getVal(swigCPtr, idx);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setVal(long idx, int val) {
    RDKFuncsPINVOKE.SparseIntVect64_setVal(swigCPtr, idx, val);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public long getLength() {
    long ret = RDKFuncsPINVOKE.SparseIntVect64_getLength(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int getTotalVal(bool doAbs) {
    int ret = RDKFuncsPINVOKE.SparseIntVect64_getTotalVal__SWIG_0(swigCPtr, doAbs);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int getTotalVal() {
    int ret = RDKFuncsPINVOKE.SparseIntVect64_getTotalVal__SWIG_1(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint size() {
    uint ret = RDKFuncsPINVOKE.SparseIntVect64_size(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_std__mapT_long_long_int_std__lessT_long_long_t_t getNonzeroElements() {
    SWIGTYPE_p_std__mapT_long_long_int_std__lessT_long_long_t_t ret = new SWIGTYPE_p_std__mapT_long_long_int_std__lessT_long_long_t_t(RDKFuncsPINVOKE.SparseIntVect64_getNonzeroElements(swigCPtr), false);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool eq(SparseIntVect64 v2) {
    bool ret = RDKFuncsPINVOKE.SparseIntVect64_eq(swigCPtr, SparseIntVect64.getCPtr(v2));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ne(SparseIntVect64 v2) {
    bool ret = RDKFuncsPINVOKE.SparseIntVect64_ne(swigCPtr, SparseIntVect64.getCPtr(v2));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string toString() {
    string ret = RDKFuncsPINVOKE.SparseIntVect64_toString(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void fromString(string txt) {
    RDKFuncsPINVOKE.SparseIntVect64_fromString(swigCPtr, txt);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public Long_Pair_Vect getNonzero() {
    Long_Pair_Vect ret = new Long_Pair_Vect(RDKFuncsPINVOKE.SparseIntVect64_getNonzero(swigCPtr), true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
