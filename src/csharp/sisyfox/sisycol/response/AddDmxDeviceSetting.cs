// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace sisyfox.sisycol.response
{

using global::System;
using global::FlatBuffers;

public struct AddDmxDeviceSetting : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static AddDmxDeviceSetting GetRootAsAddDmxDeviceSetting(ByteBuffer _bb) { return GetRootAsAddDmxDeviceSetting(_bb, new AddDmxDeviceSetting()); }
  public static AddDmxDeviceSetting GetRootAsAddDmxDeviceSetting(ByteBuffer _bb, AddDmxDeviceSetting obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public AddDmxDeviceSetting __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public uint DeviceId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public uint SettingId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }

  public static Offset<AddDmxDeviceSetting> CreateAddDmxDeviceSetting(FlatBufferBuilder builder,
      uint deviceId = 0,
      uint settingId = 0) {
    builder.StartObject(2);
    AddDmxDeviceSetting.AddSettingId(builder, settingId);
    AddDmxDeviceSetting.AddDeviceId(builder, deviceId);
    return AddDmxDeviceSetting.EndAddDmxDeviceSetting(builder);
  }

  public static void StartAddDmxDeviceSetting(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void AddDeviceId(FlatBufferBuilder builder, uint deviceId) { builder.AddUint(0, deviceId, 0); }
  public static void AddSettingId(FlatBufferBuilder builder, uint settingId) { builder.AddUint(1, settingId, 0); }
  public static Offset<AddDmxDeviceSetting> EndAddDmxDeviceSetting(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<AddDmxDeviceSetting>(o);
  }
};


}
