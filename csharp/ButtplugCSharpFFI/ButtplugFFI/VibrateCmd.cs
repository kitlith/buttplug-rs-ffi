// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace ButtplugFFI
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct VibrateCmd : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static VibrateCmd GetRootAsVibrateCmd(ByteBuffer _bb) { return GetRootAsVibrateCmd(_bb, new VibrateCmd()); }
  public static VibrateCmd GetRootAsVibrateCmd(ByteBuffer _bb, VibrateCmd obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public VibrateCmd __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public ButtplugFFI.VibrateComponent? Speeds(int j) { int o = __p.__offset(4); return o != 0 ? (ButtplugFFI.VibrateComponent?)(new ButtplugFFI.VibrateComponent()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int SpeedsLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<ButtplugFFI.VibrateCmd> CreateVibrateCmd(FlatBufferBuilder builder,
      VectorOffset speedsOffset = default(VectorOffset)) {
    builder.StartTable(1);
    VibrateCmd.AddSpeeds(builder, speedsOffset);
    return VibrateCmd.EndVibrateCmd(builder);
  }

  public static void StartVibrateCmd(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddSpeeds(FlatBufferBuilder builder, VectorOffset speedsOffset) { builder.AddOffset(0, speedsOffset.Value, 0); }
  public static VectorOffset CreateSpeedsVector(FlatBufferBuilder builder, Offset<ButtplugFFI.VibrateComponent>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateSpeedsVectorBlock(FlatBufferBuilder builder, Offset<ButtplugFFI.VibrateComponent>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartSpeedsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<ButtplugFFI.VibrateCmd> EndVibrateCmd(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<ButtplugFFI.VibrateCmd>(o);
  }
};


}