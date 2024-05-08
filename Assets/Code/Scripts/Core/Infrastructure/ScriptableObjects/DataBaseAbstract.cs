using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Core.Extensions;
using Core.Infrastructure;

namespace Core.ScriptableObjects 
{
    public interface IDataBase 
    {
        
    }

    public abstract class DataBaseAbstract<TElement> : ScriptableObject, IDataBase
    {
        [SerializeField] private TElement[] _elements;

        public TElement[] Elements => _elements;

        public bool GetElementByIndex(int index, out TElement element)
        {
            element = default;

            if (_elements.Length > index && index >= 0) 
            {
                element = _elements[index];
                return true;
            }

            return false;
        }

        public TElement GetRandomElement() 
        {
            return _elements.GetRandomElement();        
        }
    }

    public abstract class DataBaseAbstract<TElement, TType> : ScriptableObject, IDataBase where TType : Enum where TElement : DataAbstractSO<TType>
    {
        [SerializeField] private TElement[] _elements;

        public TElement[] Elements => _elements;

        public Dictionary<TType, TElement> ElementsDictionary { get { return _elements.ToDictionary(key => key.Type); } }

        public bool GetElementByIndex(int index, out TElement element)
        {
            element = default;

            if (_elements.Length > index && index >= 0)
            {
                element = _elements[index];
                return true;
            }

            return false;
        }

        public TElement GetRandomElement()
        {
            return _elements.GetRandomElement();
        }
    }

    public abstract class DataBaseViewsAbstract<TElement, TType> : ScriptableObject, IDataBase 
        where TType : Enum 
        where TElement : ElementViewBase<TType>
    {
        [SerializeField] private TElement[] _elements;

        public TElement[] Elements => _elements;

        public Dictionary<TType, TElement> ElementsDictionary { get { return _elements.ToDictionary(key => key.Type); } }

        public bool GetElementByIndex(int index, out TElement element)
        {
            element = default;

            if (_elements.Length > index && index >= 0)
            {
                element = _elements[index];
                return true;
            }

            return false;
        }

        public TElement GetRandomElement()
        {
            return _elements.GetRandomElement();
        }
    }
}