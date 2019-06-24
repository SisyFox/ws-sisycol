// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace sisyfox.sisycol.request
{

using global::System;
using global::FlatBuffers;

public struct CreditStatus : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static CreditStatus GetRootAsCreditStatus(ByteBuffer _bb) { return GetRootAsCreditStatus(_bb, new CreditStatus()); }
  public static CreditStatus GetRootAsCreditStatus(ByteBuffer _bb, CreditStatus obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public CreditStatus __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int AvailableCredits { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)-1; } }

  public static Offset<CreditStatus> CreateCreditStatus(FlatBufferBuilder builder,
      int availableCredits = -1) {
    builder.StartObject(1);
    CreditStatus.AddAvailableCredits(builder, availableCredits);
    return CreditStatus.EndCreditStatus(builder);
  }

  public static void StartCreditStatus(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddAvailableCredits(FlatBufferBuilder builder, int availableCredits) { builder.AddInt(0, availableCredits, -1); }
  public static Offset<CreditStatus> EndCreditStatus(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<CreditStatus>(o);
  }
};


}
