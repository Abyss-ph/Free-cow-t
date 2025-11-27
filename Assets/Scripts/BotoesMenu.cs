using UnityEngine;
using UnityEngine.SceneManagement;

public class BotoesMenu : MonoBehaviour
{

    public void IniciarJogo()
    {
        SceneManager.LoadScene("game");
    }

    public void SairDoJogo()
    {
        Application.Quit();
    }


}
