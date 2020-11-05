//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.0
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace mscl {

public class GpioFeatureBehaviors : global::System.IDisposable 
    , global::System.Collections.Generic.IDictionary<GpioConfiguration.Feature, GpioBehaviorModes>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal GpioFeatureBehaviors(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(GpioFeatureBehaviors obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~GpioFeatureBehaviors() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          msclPINVOKE.delete_GpioFeatureBehaviors(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }


  public GpioBehaviorModes this[GpioConfiguration.Feature key] {
    get {
      return getitem(key);
    }

    set {
      setitem(key, value);
    }
  }

  public bool TryGetValue(GpioConfiguration.Feature key, out GpioBehaviorModes value) {
    if (this.ContainsKey(key)) {
      value = this[key];
      return true;
    }
    value = default(GpioBehaviorModes);
    return false;
  }

  public int Count {
    get {
      return (int)size();
    }
  }

  public bool IsReadOnly {
    get {
      return false;
    }
  }

  public global::System.Collections.Generic.ICollection<GpioConfiguration.Feature> Keys {
    get {
      global::System.Collections.Generic.ICollection<GpioConfiguration.Feature> keys = new global::System.Collections.Generic.List<GpioConfiguration.Feature>();
      int size = this.Count;
      if (size > 0) {
        global::System.IntPtr iter = create_iterator_begin();
        for (int i = 0; i < size; i++) {
          keys.Add(get_next_key(iter));
        }
        destroy_iterator(iter);
      }
      return keys;
    }
  }

  public global::System.Collections.Generic.ICollection<GpioBehaviorModes> Values {
    get {
      global::System.Collections.Generic.ICollection<GpioBehaviorModes> vals = new global::System.Collections.Generic.List<GpioBehaviorModes>();
      foreach (global::System.Collections.Generic.KeyValuePair<GpioConfiguration.Feature, GpioBehaviorModes> pair in this) {
        vals.Add(pair.Value);
      }
      return vals;
    }
  }

  public void Add(global::System.Collections.Generic.KeyValuePair<GpioConfiguration.Feature, GpioBehaviorModes> item) {
    Add(item.Key, item.Value);
  }

  public bool Remove(global::System.Collections.Generic.KeyValuePair<GpioConfiguration.Feature, GpioBehaviorModes> item) {
    if (Contains(item)) {
      return Remove(item.Key);
    } else {
      return false;
    }
  }

  public bool Contains(global::System.Collections.Generic.KeyValuePair<GpioConfiguration.Feature, GpioBehaviorModes> item) {
    if (this[item.Key] == item.Value) {
      return true;
    } else {
      return false;
    }
  }

  public void CopyTo(global::System.Collections.Generic.KeyValuePair<GpioConfiguration.Feature, GpioBehaviorModes>[] array) {
    CopyTo(array, 0);
  }

  public void CopyTo(global::System.Collections.Generic.KeyValuePair<GpioConfiguration.Feature, GpioBehaviorModes>[] array, int arrayIndex) {
    if (array == null)
      throw new global::System.ArgumentNullException("array");
    if (arrayIndex < 0)
      throw new global::System.ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (array.Rank > 1)
      throw new global::System.ArgumentException("Multi dimensional array.", "array");
    if (arrayIndex+this.Count > array.Length)
      throw new global::System.ArgumentException("Number of elements to copy is too large.");

    global::System.Collections.Generic.IList<GpioConfiguration.Feature> keyList = new global::System.Collections.Generic.List<GpioConfiguration.Feature>(this.Keys);
    for (int i = 0; i < keyList.Count; i++) {
      GpioConfiguration.Feature currentKey = keyList[i];
      array.SetValue(new global::System.Collections.Generic.KeyValuePair<GpioConfiguration.Feature, GpioBehaviorModes>(currentKey, this[currentKey]), arrayIndex+i);
    }
  }

  global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<GpioConfiguration.Feature, GpioBehaviorModes>> global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<GpioConfiguration.Feature, GpioBehaviorModes>>.GetEnumerator() {
    return new GpioFeatureBehaviorsEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new GpioFeatureBehaviorsEnumerator(this);
  }

  public GpioFeatureBehaviorsEnumerator GetEnumerator() {
    return new GpioFeatureBehaviorsEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class GpioFeatureBehaviorsEnumerator : global::System.Collections.IEnumerator,
      global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<GpioConfiguration.Feature, GpioBehaviorModes>>
  {
    private GpioFeatureBehaviors collectionRef;
    private global::System.Collections.Generic.IList<GpioConfiguration.Feature> keyCollection;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public GpioFeatureBehaviorsEnumerator(GpioFeatureBehaviors collection) {
      collectionRef = collection;
      keyCollection = new global::System.Collections.Generic.List<GpioConfiguration.Feature>(collection.Keys);
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public global::System.Collections.Generic.KeyValuePair<GpioConfiguration.Feature, GpioBehaviorModes> Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (global::System.Collections.Generic.KeyValuePair<GpioConfiguration.Feature, GpioBehaviorModes>)currentObject;
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
        GpioConfiguration.Feature currentKey = keyCollection[currentIndex];
        currentObject = new global::System.Collections.Generic.KeyValuePair<GpioConfiguration.Feature, GpioBehaviorModes>(currentKey, collectionRef[currentKey]);
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


  public GpioFeatureBehaviors() : this(msclPINVOKE.new_GpioFeatureBehaviors__SWIG_0(), true) {
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public GpioFeatureBehaviors(GpioFeatureBehaviors other) : this(msclPINVOKE.new_GpioFeatureBehaviors__SWIG_1(GpioFeatureBehaviors.getCPtr(other)), true) {
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = msclPINVOKE.GpioFeatureBehaviors_size(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool empty() {
    bool ret = msclPINVOKE.GpioFeatureBehaviors_empty(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Clear() {
    msclPINVOKE.GpioFeatureBehaviors_Clear(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  private GpioBehaviorModes getitem(GpioConfiguration.Feature key) {
    GpioBehaviorModes ret = new GpioBehaviorModes(msclPINVOKE.GpioFeatureBehaviors_getitem(swigCPtr, (int)key), false);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(GpioConfiguration.Feature key, GpioBehaviorModes x) {
    msclPINVOKE.GpioFeatureBehaviors_setitem(swigCPtr, (int)key, GpioBehaviorModes.getCPtr(x));
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool ContainsKey(GpioConfiguration.Feature key) {
    bool ret = msclPINVOKE.GpioFeatureBehaviors_ContainsKey(swigCPtr, (int)key);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Add(GpioConfiguration.Feature key, GpioBehaviorModes value) {
    msclPINVOKE.GpioFeatureBehaviors_Add(swigCPtr, (int)key, GpioBehaviorModes.getCPtr(value));
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Remove(GpioConfiguration.Feature key) {
    bool ret = msclPINVOKE.GpioFeatureBehaviors_Remove(swigCPtr, (int)key);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private global::System.IntPtr create_iterator_begin() {
    global::System.IntPtr ret = msclPINVOKE.GpioFeatureBehaviors_create_iterator_begin(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private GpioConfiguration.Feature get_next_key(global::System.IntPtr swigiterator) {
    GpioConfiguration.Feature ret = (GpioConfiguration.Feature)msclPINVOKE.GpioFeatureBehaviors_get_next_key(swigCPtr, swigiterator);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void destroy_iterator(global::System.IntPtr swigiterator) {
    msclPINVOKE.GpioFeatureBehaviors_destroy_iterator(swigCPtr, swigiterator);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
