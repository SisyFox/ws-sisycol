// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace sisyfox.sisycol.request
{

using global::System;
using global::FlatBuffers;

public struct GetUserRange : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static GetUserRange GetRootAsGetUserRange(ByteBuffer _bb) { return GetRootAsGetUserRange(_bb, new GetUserRange()); }
  public static GetUserRange GetRootAsGetUserRange(ByteBuffer _bb, GetUserRange obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public GetUserRange __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public uint StartUid { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public byte Range { get { int o = __p.__offset(6); return o != 0 ? __p.bb.Get(o + __p.bb_pos) : (byte)0; } }

  public static Offset<GetUserRange> CreateGetUserRange(FlatBufferBuilder builder,
      uint startUid = 0,
      byte range = 0) {
    builder.StartObject(2);
    GetUserRange.AddStartUid(builder, startUid);
    GetUserRange.AddRange(builder, range);
    return GetUserRange.EndGetUserRange(builder);
  }

  public static void StartGetUserRange(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void AddStartUid(FlatBufferBuilder builder, uint startUid) { builder.AddUint(0, startUid, 0); }
  public static void AddRange(FlatBufferBuilder builder, byte range) { builder.AddByte(1, range, 0); }
  public static Offset<GetUserRange> EndGetUserRange(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<GetUserRange>(o);
  }
};


}
