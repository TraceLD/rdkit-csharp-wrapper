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

public class CachedMolHolder : MolHolderBase {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal CachedMolHolder(global::System.IntPtr cPtr, bool cMemoryOwn) : base(RDKFuncsPINVOKE.CachedMolHolder_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CachedMolHolder obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CachedMolHolder() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          RDKFuncsPINVOKE.delete_CachedMolHolder(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public CachedMolHolder() : this(RDKFuncsPINVOKE.new_CachedMolHolder(), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public override uint addMol(ROMol m) {
    uint ret = RDKFuncsPINVOKE.CachedMolHolder_addMol(swigCPtr, ROMol.getCPtr(m));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint addBinary(string pickle) {
    uint ret = RDKFuncsPINVOKE.CachedMolHolder_addBinary(swigCPtr, pickle);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override ROMol getMol(uint idx) {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.CachedMolHolder_getMol(swigCPtr, idx);
    ROMol ret = (cPtr == global::System.IntPtr.Zero) ? null : new ROMol(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override uint size() {
    uint ret = RDKFuncsPINVOKE.CachedMolHolder_size(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Str_Vect getMols() {
    Str_Vect ret = new Str_Vect(RDKFuncsPINVOKE.CachedMolHolder_getMols__SWIG_0(swigCPtr), false);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}