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

public class AromaticAtomIterator : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal AromaticAtomIterator(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(AromaticAtomIterator obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~AromaticAtomIterator() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RDKFuncsPINVOKE.delete_AromaticAtomIterator(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public AromaticAtomIterator() : this(RDKFuncsPINVOKE.new_AromaticAtomIterator__SWIG_0(), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public AromaticAtomIterator(ROMol mol) : this(RDKFuncsPINVOKE.new_AromaticAtomIterator__SWIG_1(ROMol.getCPtr(mol)), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public AromaticAtomIterator(ROMol mol, int pos) : this(RDKFuncsPINVOKE.new_AromaticAtomIterator__SWIG_2(ROMol.getCPtr(mol), pos), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public AromaticAtomIterator(AromaticAtomIterator other) : this(RDKFuncsPINVOKE.new_AromaticAtomIterator__SWIG_3(AromaticAtomIterator.getCPtr(other)), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool eq(AromaticAtomIterator other) {
    bool ret = RDKFuncsPINVOKE.AromaticAtomIterator_eq(swigCPtr, AromaticAtomIterator.getCPtr(other));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ne(AromaticAtomIterator other) {
    bool ret = RDKFuncsPINVOKE.AromaticAtomIterator_ne(swigCPtr, AromaticAtomIterator.getCPtr(other));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Atom getAtom() {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.AromaticAtomIterator_getAtom(swigCPtr);
    Atom ret = (cPtr == global::System.IntPtr.Zero) ? null : new Atom(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public AromaticAtomIterator next() {
    AromaticAtomIterator ret = new AromaticAtomIterator(RDKFuncsPINVOKE.AromaticAtomIterator_next__SWIG_0(swigCPtr), false);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public AromaticAtomIterator next(int arg0) {
    AromaticAtomIterator ret = new AromaticAtomIterator(RDKFuncsPINVOKE.AromaticAtomIterator_next__SWIG_1(swigCPtr, arg0), true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public AromaticAtomIterator prev() {
    AromaticAtomIterator ret = new AromaticAtomIterator(RDKFuncsPINVOKE.AromaticAtomIterator_prev__SWIG_0(swigCPtr), false);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public AromaticAtomIterator prev(int arg0) {
    AromaticAtomIterator ret = new AromaticAtomIterator(RDKFuncsPINVOKE.AromaticAtomIterator_prev__SWIG_1(swigCPtr, arg0), true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
