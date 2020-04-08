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

public class AdvancedLowPassFilterData : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal AdvancedLowPassFilterData(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(AdvancedLowPassFilterData obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~AdvancedLowPassFilterData() {
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
          msclPINVOKE.delete_AdvancedLowPassFilterData(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public AdvancedLowPassFilterData() : this(msclPINVOKE.new_AdvancedLowPassFilterData__SWIG_0(), true) {
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public AdvancedLowPassFilterData(MipTypes.ChannelField descriptor) : this(msclPINVOKE.new_AdvancedLowPassFilterData__SWIG_1((int)descriptor), true) {
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public MipTypes.ChannelField dataDescriptor {
    set {
      msclPINVOKE.AdvancedLowPassFilterData_dataDescriptor_set(swigCPtr, (int)value);
      if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      MipTypes.ChannelField ret = (MipTypes.ChannelField)msclPINVOKE.AdvancedLowPassFilterData_dataDescriptor_get(swigCPtr);
      if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public AdvancedLowPassFilterData.ManualFilterBandwidthConfig manualFilterBandwidthConfig {
    set {
      msclPINVOKE.AdvancedLowPassFilterData_manualFilterBandwidthConfig_set(swigCPtr, (int)value);
      if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      AdvancedLowPassFilterData.ManualFilterBandwidthConfig ret = (AdvancedLowPassFilterData.ManualFilterBandwidthConfig)msclPINVOKE.AdvancedLowPassFilterData_manualFilterBandwidthConfig_get(swigCPtr);
      if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public bool applyLowPassFilter {
    set {
      msclPINVOKE.AdvancedLowPassFilterData_applyLowPassFilter_set(swigCPtr, value);
      if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      bool ret = msclPINVOKE.AdvancedLowPassFilterData_applyLowPassFilter_get(swigCPtr);
      if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public ushort cutoffFrequency {
    set {
      msclPINVOKE.AdvancedLowPassFilterData_cutoffFrequency_set(swigCPtr, value);
      if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      ushort ret = msclPINVOKE.AdvancedLowPassFilterData_cutoffFrequency_get(swigCPtr);
      if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public static byte getDataDescriptorForCommand(MipTypes.ChannelField descriptor) {
    byte ret = msclPINVOKE.AdvancedLowPassFilterData_getDataDescriptorForCommand((int)descriptor);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static MipTypes.ChannelField getDataDescriptorFromUint8(byte descriptor) {
    MipTypes.ChannelField ret = (MipTypes.ChannelField)msclPINVOKE.AdvancedLowPassFilterData_getDataDescriptorFromUint8(descriptor);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public enum ManualFilterBandwidthConfig {
    SET_TO_HALF_REPORTING_RATE = 0x00,
    USER_SPECIFIED_CUTOFF_FREQ = 0x01
  }

}

}