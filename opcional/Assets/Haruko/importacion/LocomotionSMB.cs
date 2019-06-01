using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocomotionSMB : StateMachineBehaviour
{
    public float m_Damping = 0.15f;
    readonly int m_HashHorizontalParam = Animator.StringToHash("Horizontal");
    readonly int m_HashVerticalParam = Animator.StringToHash("Vertical");
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 input = new Vector2(horizontal, vertical).normalized;
        animator.SetFloat(m_HashHorizontalParam, input.x, m_Damping, Time.deltaTime);
        animator.SetFloat(m_HashVerticalParam, input.y, m_Damping, Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftShift))
        {
            animator.speed = 5;
        }
        else
        {
            animator.speed = 1;
        }
        
    }

   
}
