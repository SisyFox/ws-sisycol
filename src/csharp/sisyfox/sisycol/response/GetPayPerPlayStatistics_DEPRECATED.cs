// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace sisyfox.sisycol.response
{

using global::System;
using global::FlatBuffers;

public struct GetPayPerPlayStatistics_DEPRECATED : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static GetPayPerPlayStatistics_DEPRECATED GetRootAsGetPayPerPlayStatistics_DEPRECATED(ByteBuffer _bb) { return GetRootAsGetPayPerPlayStatistics_DEPRECATED(_bb, new GetPayPerPlayStatistics_DEPRECATED()); }
  public static GetPayPerPlayStatistics_DEPRECATED GetRootAsGetPayPerPlayStatistics_DEPRECATED(ByteBuffer _bb, GetPayPerPlayStatistics_DEPRECATED obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public GetPayPerPlayStatistics_DEPRECATED __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public PayPerPlayStatistic? Data(int j) { int o = __p.__offset(4); return o != 0 ? (PayPerPlayStatistic?)(new PayPerPlayStatistic()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int DataLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<GetPayPerPlayStatistics_DEPRECATED> CreateGetPayPerPlayStatistics_DEPRECATED(FlatBufferBuilder builder,
      VectorOffset dataOffset = default(VectorOffset)) {
    builder.StartObject(1);
    GetPayPerPlayStatistics_DEPRECATED.AddData(builder, dataOffset);
    return GetPayPerPlayStatistics_DEPRECATED.EndGetPayPerPlayStatistics_DEPRECATED(builder);
  }

  public static void StartGetPayPerPlayStatistics_DEPRECATED(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddData(FlatBufferBuilder builder, VectorOffset dataOffset) { builder.AddOffset(0, dataOffset.Value, 0); }
  public static VectorOffset CreateDataVector(FlatBufferBuilder builder, Offset<PayPerPlayStatistic>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartDataVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<GetPayPerPlayStatistics_DEPRECATED> EndGetPayPerPlayStatistics_DEPRECATED(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<GetPayPerPlayStatistics_DEPRECATED>(o);
  }
};


}
