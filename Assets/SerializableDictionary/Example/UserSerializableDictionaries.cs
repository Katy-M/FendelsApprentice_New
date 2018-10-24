using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

// [Serializable]
// public class StringStringDictionary : SerializableDictionary<string, string> {}

// [Serializable]
// public class ObjectColorDictionary : SerializableDictionary<UnityEngine.Object, Color> {}

// [Serializable]
// public class ColorArrayStorage : SerializableDictionary.Storage<Color[]> {}

// [Serializable]
// public class StringColorArrayDictionary : SerializableDictionary<string, Color[], ColorArrayStorage> {}


[Serializable]
public class RecipeDictionary : SerializableDictionary<Pair, int>{}

[Serializable]
public class Pair
{
    public int first;
    public int second;

    public Pair(int f, int s)
    {
        first = f;
        second = s;
    }
}

// [Serializable]
// public class QuaternionMyClassDictionary : SerializableDictionary<Quaternion, MyClass> {}