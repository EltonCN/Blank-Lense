using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using Lean.Localization;

public class LeanLocalizedTextMeshProUGUIMixerBehaviour : PlayableBehaviour
{
    string m_DefaultTranslationName;

    string m_AssignedTranslationName;

    LeanLocalizedTextMeshProUGUI m_TrackBinding;

    public override void ProcessFrame(Playable playable, FrameData info, object playerData)
    {
        m_TrackBinding = playerData as LeanLocalizedTextMeshProUGUI;

        if (m_TrackBinding == null)
            return;

        if (m_TrackBinding.TranslationName != m_AssignedTranslationName)
            m_DefaultTranslationName = m_TrackBinding.TranslationName;

        int inputCount = playable.GetInputCount ();

        float totalWeight = 0f;
        float greatestWeight = 0f;
        int currentInputs = 0;

        for (int i = 0; i < inputCount; i++)
        {
            float inputWeight = playable.GetInputWeight(i);
            ScriptPlayable<LeanLocalizedTextMeshProUGUIBehaviour> inputPlayable = (ScriptPlayable<LeanLocalizedTextMeshProUGUIBehaviour>)playable.GetInput(i);
            LeanLocalizedTextMeshProUGUIBehaviour input = inputPlayable.GetBehaviour ();
            
            totalWeight += inputWeight;

            if (inputWeight > greatestWeight)
            {
                m_AssignedTranslationName = input.TranslationName;
                m_TrackBinding.TranslationName = m_AssignedTranslationName;
                greatestWeight = inputWeight;
            }

            if (!Mathf.Approximately (inputWeight, 0f))
                currentInputs++;
        }

        if (currentInputs != 1 && 1f - totalWeight > greatestWeight)
        {
            m_TrackBinding.TranslationName = m_DefaultTranslationName;
        }
    }
}
