using UnityEngine;
using UnityEngine.SceneManagement; 

public class SceneYoneticisi :
MonoBehaviour
{
    public void OyunuBaslat()
    {

        SceneManager.LoadScene( "GameScene" );
    }
}

