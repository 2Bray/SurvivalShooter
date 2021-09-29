using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public GameObject enemy;
    public float spawnTime = 20f;
    public Transform[] spawnPoints;

    [SerializeField]
    EnemyFactoryScript factory;
    IFactory Factory { get { return factory as IFactory; } }

    void Start()
    {
        //Mengeksekusi fungsi Spawn setiap beberapa detik sesuai dengan nilai spawnTime
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }


    void Spawn()
    {
        //Jika player telah mati maka tidak membuat enemy baru
        if (playerHealth.GetCurrentHealth() <= 0f)
        {
            return;
        }

        int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        int spawnEnemy = Random.Range(0, 3);

        //Memduplikasi enemy
        Factory.FactoryMethod(spawnEnemy);
    }
}
