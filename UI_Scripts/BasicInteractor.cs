using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class BasicInteractor : XRBaseControllerInteractor
{
    public override void GetValidTargets(List<IXRInteractable> targets)
    {
        base.GetValidTargets(targets);
    }

    //protected override List<XRBaseInteractable> ValidTargets { get; }
}
