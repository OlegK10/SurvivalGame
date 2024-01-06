using System.Collections;
using UnityEngine;

public abstract class Gun : MonoBehaviour
{
    public string Name { get; set; }
    public int Damage { get; set; }
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

    public float FireRate { get; set; }
    public ScopeData.Types[] EnabledScope { get; set; }

    private bool IsReloading { get; set; }
    private bool IsShootIntervalWait { get; set; }

    public void Shoot(int? cartridgesByShoot)
    {
        if (CanShoot())
        {
            Vector3 gunFireRatePos = gameObject.transform.position;
            gunFireRatePos.y = FireRate;
            gameObject.transform.position = gunFireRatePos;

            StartCoroutine(FireRateProcess());
            CurrentCartridgesCount -= cartridgesByShoot ?? 1;
            CurrentSpreadRadius = Mathf.Lerp(MinSpreadRadius, MaxSpreadRadius, TimeToIncreaseSpread);
        }
        else
        {
            CurrentSpreadRadius = Mathf.Lerp(MaxSpreadRadius, MinSpreadRadius, TimeToDecreaseSpread);
        }
    }

    public void Reload()
    {
        if (CanReload())
        {
            IsReloading = true;
            StartCoroutine(ReloadProcess());
        }
    }

    private bool CanShoot()
    {
        return IsShootIntervalWait && CurrentCartridgesCount > 0 && !IsReloading;
    }

    private bool CanReload()
    {
        return CurrentCartridgesCount > 0 && !IsReloading;
    }

    private IEnumerator FireRateProcess()
    {
        IsShootIntervalWait = false;
        yield return new WaitForSeconds(ShootInterval);
        IsShootIntervalWait = true;
    }

    private IEnumerator ReloadProcess()
    {
        yield return new WaitForSeconds(ReloadTime);
        IsReloading = false;
        CurrentCartridgesCount = MaxCartridgesCountInMagazine;
    }
}
