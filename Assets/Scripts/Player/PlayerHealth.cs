using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    private int maxHealth = 10;
    private int currentHealth;

    public int CurrentHealth { get => currentHealth; set => currentHealth = value; }
    public int MaxHealth { get => maxHealth; }

    // Start is called before the first frame update
    void Start()
    {
        CurrentHealth = MaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        GameManager.Instance.HealthText(CurrentHealth);
    }

    public void TakeDamage(int damage){

        CurrentHealth -= damage;
        if(CurrentHealth <= 0){
            GameManager.Instance.IsAlive = false;
            Destroy(gameObject);
            GameManager.Instance.LoadScene("SampleScene");
        }
    }

    public void TakeHeal(int healAmount){

        if (CurrentHealth + healAmount < MaxHealth){

            CurrentHealth +=healAmount; 
        }
        else if(CurrentHealth + healAmount >= MaxHealth){
            CurrentHealth = MaxHealth;

        }
        
    }

}
