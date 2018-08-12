using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitOnEnter : StateMachineBehaviour {

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    // This OnStateEnter closes the application once the animation is finished.
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Quit();
    }

    // Checks if editor is playing, if so it will stop the editor if not it will close the application.
    public void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else 
        Application.Quit ();
#endif
    }
}
