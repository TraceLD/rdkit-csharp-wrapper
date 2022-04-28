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

public class AbbreviationDefinition_Vect : global::System.IDisposable, global::System.Collections.IEnumerable
    , global::System.Collections.Generic.IEnumerable<AbbreviationDefinition>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal AbbreviationDefinition_Vect(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(AbbreviationDefinition_Vect obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~AbbreviationDefinition_Vect() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RDKFuncsPINVOKE.delete_AbbreviationDefinition_Vect(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public AbbreviationDefinition_Vect(global::System.Collections.ICollection c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (AbbreviationDefinition element in c) {
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

  public AbbreviationDefinition this[int index]  {
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

  public void CopyTo(AbbreviationDefinition[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(AbbreviationDefinition[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, AbbreviationDefinition[] array, int arrayIndex, int count)
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

  global::System.Collections.Generic.IEnumerator<AbbreviationDefinition> global::System.Collections.Generic.IEnumerable<AbbreviationDefinition>.GetEnumerator() {
    return new AbbreviationDefinition_VectEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new AbbreviationDefinition_VectEnumerator(this);
  }

  public AbbreviationDefinition_VectEnumerator GetEnumerator() {
    return new AbbreviationDefinition_VectEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class AbbreviationDefinition_VectEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<AbbreviationDefinition>
  {
    private AbbreviationDefinition_Vect collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public AbbreviationDefinition_VectEnumerator(AbbreviationDefinition_Vect collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public AbbreviationDefinition Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (AbbreviationDefinition)currentObject;
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
    RDKFuncsPINVOKE.AbbreviationDefinition_Vect_Clear(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Add(AbbreviationDefinition x) {
    RDKFuncsPINVOKE.AbbreviationDefinition_Vect_Add(swigCPtr, AbbreviationDefinition.getCPtr(x));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = RDKFuncsPINVOKE.AbbreviationDefinition_Vect_size(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private uint capacity() {
    uint ret = RDKFuncsPINVOKE.AbbreviationDefinition_Vect_capacity(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void reserve(uint n) {
    RDKFuncsPINVOKE.AbbreviationDefinition_Vect_reserve(swigCPtr, n);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public AbbreviationDefinition_Vect() : this(RDKFuncsPINVOKE.new_AbbreviationDefinition_Vect__SWIG_0(), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public AbbreviationDefinition_Vect(AbbreviationDefinition_Vect other) : this(RDKFuncsPINVOKE.new_AbbreviationDefinition_Vect__SWIG_1(AbbreviationDefinition_Vect.getCPtr(other)), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public AbbreviationDefinition_Vect(int capacity) : this(RDKFuncsPINVOKE.new_AbbreviationDefinition_Vect__SWIG_2(capacity), true) {
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  private AbbreviationDefinition getitemcopy(int index) {
    AbbreviationDefinition ret = new AbbreviationDefinition(RDKFuncsPINVOKE.AbbreviationDefinition_Vect_getitemcopy(swigCPtr, index), true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private AbbreviationDefinition getitem(int index) {
    AbbreviationDefinition ret = new AbbreviationDefinition(RDKFuncsPINVOKE.AbbreviationDefinition_Vect_getitem(swigCPtr, index), false);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, AbbreviationDefinition val) {
    RDKFuncsPINVOKE.AbbreviationDefinition_Vect_setitem(swigCPtr, index, AbbreviationDefinition.getCPtr(val));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(AbbreviationDefinition_Vect values) {
    RDKFuncsPINVOKE.AbbreviationDefinition_Vect_AddRange(swigCPtr, AbbreviationDefinition_Vect.getCPtr(values));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public AbbreviationDefinition_Vect GetRange(int index, int count) {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.AbbreviationDefinition_Vect_GetRange(swigCPtr, index, count);
    AbbreviationDefinition_Vect ret = (cPtr == global::System.IntPtr.Zero) ? null : new AbbreviationDefinition_Vect(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, AbbreviationDefinition x) {
    RDKFuncsPINVOKE.AbbreviationDefinition_Vect_Insert(swigCPtr, index, AbbreviationDefinition.getCPtr(x));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, AbbreviationDefinition_Vect values) {
    RDKFuncsPINVOKE.AbbreviationDefinition_Vect_InsertRange(swigCPtr, index, AbbreviationDefinition_Vect.getCPtr(values));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    RDKFuncsPINVOKE.AbbreviationDefinition_Vect_RemoveAt(swigCPtr, index);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    RDKFuncsPINVOKE.AbbreviationDefinition_Vect_RemoveRange(swigCPtr, index, count);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public static AbbreviationDefinition_Vect Repeat(AbbreviationDefinition value, int count) {
    global::System.IntPtr cPtr = RDKFuncsPINVOKE.AbbreviationDefinition_Vect_Repeat(AbbreviationDefinition.getCPtr(value), count);
    AbbreviationDefinition_Vect ret = (cPtr == global::System.IntPtr.Zero) ? null : new AbbreviationDefinition_Vect(cPtr, true);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    RDKFuncsPINVOKE.AbbreviationDefinition_Vect_Reverse__SWIG_0(swigCPtr);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Reverse(int index, int count) {
    RDKFuncsPINVOKE.AbbreviationDefinition_Vect_Reverse__SWIG_1(swigCPtr, index, count);
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, AbbreviationDefinition_Vect values) {
    RDKFuncsPINVOKE.AbbreviationDefinition_Vect_SetRange(swigCPtr, index, AbbreviationDefinition_Vect.getCPtr(values));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool equals(AbbreviationDefinition_Vect o) {
    bool ret = RDKFuncsPINVOKE.AbbreviationDefinition_Vect_equals(swigCPtr, AbbreviationDefinition_Vect.getCPtr(o));
    if (RDKFuncsPINVOKE.SWIGPendingException.Pending) throw RDKFuncsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
