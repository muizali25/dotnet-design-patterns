using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creational.abstract_factory.ui_component
{
    interface IButton
    {
        void Render();
    }
    interface ICheckBox
    {
        void Render();
    }

    interface IGUIFactory
    {
        IButton CreateButton();
        ICheckBox CreateCheckBox();
    }

    class WindowsButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Rendering Windows Button");
        }
    }

    class MacButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Rendering Mac Button");
        }
    }

    class WindowsCheckBox : ICheckBox
    {
        public void Render()
        {
            Console.WriteLine("Rendering Windows CheckBox");
        }
    }

    class MacCheckBox : ICheckBox
    {
        public void Render()
        {
            Console.WriteLine("Rendering Mac CheckBox");
        }
    }

    class WindowsFactory : IGUIFactory
    {
        public IButton CreateButton() => new WindowsButton();
        public ICheckBox CreateCheckBox() => new WindowsCheckBox();
    }

    public enum OS
    {
        Windows,
        Mac,        
    }
    class MacFactory : IGUIFactory
    {
        public IButton CreateButton() => new MacButton();
        public ICheckBox CreateCheckBox() => new MacCheckBox();
    }   
}
