using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MethodOfMak
{
    public class Element
    {
        public Element(float value)
        {
            _value = value;
            _isSelected = false;
        }
        private float _value;
        private bool _isSelected;
        private bool _inA = false;
        public float Value { get => _value; set => this._value = value; }
        public bool IsSelected { get => _isSelected; set => _isSelected = value; }
        public bool InA { get => _inA; set => _inA = value; }
    }
}
