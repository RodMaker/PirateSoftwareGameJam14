using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private int startingHealth = 3;
    [SerializeField] private GameObject deathVFXPrefab;
    [SerializeField] private float knockBackThrust = 15f;
    [SerializeField] private int expAmount = 100; // ADDED

    private int currentHealth;
    private Knockback knockback;
    private Flash flash;

    public bool isBoss = false; // ADDED
    public GameObject floatingText;

    private void Awake()
    {
        flash = GetComponent<Flash>();
        knockback = GetComponent<Knockback>();
    }

    private void Start()
    {
        currentHealth = startingHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        SoundManager.Instance.PlaySound3D("EnemyTakeDamage", transform.position);
        knockback.GetKnockedBack(PlayerController.Instance.transform, knockBackThrust);
        GameObject text = Instantiate(floatingText, transform.position, Quaternion.identity) as GameObject; // ADDED
        text.transform.GetChild(0).GetComponent<TextMesh>().text = "-" + damage.ToString(); // ADDED
        StartCoroutine(flash.FlashRoutine());
        StartCoroutine(CheckDetectDeathRoutine());
    }

    private IEnumerator CheckDetectDeathRoutine()
    {
        yield return new WaitForSeconds(flash.GetRestoreMatTime());
        DetectDeath();
    }

    public void DetectDeath()
    {
        if (currentHealth <= 0)
        {
            SoundManager.Instance.PlaySound3D("EnemyDeath", transform.position);
            Instantiate(deathVFXPrefab, transform.position, Quaternion.identity);
            GetComponent<PickUpSpawner>().DropItems();
            ExperienceManager.Instance.AddExperience(expAmount); // ADDED

            if (isBoss)
            {
                SceneManager.LoadScene("Credits");
            }
            
            Destroy(gameObject);
        }
    }
}
