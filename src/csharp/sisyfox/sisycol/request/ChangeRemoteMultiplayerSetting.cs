// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace sisyfox.sisycol.request
{

using global::System;
using global::FlatBuffers;

public struct ChangeRemoteMultiplayerSetting : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static ChangeRemoteMultiplayerSetting GetRootAsChangeRemoteMultiplayerSetting(ByteBuffer _bb) { return GetRootAsChangeRemoteMultiplayerSetting(_bb, new ChangeRemoteMultiplayerSetting()); }
  public static ChangeRemoteMultiplayerSetting GetRootAsChangeRemoteMultiplayerSetting(ByteBuffer _bb, ChangeRemoteMultiplayerSetting obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public ChangeRemoteMultiplayerSetting __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public uint Ip { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public bool Value { get { int o = __p.__offset(6); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }

  public static Offset<ChangeRemoteMultiplayerSetting> CreateChangeRemoteMultiplayerSetting(FlatBufferBuilder builder,
      uint ip = 0,
      bool value = false) {
    builder.StartObject(2);
    ChangeRemoteMultiplayerSetting.AddIp(builder, ip);
    ChangeRemoteMultiplayerSetting.AddValue(builder, value);
    return ChangeRemoteMultiplayerSetting.EndChangeRemoteMultiplayerSetting(builder);
  }

  public static void StartChangeRemoteMultiplayerSetting(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void AddIp(FlatBufferBuilder builder, uint ip) { builder.AddUint(0, ip, 0); }
  public static void AddValue(FlatBufferBuilder builder, bool value) { builder.AddBool(1, value, false); }
  public static Offset<ChangeRemoteMultiplayerSetting> EndChangeRemoteMultiplayerSetting(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<ChangeRemoteMultiplayerSetting>(o);
  }
};


}
