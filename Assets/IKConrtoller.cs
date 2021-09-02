using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IKConrtoller : MonoBehaviour
{
    private Animator animator;
    [SerializeField] Transform chest;
    void Start()
    {
        animator = this.GetComponent<Animator>();
    }

    private void OnAnimatorIK(int layerIndex)
    {
        animator.SetBoneLocalRotation(HumanBodyBones.Chest, chest.rotation);
    }
}
