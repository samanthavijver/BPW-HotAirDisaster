using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;

public class DontDestroy : MonoBehaviour {

    public GameObject[] ChildrenToDestroy;      // List of children that will be destroyed on scene change

	void Start()
    {
        // Tells unity which objects to keep on scene change
		DontDestroyOnLoad(this.gameObject);
        SceneManager.activeSceneChanged += OnSceneChange;   
	}

    // Tells Unity that children in list should be destroyed on scene change
    private void OnSceneChange(Scene arg0, Scene arg1)
    {
        for(int i = 0; i < ChildrenToDestroy.Length; i++)
        {
            Destroy(ChildrenToDestroy[i]);
        }
        SceneManager.activeSceneChanged -= OnSceneChange;
    }
}
