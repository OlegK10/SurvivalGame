using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public class CartridgeData
{
    public enum Types
    {
        Parabelum,
        ACP,
        mm5_56,
        mm7_62,
        Gauge,
        BMG,
        Magnum,
        mm12_7,
        Grenade20,
        RPGs,
        Arrow,
        Bolt
    }

    public class CartridgeTypeInfo
    {
        public string name;
        public CartridgeTypeInfo(string name)
        {
            this.name = name;
        }
    }

    public static Dictionary<Types, CartridgeTypeInfo> CartridgeTypeData = new() {
        {Types.Parabelum, new CartridgeTypeInfo("9mm Parabellum")},
        {Types.ACP, new CartridgeTypeInfo(".45 ACP") },
        {Types.mm5_56, new CartridgeTypeInfo("5.56x45mm") },
        {Types.mm7_62, new CartridgeTypeInfo("7.62x39mm") },
        {Types.Gauge, new CartridgeTypeInfo("12 Gauge") },
        {Types.BMG, new CartridgeTypeInfo("50 BMG") },
        {Types.mm12_7, new CartridgeTypeInfo("12.7x108mm") },
        {Types.Grenade20, new CartridgeTypeInfo("20mm Granades") },
        {Types.RPGs, new CartridgeTypeInfo("RPGs") },
        {Types.Arrow, new CartridgeTypeInfo("Arrow") },
        {Types.Bolt, new CartridgeTypeInfo("Bolt") }
    };
}
