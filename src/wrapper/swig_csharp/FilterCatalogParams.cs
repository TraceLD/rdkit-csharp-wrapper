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

public class FilterCatalogParams : CatalogParams {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FilterCatalogParams(global::System.IntPtr cPtr, bool cMemoryOwn) : base(RDKFuncsPINVOKE.FilterCatalogParams_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FilterCatalogParams obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FilterCatalogParams() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RDKFuncsPINVOKE.delete_FilterCatalogParams(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public FilterCatalogParams() : this(RDKFuncsPINVOKE.new_FilterCatalogParams__SWIG_0(), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public FilterCatalogParams(FilterCatalogParams.FilterCatalogs catalogs) : this(RDKFuncsPINVOKE.new_FilterCatalogParams__SWIG_1((int)catalogs), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public FilterCatalogParams(FilterCatalogParams other) : this(RDKFuncsPINVOKE.new_FilterCatalogParams__SWIG_2(FilterCatalogParams.getCPtr(other)), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual bool addCatalog(FilterCatalogParams.FilterCatalogs catalogs) {
    bool ret = RDKFuncsPINVOKE.FilterCatalogParams_addCatalog(swigCPtr, (int)catalogs);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_std__vectorT_RDKit__FilterCatalogParams__FilterCatalogs_t getCatalogs() {
    SWIGTYPE_p_std__vectorT_RDKit__FilterCatalogParams__FilterCatalogs_t ret = new SWIGTYPE_p_std__vectorT_RDKit__FilterCatalogParams__FilterCatalogs_t(RDKFuncsPINVOKE.FilterCatalogParams_getCatalogs(swigCPtr), false);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void fillCatalog(FilterCatalog catalog) {
    RDKFuncsPINVOKE.FilterCatalogParams_fillCatalog(swigCPtr, FilterCatalog.getCPtr(catalog));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void toStream(SWIGTYPE_p_std__ostream ss) {
    RDKFuncsPINVOKE.FilterCatalogParams_toStream(swigCPtr, SWIGTYPE_p_std__ostream.getCPtr(ss));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public override string Serialize() {
    string ret = RDKFuncsPINVOKE.FilterCatalogParams_Serialize(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void initFromStream(SWIGTYPE_p_std__istream ss) {
    RDKFuncsPINVOKE.FilterCatalogParams_initFromStream(swigCPtr, SWIGTYPE_p_std__istream.getCPtr(ss));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void initFromString(string text) {
    RDKFuncsPINVOKE.FilterCatalogParams_initFromString(swigCPtr, text);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public enum FilterCatalogs : uint {
    PAINS_A = (1u << 1),
    PAINS_B = (1u << 2),
    PAINS_C = (1u << 3),
    PAINS = PAINS_A|PAINS_B|PAINS_C,
    BRENK = (1u << 4),
    NIH = (1u << 5),
    ZINC = (1u << 6),
    ALL = PAINS|BRENK|NIH|ZINC
  }

}

}
