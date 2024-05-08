using System;
using UnityEngine;

namespace Core.Infrastructure 
{
    public class ElementViewBase<TType>: ViewBase
        where TType : Enum
    {
        [SerializeField] private TType _type;

        public TType Type => _type;
    }
}