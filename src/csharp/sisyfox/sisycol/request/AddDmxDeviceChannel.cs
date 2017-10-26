// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace sisyfox.sisycol.request
{

using global::System;
using global::FlatBuffers;

public struct AddDmxDeviceChannel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static AddDmxDeviceChannel GetRootAsAddDmxDeviceChannel(ByteBuffer _bb) { return GetRootAsAddDmxDeviceChannel(_bb, new AddDmxDeviceChannel()); }
  public static AddDmxDeviceChannel GetRootAsAddDmxDeviceChannel(ByteBuffer _bb, AddDmxDeviceChannel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public AddDmxDeviceChannel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public uint DeviceId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public uint Channel { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public byte Norm { get { int o = __p.__offset(8); return o != 0 ? __p.bb.Get(o + __p.bb_pos) : (byte)0; } }
  public byte Test { get { int o = __p.__offset(10); return o != 0 ? __p.bb.Get(o + __p.bb_pos) : (byte)0; } }

  public static Offset<AddDmxDeviceChannel> CreateAddDmxDeviceChannel(FlatBufferBuilder builder,
      uint deviceId = 0,
      uint channel = 0,
      byte norm = 0,
      byte test = 0) {
    builder.StartObject(4);
    AddDmxDeviceChannel.AddChannel(builder, channel);
    AddDmxDeviceChannel.AddDeviceId(builder, deviceId);
    AddDmxDeviceChannel.AddTest(builder, test);
    AddDmxDeviceChannel.AddNorm(builder, norm);
    return AddDmxDeviceChannel.EndAddDmxDeviceChannel(builder);
  }

  public static void StartAddDmxDeviceChannel(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddDeviceId(FlatBufferBuilder builder, uint deviceId) { builder.AddUint(0, deviceId, 0); }
  public static void AddChannel(FlatBufferBuilder builder, uint channel) { builder.AddUint(1, channel, 0); }
  public static void AddNorm(FlatBufferBuilder builder, byte norm) { builder.AddByte(2, norm, 0); }
  public static void AddTest(FlatBufferBuilder builder, byte test) { builder.AddByte(3, test, 0); }
  public static Offset<AddDmxDeviceChannel> EndAddDmxDeviceChannel(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<AddDmxDeviceChannel>(o);
  }
};


}
