using System;
namespace HundoDataStructure.Nodes
{
    public class BinaryTreeNode<TKey,TValue> : INode<TKey,TValue>
    {
        public TValue Value { get; set; }
        public TKey Key { get; set; }
        private BinaryTreeNode<TKey,TValue> _parent;
        private BinaryTreeNode<TKey, TValue> _leftNode;
        private BinaryTreeNode<TKey, TValue> _rightNode;

        /// <summary>
        /// 根節點
        /// </summary>
        public BinaryTreeNode<TKey, TValue> Parent { get => _parent; set => _parent = value; }

        /// <summary>
        /// 左節點
        /// </summary>
        public BinaryTreeNode<TKey, TValue> LeftChild
        {
            get
            {
                return _leftNode;
            }
            set
            {
                _leftNode = value;
                if(value != null)_leftNode.Parent = this;
            }
        }

        /// <summary>
        /// 右節點
        /// </summary>
        public BinaryTreeNode<TKey, TValue> RightChild 
        { 
            get
            {
                return _rightNode;
            }
            set
            {
                _rightNode = value;
                if (value != null) _rightNode.Parent = this;
            }
        }

        /// <summary>
        /// 是否有左節點
        /// </summary>
        public bool HasLeftChild
        {
            get
            {
                return LeftChild != null;
            }
        }

        /// <summary>
        /// 是否有右節點
        /// </summary>
        public bool HasRightChild
        {
            get
            {
                return RightChild != null;
            }
        }

        /// <summary>
        /// 取得兄弟節點
        /// </summary>
        public BinaryTreeNode<TKey,TValue> Sibiling {
            get
            {
                if (_parent.LeftChild == this) return _parent.RightChild;
                else return _parent.LeftChild;
            }
        }

        /// <summary>
        /// 子節點個數
        /// </summary>
        public int Degree
        {
            get => (LeftChild != null ? 1 : 0) + (RightChild != null ? 1 : 0);
        }

        /// <summary>
        /// 到根節點的距離(根節點Depth為0)
        /// </summary>
        public int Depth { get => IsRoot ? 0 : Parent.Depth + 1; }

        /// <summary>
        /// 到葉節點的距離
        /// </summary>
        public int Height
        {
            get
            {
                return IsLeaf ? 0 : Math.Max(
                    HasLeftChild ? LeftChild.Height + 1 : 0,
                    HasRightChild ? RightChild.Height + 1 : 0);
            }
        }

        /// <summary>
        /// 是葉節點
        /// </summary>
        public bool IsLeaf { get => Degree == 0; }

        /// <summary>
        /// 是根節點
        /// </summary>
        public bool IsRoot { get => Parent is null; }

        /// <summary>
        /// 是否至少有一個子節點
        /// </summary>
        public bool IsInternal { get => Degree > 0; }

        public BinaryTreeNode()
        {
        }
        public BinaryTreeNode(TKey key, TValue value) : this()
        {
            Key = key;
            Value = value;
        }

    }
}