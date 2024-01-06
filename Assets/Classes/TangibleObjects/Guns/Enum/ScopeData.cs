using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeData : MonoBehaviour
{
    public enum Types
    {
        Iron,
        RedDot,
        Holographic,
        Scopex2,
        Scopex4,
        Scopex6,
        Scopex8,
        Scopex16,
        Infrared,
        NightVision
    }

    public class ScopeTypeInfo
    {
        public string name;
        public float scopeValue;

        public ScopeTypeInfo(string name, float scopeValue)
        {
            this.name = name;   
            this.scopeValue = scopeValue;
        }
    }

    public static Dictionary<Types, ScopeTypeInfo> ScopeTypeData = new()
    {
        { Types.Iron, new ScopeTypeInfo("Iron scope", 2)},
        { Types.RedDot, new ScopeTypeInfo("Iron scope", 2)},
        { Types.Holographic, new ScopeTypeInfo("Iron scope", 2)},
        { Types.Scopex2, new ScopeTypeInfo("Scope x2", 3)},
        { Types.Scopex4, new ScopeTypeInfo("Scope x4", 4)},
        { Types.Scopex6, new ScopeTypeInfo("Scope x6", 6)},
        { Types.Scopex8, new ScopeTypeInfo("Scope x8", 8)},
        { Types.Scopex16, new ScopeTypeInfo("Scope x16", 16)},
        { Types.Infrared, new ScopeTypeInfo("Iron scope", 4)},
        { Types.NightVision, new ScopeTypeInfo("Iron scope", 4)},

    };
}
