using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu]
public class SceneManagement : ScriptableObject
{
   public void LoadScene (Object sceneName)
   {
      var newName = sceneName.name;
      SceneManager.LoadScene(newName);
    } 
}
