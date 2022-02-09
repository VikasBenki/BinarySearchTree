using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeProb
{
    public class INode<T>
    {
        //Variables
        public T data;
        public INode<T> left;
        public INode<T> right;
        /// <summary>
        /// initialization of the nodes.
        /// </summary>
        /// <param name="data"></param>
        public INode(T data)
        {
            this.data = data;
            this.left = null;
            this.right = null;
        }
    }
}

