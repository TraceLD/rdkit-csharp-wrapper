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

public class ForceFieldContrib : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  private bool swigCMemOwnBase;

  internal ForceFieldContrib(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwnBase = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ForceFieldContrib obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ForceFieldContrib() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwnBase) {
          swigCMemOwnBase = false;
          RDKFuncsPINVOKE.delete_ForceFieldContrib(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public virtual double getEnergy(SWIGTYPE_p_double pos) {
    double ret = RDKFuncsPINVOKE.ForceFieldContrib_getEnergy(swigCPtr, SWIGTYPE_p_double.getCPtr(pos));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void getGrad(SWIGTYPE_p_double pos, SWIGTYPE_p_double grad) {
    RDKFuncsPINVOKE.ForceFieldContrib_getGrad(swigCPtr, SWIGTYPE_p_double.getCPtr(pos), SWIGTYPE_p_double.getCPtr(grad));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual ForceFieldContrib copy() {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.ForceFieldContrib_copy(swigCPtr);
    ForceFieldContrib ret = (cPtr == global::System.IntPtr.Zero) ? null : new ForceFieldContrib(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
