using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Command
{
    public class PasteCommand : ICommand
    {
        private readonly Document _document;

        public PasteCommand(Document document)
        {
            _document = document;
        }

        public void Execute()
        {
            _document.Paste();
        }
    }
}
