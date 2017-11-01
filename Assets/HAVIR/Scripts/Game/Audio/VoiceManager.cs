using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceManager : IDisposable
{
    private ISpeakable _Voice;
    private static VoiceManager _VoiceManager;
    public static VoiceManager Instance
    {
        get
        {
            if (_VoiceManager == null)
                _VoiceManager = new VoiceManager();
            return _VoiceManager;
        }
    }
    
    public VoiceManager()
    {
        Init();
    }

    /// <summary>
    /// Inicializa las variables necesarias para el control de vos
    /// </summary>
    private void Init()
    {
        _Voice = new WindowsVoice();
        _Voice.AddToSpeechQueue("Buenos días señor, en que le puedo ayudar");
    }
    
    public void AddToSpeechQueue(string msg)
    {
        _Voice.AddToSpeechQueue(msg);
    }

    public void Pause()
    {
        _Voice.Pause();
    }

    public void Stop()
    {
        _Voice.Stop();
    }

    public void Continue()
    {
        _Voice.Continue();
    }

    public void Dispose()
    {
        _Voice.Dispose();
        _VoiceManager = null;
    }
}
