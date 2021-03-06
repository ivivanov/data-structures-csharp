﻿using System;
using System.Diagnostics.Contracts;

namespace DataStructures.RootedTreeSpace
{
    /// <summary>
    /// Node of rooted tree
    /// </summary>
    /// <typeparam name="T">Data type</typeparam>
    [Serializable]
    public class Node<T>
        where T : IComparable<T>, IEquatable<T>
    {
        public readonly T data;

        public T Data
        {
            get { return data; }
        }
        public int Height { get; internal set; }
        internal Node<T> Parent { get; set; }
        internal Node<T> Left { get; set; }
        internal Node<T> Right { get; set; }

        public Node<T> Root { get; set; }

        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(Root != null);
        }

        public Node(T data, Node<T> parent)
        {
            Contract.Requires<ArgumentNullException>(parent != null);

            this.data = data;
            Parent = parent;
            Left = null;
            Right = null;
        }

        public bool Equals(Node<T> otherNode)
        {
            if (otherNode == null)
            {
                return false;
            }
            return data.Equals(otherNode.Data);
        }

        public override bool Equals(object obj)
        {
            Node<T> otherNode = obj as Node<T>;
            if (otherNode == null)
            {
                return false;
            }
            return Data.Equals(otherNode.Data);
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hash = 17;
                // Suitable nullity checks etc, of course :)
                hash = hash * 23 + data.GetHashCode();
                return hash;
            }
        }
    }
}
