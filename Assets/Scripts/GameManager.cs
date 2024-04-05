using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public int goldAmount;
    public Text goldText;
    public Text healthText;

    public GameObject coinPrefab;

    public Transform coinSpawnLocation;


    public static GameManager Instance { get; private set; }
    
    
    bool isAlive = true;
    public bool IsAlive { get => isAlive; set => isAlive = value; }

    private void Awake(){ 
    // If there is an instance, and it's not me, delete myself.
    if (Instance != null && Instance != this) 
    { 
        Destroy(this); 
    } 
    else 
    { 
        Instance = this; 
    } 
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Time.deltaTime);
    }

    public void AddGold(int goldToAdd){

        //Debug.Log("test");
        goldAmount += goldToAdd;
        goldText.text = "Gold: " + goldAmount;
    }

    public void HealthText(int health){

        healthText.text = "Health: " + health;
    }


    public void SpawnCoin(){

        Instantiate(coinPrefab, coinSpawnLocation.transform.position, Quaternion.identity);

    }

    public void GameOverText(){

        //maxhealt singleton ile bu fonksiyonu çağıracak. courtine olacak bu 

    }


//Put this in whenever you want to load a scene
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }


}
