using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[Serializable]
public class TextMeshProUGUI_VertexColorClip : PlayableAsset, ITimelineClipAsset
{
    public TextMeshProUGUI_VertexColorBehaviour template = new TextMeshProUGUI_VertexColorBehaviour ();

    public ClipCaps clipCaps
    {
        get { return ClipCaps.Blending; }
    }

    public override Playable CreatePlayable (PlayableGraph graph, GameObject owner)
    {
        var playable = ScriptPlayable<TextMeshProUGUI_VertexColorBehaviour>.Create (graph, template);
        return playable;
    }
}
