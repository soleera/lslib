﻿using LSLib.Granny.GR2;
using System;

#pragma warning disable 0649

namespace LSLib.Granny.Model.VertexFormat
{
    [StructSerialization(MixedMarshal = true)]
    internal class PNTG3323_Prototype
    {
        [Serialization(ArraySize = 3)]
        public float[] Position;
        [Serialization(ArraySize = 3)]
        public float[] Normal;
        [Serialization(ArraySize = 2)]
        public float[] TextureCoordinates0;
        [Serialization(ArraySize = 3)]
        public float[] Tangent;
    }

    [VertexPrototype(Prototype = typeof(PNTG3323_Prototype))]
    public class PNTG3323 : Vertex
    {
        public override bool HasBoneInfluences()
        {
            return false;
        }

        public override void Serialize(WritableSection section)
        {
            WriteVector3(section, Position);
            WriteVector3(section, Normal);
            WriteVector2(section, TextureCoordinates0);
            WriteVector3(section, Tangent);
        }

        public override void Unserialize(GR2Reader reader)
        {
            Position = ReadVector3(reader);
            Normal = ReadVector3(reader);
            TextureCoordinates0 = ReadVector2(reader);
            Tangent = ReadVector3(reader);
        }
    }
}