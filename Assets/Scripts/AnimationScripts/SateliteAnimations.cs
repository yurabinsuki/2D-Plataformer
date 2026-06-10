using UnityEngine;

public class SateliteAnimations : MonoBehaviour
{

public Animator animator;
public string triggerToPlay = "isFlying";

public KeyCode keyToTrigger = KeyCode.A;
public KeyCode keyToStop = KeyCode.S;

/*
private void OnValidate()
{
	if(animator == null) animator = GetComponent<Animator>();
}
*/
private void FlyAnimation()
{
	if(Input.GetKeyDown(keyToTrigger))
		{
			animator.SetBool(triggerToPlay, true);
		}
		else if (Input.GetKeyDown(keyToStop))
		{
			animator.SetBool(triggerToPlay, false);
		}
}

void Update ()
    {
        FlyAnimation();
    }

}
