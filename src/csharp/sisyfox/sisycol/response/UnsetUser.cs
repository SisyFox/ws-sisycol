// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace sisyfox.sisycol.response
{

using global::System;
using global::FlatBuffers;

public struct UnsetUser : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static UnsetUser GetRootAsUnsetUser(ByteBuffer _bb) { return GetRootAsUnsetUser(_bb, new UnsetUser()); }
  public static UnsetUser GetRootAsUnsetUser(ByteBuffer _bb, UnsetUser obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public UnsetUser __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }


  public static void StartUnsetUser(FlatBufferBuilder builder) { builder.StartObject(0); }
  public static Offset<UnsetUser> EndUnsetUser(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<UnsetUser>(o);
  }
};


}
