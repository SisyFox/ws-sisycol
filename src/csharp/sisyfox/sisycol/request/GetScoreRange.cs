// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace sisyfox.sisycol.request
{

using global::System;
using global::FlatBuffers;

public struct GetScoreRange : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static GetScoreRange GetRootAsGetScoreRange(ByteBuffer _bb) { return GetRootAsGetScoreRange(_bb, new GetScoreRange()); }
  public static GetScoreRange GetRootAsGetScoreRange(ByteBuffer _bb, GetScoreRange obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public GetScoreRange __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public byte Range { get { int o = __p.__offset(4); return o != 0 ? __p.bb.Get(o + __p.bb_pos) : (byte)0; } }
  public uint StartId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }

  public static Offset<GetScoreRange> CreateGetScoreRange(FlatBufferBuilder builder,
      byte range = 0,
      uint startId = 0) {
    builder.StartObject(2);
    GetScoreRange.AddStartId(builder, startId);
    GetScoreRange.AddRange(builder, range);
    return GetScoreRange.EndGetScoreRange(builder);
  }

  public static void StartGetScoreRange(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void AddRange(FlatBufferBuilder builder, byte range) { builder.AddByte(0, range, 0); }
  public static void AddStartId(FlatBufferBuilder builder, uint startId) { builder.AddUint(1, startId, 0); }
  public static Offset<GetScoreRange> EndGetScoreRange(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<GetScoreRange>(o);
  }
};


}
