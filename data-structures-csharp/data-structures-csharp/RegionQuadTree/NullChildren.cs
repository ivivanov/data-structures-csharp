﻿using System;

namespace DataStructures.RegionQuadTreeSpace
{
    [Serializable]
    public sealed class NullChildren<T> : Children<T>
        where T : IComparable<T>, IEquatable<T>
    {
        public NullChildren(Node<T> parent)
            : base(parent, null, null, null, null)
        {

        }

        public override Node<T> GetContainingChild(Point point)
        {
            return null;
        }
    }
}
