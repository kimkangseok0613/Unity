using UnityEngine;
using UnityEngine.InputSystem;

public class AnimatorMousey : MonoBehaviour
{
    public Animator animator;

    public void Idle()
    {
        animator.SetBool("Walk",false);
        animator.SetBool("Attack",false );
    }
    public void Walk()
    {
        animator.SetBool("Walk", true);
    }
    public void Attack()
    {
        animator.SetBool("Attack", true);
    }
    public void Die()
    {
        animator.SetTrigger("Die");
    }
}
