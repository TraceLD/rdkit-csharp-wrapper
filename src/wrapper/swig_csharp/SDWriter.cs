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

public class SDWriter : MolWriter {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal SDWriter(global::System.IntPtr cPtr, bool cMemoryOwn) : base(RDKFuncsPINVOKE.SDWriter_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SDWriter obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~SDWriter() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RDKFuncsPINVOKE.delete_SDWriter(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public SDWriter(string fileName) : this(RDKFuncsPINVOKE.new_SDWriter__SWIG_0(fileName), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public SDWriter(SWIGTYPE_p_std__ostream outStream, bool takeOwnership) : this(RDKFuncsPINVOKE.new_SDWriter__SWIG_1(SWIGTYPE_p_std__ostream.getCPtr(outStream), takeOwnership), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public SDWriter(SWIGTYPE_p_std__ostream outStream) : this(RDKFuncsPINVOKE.new_SDWriter__SWIG_2(SWIGTYPE_p_std__ostream.getCPtr(outStream)), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void setProps(Str_Vect propNames) {
    RDKFuncsPINVOKE.SDWriter_setProps(swigCPtr, Str_Vect.getCPtr(propNames));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public static string getText(ROMol mol, int confId, bool kekulize, bool force_V3000, int molid, Str_Vect propNames) {
    string ret = RDKFuncsPINVOKE.SDWriter_getText__SWIG_0(ROMol.getCPtr(mol), confId, kekulize, force_V3000, molid, Str_Vect.getCPtr(propNames));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static string getText(ROMol mol, int confId, bool kekulize, bool force_V3000, int molid) {
    string ret = RDKFuncsPINVOKE.SDWriter_getText__SWIG_1(ROMol.getCPtr(mol), confId, kekulize, force_V3000, molid);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static string getText(ROMol mol, int confId, bool kekulize, bool force_V3000) {
    string ret = RDKFuncsPINVOKE.SDWriter_getText__SWIG_2(ROMol.getCPtr(mol), confId, kekulize, force_V3000);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static string getText(ROMol mol, int confId, bool kekulize) {
    string ret = RDKFuncsPINVOKE.SDWriter_getText__SWIG_3(ROMol.getCPtr(mol), confId, kekulize);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static string getText(ROMol mol, int confId) {
    string ret = RDKFuncsPINVOKE.SDWriter_getText__SWIG_4(ROMol.getCPtr(mol), confId);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static string getText(ROMol mol) {
    string ret = RDKFuncsPINVOKE.SDWriter_getText__SWIG_5(ROMol.getCPtr(mol));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void write(ROMol mol, int confId) {
    RDKFuncsPINVOKE.SDWriter_write__SWIG_0(swigCPtr, ROMol.getCPtr(mol), confId);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void write(ROMol mol) {
    RDKFuncsPINVOKE.SDWriter_write__SWIG_1(swigCPtr, ROMol.getCPtr(mol));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void flush() {
    RDKFuncsPINVOKE.SDWriter_flush(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void close() {
    RDKFuncsPINVOKE.SDWriter_close(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public override uint numMols() {
    uint ret = RDKFuncsPINVOKE.SDWriter_numMols(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setForceV3000(bool val) {
    RDKFuncsPINVOKE.SDWriter_setForceV3000(swigCPtr, val);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool getForceV3000() {
    bool ret = RDKFuncsPINVOKE.SDWriter_getForceV3000(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setKekulize(bool val) {
    RDKFuncsPINVOKE.SDWriter_setKekulize(swigCPtr, val);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool getKekulize() {
    bool ret = RDKFuncsPINVOKE.SDWriter_getKekulize(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}