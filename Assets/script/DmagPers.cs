using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class DmagPers : MonoBehaviour
{
    [SerializeField] Text HealthText;
    [SerializeField] private int health;
    private float GodMod;
    private float TimeGodMod = 1;
    public static bool Heal;
    
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "vrag" && GodMod > 1)
        {
            health--;
            GodMod = 0;
        }
    }
    private void Update()
    {
        if (Heal)
        {
            health++;
            Heal = false;
        }
        HealthText.text = System.Convert.ToString(health);
        if (health <= 0)
        {
            Bank.Key = 0;
            Bank.money = 0;
            SpawnVrag.KolvoVrag = 0;
            SceneManager.LoadScene("GameOver");
        }
        if (GodMod <= TimeGodMod)
        {
            GodMod += Time.deltaTime;
        }
    }
}
