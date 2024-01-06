using System.Collections;
using UnityEngine;

public abstract class Gun : MonoBehaviour
{
    public string Name { get; set; }
    public int Damage { get; set; }

    public GameObject CartridgeObject { get; set; }
    public int CurrentCartridgesCount { get; set; }
    public int MaxCartridgesCountInMagazine { get; set; }
    public float CartridgeSpeed { get; set; }
    public CartridgeData.Types CartridgesType { get; set; }

    public float ReloadTime { get; set; }
    public float ShootInterval { get; set; }

    public float MaxSpreadRadius { get; set; }
    public float MinSpreadRadius { get; set; }
    public float TimeToIncreaseSpread { get; set; }
    public float TimeToDecreaseSpread { get; set; }
    public float CurrentSpreadRadius { get; set; }

    public float Recoil { get; set; }
    public ScopeData.Types[] EnabledScope { get; set; }

    private bool IsReloading = false;
    private bool IsShootIntervalWait = false;


    public void Shoot()
    {
        if (CanShoot())
        {
            StartCoroutine(FireRateProcess());
            CurrentCartridgesCount--;
            CurrentSpreadRadius = Mathf.Lerp(MinSpreadRadius, MaxSpreadRadius, TimeToIncreaseSpread);
            Debug.Log(CurrentCartridgesCount);
        }
        CurrentSpreadRadius = Mathf.Lerp(MaxSpreadRadius, MinSpreadRadius, TimeToDecreaseSpread);
    }

    public void Reload() //check if exist in inventory
    {
        if (CanReload())
        {
            IsReloading = true;
            StartCoroutine(ReloadProcess());
            Debug.Log("REOLAD --" + CurrentCartridgesCount);
        }

    }

    private bool CanShoot()
    {
        return !IsShootIntervalWait && CurrentCartridgesCount > 0 && !IsReloading;
    }

    private bool CanReload()
    {
        return CurrentCartridgesCount > 0 && !IsReloading;
    }

    private IEnumerator FireRateProcess()
    {
        IsShootIntervalWait = true;
        yield return new WaitForSeconds(ShootInterval);
        IsShootIntervalWait = false;
    }

    private IEnumerator ReloadProcess()
    {
        yield return new WaitForSeconds(ReloadTime);
        IsReloading = false;
        CurrentCartridgesCount = MaxCartridgesCountInMagazine;
    }
}
