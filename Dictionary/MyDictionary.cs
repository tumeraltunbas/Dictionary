using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<TypeKey, TypeValue>
    {
        TypeKey[] keys;
        TypeValue[] values;
        public MyDictionary()
        {
            keys = new TypeKey[0];
            values = new TypeValue[0];
        }
        public void Add(TypeKey key,TypeValue value)
        {
            TypeKey[] tempKeys = keys;
            TypeValue[] tempValues = values;
            keys = new TypeKey[keys.Length + 1];
            values = new TypeValue[values.Length + 1];
            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
                values[i] = tempValues[i];
            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;

        }

    }
    
}
