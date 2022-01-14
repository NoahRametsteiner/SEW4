using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WPFDemo
{
    public class ListBoxData
    {
        public String Name { get; set; }
        public Int32 Id { get; set; }

        public override string ToString()
        {
            return String.Format("{0} {1}", this.Name, this.Id);
        }
    }
}
