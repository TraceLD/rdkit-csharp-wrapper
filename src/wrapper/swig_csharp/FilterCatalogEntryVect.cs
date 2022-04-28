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

public class FilterCatalogEntryVect : global::System.IDisposable, global::System.Collections.IEnumerable
    , global::System.Collections.Generic.IList<FilterCatalogEntry>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FilterCatalogEntryVect(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FilterCatalogEntryVect obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FilterCatalogEntryVect() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RDKFuncsPINVOKE.delete_FilterCatalogEntryVect(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public FilterCatalogEntryVect(global::System.Collections.ICollection c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (FilterCatalogEntry element in c) {
      this.Add(element);
    }
  }

  public bool IsFixedSize {
    get {
      return false;
    }
  }

  public bool IsReadOnly {
    get {
      return false;
    }
  }

  public FilterCatalogEntry this[int index]  {
    get {
      return getitem(index);
    }
    set {
      setitem(index, value);
    }
  }

  public int Capacity {
    get {
      return (int)capacity();
    }
    set {
      if (value < size())
        throw new global::System.ArgumentOutOfRangeException("Capacity");
      reserve((uint)value);
    }
  }

  public int Count {
    get {
      return (int)size();
    }
  }

  public bool IsSynchronized {
    get {
      return false;
    }
  }

  public void CopyTo(FilterCatalogEntry[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(FilterCatalogEntry[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, FilterCatalogEntry[] array, int arrayIndex, int count)
  {
    if (array == null)
      throw new global::System.ArgumentNullException("array");
    if (index < 0)
      throw new global::System.ArgumentOutOfRangeException("index", "Value is less than zero");
    if (arrayIndex < 0)
      throw new global::System.ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (count < 0)
      throw new global::System.ArgumentOutOfRangeException("count", "Value is less than zero");
    if (array.Rank > 1)
      throw new global::System.ArgumentException("Multi dimensional array.", "array");
    if (index+count > this.Count || arrayIndex+count > array.Length)
      throw new global::System.ArgumentException("Number of elements to copy is too large.");
    for (int i=0; i<count; i++)
      array.SetValue(getitemcopy(index+i), arrayIndex+i);
  }

  global::System.Collections.Generic.IEnumerator<FilterCatalogEntry> global::System.Collections.Generic.IEnumerable<FilterCatalogEntry>.GetEnumerator() {
    return new FilterCatalogEntryVectEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new FilterCatalogEntryVectEnumerator(this);
  }

  public FilterCatalogEntryVectEnumerator GetEnumerator() {
    return new FilterCatalogEntryVectEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class FilterCatalogEntryVectEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<FilterCatalogEntry>
  {
    private FilterCatalogEntryVect collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public FilterCatalogEntryVectEnumerator(FilterCatalogEntryVect collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public FilterCatalogEntry Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (FilterCatalogEntry)currentObject;
      }
    }

    // Type-unsafe IEnumerator.Current
    object global::System.Collections.IEnumerator.Current {
      get {
        return Current;
      }
    }

    public bool MoveNext() {
      int size = collectionRef.Count;
      bool moveOkay = (currentIndex+1 < size) && (size == currentSize);
      if (moveOkay) {
        currentIndex++;
        currentObject = collectionRef[currentIndex];
      } else {
        currentObject = null;
      }
      return moveOkay;
    }

    public void Reset() {
      currentIndex = -1;
      currentObject = null;
      if (collectionRef.Count != currentSize) {
        throw new global::System.InvalidOperationException("Collection modified.");
      }
    }

    public void Dispose() {
        currentIndex = -1;
        currentObject = null;
    }
  }

  public void Clear() {
    RDKFuncsPINVOKE.FilterCatalogEntryVect_Clear(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Add(FilterCatalogEntry x) {
    RDKFuncsPINVOKE.FilterCatalogEntryVect_Add(swigCPtr, FilterCatalogEntry.getCPtr(x));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = RDKFuncsPINVOKE.FilterCatalogEntryVect_size(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private uint capacity() {
    uint ret = RDKFuncsPINVOKE.FilterCatalogEntryVect_capacity(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void reserve(uint n) {
    RDKFuncsPINVOKE.FilterCatalogEntryVect_reserve(swigCPtr, n);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public FilterCatalogEntryVect() : this(RDKFuncsPINVOKE.new_FilterCatalogEntryVect__SWIG_0(), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public FilterCatalogEntryVect(FilterCatalogEntryVect other) : this(RDKFuncsPINVOKE.new_FilterCatalogEntryVect__SWIG_1(FilterCatalogEntryVect.getCPtr(other)), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public FilterCatalogEntryVect(int capacity) : this(RDKFuncsPINVOKE.new_FilterCatalogEntryVect__SWIG_2(capacity), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  private FilterCatalogEntry getitemcopy(int index) {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.FilterCatalogEntryVect_getitemcopy(swigCPtr, index);
    FilterCatalogEntry ret = (cPtr == global::System.IntPtr.Zero) ? null : new FilterCatalogEntry(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private FilterCatalogEntry getitem(int index) {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.FilterCatalogEntryVect_getitem(swigCPtr, index);
    FilterCatalogEntry ret = (cPtr == global::System.IntPtr.Zero) ? null : new FilterCatalogEntry(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, FilterCatalogEntry val) {
    RDKFuncsPINVOKE.FilterCatalogEntryVect_setitem(swigCPtr, index, FilterCatalogEntry.getCPtr(val));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(FilterCatalogEntryVect values) {
    RDKFuncsPINVOKE.FilterCatalogEntryVect_AddRange(swigCPtr, FilterCatalogEntryVect.getCPtr(values));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public FilterCatalogEntryVect GetRange(int index, int count) {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.FilterCatalogEntryVect_GetRange(swigCPtr, index, count);
    FilterCatalogEntryVect ret = (cPtr == global::System.IntPtr.Zero) ? null : new FilterCatalogEntryVect(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, FilterCatalogEntry x) {
    RDKFuncsPINVOKE.FilterCatalogEntryVect_Insert(swigCPtr, index, FilterCatalogEntry.getCPtr(x));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, FilterCatalogEntryVect values) {
    RDKFuncsPINVOKE.FilterCatalogEntryVect_InsertRange(swigCPtr, index, FilterCatalogEntryVect.getCPtr(values));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    RDKFuncsPINVOKE.FilterCatalogEntryVect_RemoveAt(swigCPtr, index);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    RDKFuncsPINVOKE.FilterCatalogEntryVect_RemoveRange(swigCPtr, index, count);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public static FilterCatalogEntryVect Repeat(FilterCatalogEntry value, int count) {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.FilterCatalogEntryVect_Repeat(FilterCatalogEntry.getCPtr(value), count);
    FilterCatalogEntryVect ret = (cPtr == global::System.IntPtr.Zero) ? null : new FilterCatalogEntryVect(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    RDKFuncsPINVOKE.FilterCatalogEntryVect_Reverse__SWIG_0(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Reverse(int index, int count) {
    RDKFuncsPINVOKE.FilterCatalogEntryVect_Reverse__SWIG_1(swigCPtr, index, count);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, FilterCatalogEntryVect values) {
    RDKFuncsPINVOKE.FilterCatalogEntryVect_SetRange(swigCPtr, index, FilterCatalogEntryVect.getCPtr(values));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Contains(FilterCatalogEntry value) {
    bool ret = RDKFuncsPINVOKE.FilterCatalogEntryVect_Contains(swigCPtr, FilterCatalogEntry.getCPtr(value));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int IndexOf(FilterCatalogEntry value) {
    int ret = RDKFuncsPINVOKE.FilterCatalogEntryVect_IndexOf(swigCPtr, FilterCatalogEntry.getCPtr(value));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int LastIndexOf(FilterCatalogEntry value) {
    int ret = RDKFuncsPINVOKE.FilterCatalogEntryVect_LastIndexOf(swigCPtr, FilterCatalogEntry.getCPtr(value));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Remove(FilterCatalogEntry value) {
    bool ret = RDKFuncsPINVOKE.FilterCatalogEntryVect_Remove(swigCPtr, FilterCatalogEntry.getCPtr(value));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
