using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            new Client().Main();
        }
    }

    public class Client
    {
        public void Main()
        {
            ClientMethod(new WinFactory());
        }

        private void ClientMethod(IGuiFactory factory)
        {
            var winButton = factory.CreateButton();
            winButton.paint();
        }
    }

    internal interface IGuiFactory
    {
        IButton CreateButton();
        ICheckBox CreateCheckBox();
    }

    internal interface ICheckBox 
    {
        void paint();
    }

    internal interface IButton
    {
        void paint();
    }

    public class WinFactory :IGuiFactory
    {
        public WinButton CreateButton()
        {
            throw new NotImplementedException();
        }

        public WinCheckBox CreateCheckBox()
        {
            throw new NotImplementedException();
        }

        IButton IGuiFactory.CreateButton()
        {
            throw new NotImplementedException();
        }

        ICheckBox IGuiFactory.CreateCheckBox()
        {
            throw new NotImplementedException();
        }
    }

    public class WinCheckBox : IButton
    {
        public void paint()
        {
            Console.WriteLine("check box win style");
        }
    }

    public class WinButton : IButton
    {
        public void paint()
        {
            throw new NotImplementedException();
        }
    }
}
