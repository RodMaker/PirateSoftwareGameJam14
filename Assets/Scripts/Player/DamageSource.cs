using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering.Universal;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class DamageSource : MonoBehaviour
{
    private int damageAmount;

    private void Start()
    {
        MonoBehaviour currentActiveWeapon = ActiveWeapon.Instance.CurrentActiveWeapon;
        damageAmount = (currentActiveWeapon as IWeapon).GetWeaponInfo().weaponDamage;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        EnemyHealth enemyHealth = other.gameObject.GetComponent<EnemyHealth>();
        
        
        switch (ActiveWeapon.Instance.CurrentActiveWeapon.gameObject.name)
        {
            case "Sword"):
                enemyHealth?.TakeDamage(damageAmount + ActiveWeapon.Instance.swordDmgUp);
                break;
            case "Staff":
                enemyHealth?.TakeDamage(damageAmount + ActiveWeapon.Instance.staffDmgUp);
                break;
            case "Bow":
                enemyHealth?.TakeDamage(damageAmount + ActiveWeapon.Instance.bowDmgUp);
                break;
            default:
                Debug.LogError("Shit is really fucked up");
                break;
        }
    }

    public void UpgradeDamage(int upgradeAmount)
    {
        damageAmount += upgradeAmount;
    }
}
