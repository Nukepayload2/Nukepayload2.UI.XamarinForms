using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace Nukepayload2.UI.XamarinForms.Gallery
{
    public class ColorItem : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private Color _color;
        private string _name;

        public ColorItem(Color color, string name)
        {
            Color = color;
            Name = name;
        }

        public Color Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Color)));
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
            }
        }

        public override bool Equals(object obj)
        {
            if (obj is ColorItem itm)
            {
                return string.Equals(Name, itm?.Name);
            }
            return false;
        }
    }
}
