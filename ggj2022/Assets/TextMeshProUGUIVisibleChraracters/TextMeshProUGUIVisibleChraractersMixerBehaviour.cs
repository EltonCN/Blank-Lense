using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using TMPro;

public class TextMeshProUGUIVisibleChraractersMixerBehaviour : PlayableBehaviour
{
    int m_DefaultMaxVisibleCharacters;

    int m_AssignedMaxVisibleCharacters;

    TextMeshProUGUI m_TrackBinding;

    public override void ProcessFrame(Playable playable, FrameData info, object playerData)
    {
        m_TrackBinding = playerData as TextMeshProUGUI;

        if (m_TrackBinding == null)
            return;

        if (m_TrackBinding.maxVisibleCharacters != m_AssignedMaxVisibleCharacters)
            m_DefaultMaxVisibleCharacters = m_TrackBinding.maxVisibleCharacters;

        int inputCount = playable.GetInputCount ();

        float blendedMaxVisibleCharacters = 0f;
        float totalWeight = 0f;
        float greatestWeight = 0f;

        for (int i = 0; i < inputCount; i++)
        {
            float inputWeight = playable.GetInputWeight(i);
            ScriptPlayable<TextMeshProUGUIVisibleChraractersBehaviour> inputPlayable = (ScriptPlayable<TextMeshProUGUIVisibleChraractersBehaviour>)playable.GetInput(i);
            TextMeshProUGUIVisibleChraractersBehaviour input = inputPlayable.GetBehaviour ();
            
            blendedMaxVisibleCharacters += input.maxVisibleCharacters * inputWeight;
            totalWeight += inputWeight;

            if (inputWeight > greatestWeight)
            {
                greatestWeight = inputWeight;
            }
        }

        m_AssignedMaxVisibleCharacters = Mathf.RoundToInt (blendedMaxVisibleCharacters + m_DefaultMaxVisibleCharacters * (1f - totalWeight));
        m_TrackBinding.maxVisibleCharacters = m_AssignedMaxVisibleCharacters;
    }
}
