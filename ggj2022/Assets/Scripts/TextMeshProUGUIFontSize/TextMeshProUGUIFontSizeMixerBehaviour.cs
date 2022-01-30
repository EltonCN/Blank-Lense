using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using TMPro;

public class TextMeshProUGUIFontSizeMixerBehaviour : PlayableBehaviour
{
    float m_DefaultFontSize;

    float m_AssignedFontSize;

    TextMeshProUGUI m_TrackBinding;

    public override void ProcessFrame(Playable playable, FrameData info, object playerData)
    {
        m_TrackBinding = playerData as TextMeshProUGUI;

        if (m_TrackBinding == null)
            return;

        if (!Mathf.Approximately(m_TrackBinding.fontSize, m_AssignedFontSize))
            m_DefaultFontSize = m_TrackBinding.fontSize;

        int inputCount = playable.GetInputCount ();

        float blendedFontSize = 0f;
        float totalWeight = 0f;
        float greatestWeight = 0f;

        for (int i = 0; i < inputCount; i++)
        {
            float inputWeight = playable.GetInputWeight(i);
            ScriptPlayable<TextMeshProUGUIFontSizeBehaviour> inputPlayable = (ScriptPlayable<TextMeshProUGUIFontSizeBehaviour>)playable.GetInput(i);
            TextMeshProUGUIFontSizeBehaviour input = inputPlayable.GetBehaviour ();
            
            blendedFontSize += input.fontSize * inputWeight;
            totalWeight += inputWeight;

            if (inputWeight > greatestWeight)
            {
                greatestWeight = inputWeight;
            }
        }

        m_AssignedFontSize = blendedFontSize + m_DefaultFontSize * (1f - totalWeight);
        m_TrackBinding.fontSize = m_AssignedFontSize;
    }
}
