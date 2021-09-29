using UnityEngine;
using UnityEngine.UI;

public class GameOverManager : MonoBehaviour
{
    public Text warningText;
    public PlayerHealth playerHealth;

    bool game = true;

    [HideInInspector] public Animator anim;

    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (playerHealth.GetCurrentHealth() <= 0)
        {
            anim.SetTrigger("GameOver");
            game = false;
        }
    }

    public void ShowWarning(float enemyDistance)
    {
        if (game)
        {
            warningText.text = string.Format("! {0} m", Mathf.RoundToInt(enemyDistance));
            anim.SetTrigger("Warning");
        }
    }

    public void OnClickRetry() => UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    public void OnClickExit() => Application.Quit();
}