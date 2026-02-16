using creational.abstract_factory.ui_component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creational.abstract_factory.ui_component_demo
{
    class Application
    {
        IGUIFactory factory;
        private readonly IButton _button;
        private readonly ICheckBox _checkBox;
        public Application(OS os)
        {
            if (os == OS.Windows)
            {
                factory = new WindowsFactory();
            }
            else if (os == OS.Mac)
            {
                factory = new MacFactory();
            }
            else
            {
                factory = new WindowsFactory();
            }

            _button = factory.CreateButton();
            _checkBox = factory.CreateCheckBox();
        }
        public void Render()
        {
            _button.Render();
            _checkBox.Render();
        }
    }

    public class AbstractFactoryUIComponentDemo
    {
        public void Run()
        {
            Application winApp = new Application(OS.Windows);
            winApp.Render();

            Application macApp = new Application(OS.Mac);
            macApp.Render();
        }
    }
}
