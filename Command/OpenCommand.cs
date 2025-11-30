using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Command
{
    /*public class OpenCommand : ICommand
    {
        private readonly Application _application;

        public OpenCommand(Application application)
        {
            _application = application;
        }

        protected virtual string AskUser()
        {
            Console.Write("Введите имя документа: ");
            return Console.ReadLine();
        }

        public void Execute()
        {
            string name = AskUser();

            if (!string.IsNullOrEmpty(name))
            {
                Document document = new Document(name);
                _application.Add(document);
                document.Open();
            }
        }
    }*/
}
