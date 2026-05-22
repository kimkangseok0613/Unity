using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimatorMousey : MonoBehaviour
{
    public Animator animator;
    public AnimatorStateInfo animatorStateInfo;

    public void Idle()
    {
        animatorStateInfo = animator.GetCurrentAnimatorStateInfo(0);

        if (animatorStateInfo.IsName("Walk"))
        {
            animator.SetBool("Walk", false);
            animator.SetBool("Idle", true);
        }
        else if (animatorStateInfo.IsName("Attack"))
        {
            animator.SetBool("Attack", false);
            animator.SetBool("Idle", true);
        }
    }
    public void Walk()
    {
        animatorStateInfo = animator.GetCurrentAnimatorStateInfo(0);

        if(animatorStateInfo.IsName("Attack"))
        {
            animator.SetBool("Walk", true);
            animator.SetBool("Attack", false);
        }
        else if(animatorStateInfo.IsName("Idle"))
        {
            animator.SetBool("Walk", true);
            animator.SetBool("Idle", false);
        }
    }
    public void Attack()
    {
        animatorStateInfo = animator.GetCurrentAnimatorStateInfo(0);

        if (animatorStateInfo.IsName("Walk"))
        {
            animator.SetBool("Walk", false);
            animator.SetBool("Attack", true);
        }
        else if (animatorStateInfo.IsName("Idle"))
        {
            animator.SetBool("Attack", true);
            animator.SetBool("Idle", false);
        }
    }
    public void Die()
    {
        animatorStateInfo = animator.GetCurrentAnimatorStateInfo(0);

        if(animatorStateInfo.IsName("Die") || animator.IsInTransition(0))
        {
            return;
        }
        else
        {
            animator.SetTrigger("Die");
        }
    }
}
