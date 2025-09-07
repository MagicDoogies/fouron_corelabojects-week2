using UnityEditor.Animations;
using UnityEngine;

public class AnimatorDemo : MonoBehaviour
{
    public Animator alienAnimator;
 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        alienAnimator = GetComponent<Animator>();

        alienAnimator.SetBool("IsIdle", true);
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetMouseButtonDown(0)) //When I click the left-mouse button, the dog enlarges. 
       {
            alienAnimator.SetBool("IsIdle", false);
            alienAnimator.SetBool("IsEnlarge", true);
            alienAnimator.SetBool("IsWiggle", false);

       }
        if (Input.GetMouseButtonDown(1))//When I click the right-mouse button, the dog wiggles. 
        {
            alienAnimator.SetBool("IsIdle", false);
            alienAnimator.SetBool("IsEnlarge", false);
            alienAnimator.SetBool("IsWiggle", true);

        }
        if (Input.GetKeyDown(KeyCode.Space))//When I click the 'space bar' key, the dog goes back to the idle state. 
        {
            alienAnimator.SetBool("IsIdle", true);
            alienAnimator.SetBool("IsEnlarge", false);
            alienAnimator.SetBool("IsWiggle", false);

        }

    }
}
