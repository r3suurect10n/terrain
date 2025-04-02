using Unity.Cinemachine;
using UnityEngine;
using UnityEngine.Playables;

public class CamerasControl : MonoBehaviour
{
    [SerializeField] private CinemachineCamera[] _cams;
    [SerializeField] private PlayableDirector[] _timelines;

    [SerializeField] private int _camIndex;
    [SerializeField] private int _camPriority;

    private void Update()
    {
        if (_camIndex < _cams.Length - 1)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (_camIndex > 0)
                    _timelines[_camIndex - 1].Stop();

                _camIndex++;
                _camPriority++;
                _cams[_camIndex].Priority = _camPriority;                
            }
        }
        if (_camIndex > 0 && _cams[_camIndex].IsLive)
            _timelines[_camIndex - 1].Play();
    }
}
