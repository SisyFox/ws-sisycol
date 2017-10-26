// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace sisyfox.sisycol.request
{

using global::System;
using global::FlatBuffers;

public struct RemoveDmxRuleSetting : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static RemoveDmxRuleSetting GetRootAsRemoveDmxRuleSetting(ByteBuffer _bb) { return GetRootAsRemoveDmxRuleSetting(_bb, new RemoveDmxRuleSetting()); }
  public static RemoveDmxRuleSetting GetRootAsRemoveDmxRuleSetting(ByteBuffer _bb, RemoveDmxRuleSetting obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public RemoveDmxRuleSetting __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public uint DeviceId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public uint SettingId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public uint RuleSettingId { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }

  public static Offset<RemoveDmxRuleSetting> CreateRemoveDmxRuleSetting(FlatBufferBuilder builder,
      uint deviceId = 0,
      uint settingId = 0,
      uint ruleSettingId = 0) {
    builder.StartObject(3);
    RemoveDmxRuleSetting.AddRuleSettingId(builder, ruleSettingId);
    RemoveDmxRuleSetting.AddSettingId(builder, settingId);
    RemoveDmxRuleSetting.AddDeviceId(builder, deviceId);
    return RemoveDmxRuleSetting.EndRemoveDmxRuleSetting(builder);
  }

  public static void StartRemoveDmxRuleSetting(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddDeviceId(FlatBufferBuilder builder, uint deviceId) { builder.AddUint(0, deviceId, 0); }
  public static void AddSettingId(FlatBufferBuilder builder, uint settingId) { builder.AddUint(1, settingId, 0); }
  public static void AddRuleSettingId(FlatBufferBuilder builder, uint ruleSettingId) { builder.AddUint(2, ruleSettingId, 0); }
  public static Offset<RemoveDmxRuleSetting> EndRemoveDmxRuleSetting(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<RemoveDmxRuleSetting>(o);
  }
};


}
