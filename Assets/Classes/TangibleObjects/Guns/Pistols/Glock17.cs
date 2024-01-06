using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glock17 : Gun
{
    public Glock17()
    {
        Name = "Glock 17";
        CurrentCartridgesCount = 20;
        MaxCartridgesCountInMagazine = 20;
        CartridgesType = CartridgeData.Types.Parabelum;
        ReloadTime = 3;
        ShootInterval= .2f;
        CartridgeSpeed = 20;

        MaxSpreadRadius = 8;
        MinSpreadRadius = 4;
        TimeToIncreaseSpread = .7f;
        TimeToDecreaseSpread = .2f;

        FireRate = 2;
        EnabledScope = new ScopeData.Types[] { ScopeData.Types.Iron, ScopeData.Types.Holographic, ScopeData.Types.RedDot };
    }
}
