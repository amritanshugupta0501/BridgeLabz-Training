using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.linkedlist.TextEditorSystem
{
    internal class TextStateNode
    {
        public string Content;
        public TextStateNode Next;
        public TextStateNode Previous;
        public TextStateNode(string content)
        {
            Content = content;
            Next = null;
            Previous = null;
        }
    }
}
