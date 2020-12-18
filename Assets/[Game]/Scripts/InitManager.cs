using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class InitManager : MonoBehaviour
{
    private IEnumerator Start()
    {
        
        yield return SceneManager.LoadSceneAsync(PlayerPrefs.GetString("LastLevel","Level01"), LoadSceneMode.Additive);
        SceneManager.SetActiveScene(SceneManager.GetSceneByName(PlayerPrefs.GetString("LastLevel", "Level01")));
        Destroy(gameObject);
    }
}
