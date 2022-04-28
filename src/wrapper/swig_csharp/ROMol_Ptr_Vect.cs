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

public class ROMol_Ptr_Vect : global::System.IDisposable, global::System.Collections.IEnumerable
    , global::System.Collections.Generic.IList<ROMol>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ROMol_Ptr_Vect(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ROMol_Ptr_Vect obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ROMol_Ptr_Vect() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RDKFuncsPINVOKE.delete_ROMol_Ptr_Vect(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public ROMol_Ptr_Vect(global::System.Collections.ICollection c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (ROMol element in c) {
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

  public ROMol this[int index]  {
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

  public void CopyTo(ROMol[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(ROMol[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, ROMol[] array, int arrayIndex, int count)
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

  global::System.Collections.Generic.IEnumerator<ROMol> global::System.Collections.Generic.IEnumerable<ROMol>.GetEnumerator() {
    return new ROMol_Ptr_VectEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new ROMol_Ptr_VectEnumerator(this);
  }

  public ROMol_Ptr_VectEnumerator GetEnumerator() {
    return new ROMol_Ptr_VectEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class ROMol_Ptr_VectEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<ROMol>
  {
    private ROMol_Ptr_Vect collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public ROMol_Ptr_VectEnumerator(ROMol_Ptr_Vect collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public ROMol Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (ROMol)currentObject;
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
    RDKFuncsPINVOKE.ROMol_Ptr_Vect_Clear(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Add(ROMol x) {
    RDKFuncsPINVOKE.ROMol_Ptr_Vect_Add(swigCPtr, ROMol.getCPtr(x));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = RDKFuncsPINVOKE.ROMol_Ptr_Vect_size(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private uint capacity() {
    uint ret = RDKFuncsPINVOKE.ROMol_Ptr_Vect_capacity(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void reserve(uint n) {
    RDKFuncsPINVOKE.ROMol_Ptr_Vect_reserve(swigCPtr, n);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public ROMol_Ptr_Vect() : this(RDKFuncsPINVOKE.new_ROMol_Ptr_Vect__SWIG_0(), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public ROMol_Ptr_Vect(ROMol_Ptr_Vect other) : this(RDKFuncsPINVOKE.new_ROMol_Ptr_Vect__SWIG_1(ROMol_Ptr_Vect.getCPtr(other)), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public ROMol_Ptr_Vect(int capacity) : this(RDKFuncsPINVOKE.new_ROMol_Ptr_Vect__SWIG_2(capacity), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  private ROMol getitemcopy(int index) {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.ROMol_Ptr_Vect_getitemcopy(swigCPtr, index);
    ROMol ret = (cPtr == global::System.IntPtr.Zero) ? null : new ROMol(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private ROMol getitem(int index) {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.ROMol_Ptr_Vect_getitem(swigCPtr, index);
    ROMol ret = (cPtr == global::System.IntPtr.Zero) ? null : new ROMol(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, ROMol val) {
    RDKFuncsPINVOKE.ROMol_Ptr_Vect_setitem(swigCPtr, index, ROMol.getCPtr(val));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(ROMol_Ptr_Vect values) {
    RDKFuncsPINVOKE.ROMol_Ptr_Vect_AddRange(swigCPtr, ROMol_Ptr_Vect.getCPtr(values));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public ROMol_Ptr_Vect GetRange(int index, int count) {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.ROMol_Ptr_Vect_GetRange(swigCPtr, index, count);
    ROMol_Ptr_Vect ret = (cPtr == global::System.IntPtr.Zero) ? null : new ROMol_Ptr_Vect(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, ROMol x) {
    RDKFuncsPINVOKE.ROMol_Ptr_Vect_Insert(swigCPtr, index, ROMol.getCPtr(x));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, ROMol_Ptr_Vect values) {
    RDKFuncsPINVOKE.ROMol_Ptr_Vect_InsertRange(swigCPtr, index, ROMol_Ptr_Vect.getCPtr(values));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    RDKFuncsPINVOKE.ROMol_Ptr_Vect_RemoveAt(swigCPtr, index);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    RDKFuncsPINVOKE.ROMol_Ptr_Vect_RemoveRange(swigCPtr, index, count);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public static ROMol_Ptr_Vect Repeat(ROMol value, int count) {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.ROMol_Ptr_Vect_Repeat(ROMol.getCPtr(value), count);
    ROMol_Ptr_Vect ret = (cPtr == global::System.IntPtr.Zero) ? null : new ROMol_Ptr_Vect(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    RDKFuncsPINVOKE.ROMol_Ptr_Vect_Reverse__SWIG_0(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Reverse(int index, int count) {
    RDKFuncsPINVOKE.ROMol_Ptr_Vect_Reverse__SWIG_1(swigCPtr, index, count);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, ROMol_Ptr_Vect values) {
    RDKFuncsPINVOKE.ROMol_Ptr_Vect_SetRange(swigCPtr, index, ROMol_Ptr_Vect.getCPtr(values));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Contains(ROMol value) {
    bool ret = RDKFuncsPINVOKE.ROMol_Ptr_Vect_Contains(swigCPtr, ROMol.getCPtr(value));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int IndexOf(ROMol value) {
    int ret = RDKFuncsPINVOKE.ROMol_Ptr_Vect_IndexOf(swigCPtr, ROMol.getCPtr(value));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int LastIndexOf(ROMol value) {
    int ret = RDKFuncsPINVOKE.ROMol_Ptr_Vect_LastIndexOf(swigCPtr, ROMol.getCPtr(value));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Remove(ROMol value) {
    bool ret = RDKFuncsPINVOKE.ROMol_Ptr_Vect_Remove(swigCPtr, ROMol.getCPtr(value));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
