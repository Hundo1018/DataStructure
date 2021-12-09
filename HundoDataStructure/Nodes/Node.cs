namespace HundoDataStructure
{
    public interface INode<T>
    {
        /// <summary>
        /// 存放數值
        /// </summary>
        T Value { get; set; }


        /// <summary>
        /// 子節點個數
        /// </summary>
        int Degree { get; }

        /// <summary>
        /// 到根節點的距離(根節點Depth為0)
        /// </summary>
        int Depth { get; }

        /// <summary>
        /// 到葉節點的距離
        /// </summary>
        int Height { get; }

        /// <summary>
        /// 是葉節點
        /// </summary>
        bool IsLeaf { get; }

        /// <summary>
        /// 是根節點
        /// </summary>
        bool IsRoot { get; }

        /// <summary>
        /// 是否至少有一個子節點
        /// </summary>
        bool IsInternal { get; }
    }
}
