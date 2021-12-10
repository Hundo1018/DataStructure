using Microsoft.VisualStudio.TestTools.UnitTesting;
using HundoDataStructure.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HundoDataStructure.Nodes.Tests
{
    [TestClass()]
    public class BinaryTreeNodeTests
    {
        /// <summary>
        /// 測試建構子
        /// </summary>
        [TestMethod()]
        public void ConstructorTest()
        {
            int v1 = 1;
            BinaryTreeNode<int,int> node = new BinaryTreeNode<int,int>(v1,v1);
            Assert.AreEqual(v1, node.Value);
        }

        /// <summary>
        /// 左右連結測試
        /// </summary>
        [TestMethod()]
        public void LinkTest()
        {
            int v1 = 1, v2 = 2, v3 = 3;
            BinaryTreeNode<int,int> nodeRoot = new BinaryTreeNode<int,int>(v1,v1);
            BinaryTreeNode<int,int> nodeLeft = new BinaryTreeNode<int,int>(v2,v2);
            BinaryTreeNode<int,int> nodeRight = new BinaryTreeNode<int,int>(v3,v3);
            nodeRoot.LeftChild = nodeLeft;
            nodeRoot.RightChild = nodeRight;
            Assert.IsNotNull(nodeRoot.RightChild);
        }

        /// <summary>
        /// 左右連結測試
        /// </summary>
        [TestMethod()]
        public void LinkTest2()
        {
            int v1 = 1, v2 = 2, v3 = 3;
            BinaryTreeNode<int,int> nodeRoot = new BinaryTreeNode<int,int>(v1,v1);
            BinaryTreeNode<int,int> nodeLeft = new BinaryTreeNode<int,int>(v2,v2);
            BinaryTreeNode<int,int> nodeRight = new BinaryTreeNode<int,int>(v3,v3);
            nodeRoot.LeftChild = nodeLeft;
            nodeRoot.RightChild = nodeRight;
            Assert.AreEqual(v3, nodeRoot.RightChild.Value);
        }

        /// <summary>
        /// 左右連結測試
        /// </summary>
        [TestMethod()]
        public void LinkTest3()
        {
            int v1 = 1, v2 = 2;
            BinaryTreeNode<int,int> nodeRoot = new BinaryTreeNode<int,int>(v1,v1);
            BinaryTreeNode<int,int> nodeLeft = new BinaryTreeNode<int,int>(v2,v2);
            nodeRoot.LeftChild = nodeLeft;
            Assert.AreEqual(v1, nodeLeft.Parent.Value);
        }

        /// <summary>
        /// 判斷根節點測試
        /// </summary>
        [TestMethod()]
        public void IsRootTest()
        {
            int v1 = 1;
            BinaryTreeNode<int,int> node = new BinaryTreeNode<int,int>(v1,v1);
            Assert.IsTrue(node.IsRoot);
        }

        /// <summary>
        /// 判斷根節點測試
        /// </summary>
        [TestMethod()]
        public void IsRootTest2()
        {
            int v1 = 1;
            BinaryTreeNode<int,int> node = new BinaryTreeNode<int,int>(v1,v1);
            BinaryTreeNode<int,int> nodeLeft = new BinaryTreeNode<int,int>(v1,v1);
            node.LeftChild = nodeLeft;
            Assert.IsFalse(nodeLeft.IsRoot);
        }

        /// <summary>
        /// 判斷葉節點測試
        /// </summary>
        [TestMethod()]
        public void IsLeafTest()
        {
            int v1 = 1;
            BinaryTreeNode<int,int> node = new BinaryTreeNode<int,int>(v1,v1);
            Assert.IsTrue(node.IsLeaf);
        }

        /// <summary>
        /// 判斷葉節點測試
        /// </summary>
        [TestMethod()]
        public void IsLeafTest2()
        {
            int v1 = 1;
            BinaryTreeNode<int,int> node = new BinaryTreeNode<int,int>(v1,v1);
            BinaryTreeNode<int,int> nodeLeft = new BinaryTreeNode<int,int>(v1,v1);
            node.LeftChild = nodeLeft;
            Assert.IsTrue(nodeLeft.IsLeaf);
        }

        /// <summary>
        /// 判斷含有左節點測試
        /// </summary>
        [TestMethod()]
        public void HasLeftChildTest()
        {
            int v1 = 1;
            BinaryTreeNode<int,int> node = new BinaryTreeNode<int,int>(v1,v1);
            BinaryTreeNode<int,int> nodeLeft = new BinaryTreeNode<int,int>(v1,v1);
            node.LeftChild = nodeLeft;
            Assert.IsTrue(node.HasLeftChild);
        }

        /// <summary>
        /// 判斷不含有左節點測試
        /// </summary>
        [TestMethod()]
        public void HasLeftChildTest2()
        {
            int v1 = 1;
            BinaryTreeNode<int,int> node = new BinaryTreeNode<int,int>(v1,v1);
            BinaryTreeNode<int,int> nodeLeft = new BinaryTreeNode<int,int>(v1,v1);
            node.LeftChild = nodeLeft;
            Assert.IsFalse(nodeLeft.HasLeftChild);
        }

        /// <summary>
        /// 兄弟節點測試
        /// </summary>
        [TestMethod()]
        public void SibilingTest()
        {
            int v1 = 1, v2 = 2, v3 = 3;
            BinaryTreeNode<int,int> node = new BinaryTreeNode<int,int>(v1,v1);
            BinaryTreeNode<int,int> nodeLeft = new BinaryTreeNode<int,int>(v2,v2);
            BinaryTreeNode<int,int> nodeRight = new BinaryTreeNode<int,int>(v3,v3);
            node.LeftChild = nodeLeft;
            node.RightChild = nodeRight;
            Assert.AreEqual(nodeLeft.Sibiling.Value, nodeRight.Value);
        }

        /// <summary>
        /// Degree測試
        /// </summary>
        [TestMethod()]
        public void DegreeTest()
        {
            int v1 = 1;
            BinaryTreeNode<int,int> node = new BinaryTreeNode<int,int>(v1,v1);
            Assert.AreEqual(0, node.Degree);
        }

        /// <summary>
        /// Degree測試
        /// </summary>
        [TestMethod()]
        public void DegreeTest2()
        {
            int v1 = 1, v2 = 2, v3 = 3;
            BinaryTreeNode<int,int> node = new BinaryTreeNode<int,int>(v1,v1);
            BinaryTreeNode<int,int> nodeLeft = new BinaryTreeNode<int,int>(v2,v2);
            BinaryTreeNode<int,int> nodeRight = new BinaryTreeNode<int,int>(v3,v3);
            node.LeftChild = nodeLeft;
            node.RightChild = nodeRight;
            Assert.AreEqual(2, node.Degree);
        }

        /// <summary>
        /// Degree測試
        /// </summary>
        [TestMethod()]
        public void DegreeTest3()
        {
            int v1 = 1, v2 = 2;
            BinaryTreeNode<int,int> node = new BinaryTreeNode<int,int>(v1,v1);
            BinaryTreeNode<int,int> nodeLeft = new BinaryTreeNode<int,int>(v2,v2);
            node.LeftChild = nodeLeft;
            Assert.AreEqual(1, node.Degree);
        }

        /// <summary>
        /// 深度測試
        /// </summary>
        [TestMethod()]
        public void DepthTest()
        {
            int v1 = 1;
            BinaryTreeNode<int,int> node = new BinaryTreeNode<int,int>(v1,v1);
            Assert.AreEqual(0, node.Depth);
        }

        /// <summary>
        /// 深度測試2
        /// </summary>
        [TestMethod()]
        public void DepthTest2()
        {
            int v1 = 1, v2 = 2;
            BinaryTreeNode<int,int> node = new BinaryTreeNode<int,int>(v1,v1);
            BinaryTreeNode<int,int> nodeLeft1 = new BinaryTreeNode<int,int>(v2,v2);
            node.LeftChild = nodeLeft1;
            Assert.AreEqual(1, nodeLeft1.Depth);
        }

        /// <summary>
        /// 深度測試
        /// </summary>
        [TestMethod()]
        public void DepthTest3()
        {
            int v1 = 1, v2 = 2, v3 = 3;
            BinaryTreeNode<int,int> node = new BinaryTreeNode<int,int>(v1,v1);
            BinaryTreeNode<int,int> nodeLeft1 = new BinaryTreeNode<int,int>(v2,v2);
            BinaryTreeNode<int,int> nodeLeft2 = new BinaryTreeNode<int,int>(v3,v3);
            node.LeftChild = nodeLeft1;
            nodeLeft1.LeftChild = nodeLeft2;
            Assert.AreEqual(2, nodeLeft2.Depth);
        }

        /// <summary>
        /// 高度測試
        /// </summary>
        [TestMethod()]
        public void HeightTest()
        {
            int v1 = 1;
            BinaryTreeNode<int,int> node = new BinaryTreeNode<int,int>(v1,v1);
            Assert.AreEqual(0, node.Height);
        }

        /// <summary>
        /// 高度測試2
        /// </summary>
        [TestMethod()]
        public void Heightest2()
        {
            int v1 = 1, v2 = 2;
            BinaryTreeNode<int,int> node = new BinaryTreeNode<int,int>(v1,v1);
            BinaryTreeNode<int,int> nodeLeft1 = new BinaryTreeNode<int,int>(v2,v2);
            node.LeftChild = nodeLeft1;
            Assert.AreEqual(1, node.Height);
        }

        /// <summary>
        /// 高度測試
        /// </summary>
        [TestMethod()]
        public void HeightTest3()
        {
            int v1 = 1, v2 = 2, v3 = 3;
            BinaryTreeNode<int,int> node = new BinaryTreeNode<int,int>(v1,v1);
            BinaryTreeNode<int,int> nodeLeft1 = new BinaryTreeNode<int,int>(v2,v2);
            BinaryTreeNode<int,int> nodeLeft2 = new BinaryTreeNode<int,int>(v3,v3);
            node.LeftChild = nodeLeft1;
            nodeLeft1.LeftChild = nodeLeft2;
            Assert.AreEqual(2, node.Height);
        }
    }
}