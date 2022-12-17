using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    public delegate void NameChangeEventHandler(object sender, NameChangeEventArgs args);
    public class Dispatcher
    {
        private string name;
        public event NameChangeEventHandler NameChange;
        public Dispatcher(string name)
        {
            this.name = name;
        }
        public string Name
        {
            get 
            { 
                return name; 
            }
            set
            {
                OnNameChange(new NameChangeEventArgs(value));
                name = value;
            }
        }
        private void OnNameChange(NameChangeEventArgs args)
        {
            NameChange(this, args);
        }
    }
}
