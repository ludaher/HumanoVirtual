using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;
using System.Text;
using System;

public class WindowsVoice : ISpeakable
{
    [DllImport("WindowsVoice")]
    private static extern void initSpeech();
    [DllImport("WindowsVoice")]
    private static extern void destroySpeech();

    [DllImport("WindowsVoice")]
    private static extern void addToSpeechQueue(string s);
    [DllImport("WindowsVoice")]
    private static extern void clearSpeechQueue();
    [DllImport("WindowsVoice")]
    private static extern void statusMessage(StringBuilder str, int length);

    public WindowsVoice()
    {
        initSpeech();
    }

    public void AddToSpeechQueue(string msg)
    {
        addToSpeechQueue(msg);
    }

    public void Stop()
    {
        clearSpeechQueue();
        //destroySpeech();
        //initSpeech();
    }

    public void Pause()
    {
        clearSpeechQueue();
    }

    public void Continue()
    {

    }

    public void Dispose()
    {
        destroySpeech();
    }
}