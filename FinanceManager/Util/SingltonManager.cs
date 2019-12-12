using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinanceManager.Util
{
    public static class SingltonManager
    {

        private static readonly List<Type> _registeredTypes = new List<Type>();
        private static readonly List<Object> _objects = new List<Object>();

        static public void RegisterSinglton<T>()
        {
            if (!_registeredTypes.Contains(typeof(T)))
            {
                _registeredTypes.Add(typeof(T));
            }
        }

        static public T GetSinglton<T>()
        {
            if (_registeredTypes.Contains(typeof(T)))
            {
                object obj = _objects.SingleOrDefault(o => o.GetType() == typeof(T));
                if (obj == null)
                {
                    obj = Activator.CreateInstance(typeof(T));
                    _objects.Add(obj);
                }

                return (T)obj;
            }

            throw new Exception("Unregistered singlton type.");
        }

        static public void RemoveSinglton<T>()
        {
            if (_registeredTypes.Contains(typeof(T)))
            {
                _registeredTypes.Remove(typeof(T));
                _objects.Remove(_objects.SingleOrDefault(o => o.GetType() == typeof(T)));
            }

            throw new Exception("Unregistered singlton type.");
        }

    }
}
