// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace sisyfox.sisycol.request
{

using global::System;
using global::FlatBuffers;

public struct GetScoreFiltered : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static GetScoreFiltered GetRootAsGetScoreFiltered(ByteBuffer _bb) { return GetRootAsGetScoreFiltered(_bb, new GetScoreFiltered()); }
  public static GetScoreFiltered GetRootAsGetScoreFiltered(ByteBuffer _bb, GetScoreFiltered obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public GetScoreFiltered __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public ulong TimestampBegin { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetUlong(o + __p.bb_pos) : (ulong)0; } }
  public ulong TimestampEnd { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetUlong(o + __p.bb_pos) : (ulong)0; } }

  public static Offset<GetScoreFiltered> CreateGetScoreFiltered(FlatBufferBuilder builder,
      ulong timestamp_begin = 0,
      ulong timestamp_end = 0) {
    builder.StartObject(2);
    GetScoreFiltered.AddTimestampEnd(builder, timestamp_end);
    GetScoreFiltered.AddTimestampBegin(builder, timestamp_begin);
    return GetScoreFiltered.EndGetScoreFiltered(builder);
  }

  public static void StartGetScoreFiltered(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void AddTimestampBegin(FlatBufferBuilder builder, ulong timestampBegin) { builder.AddUlong(0, timestampBegin, 0); }
  public static void AddTimestampEnd(FlatBufferBuilder builder, ulong timestampEnd) { builder.AddUlong(1, timestampEnd, 0); }
  public static Offset<GetScoreFiltered> EndGetScoreFiltered(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<GetScoreFiltered>(o);
  }
};


}
