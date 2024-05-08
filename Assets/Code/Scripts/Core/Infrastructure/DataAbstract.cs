using System;
using UnityEngine;

namespace Core.Infrastructure 
{
    public abstract class DataAbstract
    {
    
    }

    public abstract class DataAbstract<TType> where TType : Enum
    {
        private TType _type;

        public TType Type => _type;
    }

    public abstract class DataAbstractSO<TType> : ScriptableObject where TType : Enum
    {
        [SerializeField] private TType _type;

        public TType Type => _type;
    }
}