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

public class BondStretchContrib : ForceFieldContrib {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnDerived;

  internal BondStretchContrib(global::System.IntPtr cPtr, bool cMemoryOwn) : base(RDKFuncsPINVOKE.BondStretchContrib_SWIGSmartPtrUpcast(cPtr), true) {
    swigCMemOwnDerived = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(BondStretchContrib obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~BondStretchContrib() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnDerived) {
          swigCMemOwnDerived = false;
          RDKFuncsPINVOKE.delete_BondStretchContrib(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public BondStretchContrib() : this(RDKFuncsPINVOKE.new_BondStretchContrib__SWIG_0(), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public BondStretchContrib(ForceField owner, uint idx1, uint idx2, double bondOrder, AtomicParams end1Params, AtomicParams end2Params) : this(RDKFuncsPINVOKE.new_BondStretchContrib__SWIG_1(ForceField.getCPtr(owner), idx1, idx2, bondOrder, AtomicParams.getCPtr(end1Params), AtomicParams.getCPtr(end2Params)), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public override double getEnergy(SWIGTYPE_p_double pos) {
    double ret = RDKFuncsPINVOKE.BondStretchContrib_getEnergy(swigCPtr, SWIGTYPE_p_double.getCPtr(pos));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void getGrad(SWIGTYPE_p_double pos, SWIGTYPE_p_double grad) {
    RDKFuncsPINVOKE.BondStretchContrib_getGrad(swigCPtr, SWIGTYPE_p_double.getCPtr(pos), SWIGTYPE_p_double.getCPtr(grad));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public override ForceFieldContrib copy() {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.BondStretchContrib_copy(swigCPtr);
    BondStretchContrib ret = (cPtr == global::System.IntPtr.Zero) ? null : new BondStretchContrib(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
