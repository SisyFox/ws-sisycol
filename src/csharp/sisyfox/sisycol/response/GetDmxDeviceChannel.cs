// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace sisyfox.sisycol.response
{

using global::System;
using global::FlatBuffers;

public struct GetDmxDeviceChannel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static GetDmxDeviceChannel GetRootAsGetDmxDeviceChannel(ByteBuffer _bb) { return GetRootAsGetDmxDeviceChannel(_bb, new GetDmxDeviceChannel()); }
  public static GetDmxDeviceChannel GetRootAsGetDmxDeviceChannel(ByteBuffer _bb, GetDmxDeviceChannel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public GetDmxDeviceChannel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public uint DeviceId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public uint ChannelId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public sisyfox.sisycol.DmxDeviceChannel? Channel { get { int o = __p.__offset(8); return o != 0 ? (sisyfox.sisycol.DmxDeviceChannel?)(new sisyfox.sisycol.DmxDeviceChannel()).__assign(o + __p.bb_pos, __p.bb) : null; } }

  public static void StartGetDmxDeviceChannel(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddDeviceId(FlatBufferBuilder builder, uint deviceId) { builder.AddUint(0, deviceId, 0); }
  public static void AddChannelId(FlatBufferBuilder builder, uint channelId) { builder.AddUint(1, channelId, 0); }
  public static void AddChannel(FlatBufferBuilder builder, Offset<sisyfox.sisycol.DmxDeviceChannel> channelOffset) { builder.AddStruct(2, channelOffset.Value, 0); }
  public static Offset<GetDmxDeviceChannel> EndGetDmxDeviceChannel(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<GetDmxDeviceChannel>(o);
  }
};


}
