using System.Collections.Generic;
using Iterators;
using BinaryTrees;
using INodes;
using Nodes;

namespace BinaryTreeIterators
{
    public class BinaryTreePreOrderIterator : Iterator
    {
        private readonly BinaryTree _tree;
        private Stack<INode> _stack;
        private INode _current;

        public BinaryTreePreOrderIterator(BinaryTree tree)
        {
            _tree = tree;
            Reset();
        }

        public override object Current()
        {
            return _current?.Value;
        }

        public override int Key() => 0;

        public override bool MoveNext()
        {
            if (_stack.Count == 0)
                return false;

            _current = _stack.Pop();

            // ПРЯМОЙ ОБХОД: Node → Left → Right
            if (_current is Node n)
            {
                if (n.Right != null) _stack.Push(n.Right);
                if (n.Left != null) _stack.Push(n.Left);
            }

            return true;
        }

        public override void Reset()
        {
            _stack = new Stack<INode>();

            if (!_tree.IsEmpty())
                _stack.Push(_tree.Root);

            _current = null;
        }
    }
}